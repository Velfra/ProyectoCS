using ClasesNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlStock
{
    public partial class frmCategoria : Form
    {
        
        int CategoriaID;
        string modo;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var p = ObtenerDatosFormulario();

            if (modo == "AGREGAR")
            {
                Categoria.AgregarCategoria(p);
            }
            else if (modo == "EDITAR")
            {
                    Categoria.EditarCategoria(p);
                    ActualizarListaCategorias();

            }

            LimpiarFormulario();
            ActualizarListaCategorias();
            BloquearFormulario();
        }

        private Categoria ObtenerDatosFormulario()
        {
            Categoria categoria = new Categoria();
            categoria.Id = CategoriaID;
            categoria.Nombre = txtNombre.Text;
            categoria.Descripcion = txtDescripcion.Text;
            return categoria;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormularios();
            txtNombre.Focus();
        }

        private void DesbloquearFormularios()
        {
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            dgvCategoria.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;


        }


        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
           
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {  
                modo = "EDITAR";
                DesbloquearFormularios();
                txtNombre.Focus();         
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            ActualizarListaCategorias();
            BloquearFormulario();
            
        }

        private void ActualizarListaCategorias()
        {
            dgvCategoria.DataSource = null;
            dgvCategoria.DataSource = Categoria.ObtenerCategorias();
        }


        private void BloquearFormulario()
        {
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
           

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            dgvCategoria.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

               var p = ObtenerDatosFormulario();
                Categoria.EliminarCategoria(p);
                ActualizarListaCategorias();
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



        private void tbcCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListaCategorias();
        }

        private void dgvCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriaID = Convert.ToInt32(this.dgvCategoria.CurrentRow.Cells[0].Value);
            txtNombre.Text = this.dgvCategoria.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = this.dgvCategoria.CurrentRow.Cells[2].Value.ToString();
            tbcCategoria.SelectedIndex = 0;
            btnAgregar.Enabled = false;
        }
    }
}

