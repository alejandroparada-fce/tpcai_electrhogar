using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Negocio;

namespace tpcai_electrhogar
{
    public partial class FormClienteRegistrar : Form
    {
        private string mensajeError;
        public FormClienteRegistrar()
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


            mensajeError = mensajeError1 + "\n" + mensajeError2 + "\n" + mensajeError3 + "\n" + mensajeError4 + "\n" + mensajeError5 + "\n" + mensajeError6;
            lblError.Text = mensajeError;

            if (valido1 & valido2 & valido3 & valido4 & valido5 & valido6)
            {
                String nombre = textBoxNombre.Text;
                String apellido = textBoxApellido.Text;
                int dni = Int32.Parse(textBoxDNI.Text);
                String direccion = textBoxDirección.Text;
                String telefono = textBoxTelefono.Text;
                String email = textBoxMail.Text;
                DateTime fechaNacimiento = dateNacimiento.Value;
                
                try
                {
                    ModuloClientes.AgregarCliente(nombre,apellido,dni,direccion,telefono,email,fechaNacimiento, out string error);

                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error);
                    }
                    else
                    {
                        MessageBox.Show("Cliente Creado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btnCancelarContrasena_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
    