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

namespace tpcai_electrhogar
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ModulosForm modulos = new ModulosForm();
            //modulos.Show();

            ModuloLogueo.Loguearse(textBoxUsuario.Text, textBoxContraseña.Text, "CAI20241");
            bool UsuarioPresente = ModuloLogueo.ExisteUsuario();
            bool UsuarioAutenticado = ModuloLogueo.Autenticado();
            bool cambioContraseña = ModuloLogueo.CambioContraseña();
            bool usuarioBloqueado = ModuloLogueo.ChequearBloqueo(textBoxUsuario.Text);

            if(textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
            {
                lblError.Text = "Debe ingresar un usuario y una contraseña";
            }            
            else if(!UsuarioPresente)
            {
                lblError.Text = "No se encontró el usuario";
            }
           else  if (usuarioBloqueado)
            {
                lblError.Text = "El usuario ha fallado tres veces en autenticarse. Usuario bloqueado.";
            }
            else if (!UsuarioAutenticado)
            {
                lblError.Text = "Contraseña errónea";
            }
            else if(cambioContraseña)
            {
                this.Hide();
                CambiarContrasenaForm cambiocontraseñaform = new CambiarContrasenaForm();
                cambiocontraseñaform.Show();
            }
            else if(!cambioContraseña & UsuarioAutenticado)
            {
                this.Hide();
                ModulosForm modulosForm = new ModulosForm();
                modulosForm.Show();
            }



        }


    }
}
