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
    public partial class frmProveedor : Form
    {
        DataSet resultados = new DataSet();
        DataView mifiltro;
        int proveedorID;
        string modo;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var p = ObtenerDatosFormulario();

            if(ValidarCampos())
            {
                    if (modo == "AGREGAR")
                    {
                        Proveedor.AgregarProveedor(p);
                    }
                    else if (modo == "EDITAR")
                    {

                        Proveedor.EditarProveedor(p);
                        ActualizarListaProveedores();
                    
                    }

                    LimpiarFormulario();
                    ActualizarListaProveedores();
                    BloquearFormulario();
            }
           


        }


        private Proveedor ObtenerDatosFormulario()
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Id = proveedorID;
            proveedor.RazonSocial = txtNombreProveedor.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.Contacto = txtTelefono.Text;
            proveedor.Email = txtMail.Text;

            return proveedor;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormularios();
            txtNombreProveedor.Focus();
        }

        private void DesbloquearFormularios()
        {
            txtNombreProveedor.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtMail.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            dgvProveedor.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;


        }

        
        private void LimpiarFormulario()
        {
            txtNombreProveedor.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {         
                modo = "EDITAR";
                DesbloquearFormularios();
                txtNombreProveedor.Focus();  
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            ActualizarListaProveedores();
            BloquearFormulario();
        }

        private void ActualizarListaProveedores()
        {
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = Proveedor.ObtenerProveedores();
        }


        private void BloquearFormulario()
        {
            txtNombreProveedor.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtMail.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            dgvProveedor.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

                var p = ObtenerDatosFormulario();
                Proveedor.EliminarProveedor(p);
                ActualizarListaProveedores();
                LimpiarFormulario();           
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNombreProveedor.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error");
                txtNombreProveedor.Focus();
                return false;
            }
            if (txtNombreProveedor.Text.Length < 3 || txtNombreProveedor.Text.Length > 30)
            {
                MessageBox.Show("La longitud de caracteres es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreProveedor.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía", "Error");
                txtDireccion.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Agregue un número de telefono", "Error");
                txtTelefono.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("El proveedor no posee Email, por favor verifique", "Error");
                txtMail.Focus();
                return false;
            }

            return true;
        }

        private void tbcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultados.Clear();
            this.leer_datos("Select Proveedor.Id,RazonSocial,Direccion,Contacto,Email from Proveedor", ref resultados, "Proveedor");
            this.mifiltro = ((DataTable)resultados.Tables["Proveedor"]).DefaultView;
            this.dgvProveedor.DataSource = mifiltro;
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salidaDatos = "";
            string[] palabrasBusqueda = this.txtBuscar.Text.Split(' ');
            foreach (string palabra in palabrasBusqueda)
            {
                if (salidaDatos.Length == 0)
                {
                    salidaDatos = "(RazonSocial Like '%" + txtBuscar.Text + "%')";
                }
                else
                {
                    salidaDatos += "(RazonSocial Like '%" + txtBuscar.Text + "%')";
                }
            }
            this.mifiltro.RowFilter = salidaDatos;
        }

        private void dgvProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            proveedorID = Convert.ToInt32(this.dgvProveedor.CurrentRow.Cells[0].Value);
            txtNombreProveedor.Text = this.dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = this.dgvProveedor.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text =this.dgvProveedor.CurrentRow.Cells[3].Value.ToString();
            txtMail.Text = this.dgvProveedor.CurrentRow.Cells[4].Value.ToString();
            tbcPrincipal.SelectedIndex = 0;
            btnAgregar.Enabled = false;
        }
    }
}
