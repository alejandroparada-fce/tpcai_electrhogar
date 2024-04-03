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
    public partial class CambiarContrasenaForm : Form
    {
        public CambiarContrasenaForm()
        {
            InitializeComponent();
        }
       
        private void CambiarContrasenaForm_Load(object sender, EventArgs e)
        {

        }
        private void ContraseñaActual_TextChanged(object sender, EventArgs e)
        {
            //Hacer validacion con la contraseña temporal cuando tenga la base de datos
        }
        private void cancelarContrasena_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulosForm modulosForm = new ModulosForm();
            modulosForm.Show();
        }

        private void GuardarContrasena_Click(object sender, EventArgs e)
        {
            string mensajeError2 = "";
            string mensajeError = "";
            bool validar1 = Validaciones.ValidarContraseña(ContrasenaNueva.Text, "Nueva Contraseña", 8, 15, out string mensajeError1);
            bool validar2 = RepetirContrasena.Text == ContrasenaNueva.Text;
            if (!validar2)
            {
                mensajeError2 = "Las contraseñas no coinciden.";
            }
            mensajeError = mensajeError1 + "\n" + mensajeError2;
            lblError.Text = mensajeError;
            //Falta hacer el llamado de logica de negocio para el guardado en base de datos, y el cambio de estado
        }

     
    }
}
