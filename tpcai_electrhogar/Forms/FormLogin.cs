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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tpcai_electrhogar
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            int estadoAutenticacion = ModuloLogueo.Loguearse(txtUsuario.Text, txtPass.Text, "CAI20241");

            

            switch (estadoAutenticacion)
            {
                case 0:
                    //Discrimino si no encontró al usuario o se cargó un valor por defecto
                    if (txtUsuario.Text == "Usuario" || txtUsuario.Text == "")
                    {
                        lblError.Text = "Debe ingresar un usuario";
                    }
                    else
                    {
                        lblError.Text = "No se encontró al usuario";
                    }
                    break;
                case 1:
                    lblError.Text = "El usuario ha sido bloqueado";
                    break;
                case 2:
                    FormUtils.CambiarFormulario(this, new FormCambiarContrasena(txtUsuario.Text, txtPass.Text));
                    break;
                case 3:
                    FormUtils.CambiarFormulario(this, new FormCambiarContrasena(txtUsuario.Text, txtPass.Text));
                    break;
                case 4:
                    ModuloLogueo.Pass = txtPass.Text;
                    FormUtils.CambiarFormulario(this, new FormBienvenida(txtUsuario.Text));
                    break;
                case 5:
                    //Discrimino si la contraseña es inválida o se cargó un valor por defecto
                    if (txtPass.Text == "Contraseña" || txtPass.Text == "")
                    {
                        lblError.Text = "Debe ingresar una contraseña";
                    }
                    else
                    {
                        lblError.Text = "Contraseña invalida";
                    }
                    break;
                default:
                    lblError.Text = "Debe ingresar un usuario y una contraseña";
                    break;
            }

        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            FormUtils.LimpiarCampo(this, txtUsuario, "Usuario");
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            FormUtils.LimpiarCampo(this, txtUsuario, "Usuario");
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            FormUtils.LimpiarCampoContrasena(this, txtPass, "Contraseña");
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            FormUtils.LimpiarCampoContrasena(this, txtPass, "Contraseña");
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            FormUtils.MinimizarFormulario(this);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            FormUtils.MaximizarFormulario(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormUtils.SalirAplicacion();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void checkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.MostrarContrasena(this, txtPass, checkMostrarContrasena.Checked);
        }

        private void checkMostrarContrasena_Enter(object sender, EventArgs e)
        {
            FormUtils.MostrarContrasena(this, txtPass, checkMostrarContrasena.Checked);
        }
    }
}
