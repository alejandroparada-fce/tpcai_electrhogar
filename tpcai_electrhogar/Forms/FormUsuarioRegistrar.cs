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
    public partial class FormUsuarioRegistrar : Form
    {
        private string mensajeError;

        /*Se usa como convención para el nombre de formularios describir
la función del mismo + "Form"
Apariencia/BackColor: 15,15,15 (RGB)
Estilo De ventana/Opacity: 90 %
Textbox: se sacan bordes, se cambia fuente a Century Gothic y se usa tamaño 12.
Se agrega panel dockeado a la izquierda (RGB 0,122,204).
*/
        public FormUsuarioRegistrar()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool valido1 = Validaciones.ValidarCadena(textBoxNombre.Text, "'Nombre'", 3, 30, out string mensajeError1);
            bool valido2 = Validaciones.ValidarCadena(textBoxApellido.Text, "'Apellido'", 3, 30, out string mensajeError2);
            bool valido3 = Validaciones.ValidarEntero(textBoxDNI.Text, "'DNI'", 1000000, 100000000, out int DNI, out string mensajeError3);
            bool valido4 = Validaciones.ValidarCadena(textBoxDirección.Text, "'Dirección'", 3, 30, out string mensajeError4);
            bool valido5 = Validaciones.ValidarCadena(textBoxTelefono.Text, "'Teléfono'", 3, 30, out string mensajeError5);
            bool valido6 = Validaciones.ValidarCadena(textBoxMail.Text, "'Correo Electrónico'", 3, 30, out string mensajeError6);
            bool valido7 = Validaciones.ValidarCadena(textBoxNombreUsuario.Text, "'Nombre de Usuario'", 8, 15, out string mensajeError7);
            bool valido8 = Validaciones.ValidarPatronUsuario(textBoxNombre.Text, textBoxApellido.Text, textBoxNombreUsuario.Text, out string mensajeError8);

            mensajeError = mensajeError1 + "\n" + mensajeError2 + "\n" + mensajeError3 + "\n" + mensajeError4 + "\n" + mensajeError5 + "\n" + mensajeError6
                + "\n" + mensajeError7 + "\n" + mensajeError8;
            lblError.Text = mensajeError;

            //Sumo 1 para que el valor del indice del combobox coincida con el 
            //de la base de datos.
            int host = comboBoxPerfil.SelectedIndex + 1;



            if (valido1 & valido2 & valido3 & valido4 & valido5 & valido6 & valido7 & valido8)
            {
                try
                {
                    ModuloUsuarios.AltaUsuario(textBoxNombre.Text, textBoxApellido.Text,
                       DNI, dateNacimiento.Value.Date, textBoxDirección.Text, textBoxTelefono.Text, textBoxMail.Text,
                       textBoxNombreUsuario.Text, "CAI20241", DateTime.Now, null, host);
                    MessageBox.Show("Usuario Creado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void RegistrarUsuariosForm_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
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
    }
    //
}