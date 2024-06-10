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
            FormProveedorAdm formProveedorAdm = new FormProveedorAdm();
            formProveedorAdm.Show();
        }

        private string mensajeError;
        // FormConfirmacion pide parametro
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //FormConfirmacion formConfirmacion = new FormConfirmacion(id);
            //formConfirmacion.Show();
            bool valido1 = Validaciones.ValidarCadena(txtNombre.Text, "'Nombre'", 3, 30, out string mensajeError1);
            bool valido2 = Validaciones.ValidarCadena(txtApellido.Text, "'Apellido'", 3, 30, out string mensajeError2);
            bool valido3 = Validaciones.ValidarCadena(txtEmail.Text, "'Correo Electrónico'", 3, 30, out string mensajeError3);
            bool valido4 = Validaciones.ValidarCadena(txtCUIT.Text, "'CUIT'", 11, 16, out string mensajeError4);



            mensajeError = mensajeError1 + "\n" + mensajeError2 + "\n" + mensajeError3 + "\n" + mensajeError4;
            lblError.Text = mensajeError;

            if (valido1 & valido2 & valido3 & valido4)
            {
                String nombre = txtNombre.Text;
                String apellido = txtApellido.Text;
                String email = txtEmail.Text;
                String cuit = txtCUIT.Text;

                try
                {
                    ModuloProveedor.ProveedorAgregar(nombre, apellido, email, cuit, out string error);

                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error);
                    }
                    else
                    {
                        MessageBox.Show("Proveedor Agregado");

                        this.Hide();
                        FormProveedorAdm formProveedorAdm = new FormProveedorAdm();
                        formProveedorAdm.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
