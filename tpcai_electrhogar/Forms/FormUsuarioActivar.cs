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
    public partial class FormUsuarioActivar : Form
    {
        public FormUsuarioActivar()
        {
            InitializeComponent();

            dgvUsuarios.DataSource = ModuloUsuarios.ConsultarUsuariosBaja();
            dgvUsuarios.Columns["id"].Visible = true;
            //dgvUsuarios.Columns[1].HeaderText = "Nombre";
            //dgvUsuarios.Columns[2].HeaderText = "Apellido";
            //dgvUsuarios.Columns[3].HeaderText = "Nombre de Usuario";
            FormUtils.AjustarColumnas(dgvUsuarios);
            //FormUtils.AjustarFilas(dgvUsuarios);
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

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    dgvUsuarios.DataSource = ;
        //    dgvUsuarios.Columns["id"].Visible = true;
        //    dgvUsuarios.Columns[1].HeaderText = "Nombre";
        //    dgvUsuarios.Columns[2].HeaderText = "Apellido";
        //    dgvUsuarios.Columns[3].HeaderText = "Nombre de Usuario";
        //    FormUtils.AjustarColumnas(dgvUsuarios);
        //}

        //private void txtBuscar_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtBuscar.Text == "")
        //    {
        //        dgvUsuarios.DataSource = ;
        //        dgvUsuarios.Columns["id"].Visible = true;
        //        dgvUsuarios.Columns[1].HeaderText = "Nombre";
        //        dgvUsuarios.Columns[2].HeaderText = "Apellido";
        //        dgvUsuarios.Columns[3].HeaderText = "Nombre de Usuario";
        //        FormUtils.AjustarColumnas(dgvUsuarios);
        //    }
        //}

        private void btnActivar_Click(object sender, EventArgs e)
        {
            

            UsuarioActivarEnt usuarioSeleccionado = (UsuarioActivarEnt)dgvUsuarios.Rows[dgvUsuarios.CurrentCell.RowIndex].DataBoundItem;
            Guid id = usuarioSeleccionado.Id;
            string nombreUsuario = usuarioSeleccionado.NombreUsuario;


            if (MessageBox.Show("¿Está seguro que desea activar este usuario?", "¿Activar este usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvUsuarios.Rows.Count > 0)
                {
                    try
                    {
                        ModuloUsuarios.ActivarUsuario(id, Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), nombreUsuario, out string error);
                        if (string.IsNullOrEmpty(error))
                        {
                            dgvUsuarios.DataSource = ModuloUsuarios.ConsultarUsuariosBaja();
                            MessageBox.Show("Usuario activado.");
                            this.Hide();
                            FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
                            ModuloLogueo.UsuarioAuntenticado.host);
                            modulosForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Acción fallida.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No existen usuario desactivados.");
                }
                
            }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }


    }
}
