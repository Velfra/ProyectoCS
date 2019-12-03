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
        
        public frmEntradaSalida()
        {
            InitializeComponent();
        }

        private void frmEntradaSalida_Load(object sender, EventArgs e)
        {
            cboProducto.DataSource = Producto.ObtenerProductos();
            cboProducto.SelectedItem = null;
            nudStock.Enabled = false;
           // nudStock.Value = 0;

           
        }

        private void cboProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem != null)
            {
                Producto p = (Producto)cboProducto.SelectedItem;
                nudStock.Value = p.Cantidad;       
            }
            else
            {
                nudStock.Value = 0;
            }
          
        }

        private void leer_datos(string query, string tabla)
        {
            
        }
    }
}
