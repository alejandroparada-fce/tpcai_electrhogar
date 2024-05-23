using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
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

           public void llenarDataGrid(ProductoVentaEnt producto)
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells["Id"].Value?.ToString() == producto.idProducto.ToString())
                {
                    MessageBox.Show("El producto con este ID ya existe en la lista.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            object[] fila1 = { producto.idProducto, producto.idCategoria, producto.precio, producto.nombre, producto.stock };
            dgvProductos.Rows.Add(fila1);
            CalcularMonto();
            TildarOpciones();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarProducto formAgregarProducto = new FormAgregarProducto(this);
            formAgregarProducto.ShowDialog();
           

        }

        private void BorrarCelda()
        {
            if (dgvProductos.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dgvProductos.SelectedRows)
                {
                    dgvProductos.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila a eliminar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarCelda();
            CalcularMonto();
            TildarOpciones();
           
        }

        private void CalcularMonto()
        {
            decimal suma = 0;
            decimal electroHogar = 0;
            decimal descuentoElectro = 0;
            decimal descuentoCliente = 0;
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells["Precio"].Value != null && decimal.TryParse(row.Cells["Precio"].Value.ToString(), out decimal valor))
                    if (row.Cells["Cantidad"].Value != null && decimal.TryParse(row.Cells["Cantidad"].Value.ToString(), out decimal cantidad))
                {                  
                        
                        suma = suma + (valor * cantidad);

                    if (row.Cells["IdCategoria"].Value != null && int.TryParse(row.Cells["IdCategoria"].Value.ToString(), out int categoria))
                    {
                        if (categoria == 3)

                        {
                            electroHogar = electroHogar + (valor * cantidad);
                        }

                    }
                }
            }

            if (electroHogar > 100000)
            {
                descuentoElectro = electroHogar * 0.05m;
            }

            /*if (esClienteNuevo)
            {
                descuentocliente = (suma - descuentoelectro) * 0.05m;
            }*/

            montoTotal = suma - descuentoElectro; //- descuentocliente;

            txtMontoTotal.Text = montoTotal.ToString();
            txtMontoParcial.Text = suma.ToString();
            txtDescuento.Text = descuentoElectro.ToString();
        }
        private void TildarOpciones()
        {
            if (!(txtDescuento.Text == "0"))
            {
                checkElectro.Checked = true;
            }
            else
            {
               checkElectro.Checked = false;
            }
        }

    }
}