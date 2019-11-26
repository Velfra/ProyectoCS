using ClasesNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
    }
}
