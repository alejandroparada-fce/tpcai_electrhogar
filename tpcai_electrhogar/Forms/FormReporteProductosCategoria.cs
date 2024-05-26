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
    public partial class FormReporteProductosCategoria : Form
    {
        public FormReporteProductosCategoria()
        {
            InitializeComponent();
            cargarGrid();
            
        }
        
        /*---------------------------------------------------------------------------------------------------------------------------------
          Con los servicios del web service no se puede elaborar bien este reporte, procedo a generar ventas aleatorias para su elaboracion
        ----------------------------------------------------------------------------------------------------------------------------------*/

        private void cargarGrid()
        {
            List<ProductoEnt> productos = ModuloProducto.ConsultarProductos(out string error);
            DataTable dataTable = new DataTable();

            
            dataTable.Columns.Add("ID", typeof(Guid));
            dataTable.Columns.Add("Nombre", typeof(string)); 
            dataTable.Columns.Add("Id categoria", typeof(int));
            dataTable.Columns.Add("Ventas", typeof(int));    



           
            Random random = new Random();
            foreach (var producto in productos)
            {
                int ventas = random.Next(1, 1000);
                dataTable.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoria, ventas);
                                                                        
            }


            var productosMasVendidos = from row in dataTable.AsEnumerable()
                                       group row by row.Field<int>("Id categoria") into grp
                                       let maxVentas = grp.Max(r => r.Field<int>("Ventas"))
                                       select grp.First(r => r.Field<int>("Ventas") == maxVentas);

            
            DataTable dataTableFiltrado = dataTable.Clone();
            foreach (var producto in productosMasVendidos)
            {
                dataTableFiltrado.ImportRow(producto);
            }

            DataView dataView = dataTableFiltrado.DefaultView;
            dataView.Sort = "Ventas Desc";
            dataTableFiltrado = dataView.ToTable();

            
            dgvReporte.DataSource = dataTableFiltrado;


            dgvReporte.Columns[0].Visible = false;
            

            FormUtils.AjustarColumnas(dgvReporte);
            FormUtils.AjustarFilas(dgvReporte);

        }

        
        

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            FormUtils.SalirAplicacion();
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            FormUtils.MinimizarFormulario(this);
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            FormUtils.MinimizarFormulario(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
ModuloLogueo.UsuarioAuntenticado.host);
            modulosForm.Show();
        }
    }
}
