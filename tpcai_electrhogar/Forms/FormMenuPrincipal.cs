using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Forms;
using tpcai_electrhogar.Negocio;

namespace tpcai_electrhogar
{
    public partial class FormMenuPrincipal : Form
    {
        private string _username;
        private int _autorizacion;

        public FormMenuPrincipal()
        {
            InitializeComponent();
        }
        public FormMenuPrincipal(string username, int autorizacion)
        {
            InitializeComponent();
            _username = username;
            lblUsername.Text = _username;
            _autorizacion = autorizacion;

            switch (_autorizacion)
            {
                //Se deshabilitan botones para los vendedores
                case 1:
                   btnUsuarios.Enabled = false;
                   btnProductos.Enabled = false;
                   btnProveedores.Enabled = false;
                   btnReporteProductoMasVendidoPorCategoria.Enabled = false;
                   btnReporteStock.Enabled = false;
                   btnVentaDevolucion.Enabled = false;
                   break;
                //Se deshabilitan botones para Supervidores
                case 2:
                   btnUsuarios.Enabled = false;
                   btnProveedores.Enabled = false;
                   btnVentaRegistrar.Enabled = false;
                   break;
                //Se deshabilitan botones para Administradores
                case 3:
                   btnVentas.Enabled = false;
                   break;
            }
        }

        public string Username { get { return _username; } set { _username = value; } }
        public int Autorizacion { get { return _autorizacion;  } set {  _autorizacion = value; } }

        
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
            FormUsuarioRegistrar registrarUsuariosForm = new FormUsuarioRegistrar();
            registrarUsuariosForm.Show();
        }

        private void btnCambioContrasena_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCambiarContrasena cambiarContrasenaForm = new FormCambiarContrasena(_username, ModuloLogueo.Pass);
            cambiarContrasenaForm.Show();
        }

        private void btnProveedorRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProveedorRegistrar altaProveedorForm = new FormProveedorRegistrar();
            altaProveedorForm.Show();
        }

        private void btnProveedorBaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProveedorBaja bajaProveedorForm = new FormProveedorBaja();
            bajaProveedorForm.Show();
        }



        private void btnProductoRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductoRegistrar agregarProductoForm = new FormProductoRegistrar();
            agregarProductoForm.Show();
        }

        private void btnVentaRegistrar_Click(object sender, EventArgs e)
        {
           this.Hide();
           FormVentaRegistrar formVentaRegistrar = new FormVentaRegistrar();
           formVentaRegistrar.Show();
        }

        private void btnClienteModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClienteListar listadoClienteForm = new FormClienteListar();
            listadoClienteForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnProductoBaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmProductos formProductoBaja = new FormAdmProductos();
            formProductoBaja.Show();
        }
        private void btnVentaDevolucion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentaDevolucion formVentaDevolucion = new FormVentaDevolucion();
            formVentaDevolucion.Show();
        }

        private void btnUsuarioBaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuarioBuscarBaja formUsuarioBuscarBaja = new FormUsuarioBuscarBaja();
            formUsuarioBuscarBaja.Show();
 
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = false;
            btnUsuarioModificar.Visible = false;
            btnUsuarioRegistrar.Visible = false;
            btnReporteStock.Visible = false;
            btnReporteProductoMasVendidoPorCategoria.Visible = false;
            btnReporteVentasPorVendedor.Visible = false;
            btnProveedorRegistrar.Visible = false;
            btnProveedorListar.Visible = false;
            btnProveedorBaja.Visible = false;
            btnProductoBaja.Visible = true;
            btnClienteModificar.Visible = false;
            btnVentaRegistrar.Visible = false;
            btnVentaDevolucion.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = false;
            btnUsuarioModificar.Visible = false;
            btnUsuarioRegistrar.Visible = false;
            btnReporteStock.Visible = false;
            btnReporteProductoMasVendidoPorCategoria.Visible = false;
            btnReporteVentasPorVendedor.Visible = false;
            btnProveedorRegistrar.Visible = false;
            btnProveedorListar.Visible = false;
            btnProveedorBaja.Visible = false;
            btnProductoBaja.Visible = false;
            btnClienteModificar.Visible = true;
            btnVentaRegistrar.Visible = false;
            btnVentaDevolucion.Visible = false;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = false;
            btnUsuarioModificar.Visible = false;
            btnUsuarioRegistrar.Visible = false;
            btnReporteStock.Visible = false;
            btnReporteProductoMasVendidoPorCategoria.Visible = false;
            btnReporteVentasPorVendedor.Visible = false;
            btnProveedorRegistrar.Visible = false;
            btnProveedorListar.Visible = false;
            btnProveedorBaja.Visible = false;
            btnProductoBaja.Visible = false;
            btnClienteModificar.Visible = false;
            btnVentaRegistrar.Visible = true;
            btnVentaDevolucion.Visible = true;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = false;
            btnUsuarioModificar.Visible = false;
            btnUsuarioRegistrar.Visible = false;
            btnReporteStock.Visible = false;
            btnReporteProductoMasVendidoPorCategoria.Visible = false;
            btnReporteVentasPorVendedor.Visible = false;
            btnProveedorRegistrar.Visible = true;
            btnProveedorListar.Visible = true;
            btnProveedorBaja.Visible = true;
            btnProductoBaja.Visible = false;
            btnClienteModificar.Visible = false;
            btnVentaRegistrar.Visible = false;
            btnVentaDevolucion.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = false;
            btnUsuarioModificar.Visible = false;
            btnUsuarioRegistrar.Visible = false;
            btnReporteStock.Visible = true;
            btnReporteProductoMasVendidoPorCategoria.Visible = true;
            btnReporteVentasPorVendedor.Visible = true;
            btnProveedorRegistrar.Visible = false;
            btnProveedorListar.Visible = false;
            btnProveedorBaja.Visible = false;
            btnProductoBaja.Visible = false;
            btnClienteModificar.Visible = false;
            btnVentaRegistrar.Visible = false;
            btnVentaDevolucion.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = true;
            btnUsuarioModificar.Visible = true;
            btnUsuarioRegistrar.Visible = true;
            btnReporteStock.Visible = false;
            btnReporteProductoMasVendidoPorCategoria.Visible = false;
            btnReporteVentasPorVendedor.Visible = false;
            btnProveedorRegistrar.Visible = false;
            btnProveedorListar.Visible = false;
            btnProveedorBaja.Visible = false;
            btnProductoBaja.Visible = false;
            btnClienteModificar.Visible = false;
            btnVentaRegistrar.Visible = false;
            btnVentaDevolucion.Visible = false;
        }

        private void btnProveedorListar_Click(object sender, EventArgs e)
        {
                this.Hide();
                FormProveedorListar listarProveedorForm = new FormProveedorListar();
                listarProveedorForm.Show();
        }

        private void btnReporteProductoMasVendidoPorCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReporteProductosCategoria reporteProductos = new FormReporteProductosCategoria();
            reporteProductos.Show();
        }

        private void btnReporteVentasPorVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReporteVentasPorVendedor reporteVentasVendedor = new FormReporteVentasPorVendedor();
            reporteVentasVendedor.Show();
        }
        
    }
}
