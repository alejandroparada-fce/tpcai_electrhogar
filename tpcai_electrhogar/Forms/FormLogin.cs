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

            /*
            this.Hide();
            FormBienvenida formBienvenida = new FormBienvenida();
            formBienvenida.Show();
            */
            

            switch (estadoAutenticacion)
            {
                case 0:
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
                    FormUtils.CambiarFormulario(this, new FormBienvenida());
                    break;
                case 5:
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
            /*
            //this.Hide();
            //ModulosForm modulos = new ModulosForm();
            //modulos.Show();

            // Constructor para enviar la información Nombre de Usuario al CambiarContrasenaForm
            
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
                FormCambiarContrasena cambiocontraseñaform = new FormCambiarContrasena(txtUsuario.Text, txtPass.Text);
                cambiocontraseñaform.Show();
                //FormUtils.CambiarFormulario(this, new CambiarContrasenaForm());
            }
            else if (!cambioContraseña & UsuarioAutenticado)
            {
                this.Hide();
                FormMenuPrincipal modulosForm = new FormMenuPrincipal(txtUsuario.Text);
                modulosForm.Show();
            }
            
            //UsuarioNegocio.Prueba();

            */
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

    }
}
