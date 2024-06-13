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
using tpcai_electrhogar.Forms;
using tpcai_electrhogar.Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace tpcai_electrhogar
{
    public partial class FormVentaDevolucion : Form
    {
        public FormVentaDevolucion()
        {
            InitializeComponent();
            FiltrarLista();
        }
        private void FiltrarLista()
        {
            List<ClienteEnt> listaClientes = ObtenerListaClientes();
            string host = "Grupo 6";
            List<ClienteEnt> clientesFiltrados = listaClientes.Where(p => p.host == host).ToList();
            MostrarClientesFiltrados(clientesFiltrados);
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
            FormUtils.AjustarColumnas(dgvClientes);
            FormUtils.AjustarFilas(dgvClientes);
            return listaClientes;
        }
        private void MostrarClientesFiltrados(List<ClienteEnt> listaClientes)
        {
            dgvClientes.Rows.Clear();
            dgvClientes.DataSource = listaClientes;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteEnt clienteSeleccionado = (ClienteEnt)dgvClientes.Rows[dgvClientes.CurrentCell.RowIndex].DataBoundItem;
            Guid id = clienteSeleccionado.id;
        }

        private void FiltrarListaVenta()
        {
            List<VentaClienteEnt> listadoVentasCliente = ObtenerListaVentas();
            int estado = 1;
            List<VentaClienteEnt> ventasFiltradas = listadoVentasCliente.Where(p => p.Estado == estado).ToList();
            MostrarVentasFiltradas(ventasFiltradas);
        }

            private List<VentaClienteEnt> ObtenerListaVentas()
        {
            ClienteEnt clienteSeleccionado = (ClienteEnt)dgvClientes.Rows[dgvClientes.CurrentCell.RowIndex].DataBoundItem;
            Guid id = clienteSeleccionado.id;
            List<VentaClienteEnt> listadoVentasCliente = ModuloVentas.ConsultarVentasCliente(id ,out string error);
            var bindingList = new BindingList<VentaClienteEnt>(listadoVentasCliente);
            var source = new BindingSource(bindingList, null);
            dgvVentas.DataSource = source;
            dgvVentas.Columns["estado"].Visible = false;
            dgvVentas.Columns[0].HeaderText = "Id";
            dgvVentas.Columns[1].HeaderText = "Cantidad";
            dgvVentas.Columns[2].HeaderText = "Fecha Alta";
            FormUtils.AjustarColumnas(dgvClientes);
            FormUtils.AjustarFilas(dgvClientes);
            return listadoVentasCliente;
        }

        private void MostrarVentasFiltradas(List<VentaClienteEnt> listadoVentasCliente)
        {
            dgvVentas.Rows.Clear();
            dgvVentas.DataSource = listadoVentasCliente;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FiltrarListaVenta();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                VentaClienteEnt ventaSeleccionada = (VentaClienteEnt)dgvVentas.Rows[dgvClientes.CurrentCell.RowIndex].DataBoundItem;
                Guid id = ventaSeleccionada.Id;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            
            if (dgvVentas.SelectedRows.Count > 0)
            {

                VentaClienteEnt ventaSeleccionada = (VentaClienteEnt)dgvVentas.Rows[dgvClientes.CurrentCell.RowIndex].DataBoundItem;
                Guid id = ventaSeleccionada.Id;
                try
                {
                    ModuloVentas.DevolverVentas(id, out string error);
                    FiltrarListaVenta();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe cargar la lista.");
            }

           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
ModuloLogueo.UsuarioAuntenticado.host);
            modulosForm.Show();
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

        private void FormVentaDevolucion_MouseDown(object sender, MouseEventArgs e)
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
    }
}
