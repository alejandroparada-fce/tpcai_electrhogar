﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Datos;
using tpcai_electrhogar.Forms;
using tpcai_electrhogar.Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace tpcai_electrhogar
{
    public partial class FormProveedorAdm : Form
    {
        public FormProveedorAdm()
        {
            InitializeComponent();
            ObtenerListaProveedor();
        }
        private string mensajeError;

        public static Guid idUsuario = new Guid("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        public static Guid idProveedor = new Guid("8fc1b7c9-a59b-46b2-af97-1ac9d9b48773");


        private List<ProveedorEnt> ObtenerListaProveedor()
        {
            List<ProveedorEnt> listaProveedor = ModuloProveedor.ProveedorListar(out string error);
            var bindingList = new BindingList<ProveedorEnt>(listaProveedor);
            var source = new BindingSource(bindingList, null);
            dgvProveedor.DataSource = source;
            dgvProveedor.Columns["id"].Visible = true;
            //dgvProveedor.Columns[1].HeaderText = "Id";
            dgvProveedor.Columns[1].HeaderText = "Nombre";
            dgvProveedor.Columns[2].HeaderText = "Apellido";
            dgvProveedor.Columns[3].HeaderText = "Email";
            dgvProveedor.Columns[4].HeaderText = "CUIT";
            FormUtils.AjustarColumnas(dgvProveedor);
            FormUtils.AjustarFilas(dgvProveedor);
            return listaProveedor;
            
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProveedorEnt proveedorSeleccionado = (ProveedorEnt)dgvProveedor.Rows[dgvProveedor.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = proveedorSeleccionado.Nombre;
            txtApellido.Text = proveedorSeleccionado.Apellido;
            txtEmail.Text = proveedorSeleccionado.Email;
            txtCUIT.Text = proveedorSeleccionado.CUIT;
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

        private void FormClienteListar_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.MoverFormulario(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProveedorEnt proveedorSeleccionado = (ProveedorEnt)dgvProveedor.Rows[dgvProveedor.CurrentCell.RowIndex].DataBoundItem;

            Guid idProveedorSeleccionado = proveedorSeleccionado.Id;
            ModuloProveedor.ProveedorBaja(idUsuario, idProveedorSeleccionado, out string error);

            //ProveedorEnt proveedorseleccionado = (ProveedorEnt)dgvProveedor.Rows[dgvProveedor.CurrentCell.RowIndex].DataBoundItem;
            //Guid id = proveedorseleccionado.id;
            //
            //try
            //{
            //    ModuloProducto.EliminarProducto(id, out string error);
            //    this.Hide();
            //    FormAdmProductos formAdmProductos = new FormAdmProductos();
            //    formAdmProductos.Show();
            //
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //FormConfirmacion formConfirmacion = new FormConfirmacion(id);
            //formConfirmacion.ShowDialog();
            //this.Hide();
            //FormProveedorListar listadoClientesForm = new FormProveedorListar();
            //listadoClientesForm.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal modulosForm = new FormMenuPrincipal(ModuloLogueo.UsuarioAuntenticado.nombreUsuario,
            ModuloLogueo.UsuarioAuntenticado.host);
            modulosForm.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ProveedorEnt proveedorSeleccionado = (ProveedorEnt)dgvProveedor.Rows[dgvProveedor.CurrentCell.RowIndex].DataBoundItem;

            Guid id = idUsuario;
            Guid idProveedor = proveedorSeleccionado.Id;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String email = txtEmail.Text;
            String cuit = txtCUIT.Text;
            bool valido1 = Validaciones.ValidarCadena(txtNombre.Text, "'Nombre'", 3, 30, out string mensajeError1);
            bool valido2 = Validaciones.ValidarCadena(txtApellido.Text, "'Apellido'", 3, 30, out string mensajeError2);
            bool valido3 = Validaciones.ValidarCadena(txtEmail.Text, "'Correo Electrónico'", 3, 30, out string mensajeError3);
            bool valido4 = Validaciones.ValidarCadena(txtCUIT.Text, "'CUIT'", 10, 13, out string mensajeError4);
            mensajeError = mensajeError1 + "\n" + mensajeError2 + "\n" + mensajeError3 + "\n" + mensajeError4;
            lblError.Text = mensajeError;

            if (valido1 & valido2 & valido3 & valido4)
            {
                try
                {
                    ModuloProveedor.ProveedorModificar(id, idProveedor, nombre, apellido, email, cuit, out string error);
                    this.Hide();
                    FormProveedorAdm listadoProveedorForm = new FormProveedorAdm();
                    listadoProveedorForm.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProveedorRegistrar registrarProveedorForm = new FormProveedorRegistrar();
            registrarProveedorForm.Show();
        }


    }
}
