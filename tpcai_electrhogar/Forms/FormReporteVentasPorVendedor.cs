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
    public partial class FormReporteVentasPorVendedor : Form
    {
        public FormReporteVentasPorVendedor()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        private void ReporteVentasPorVendedorForm_Load(object sender, EventArgs e)
        {
            dgvReporteVentas.DataSource = ModuloVentas.GenerarReporteVentasMes(out string error);
            FormUtils.AjustarColumnas(dgvReporteVentas);
            FormUtils.AjustarFilas(dgvReporteVentas);
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            FormUtils.MinimizarFormulario(this);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            FormUtils.MinimizarFormulario(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormUtils.SalirAplicacion();
        }

        private void FormReporteVentasPorVendedor_MouseDown_1(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void lblReporte_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
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
