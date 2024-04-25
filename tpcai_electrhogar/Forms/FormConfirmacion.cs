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

namespace tpcai_electrhogar
{
    public partial class FormConfirmacion : Form
    {
        private Guid idSeleccionado;
        public FormConfirmacion(Guid id)
        {
            InitializeComponent();
            idSeleccionado = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClienteListar listadoClientesForm = new FormClienteListar();
            listadoClientesForm.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Guid id = idSeleccionado;
            try
            {
                ModuloClientes.EliminarCliente(id, out string error);
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConfirmacion_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }
    }
}
