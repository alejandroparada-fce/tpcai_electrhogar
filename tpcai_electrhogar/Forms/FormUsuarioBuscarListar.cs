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

namespace tpcai_electrhogar
{
    public partial class FormUsuarioBuscarListar : Form
    {
        public FormUsuarioBuscarListar()
        {
            InitializeComponent();
  
            dgvUsuarios.DataSource = ModuloUsuarios.ConsultarUsuarios(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), out string error);
            dgvUsuarios.Columns["id"].Visible = false;
            dgvUsuarios.Columns[1].HeaderText = "Nombre";
            dgvUsuarios.Columns[2].HeaderText = "Apellido";
            dgvUsuarios.Columns[3].HeaderText = "DNI";
            dgvUsuarios.Columns[4].HeaderText = "Nombre de Usuario";
            dgvUsuarios.Columns[5].HeaderText = "Host";
            FormUtils.AjustarFilas(dgvUsuarios);
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

        private void ListarBuscarUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormUtils.SalirAplicacion();
        }
    }
}
