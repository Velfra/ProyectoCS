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

          //  nudStock.Value = Convert.ToInt32(producto.Cantidad);
        }

        private void cboProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void leer_datos(string query, string tabla)
        {
            
        }
    }
}
