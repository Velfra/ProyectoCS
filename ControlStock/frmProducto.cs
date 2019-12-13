using ClasesNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlStock
{
    public partial class frmProducto : Form
    {
        DataSet resultados = new DataSet();
        DataView mifiltro;
        int productoID;
        string modo;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            nudCantidad.Value = 0;
            cboCategoria.SelectedItem = null;
            cboProveedor.SelectedItem = null;
            nudPrecioCosto.Value = 0;

        }

        private void DesbloquearFormulario()
        {
            txtNombre.Enabled = true;
            nudCantidad.Enabled = true;
            cboCategoria.Enabled = true;
            cboProveedor.Enabled = true;
            nudPrecioCosto.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void BloquearFormulario()
        {
            txtNombre.Enabled = false;
            nudCantidad.Enabled = false;
            cboCategoria.Enabled = false;
            cboProveedor.Enabled = false;
            nudPrecioCosto.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private Producto ObtenerDatosFormulario()
        {
            Producto producto = new Producto();
            producto.Id = productoID;
            producto.Nombre = txtNombre.Text;
            producto.Categoria = (Categoria)cboCategoria.SelectedValue;
            producto.Cantidad = (int)nudCantidad.Value;
            producto.PrecioCompra = (double)(nudPrecioCosto.Value);
            producto.Proveedor = (Proveedor)cboProveedor.SelectedValue;

            return producto;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var p = ObtenerDatosFormulario();
                if(ValidarCampos())
                { 
                    if (modo == "AGREGAR")
                    {
                        Producto.AgregarProducto(p);
                    }
                    else if (modo == "EDITAR")
                    {
                            Producto.EditarProducto(p);
                            ActualizarListaProductos();
                

                    }

                    LimpiarFormulario();
                    ActualizarListaProductos();
                    BloquearFormulario();
                }
        }

        private void ActualizarListaProductos()
        {
            dgvProducto.DataSource = null;
            dgvProducto.DataSource = Producto.ObtenerProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                var p = ObtenerDatosFormulario();
                Producto.EliminarProducto(p);
                ActualizarListaProductos();
                LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
                modo = "EDITAR";
            DesbloquearFormulario();
            nudCantidad.Enabled = false;
            txtNombre.Focus();

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            ActualizarListaProductos();
            cboProveedor.DataSource = Proveedor.ObtenerProveedores();
            cboCategoria.DataSource = Categoria.ObtenerCategorias();
            cboCategoria.SelectedItem = null;
            cboProveedor.SelectedItem = null;
            BloquearFormulario();          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtNombre.Focus();
        }
      
        private void leer_datos(string query, ref DataSet dstPrincipal, string tabla)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dstPrincipal, tabla);
                da.Dispose();
                con.Close();

            }
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salidaDatos = "";
            string[] palabrasBusqueda = this.txtBuscar.Text.Split(' ');
            foreach (string palabra in palabrasBusqueda)
            {
                if (salidaDatos.Length == 0)
                {
                    salidaDatos = "(Nombre Like '%" + txtBuscar.Text + "%')";
                }
                else
                {
                    salidaDatos += "(Nombre Like '%" + txtBuscar.Text + "%')";
                }
            }
            this.mifiltro.RowFilter = salidaDatos;
        }

        private void dgvProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbcProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultados.Clear();
            this.leer_datos("Select Producto.Id,Producto.Nombre,cantidad,Categoria.Nombre,PrecioCompra,Proveedor.RazonSocial,Fecha_pedido from Producto INNER JOIN Proveedor On Proveedor.id = Producto.Proveedor INNER JOIN Categoria On Categoria.id = Producto.Categoria", ref resultados, "producto");
            this.mifiltro = ((DataTable)resultados.Tables["producto"]).DefaultView;
            this.dgvProducto.DataSource = mifiltro;
            
            
            
        }

        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {     
                     
        }

        private void dgvProducto_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            productoID = Convert.ToInt32(this.dgvProducto.CurrentRow.Cells[0].Value);
            txtNombre.Text = this.dgvProducto.CurrentRow.Cells[1].Value.ToString();
            nudCantidad.Value = Convert.ToInt32(this.dgvProducto.CurrentRow.Cells[2].Value);
            cboCategoria.Text = Convert.ToString(this.dgvProducto.CurrentRow.Cells[3].Value);
            nudPrecioCosto.Value = Convert.ToDecimal(this.dgvProducto.CurrentRow.Cells[4].Value);
            cboProveedor.Text = Convert.ToString(this.dgvProducto.CurrentRow.Cells[5].Value);
            tbcProducto.SelectedIndex = 0;
            btnAgregar.Enabled = false;
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error");
                txtNombre.Focus();
                return false;
            }
            if (txtNombre.Text.Length < 3 || txtNombre.Text.Length > 30)
            {
                MessageBox.Show("La longitud de caracteres es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (nudCantidad.Value <= 0 || nudCantidad.Value > 1000)
            {
                MessageBox.Show("Por favor ingrese una cantidad", "Error");
                nudCantidad.Focus();
                return false;
            }
            

            if (nudPrecioCosto.Value <= 0)
            {
                MessageBox.Show("Por favor ingrese un precio", "Error");
                nudPrecioCosto.Focus();
                return false;
            }
            if (cboCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una Categoria", "Error");
                cboCategoria.Focus();
                return false;
            }
            var pro = (Proveedor)cboProveedor.SelectedItem;
            if (pro == null)
            {
                MessageBox.Show("Por favor seleccione un Proveedor", "Error");
                cboProveedor.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(pro.Email))
            {
                MessageBox.Show("El proveedor no posee Email, por favor verifique", "Error");
                cboProveedor.Focus();
                return false;
            }

            return true;
        }
        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("C:/Users/Velfra/Desktop/facultad/intro C#/ListaProductos.pdf", FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph();

            PdfPTable table = new PdfPTable(3);

            //actual width of table in points

            table.TotalWidth = 400f;

            //fix the absolute width of the table

            table.LockedWidth = true;

            //relative col widths in proportions - 1/3 and 2/3

            float[] widths = new float[] { 5f, 5f, 3f};

            table.SetWidths(widths);

            table.HorizontalAlignment = 1;

            //leave a gap before and after the table

            table.SpacingBefore = 20f;

            table.SpacingAfter = 30f;

            PdfPCell cell = new PdfPCell(new Phrase("Productos"));
   
            cell.PaddingLeft = 20f;
            cell.PaddingTop = 4f;
            cell.Colspan = 3;

            cell.Border = 0;

            cell.HorizontalAlignment = 1;

            table.AddCell(cell);

            table.AddCell("Nombre");
  
            table.AddCell("Proveedor");

            table.AddCell("Stock");

            using (SqlConnection conn = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                string query = "SELECT Nombre,Proveedor.RazonSocial,Cantidad FROM Producto INNER JOIN Proveedor On Proveedor.id = Producto.Proveedor";

                SqlCommand cmd = new SqlCommand(query,conn);
                try
                {
                    conn.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader())

                    {

                        while (rdr.Read())
                        {
                            table.AddCell(rdr[0].ToString());
                            table.AddCell(rdr[1].ToString());
                            table.AddCell(rdr[2].ToString());
                        }

                    }
                }
                catch (Exception ex)
                {
                    Log.EscribirLog("SqlException", ex.Message);
                }
                document.Add(table);
            }
            document.Add(p);
            document.Close();
        }
    }
}
