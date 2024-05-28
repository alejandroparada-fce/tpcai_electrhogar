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
    public partial class FormStockCritico : Form
    {
        public FormStockCritico()
        {
            InitializeComponent();
            List<ProductoEnt> listaProductosCritico = ModuloProducto.ReporteStockCritico(cmbCategorias.SelectedIndex, out string error);
            //Si la lsita contiene elementos emito un warning
            if (listaProductosCritico.Any())
            {
                lblWarning.Text = "Hay Productos con stock Critico";
            }
            dgvStockCritico.DataSource = listaProductosCritico;
            dgvStockCritico.Columns["Id"].Visible = false;
            dgvStockCritico.Columns[2].HeaderText = "Categoría";
            dgvStockCritico.Columns[4].HeaderText = "Fecha de Alta";
            dgvStockCritico.Columns[5].HeaderText = "Fecha de Baja";
            FormUtils.AjustarColumnas(dgvStockCritico);
            FormUtils.AjustarFilas(dgvStockCritico);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
ModuloLogueo.UsuarioAuntenticado.host);
            modulosForm.Show();
        }

        private void FormStockCritico_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProductoEnt> listaProductosCritico = ModuloProducto.ReporteStockCritico(cmbCategorias.SelectedIndex, out string error);
            //Si la lsita contiene elementos emito un warning
            if (listaProductosCritico.Any())
            {
                lblWarning.Text = "Hay Productos con stock Critico";
            }
            dgvStockCritico.DataSource = listaProductosCritico;
            dgvStockCritico.Columns["Id"].Visible = false;
            FormUtils.AjustarColumnas(dgvStockCritico);
            if(cmbCategorias.SelectedIndex != 0)
            {
                FormUtils.AjustarFilas(dgvStockCritico);
            }
            
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
    }
}
