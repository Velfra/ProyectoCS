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
    public partial class frmEntradaSalida : Form
    {
        int productoID, valorStock;
        string modo;
        public frmEntradaSalida()
        {
            InitializeComponent();
        }

        private void frmEntradaSalida_Load(object sender, EventArgs e)
        {
            cboProducto.DataSource = Producto.ObtenerProductos();
            cboProducto.SelectedItem = null;
            nudStock.Enabled = false;
            BloquearFormulario();
           // nudStock.Value = 0;
           
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
            nudStock.Value =0;
            nudCantidad.Value = 0;

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            cboProducto.Focus();
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
                valorStock =Convert.ToInt32(nudStock.Value);
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


            if (modo == "AGREGAR")
            {
                if (rbnEntrada.Checked)
                {
                   
                    SumarStock(p);      
                }
                else
                {
                    RestarStock(p); 
                }

            }
            else if (modo == "EDITAR")
            {
               
            }

            LimpiarFormulario();
           // ActualizarListaProductos();
            BloquearFormulario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void SumarStock(EntradaProductos p)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "UPDATE Producto SET cantidad = "+ p.Stock+ " +"+ p.Cantidad+" where Id = "+productoID;
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd.ExecuteNonQuery();
            }

        }

        private void ActualizarListaMovimiento()
        {
            dgvMovimiento.DataSource = null;
            dgvMovimiento.DataSource = EntradaProductos.ObtenerMovimiento();
        }
    }
}
