using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Negocio;

namespace tpcai_electrhogar.Forms
{
    public partial class FormModificarProducto : Form
    {
        private string mensajeError;
        private Guid idSeleccionada;
            public FormModificarProducto(Guid id)
        {
            InitializeComponent();
            idSeleccionada = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmProductos formAdmProductos = new FormAdmProductos();
            formAdmProductos.Show();
        }

        private void cambiarBtn_Click(object sender, EventArgs e)
        {
      

            Guid id = idSeleccionada;

            string mensajeError = "";

            bool validar1 = Validaciones.ValidarEntero(stockCambio.Text, "stock", -2147483647, 2147483647, out int precio, out string mensajeError1);
            bool validar2 = Validaciones.ValidarEnteroDouble(precioCambio.Text, "precio", 0, 2147483647, out double stock, out string mensajeError2);
            mensajeError = mensajeError1;
            lblError.Text = mensajeError;
            if (validar1 & validar2)
            {
                try
                {
                    ModuloProducto.ModificarProducto(precio, stock , id,  out string error);
                    this.Hide();
                    FormAdmProductos formAdmProductos = new FormAdmProductos();
                    formAdmProductos.Show();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
