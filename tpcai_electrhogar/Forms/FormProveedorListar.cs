using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Datos;
using tpcai_electrhogar.Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace tpcai_electrhogar
{
    public partial class FormProveedorListar : Form
    {
        public FormProveedorListar()
        {
            InitializeComponent();
        }
        private string mensajeError;

        private void ListadoClientesForm_Load(object sender, EventArgs e)
        {
            //dgvClientes.DataSource = ModuloClientes.ConsultarClientes(out string error);
            List<ProveedorEnt> listaProveedor = ModuloProveedor.ProveedorListar(out string error);

            var bindingList = new BindingList<ProveedorEnt>(listaProveedor);
            var source = new BindingSource(bindingList, null);
            dgvProveedores.DataSource = source;
            dgvProveedores.Columns["id"].Visible = false;
            dgvProveedores.Columns[1].HeaderText = "Nombre";
            dgvProveedores.Columns[2].HeaderText = "Apellido";
            dgvProveedores.Columns[3].HeaderText = "Email";
            dgvProveedores.Columns[4].HeaderText = "CUIT"; 
            dgvProveedores.Columns[5].HeaderText = "Fecha Alta";
            dgvProveedores.Columns[6].HeaderText = "Fecha Baja";
        }


        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            ClienteEnt clienteSeleccionado = (ClienteEnt)dgvProveedores.Rows[dgvProveedores.CurrentCell.RowIndex].DataBoundItem;

            Guid id = clienteSeleccionado.id;
            String direccion = txtNombre.Text;
            String telefono = txtApellido.Text;
            String email = txtEmail.Text;
            bool valido1 = Validaciones.ValidarCadena(txtNombre.Text, "'Dirección'", 3, 30, out string mensajeError1);
            bool valido2 = Validaciones.ValidarCadena(txtApellido.Text, "'Teléfono'", 3, 30, out string mensajeError2);
            bool valido3 = Validaciones.ValidarCadena(txtEmail.Text, "'Correo Electrónico'", 3, 30, out string mensajeError3);
            mensajeError = mensajeError1 + "\n" + mensajeError2 + "\n" + mensajeError3;
            lblError.Text = mensajeError;

            if (valido1 & valido2 & valido3)
            {
                try
                {
                    ModuloClientes.ModificarCliente(id, direccion, telefono, email, out string error);
                    this.Hide();
                    FormProveedorListar listadoClientesForm = new FormProveedorListar();
                    listadoClientesForm.Show();

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
            FormMenuPrincipal modulosForm = new FormMenuPrincipal();
            modulosForm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteEnt clienteseleccionado = (ClienteEnt)dgvProveedores.Rows[dgvProveedores.CurrentCell.RowIndex].DataBoundItem;
            Guid id = clienteseleccionado.id;

                FormConfirmacion formConfirmacion = new FormConfirmacion(id);
                formConfirmacion.ShowDialog();
                this.Hide();
                FormProveedorListar listadoClientesForm = new FormProveedorListar();
                listadoClientesForm.Show();


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

        private void FormClienteListar_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProveedorEnt proveedorSeleccionado = (ProveedorEnt)dgvProveedores.Rows[dgvProveedores.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = proveedorSeleccionado.Nombre;
            txtApellido.Text = proveedorSeleccionado.Apellido;
            txtEmail.Text = proveedorSeleccionado.Email;
            txtCUIT.Text = proveedorSeleccionado.CUIT;
        }
    }
    }

