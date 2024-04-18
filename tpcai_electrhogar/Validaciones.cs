using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpcai_electrhogar
{
    internal static class Validaciones
    {
        public static bool ValidaVaciosFormulario(Form formulario,  out string mensajeError)
        {
            /*El método recorre todos los controles del formulario y chequea que
            los textbox tengan un mínimo y un máximo de longitud.
             */

            string mensajeError1 = null;
            string mensajeError2 = null;

            foreach (Control item in formulario.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
  
                        if (item.Text == null || item.Text.Length < 3)
                        {
                            mensajeError1 = "Debe ingresar al menos 3 caracteres ";
                        }

                        if (item.Text.Length > 10)
                        {
                            mensajeError2 = "El ingreso debe ser menor o igual a 10 caracteres";

                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            mensajeError = mensajeError1 + '\n' + mensajeError2;
            if (string.IsNullOrEmpty(mensajeError))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        //Valida cantidad de caracteres en cadenas de texto
        public static bool ValidarCadena(string ingreso, string campo, int? minCaracteres, int? maxCaracteres, out string mensajeError)
        {
            if (minCaracteres.HasValue && (ingreso == null || ingreso.Length < minCaracteres))
            {
                mensajeError = $"El campo {campo} debe tener al menos {minCaracteres} caracteres";
                return false;
            }

            if (maxCaracteres.HasValue && ingreso.Length > maxCaracteres)
            {
                mensajeError = $"El campo {campo} debe ser menor o igual a {maxCaracteres} caracteres";
                return false;
            }

            mensajeError = null;
            return true;

        }

        public static bool ValidarEntero(string ingreso, string campo, int? minimo, int? maximo, out int valor, out string mensajeError)
        {
            //Valida que sea un número
            var valido = int.TryParse(ingreso, out valor);
            if (!valido)
            {

                mensajeError = $"El campo {campo} debe contener un número entero.";
                return false;
            }

            //valida el número mínimo
            if (minimo.HasValue && valor < minimo.Value)
            {
                mensajeError = $"El campo {campo} debe contener un número mayor o igual a {minimo}";
                return false;
            }

            //valida el número máximo
            if (maximo.HasValue && valor > maximo.Value)
            {
                mensajeError = $"Ingrese un número menor o igual a {maximo} para el campo {campo}.";
                return false;
            }


            mensajeError = null;
            return true;

        }

        //Valida que el nombre de usuario no contenga el nombre y apellido de la persona
        public static bool ValidarPatronUsuario(string nombre, string apellido, string usuario, out string mensajeError) 
        {
            Regex rgNombre = new Regex(nombre, RegexOptions.IgnoreCase);
            Regex rgApellido = new Regex(apellido, RegexOptions.IgnoreCase);

            if(rgNombre.IsMatch(usuario) || rgApellido.IsMatch(usuario))
            {
                mensajeError = "El 'Nombre de Usuario' no debe contener el nombre ni el apellido";
                return false;
            }

            mensajeError = null;
            return true;
        }

        
        public static bool ValidarUsuario(string ingreso, string campoUsuario,  int? minCaracteres, int? maxCaracteres, string nombre, string apellido, string usuario, out string mensajeError)
        {
            string mensajeError1;
            string mensajeError2;

            bool ValCadena = ValidarCadena(ingreso, campoUsuario,  minCaracteres, maxCaracteres, out mensajeError1);
            bool ValidPatUsr = ValidarPatronUsuario(nombre, apellido, usuario, out mensajeError2);
            
            if(!ValCadena||!ValidPatUsr)
            {
                mensajeError = mensajeError1 + "\n" + mensajeError2;
                return false;
            }

            mensajeError = null;
            return true;
        } 
        

        //Valida requisito de mayúsculas y números en contraseña
        private static bool ValidarReqContraseña(string contraseñaIngresada, out string mensajeError)
        {
            Regex letrasMayusculas = new Regex(@"[A-Z]");
            Regex numeros = new Regex(@"[0-9]");
            mensajeError = null;

            //Se chequea que tenga una letra mayuscula
            if (!letrasMayusculas.IsMatch(contraseñaIngresada))
            {
                mensajeError += "Se requiere al menos una letra mayuscula.";
            }

            //Se chequea que tenga un número
            if (!numeros.IsMatch(contraseñaIngresada))
            {
                mensajeError += "\n" + "Se requiere al menos un número.";
            }

            //Si no hay errores se retorna verdadero
            if (string.IsNullOrEmpty(mensajeError))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Valida contraseña
        public static bool ValidarContraseña(string ingreso, string campoContraseña, int? minCaracteres, int? maxCaracteres, out string mensajeError)
        {
            string mensajeError1;
            string mensajeError2;

            bool CadenaContraseña = ValidarCadena(ingreso, campoContraseña, minCaracteres, maxCaracteres, out mensajeError1);
            bool MayusNumContraseña = ValidarReqContraseña(ingreso, out mensajeError2);

            if (!CadenaContraseña|| !MayusNumContraseña)
            {
                mensajeError = mensajeError1 + "\n" + mensajeError2;
                return false;
            }

            mensajeError = null;
            return true;
        }
        public static bool RepeticionContraseña(string contraseña, string contraseñaRepetida, out string mensajeError)
        {
            if (!(contraseña == contraseñaRepetida))
            {
                mensajeError = "Las contraseñas no coinciden";
                return false;
            }
            mensajeError = null;
            return true;
        }
    }
}
