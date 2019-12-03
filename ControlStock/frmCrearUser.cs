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
    public partial class frmCrearUser : Form
    {
        public frmCrearUser()
        {
            InitializeComponent();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Usuario.CrearUsuario(txtUsuario.Text, txtPassword.Text);
            MessageBox.Show("Usuario creado exitosamente");
        }
    }
}
