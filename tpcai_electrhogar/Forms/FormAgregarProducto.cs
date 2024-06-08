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
using tpcai_electrhogar.Negocio;

namespace tpcai_electrhogar.Forms
{
    public partial class FormAgregarProducto : Form
    {
        private FormVentaRegistrar formVentaRegistrar;
        public FormAgregarProducto(FormVentaRegistrar formVentaRegistrar)
        {
            InitializeComponent();
            CargarLista();
            this.formVentaRegistrar = formVentaRegistrar;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formVentaRegistrar.Show();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoEnt productoSeleccionado = (ProductoEnt)dgvProductos.Rows[dgvProductos.CurrentCell.RowIndex].DataBoundItem;
            int stock = productoSeleccionado.Stock;
            double precio = productoSeleccionado.Precio;
            Guid id = productoSeleccionado.Id;
            int categoria = productoSeleccionado.IdCategoria;
            string nombre = productoSeleccionado.Nombre;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensajeError = "";
            ProductoEnt productoSeleccionado = (ProductoEnt)dgvProductos.Rows[dgvProductos.CurrentCell.RowIndex].DataBoundItem;
            int stock = productoSeleccionado.Stock;
            bool validar1 = Validaciones.ValidarEntero(cantidadNumeric.Text, "'Stock'", 1, 2147483647, out int cantidad, out string mensajeError1);
            bool validar2 = Validaciones.CantidadMinima(cantidad, stock, out string mensajeError2);
            mensajeError = mensajeError1 + "\n" + mensajeError2;
            if (cantidad > 0.75 * stock)
            {
                MessageBox.Show("El producto ingresara en Stock critico");
            }
            if ((validar1 & validar2) == true)
            {
                ProductoVentaEnt producto = new ProductoVentaEnt();
                producto.idCategoria = productoSeleccionado.IdCategoria;
                producto.idProducto = productoSeleccionado.Id;
                producto.nombre = productoSeleccionado.Nombre;
                producto.precio = productoSeleccionado.Precio;
                producto.stock = cantidad;
                formVentaRegistrar.llenarDataGrid(producto);
                this.Hide();
                //FormVentaRegistrar formVentaRegistrar = new FormVentaRegistrar();
                formVentaRegistrar.Show();
            }
            else
            {
                lblError.Text = mensajeError;
            }
            }
        }
    }




           


