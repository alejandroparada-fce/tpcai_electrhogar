using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpcai_electrhogar
{
    public partial class RegistrarUsuariosForm : Form
    {
        /*Se usa como convención para el nombre de formularios describir
        la función del mismo + "Form"
        Apariencia/BackColor: 77; 99; 196 (RGB)
        Estilo De ventana/Opacity: 95 %
        Textbox: se sacan bordes, se cambia fuente a verdana y se usa itálica.
        Se agrega panel dockeado a la izquierda.
        */
        public RegistrarUsuariosForm()
        {
            InitializeComponent();
        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            lblNombreError.Text = "Error de Nombre";
            lblApellidoError.Text = "Error de Apellido";
            lblDNIError.Text = "Error de DNI";
            lblDireccionError.Text = "Error de Dirección";
            lblTelefonoError.Text = "Error de teléfono";
            lblMailError.Text = "Error de Mail";
            lblUsuarioError.Text = "Error de Usuario";
        }


    }
}
