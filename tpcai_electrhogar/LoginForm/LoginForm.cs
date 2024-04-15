using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Negocio;
using System.Runtime.InteropServices;

namespace tpcai_electrhogar
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //ModulosForm modulos = new ModulosForm();
            //modulos.Show();

            ModuloLogueo.Loguearse(txtUsuario.Text, txtPass.Text, "CAI20241");
            bool UsuarioPresente = ModuloLogueo.ExisteUsuario();
            bool UsuarioAutenticado = ModuloLogueo.Autenticado();
            bool cambioContraseña = ModuloLogueo.CambioContraseña();
            bool usuarioBloqueado = ModuloLogueo.ChequearBloqueo(txtUsuario.Text);

            if (txtUsuario.Text == "Usuario" || txtUsuario.Text == "Contraseña")
            {
                lblError.Text = "Debe ingresar un usuario y una contraseña";
            }
            else if (!UsuarioPresente)
            {
                lblError.Text = "No se encontró el usuario";
            }
            else if (usuarioBloqueado)
            {
                lblError.Text = "El usuario ha fallado tres veces en autenticarse. Usuario bloqueado.";
            }
            else if (!UsuarioAutenticado)
            {
                lblError.Text = "Contraseña errónea";
            }
            else if (cambioContraseña)
            {
                this.Hide();
                CambiarContrasenaForm cambiocontraseñaform = new CambiarContrasenaForm();
                cambiocontraseñaform.Show();
            }
            else if (!cambioContraseña & UsuarioAutenticado)
            {
                this.Hide();
                ModulosForm modulosForm = new ModulosForm();
                modulosForm.Show();
            }
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
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
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
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
