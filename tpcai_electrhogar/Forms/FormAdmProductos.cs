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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace tpcai_electrhogar.Forms
{
    public partial class FormAdmProductos : Form
    {

        public FormAdmProductos()
        {
            InitializeComponent();
        }

        private List<ProductoEnt> ObtenerListaProductos()
        {
            List<ProductoEnt> listaProductos = ModuloProducto.ConsultarProductos(out string error);
            var bindingList = new BindingList<ProductoEnt>(listaProductos);
            var source = new BindingSource(bindingList, null);
            dgvProductos.DataSource = source;
            dgvProductos.Columns["id"].Visible = false;
            dgvProductos.Columns["fechaBaja"].Visible = false;
            dgvProductos.Columns[1].HeaderText = "Id Categoria";
            dgvProductos.Columns[2].HeaderText = "Nombre";
            dgvProductos.Columns[3].HeaderText = "Fecha de Alta";
            dgvProductos.Columns[4].HeaderText = "Stock";
            dgvProductos.Columns[5].HeaderText = "Precio";
            return listaProductos;
        }
        private void CargarLista()
        {
            List<ProductoEnt> listaProductos = ObtenerListaProductos();
        }


      
        private void FormProductoBaja_MouseDown(object sender, MouseEventArgs e)
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

        private void cargarProductosBtn_Click(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void TraerProductosCategoria_Click(object sender, EventArgs e)
        {
            string mensajeError = "";
            
            bool validar1 = Validaciones.ValidarEntero(categoria.Text, "categoria", 1, 5, out int idCategoria, out string mensajeError1);
            mensajeError = mensajeError1;
            lblError.Text = mensajeError;
            if (validar1)
            {
                try
                {
                    ModuloProducto.ConsultarProductosCategoria(idCategoria, out string error);
                    CargarListaCategoria();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private List<ProductoEnt> ObtenerListaProductosCategoria()
        {
            int idCategoria = int.Parse(categoria.Text);
            List<ProductoEnt> listaProductosCategoria = ModuloProducto.ConsultarProductosCategoria(idCategoria, out string error);
            var bindingList = new BindingList<ProductoEnt>(listaProductosCategoria);
            var source = new BindingSource(bindingList, null);
            dgvProductos.DataSource = source;
            dgvProductos.Columns["id"].Visible = false;
            dgvProductos.Columns["fechaBaja"].Visible = false;
            dgvProductos.Columns[1].HeaderText = "Id Categoria";
            dgvProductos.Columns[2].HeaderText = "Nombre";
            dgvProductos.Columns[3].HeaderText = "Fecha de Alta";
            dgvProductos.Columns[4].HeaderText = "Stock";
            dgvProductos.Columns[5].HeaderText = "Precio";
            return listaProductosCategoria;
        }
        private void CargarListaCategoria()
        {
            List<ProductoEnt> listaProductosCategoria = ObtenerListaProductosCategoria();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoEnt productoSeleccionado = (ProductoEnt)dgvProductos.Rows[dgvProductos.CurrentCell.RowIndex].DataBoundItem;
            int stock = productoSeleccionado.Stock;
            double precio = productoSeleccionado.Precio;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
ModuloLogueo.UsuarioAuntenticado.host);
            modulosForm.Show();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            FormProductoRegistrar formProductoRegistrar = new FormProductoRegistrar();
            formProductoRegistrar.ShowDialog();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            ProductoEnt productoseleccionado = (ProductoEnt)dgvProductos.Rows[dgvProductos.CurrentCell.RowIndex].DataBoundItem;
            Guid id = productoseleccionado.Id;
            FormModificarProducto formModificarProducto = new FormModificarProducto(id);
            formModificarProducto.ShowDialog();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            ProductoEnt productoseleccionado = (ProductoEnt)dgvProductos.Rows[dgvProductos.CurrentCell.RowIndex].DataBoundItem;
            Guid id = productoseleccionado.Id;
            try
            {
                ModuloProducto.EliminarProducto(id, out string error);
                this.Hide();
                FormAdmProductos formAdmProductos = new FormAdmProductos();
                formAdmProductos.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
