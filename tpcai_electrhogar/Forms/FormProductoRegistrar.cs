using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Datos;
using tpcai_electrhogar.Forms;
using tpcai_electrhogar.Negocio;

namespace tpcai_electrhogar
{
    public partial class FormProductoRegistrar : Form
    {
        private string mensajeError;
        public FormProductoRegistrar()
        {
            InitializeComponent();
            ObtenerListaProveedor();
        }

        private List<ProveedorEnt> ObtenerListaProveedor()
        {
            List<ProveedorEnt> listaProveedor = ModuloProveedor.ProveedorListar(out string error);
            var bindingList = new BindingList<ProveedorEnt>(listaProveedor);
            var source = new BindingSource(bindingList, null);
            dgvProveedor.DataSource = source;
            dgvProveedor.Columns["id"].Visible = false;
            //dgvProveedor.Columns["fechaBaja"].Visible = false;
            dgvProveedor.Columns[1].HeaderText = "Nombre";
            dgvProveedor.Columns[2].HeaderText = "Apellido";
            dgvProveedor.Columns[3].HeaderText = "Email";
            dgvProveedor.Columns[4].HeaderText = "CUIT";
            //dgvProveedor.Columns[5].HeaderText = "Fecha Alta";
            return listaProveedor;
        }
        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProveedorEnt proveedorSeleccionado = (ProveedorEnt)dgvProveedor.Rows[dgvProveedor.CurrentCell.RowIndex].DataBoundItem;
            Guid idProveedor = proveedorSeleccionado.Id;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool valido1 = Validaciones.ValidarCadena(nombreProducto.Text, "'Nombre'", 3, 30, out string mensajeError1);
            bool valido2 = Validaciones.ValidarEntero(CategoriaCombo.Text, "'Categoria'", -2147483647, 2147483647, out int idCategoria, out string mensajeError2);
            bool valido3 = Validaciones.ValidarEnteroDouble(precioNumeric.Text, "Precio", 0, 2147483647, out double precio, out string mensajeError3);
            bool valido4 = Validaciones.ValidarEntero(stockNumeric.Text, "'Stock'", -2147483647, 2147483647, out int stock, out string mensajeError4);

            mensajeError = mensajeError1 + "\n" + mensajeError2 + "\n" + mensajeError3 + "\n" + mensajeError4;
            lblError.Text = mensajeError;

            ProveedorEnt proveedorSeleccionado = (ProveedorEnt)dgvProveedor.Rows[dgvProveedor.CurrentCell.RowIndex].DataBoundItem;
            Guid idProveedor = proveedorSeleccionado.Id;

            if (valido1 & valido2 & valido3 & valido4)
            {
                try
                {
                    ModuloProducto.AgregarProducto(idCategoria, idProveedor, nombreProducto.Text, precio, stock, out string error);
                    this.Hide();
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error);
                    }
                    else
                    {
                        MessageBox.Show("Producto Creado");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormProductoRegistrar_MouseDown(object sender, MouseEventArgs e)
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

        private void btnCancelarContrasena_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
ModuloLogueo.UsuarioAuntenticado.host);
            modulosForm.Show();
        }
    }
}
