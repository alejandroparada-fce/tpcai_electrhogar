using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpcai_electrhogar
{
    public partial class ModulosForm : Form
    {
        public ModulosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarUsuariosForm registrarUsuariosForm = new RegistrarUsuariosForm();
            registrarUsuariosForm.Show();
        }

        private void cambiarpassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            CambiarContrasenaForm cambiarContrasenaForm = new CambiarContrasenaForm();
            cambiarContrasenaForm.Show();
        }
    }
}
