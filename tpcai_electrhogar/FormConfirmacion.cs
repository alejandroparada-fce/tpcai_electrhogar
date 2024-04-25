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

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoClientesForm listadoClientesForm = new ListadoClientesForm();
            listadoClientesForm.Show();
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
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
    }
}
