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
    public partial class ListadoClientesForm : Form
    {
        public ListadoClientesForm()
        {
            InitializeComponent();
        }

        private void ListadoClientesForm_Load(object sender, EventArgs e)
        {
            //dgvClientes.DataSource = ModuloClientes.ConsultarClientes(out string error);
            List<ClienteEnt> listaClientes = ModuloClientes.ConsultarClientes(out string error);

            foreach (ClienteEnt c in listaClientes)
            {
                int rowIndex  = dgvClientes.Rows.Add();
                DataGridViewRow row = dgvClientes.Rows[rowIndex];
                row.Cells[0].Value = c.id;
                row.Cells[1].Value = c.nombre;
                row.Cells[2].Value = c.apellido;
                row.Cells[3].Value = c.dni;
                row.Cells[4].Value = c.direccion;
                row.Cells[5].Value = c.telefono;
                row.Cells[6].Value = c.email;
                row.Cells[7].Value = c.fechaNacimiento;
                row.Cells[8].Value = c.fechaAlta;
                row.Cells[9].Value = c.fechaBaja;
                row.Cells[10].Value = c.host;

            }
        }
    }
}
