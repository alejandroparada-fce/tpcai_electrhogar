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
    public partial class FormAgregarProducto : Form
    {
        public FormAgregarProducto()
        {
            InitializeComponent();
            CargarLista();
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
        }
    }

}
