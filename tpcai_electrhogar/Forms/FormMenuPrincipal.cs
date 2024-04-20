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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
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

        private void ModulosForm_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        // Botonera para jugar con la navegación de los formularios hechos hasta el momento.
        // Para arrancar desde la botoner y saltear el proceso de login y cambio de contraseña, comentar la linea: "Application.Run(new LoginForm());"
        // en Progam.cs para que se inicie el programa desde ese formulario.

        private void btnUsuarioRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarUsuariosForm registrarUsuariosForm = new RegistrarUsuariosForm();
            registrarUsuariosForm.Show();
        }

        private void btnCambioContrasena_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCambiarContrasena cambiarContrasenaForm = new FormCambiarContrasena();
            cambiarContrasenaForm.Show();
        }

        private void btnProveedorRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaProveedorForm altaProveedorForm = new AltaProveedorForm();
            altaProveedorForm.Show();
        }

        private void btnProveedorBaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            BajaProveedorForm bajaProveedorForm = new BajaProveedorForm();
            bajaProveedorForm.Show();
        }

        private void btnProductoRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarProductoForm agregarProductoForm = new AgregarProductoForm();
            agregarProductoForm.Show();
        }

        private void btnVentaRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
           VentaForm ventaForm = new VentaForm();
            ventaForm.Show();
        }

        
    }
}
