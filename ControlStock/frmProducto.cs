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
    public partial class frmProducto : Form
    {
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

            lstProducto.Enabled = false;
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

            lstProducto.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private Producto ObtenerDatosFormulario()
        {
            Producto producto = new Producto();
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

                if (this.lstProducto.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor seleccione una fila");
                }

                else
                {
                    int indice = lstProducto.SelectedIndex;
                    Producto.EditarProducto(p, indice);
                    ActualizarListaProductos();
                }


            }

            LimpiarFormulario();
            ActualizarListaProductos();
            BloquearFormulario();
        }

        private void ActualizarListaProductos()
        {
            lstProducto.DataSource = null;
            lstProducto.DataSource = Producto.ObtenerProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstProducto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Producto p = (Producto)lstProducto.SelectedItem;
                Producto.EliminarProducto(p);
                ActualizarListaProductos();
                LimpiarFormulario();
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

        private void lstProducto_DoubleClick(object sender, EventArgs e)
        {
            Producto p = (Producto)lstProducto.SelectedItem;

            if (p != null)
            {
                txtNombre.Text = p.Nombre;
                cboCategoria.SelectedItem = p.Categoria;
                cboProveedor.SelectedItem = p.Proveedor;
                nudCantidad.Value = p.Cantidad;
               nudPrecioCosto.Value =(decimal)p.PrecioCompra;
            }

            tbcProducto.SelectedIndex = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstProducto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                modo = "EDITAR";
                DesbloquearFormulario();
                txtNombre.Focus();
            }
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            ActualizarListaProductos();
            cboProveedor.DataSource = Proveedor.ObtenerProveedores();
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
    }
}
