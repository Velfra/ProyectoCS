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
    public partial class frmEntradaSalida : Form
    {
        DataSet resultados = new DataSet();
        DataView mifiltro;
        int productoID, valorStock;
        string modo;
        public frmEntradaSalida()
        {
            InitializeComponent();
        }

        private void frmEntradaSalida_Load(object sender, EventArgs e)
        {
            ActualizarListaProductos();
            cboProducto.DataSource = Producto.ObtenerProductos();
            cboProducto.SelectedItem = null;
            nudStock.Enabled = false;
            BloquearFormulario();
            

        }

        private EntradaProductos ObtenerDatosFormulario()
        {
            EntradaProductos movimiento = new EntradaProductos();
            movimiento.producto = (Producto)cboProducto.SelectedValue;
            movimiento.Stock = (int)nudStock.Value;
            if (rbnEntrada.Checked)
            {
                movimiento.movimiento = Movimiento.Entrada;
            }
            else
            {
                movimiento.movimiento = Movimiento.Salida;
            }
            movimiento.Cantidad = (int)(nudCantidad.Value);

            return movimiento;
        }

        private void DesbloquearFormulario()
        {
            cboProducto.Enabled = true;
            nudCantidad.Enabled = true;
            rbnEntrada.Enabled = true;
            rbnSalida.Enabled = true;

            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnCancelar.Enabled = true;

            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void BloquearFormulario()
        {
            cboProducto.Enabled = false;
            nudCantidad.Enabled = false;
            rbnEntrada.Enabled = false;
            rbnSalida.Enabled = false;

            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnCancelar.Enabled = false;

            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void LimpiarFormulario()
        {
            cboProducto.SelectedItem = null;
            nudStock.Value = 0;
            nudCantidad.Value = 0;

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            cboProducto.Focus();
        }

        private bool ValidarCampos()
        {

            if (nudCantidad.Value <= 0 || nudCantidad.Value > 1000)
            {
                MessageBox.Show("Por favor ingrese una cantidad", "Error");
                nudCantidad.Focus();
                return false;
            }


            if (nudStock.Value <= 0)
            {
                MessageBox.Show("Por favor ingrese un numero", "Error");
                nudStock.Focus();
                return false;
            }
            if (cboProducto.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un Producto", "Error");
                cboProducto.Focus();
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = "EDITAR";
            DesbloquearFormulario();
            cboProducto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void cboProducto_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem != null)
            { 
                Producto p = (Producto)cboProducto.SelectedItem;
                nudStock.Value = p.Cantidad;
                valorStock = Convert.ToInt32(nudStock.Value);
                productoID = p.Id;

            }
            else
            {
                nudStock.Value = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var p = ObtenerDatosFormulario();

            if (ValidarCampos())
            {
                if (modo == "AGREGAR")
                {
                    if (rbnEntrada.Checked)
                    {
                       EntradaProductos.AgregarProducto(p);
                        SumarStock(p);
                        
                    }
                    else
                    {
                        EntradaProductos.AgregarProducto(p);
                        RestarStock(p);
                       
                    }

                }
                else if (modo == "EDITAR")
                {
                    EntradaProductos.EditarProducto(p);
                    EntradaProductos.ActualizarStock(p);
                }

                LimpiarFormulario();
               
                BloquearFormulario();
            }

        }
    
        private void SumarStock(EntradaProductos p)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "UPDATE Producto SET cantidad = " + p.Stock + " +" + p.Cantidad + " where Id = " + productoID;
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd.ExecuteNonQuery();
            }

        }

        private void RestarStock(EntradaProductos p)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                if (p.Cantidad > p.Stock)
                {
                    MessageBox.Show("No Pueden salir mas productos de los que hay en stock", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    con.Open();
                    string textoCmd = "UPDATE Producto SET cantidad = " + p.Stock + " -" + p.Cantidad + " where Id = " + productoID;
                    SqlCommand cmd = new SqlCommand(textoCmd, con);
                    cmd.ExecuteNonQuery();
                }

            }

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

        private void tbcLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultados.Clear();
            this.leer_datos("Select Producto.Nombre,Stock, case Movimiento.Movimiento when '0' then 'ENTRADA' When '1' then 'SALIDA' end as Movimientos,Movimiento.Cantidad,FechaMovimiento from Movimiento INNER JOIN Producto On Producto.Id = Movimiento.Producto ", ref resultados, "Movimiento");
            this.mifiltro = ((DataTable)resultados.Tables["Movimiento"]).DefaultView;
            this.dgvMovimiento.DataSource = mifiltro;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("C:/Users/Velfra/Desktop/facultad/intro C#/ListaMovimiento.pdf", FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph();

            PdfPTable table = new PdfPTable(5);

            //actual width of table in points

            table.TotalWidth = 500f;

            //fix the absolute width of the table

            table.LockedWidth = true;

            //relative col widths in proportions - 1/3 and 2/3

            float[] widths = new float[] { 2f, 2f, 2f, 2f,2f };

            table.SetWidths(widths);

            table.HorizontalAlignment = 1;

            //leave a gap before and after the table

            table.SpacingBefore = 20f;

            table.SpacingAfter = 30f;

            PdfPCell cell = new PdfPCell(new Phrase("Listado de Movimientos"));

            cell.PaddingLeft = 20f;
            cell.PaddingTop = 4f;
            cell.Colspan = 5;

            cell.Border = 0;

            cell.HorizontalAlignment = 1;

            table.AddCell(cell);

            table.AddCell("Nombre");
            table.AddCell("Stock");
            table.AddCell("Movimiento");
            table.AddCell("Cantidad");
            table.AddCell("FechaMovimiento");

            using (SqlConnection conn = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                string query = "Select Producto.Nombre,Stock, case Movimiento.Movimiento when '0' then 'Entrada' When '1' then 'salida' end as Movimientos,Movimiento.Cantidad,FechaMovimiento from Movimiento INNER JOIN Producto On Producto.Id = Movimiento.Producto ";

                SqlCommand cmd = new SqlCommand(query, conn);
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
                            table.AddCell(rdr[3].ToString());
                            table.AddCell(rdr[4].ToString());
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

        private void dgvMovimiento_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            cboProducto.Text = this.dgvMovimiento.CurrentRow.Cells[0].Value.ToString();
            nudStock.Value = Convert.ToInt32(this.dgvMovimiento.CurrentRow.Cells[1].Value);
            //if (Convert.ToBoolean(this.dgvMovimiento.CurrentRow.Cells[2].Value))
            //{
            //    rbnEntrada.Checked = true;
            //}
            //else
            //{
            //    rbnSalida.Checked = true;
            //}
            nudCantidad.Value = Convert.ToInt32(this.dgvMovimiento.CurrentRow.Cells[3].Value);
            
            tbcLista.SelectedIndex = 0;
            btnAgregar.Enabled = false;
        }

        private void ActualizarListaProductos()
        {
            dgvMovimiento.DataSource = null;
            dgvMovimiento.DataSource = EntradaProductos.ObtenerMovimiento();
        }

    }
}

