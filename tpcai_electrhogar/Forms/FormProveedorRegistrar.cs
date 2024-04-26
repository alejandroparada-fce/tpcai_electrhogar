using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Datos;
using tpcai_electrhogar.Negocio;

namespace tpcai_electrhogar
{
    public partial class FormProveedorRegistrar : Form
    {
        public FormProveedorRegistrar()
        {
            InitializeComponent();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            //Errores Comentados
            string mensajeError;
            //bool valido1 = Validaciones.ValidarCadena(textBoxNombre.Text, "'Nombre'", 3, 30, out string mensajeError1);
            //bool valido2 = Validaciones.ValidarCadena(textBoxApellido.Text, "'Apellido'", 3, 30, out string mensajeError2);
            //bool valido3 = Validaciones.ValidarEntero(textBoxCUIT.Text, "'CUIT'", 1000000, 100000000, out int DNI, out string mensajeError3);
            //bool valido4 = Validaciones.ValidarCadena(textBoxMail.Text, "'EMAIL", 3, 30, out string mensajeError4);

            //mensajeError = mensajeError1 + "\n" + mensajeError2 + "\n" + mensajeError3 + "\n" + mensajeError4;

            //lblError.Text = mensajeError;
        }

        private void FormProveedorAlta_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal();
            modulosForm.Show();
        }

        // FormConfirmacion pide parametro
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //FormConfirmacion formConfirmacion = new FormConfirmacion(id);
            //formConfirmacion.Show();
            ModuloProveedor.ProveedorAgregar(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), "Paquito", "Navarro", "paquito@navarro.com", "20-25555454-0", out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
        }


        
           
}
}
