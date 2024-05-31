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
    public partial class FormBienvenida : Form
    {
        private string _username;
        public FormBienvenida(string usuario)
        {
            InitializeComponent();
            _username = usuario;
            lblUsuario.Text = _username;
        }

        // Levanta el formulario con los parametros correspondientes (opacity en 0 para que aparezca y desaparezca con los timers)
        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }

        // Lleva la opacidad de 0 a 1 y cuando llega frena este timer para arrancar el segundo
        // Va aumentando el valor de la barra de progreso circular y lo muestra
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100) 
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        // Lleva la opacidad de 1 a 0 para dar la sensación de que desaparece antes de entrar al menu principal.
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Hide();
                FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
    ModuloLogueo.UsuarioAuntenticado.host);
                modulosForm.Show();
            }
  
        }

        
    }
}
