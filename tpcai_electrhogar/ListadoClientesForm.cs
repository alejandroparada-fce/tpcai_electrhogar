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
    public partial class ListadoClientesForm : Form
    {
        public ListadoClientesForm()
        {
            InitializeComponent();
        }

        private void ListadoClientesForm_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = ModuloClientes.ConsultarClientes(out string error);
        }
    }
}
