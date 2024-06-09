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

namespace tpcai_electrhogar
{
    public partial class FormUsuarioBuscarBaja : Form
    {
        public FormUsuarioBuscarBaja()
        {
            InitializeComponent();
  
            dgvUsuarios.DataSource = ModuloUsuarios.ConsultarUsuarios(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), out string error);
            dgvUsuarios.Columns["id"].Visible = false;
            dgvUsuarios.Columns[1].HeaderText = "Nombre";
            dgvUsuarios.Columns[2].HeaderText = "Apellido";
            dgvUsuarios.Columns[3].HeaderText = "DNI";
            dgvUsuarios.Columns[4].HeaderText = "Nombre de Usuario";
            dgvUsuarios.Columns[5].HeaderText = "Host";
            FormUtils.AjustarColumnas(dgvUsuarios);
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
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
            ModuloLogueo.UsuarioAuntenticado.host);
            modulosForm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = ModuloUsuarios.BuscarUsuarios(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), txtBuscar.Text, out string error);
            dgvUsuarios.Columns["id"].Visible = false;
            dgvUsuarios.Columns[1].HeaderText = "Nombre";
            dgvUsuarios.Columns[2].HeaderText = "Apellido";
            dgvUsuarios.Columns[3].HeaderText = "DNI";
            dgvUsuarios.Columns[4].HeaderText = "Nombre de Usuario";
            dgvUsuarios.Columns[5].HeaderText = "Host";
            FormUtils.AjustarColumnas(dgvUsuarios);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                dgvUsuarios.DataSource = ModuloUsuarios.ConsultarUsuarios(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), out string error);
                dgvUsuarios.Columns["id"].Visible = false;
                dgvUsuarios.Columns[1].HeaderText = "Nombre";
                dgvUsuarios.Columns[2].HeaderText = "Apellido";
                dgvUsuarios.Columns[3].HeaderText = "DNI";
                dgvUsuarios.Columns[4].HeaderText = "Nombre de Usuario";
                dgvUsuarios.Columns[5].HeaderText = "Host";
                FormUtils.AjustarColumnas(dgvUsuarios);
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            UsuarioConsultaEnt usuarioSeleccionado = (UsuarioConsultaEnt)dgvUsuarios.Rows[dgvUsuarios.CurrentCell.RowIndex].DataBoundItem;
            Guid id = usuarioSeleccionado.id;
            string nombre = usuarioSeleccionado.nombre;
            string apellido = usuarioSeleccionado.apellido;
            string nombreUsuario = usuarioSeleccionado.nombreUsuario;
            if (MessageBox.Show("¿Está seguro de dar de baja este usuario?", "¿Dar de baja al usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ModuloUsuarios.DeshabilitarUsuario(id, Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), nombre, apellido, nombreUsuario, out string error);
                    if (string.IsNullOrEmpty(error))
                    {
                        dgvUsuarios.DataSource = ModuloUsuarios.ConsultarUsuarios(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), out error);
                        MessageBox.Show("Usuario dado de baja");
                    }
                    else
                    {
                        MessageBox.Show("Acción fallida");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }
    }
}
