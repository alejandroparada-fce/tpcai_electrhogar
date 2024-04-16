using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpcai_electrhogar
{
    internal class FormUtils
    {

        // Importamos una funcion de una biblioteca de Windows relacionada a la UI para que el mouse pueda capturar los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
       

        // Importamos una funcion de una biblioteca para enviar mensajes a ventanas/controles en Windows
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        // Funcion para minimizar la aplicacion
        public static void MinimizarFormulario(Form formulario)
        {
            formulario.WindowState = FormWindowState.Minimized;
        }

        
        // Funcion para Maximizar y volver al tamaño anterior
        public static void MaximizarFormulario(Form formulario)
        {
            if (formulario.WindowState == FormWindowState.Maximized)
            {
                // Si está maximizado, vuelve al tamaño anterior
                formulario.WindowState = FormWindowState.Normal;
            }
            else
            {
                // Si no esta maximizado, lo maximiza
                formulario.WindowState = FormWindowState.Maximized;
            }
        }

        // Funcion para salir de la aplicacion
        public static void SalirAplicacion()
        {
            Application.Exit();
        }


        // Funcion para moverse entre formularios (esconde el actual, muestra el siguiente)
        // Testeado en el login y funciona, se encuentra la linea comentada en LoginForm.cs
        public static void CambiarFormulario(Form formularioActual, Form formularioSiguiente)
        {
            formularioActual.Hide();
            formularioSiguiente.Show();
        }


        // Funcion para poder arrastrar/mover los formularios
        public static void MoverFormulario(Form formulario)
        {
            ReleaseCapture();
            SendMessage(formulario.Handle, 0x112, 0xf012, 0);
        }


        // Funcion para limpiar cualquier campo. Si no se completa vuelve al texto que tiene, si se posiciona sobre el textbox, se limpia.
        public static void LimpiarCampo(Form formulario, Control campo, string texto)
        {
            if (campo.Text == texto)
            {
                campo.Text = "";
                campo.ForeColor = Color.LightGray;
            }
            else if (campo.Text == "")
            {
                campo.Text = texto;
                campo.ForeColor = Color.DimGray;
            }
        }


        // Misma funcion que la de LimpiarCampo pero para contraseñas. Se le agrega la funcionalidad de esconder la contraseña mientras se la ingresa.
        public static void LimpiarCampoContrasena(Form formulario, Control campo, string texto)
        {
            if (campo.Text == texto)
            {
                campo.Text = "";
                campo.ForeColor = Color.LightGray;
                if (campo is TextBox textBox)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
            else if (campo.Text == "")
            {
                campo.Text = texto;
                campo.ForeColor = Color.DimGray;
                if (campo is TextBox textBox)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }
    }
}
