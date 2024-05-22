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

namespace tpcai_electrhogar.Forms
{
    public partial class FormVentaRegistrar : Form
    {
        public FormVentaRegistrar()
        {
            InitializeComponent();
            FiltrarLista();
        }

        private List<ClienteEnt> ObtenerListaClientes()
        {
            List<ClienteEnt> listaClientes = ModuloClientes.ConsultarClientes(out string error);
            var bindingList = new BindingList<ClienteEnt>(listaClientes);
            var source = new BindingSource(bindingList, null);
            dgvClientes.DataSource = source;
            dgvClientes.Columns["id"].Visible = false;
            dgvClientes.Columns["fechaBaja"].Visible = false;
            dgvClientes.Columns["fechaAlta"].Visible = false;
            dgvClientes.Columns["fechaNacimiento"].Visible = false;
            dgvClientes.Columns["host"].Visible = false;
            dgvClientes.Columns["direccion"].Visible = false;
            dgvClientes.Columns["telefono"].Visible = false;
            dgvClientes.Columns["email"].Visible = false;

            dgvClientes.Columns[0].HeaderText = "Nombre";
            dgvClientes.Columns[1].HeaderText = "Apellido";
            dgvClientes.Columns[6].HeaderText = "DNI";

            return listaClientes;

        }

        private void FiltrarLista()
        {
            List<ClienteEnt> listaClientes = ObtenerListaClientes();
            string host = "Grupo 6";
            List<ClienteEnt> clientesFiltrados = listaClientes.Where(p => p.host == host).ToList();
            MostrarClientesFiltrados(clientesFiltrados);
        }

        private void MostrarClientesFiltrados(List<ClienteEnt> listaClientes)
        {
            dgvClientes.Rows.Clear();
            dgvClientes.DataSource = listaClientes;
        }

        private void CargarLista()
        {
            List<ClienteEnt> listaClientes = ObtenerListaClientes();
        }

            private void FormVentaRegistrar_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
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
            FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
ModuloLogueo.UsuarioAuntenticado.host);
            modulosForm.Show();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteEnt clienteSeleccionado = (ClienteEnt)dgvClientes.Rows[dgvClientes.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = clienteSeleccionado.nombre;
            txtApellido.Text = clienteSeleccionado.apellido;
            txtDNI.Text = clienteSeleccionado.dni.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarProducto formAgregarProducto = new FormAgregarProducto();
            formAgregarProducto.ShowDialog();
            object[] fila1 = { };
            dgvProductos.Rows.Add(fila1);
        }
    }
}