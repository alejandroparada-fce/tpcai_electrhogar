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
                   btnReporteStockCritico.Enabled = false;
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

        private void btnCambioContrasena_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCambiarContrasena cambiarContrasenaForm = new FormCambiarContrasena(_username, ModuloLogueo.Pass);
            cambiarContrasenaForm.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = false;
            btnUsuarioModificar.Visible = false;
            btnUsuarioRegistrar.Visible = false;
            btnReporteStockCritico.Visible = false;
            btnReporteProductoMasVendidoPorCategoria.Visible = false;
            btnReporteVentasPorVendedor.Visible = false;
            btnProveedorRegistrar.Visible = false;
            btnProveedorAdm.Visible = false;
            btnProveedorBaja.Visible = false;
            btnProductoAdm.Visible = true;
            btnClienteAdm.Visible = false;
            btnVentaRegistrar.Visible = false;
            btnVentaDevolucion.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = false;
            btnUsuarioModificar.Visible = false;
            btnUsuarioRegistrar.Visible = false;
            btnReporteStockCritico.Visible = false;
            btnReporteProductoMasVendidoPorCategoria.Visible = false;
            btnReporteVentasPorVendedor.Visible = false;
            btnProveedorRegistrar.Visible = false;
            btnProveedorAdm.Visible = false;
            btnProveedorBaja.Visible = false;
            btnProductoAdm.Visible = false;
            btnClienteAdm.Visible = true;
            btnVentaRegistrar.Visible = false;
            btnVentaDevolucion.Visible = false;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = false;
            btnUsuarioModificar.Visible = false;
            btnUsuarioRegistrar.Visible = false;
            btnReporteStockCritico.Visible = false;
            btnReporteProductoMasVendidoPorCategoria.Visible = false;
            btnReporteVentasPorVendedor.Visible = false;
            btnProveedorRegistrar.Visible = false;
            btnProveedorAdm.Visible = false;
            btnProveedorBaja.Visible = false;
            btnProductoAdm.Visible = false;
            btnClienteAdm.Visible = false;
            btnVentaRegistrar.Visible = true;
            btnVentaDevolucion.Visible = true;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = false;
            btnUsuarioModificar.Visible = false;
            btnUsuarioRegistrar.Visible = false;
            btnReporteStockCritico.Visible = false;
            btnReporteProductoMasVendidoPorCategoria.Visible = false;
            btnReporteVentasPorVendedor.Visible = false;
            btnProveedorRegistrar.Visible = true;
            btnProveedorAdm.Visible = true;
            btnProveedorBaja.Visible = true;
            btnProductoAdm.Visible = false;
            btnClienteAdm.Visible = false;
            btnVentaRegistrar.Visible = false;
            btnVentaDevolucion.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = false;
            btnUsuarioModificar.Visible = false;
            btnUsuarioRegistrar.Visible = false;
            btnReporteStockCritico.Visible = true;
            btnReporteProductoMasVendidoPorCategoria.Visible = true;
            btnReporteVentasPorVendedor.Visible = true;
            btnProveedorRegistrar.Visible = false;
            btnProveedorAdm.Visible = false;
            btnProveedorBaja.Visible = false;
            btnProductoAdm.Visible = false;
            btnClienteAdm.Visible = false;
            btnVentaRegistrar.Visible = false;
            btnVentaDevolucion.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            btnUsuarioBaja.Visible = true;
            btnUsuarioModificar.Visible = true;
            btnUsuarioRegistrar.Visible = true;
            btnReporteStockCritico.Visible = false;
            btnReporteProductoMasVendidoPorCategoria.Visible = false;
            btnReporteVentasPorVendedor.Visible = false;
            btnProveedorRegistrar.Visible = false;
            btnProveedorAdm.Visible = false;
            btnProveedorBaja.Visible = false;
            btnProductoAdm.Visible = false;
            btnClienteAdm.Visible = false;
            btnVentaRegistrar.Visible = false;
            btnVentaDevolucion.Visible = false;
        }

        // Modulo Usuarios
        private void btnUsuarioRegistrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuarioRegistrar registrarUsuariosForm = new FormUsuarioRegistrar();
            registrarUsuariosForm.Show();
        }

        private void btnUsuarioBaja_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuarioBuscarBaja formUsuarioBuscarBaja = new FormUsuarioBuscarBaja();
            formUsuarioBuscarBaja.Show();
        }

        // ####### Modificar no lleva a nada, estaba solamente el boton.
        private void btnUsuarioModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
            ModuloLogueo.UsuarioAuntenticado.host);
            modulosForm.Show();
        }

        // Modulo Clientes
        private void btnClienteAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClienteListar listadoClienteForm = new FormClienteListar();
            listadoClienteForm.Show();
        }


        // Modulo Proveedores
        private void btnProveedorRegistrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormProveedorRegistrar altaProveedorForm = new FormProveedorRegistrar();
            altaProveedorForm.Show();
        }
        private void btnProveedorBaja_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormProveedorBaja bajaProveedorForm = new FormProveedorBaja();
            bajaProveedorForm.Show();
        }
        private void btnProveedorAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProveedorAdm admProveedorForm = new FormProveedorAdm();
            admProveedorForm.Show();
        }


        // Modulo Productos
        private void btnProductoRegistrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormProductoRegistrar agregarProductoForm = new FormProductoRegistrar();
            agregarProductoForm.Show();
        }

        private void btnProductoAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmProductos formProductoAdm = new FormAdmProductos();
            formProductoAdm.Show();
        }


        // Modulo Ventas
        private void btnVentaRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentaRegistrar formVentaRegistrar = new FormVentaRegistrar();
            formVentaRegistrar.Show();
        }

        private void btnVentaDevolucion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentaDevolucion formVentaDevolucion = new FormVentaDevolucion();
            formVentaDevolucion.Show();
        }


        // Modulo Reportes
        private void btnReporteVentasPorVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReporteVentasPorVendedor reporteVentasVendedor = new FormReporteVentasPorVendedor();
            reporteVentasVendedor.Show();
        }

        private void btnReporteProductoMasVendidoPorCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReporteProductosCategoria reporteProductos = new FormReporteProductosCategoria();
            reporteProductos.Show();
        }

        private void btnReporteStockCritico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStockCritico reporteStockCritico = new FormStockCritico();
            reporteStockCritico.Show();
        }

    }
}
