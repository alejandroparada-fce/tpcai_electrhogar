using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Negocio;

namespace tpcai_electrhogar.Forms
{
    public partial class FormReporteProductosCategoria : Form
    {
        public FormReporteProductosCategoria()
        {
            InitializeComponent();
            cargarGrid();
            dgvReporte.DataBindingComplete += DgvReporte_DataBindingComplete;
        }
        


        private void cargarGrid()
        {
            dgvReporte.DataSource = ModuloProducto.ConsultarProductos(out string error);
            dgvReporte.Columns.Add("Ventas", "Ventas");
            dgvReporte.Columns[0].Visible = false;
            dgvReporte.Columns[3].Visible = false;
            dgvReporte.Columns[4].Visible = false;
            dgvReporte.Columns[5].Visible = false;
            dgvReporte.Columns[6].Visible = false;
            
        }

        private void DgvReporte_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            Random random = new Random();

            foreach (DataGridViewRow row in dgvReporte.Rows)
            {
                if (!row.IsNewRow)
                {

                    int ventas = random.Next(1, 1000);
                    row.Cells["Ventas"].Value = ventas;
                }
            }



            FormUtils.AjustarColumnas(dgvReporte);
            
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
    }
}
