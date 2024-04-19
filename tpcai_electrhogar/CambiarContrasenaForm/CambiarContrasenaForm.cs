using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Datos;
using tpcai_electrhogar.Negocio;

namespace tpcai_electrhogar
{
    public partial class CambiarContrasenaForm : Form
    {
        //private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        public CambiarContrasenaForm()
        {
            InitializeComponent();
        }

        //private void ContraseñaActual_TextChanged(object sender, EventArgs e)
        //{
        //    //Hacer validacion con la contraseña temporal cuando tenga la base de datos
        //}

        private void btnCancelarContrasena_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulosForm modulosForm = new ModulosForm();
            modulosForm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormUtils.SalirAplicacion();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            FormUtils.MaximizarFormulario(this);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            FormUtils.MinimizarFormulario(this);
        }

        private string _username;

        public CambiarContrasenaForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void btnGuardarContrasena_Click(object sender, EventArgs e)
        {
            UsuarioEnt usuarioEnt = new UsuarioEnt();
            usuarioEnt.Nombre = _username;
            usuarioEnt.Contraseña = contrasenaActual.Text;
            usuarioEnt.ContraseñaNueva = contrasenaNueva.Text;

            string mensajeError = "";
            bool validar1 = Validaciones.ValidarContraseña(contrasenaNueva.Text, "'Contraseña Nueva'", 8, 15, out string mensajeError1);
            bool validar2 = Validaciones.RepetirContraseña(contrasenaNueva.Text, repetirContrasena.Text, out string mensajeError2);
            mensajeError = mensajeError1 + "\n" + mensajeError2;
                lblError.Text = mensajeError;
            if (validar1 & validar2)
            {
                try
                {
                    //usuarioNegocio.CambiarPassword(usuarioEnt);
                    //usuarioNegocio.ActivarUsuario();
                    MessageBox.Show("Contraseña cambiada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          
        }

        private void contrasenaActual_Enter(object sender, EventArgs e)
        {
            FormUtils.LimpiarCampoContrasena(this, contrasenaActual, "Contraseña Actual");
        }

        private void contrasenaActual_Leave(object sender, EventArgs e)
        {
            FormUtils.LimpiarCampoContrasena(this, contrasenaActual, "Contraseña Actual");
        }

        private void contrasenaNueva_Enter(object sender, EventArgs e)
        {
            FormUtils.LimpiarCampoContrasena(this, contrasenaNueva, "Contraseña Nueva");
        }

        private void contrasenaNueva_Leave(object sender, EventArgs e)
        {
            FormUtils.LimpiarCampoContrasena(this, contrasenaNueva, "Contraseña Nueva");
        }

        private void repetirContrasena_Enter(object sender, EventArgs e)
        {
            FormUtils.LimpiarCampoContrasena(this, repetirContrasena, "Repetir Contraseña Nueva");
        }

        private void repetirContrasena_Leave(object sender, EventArgs e)
        {
            FormUtils.LimpiarCampoContrasena(this, repetirContrasena, "Repetir Contraseña Nueva");
        }
    }
}
