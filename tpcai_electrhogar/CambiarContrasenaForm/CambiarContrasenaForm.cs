using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace tpcai_electrhogar
{
    public partial class CambiarContrasenaForm : Form
    {
        public CambiarContrasenaForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ContraseñaActual_TextChanged(object sender, EventArgs e)
        {
            //Hacer validacion con la contraseña temporal cuando tenga la base de datos
        }

        private void btnCancelarContrasena_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulosForm modulosForm = new ModulosForm();
            modulosForm.Show();
        }

        private void btnGuardarContrasena_Click(object sender, EventArgs e)
        {
            string mensajeError2 = "";
            string mensajeError = "";
            bool validar1 = Validaciones.ValidarContraseña(ContrasenaNueva.Text, "'Contraseña Nueva'", 8, 15, out string mensajeError1);
            bool validar2 = RepetirContrasena.Text == ContrasenaNueva.Text;
            if (!validar2)
            {
                mensajeError2 = "Las contraseñas no coinciden.";
            }
            mensajeError = mensajeError1 + "\n" + mensajeError2;
            lblError.Text = mensajeError;
            //Falta hacer el llamado de logica de negocio para el guardado en base de datos, y el cambio de estado
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña Actual")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña Actual";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void ContrasenaNueva_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña Nueva")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void ContrasenaNueva_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña Nueva";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void RepetirContrasena_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Repetir Contraseña Nueva")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void RepetirContrasena_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Repetir Contraseña Nueva";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void CambiarContrasenaForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
