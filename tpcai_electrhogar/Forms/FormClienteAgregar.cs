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
    public partial class FormClienteAgregar : Form
    {
        public FormClienteAgregar()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Guid clienteGuid = new Guid();
            //Guid idUsuario = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
            //ModuloClientes.AgregarCliente(idUsuario, textBoxNombre.Text, textBoxApellido.Text, int.Parse(textBoxDNI.Text), textBoxDirección.Text, textBoxTelefono.Text, textBoxMail.Text, dateNacimiento.Value, "prueba21-4", out string error);
            ModuloClientes.AgregarCliente(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), "Juan", "Suarez", 33333444, "Pedro Lopez", "1212123", "adas@gmail.com", new DateTime(2000, 4, 12), "prueba22-4", out string error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
        }

        private void btnCancelarContrasena_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal();
            modulosForm.Show();
        }
    }
}
    