﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpcai_electrhogar
{
    internal static class Validaciones
    {
        
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
        public static bool ValidarEnteroDouble(string ingreso, string campo, int? minimo, int? maximo, out double valor, out string mensajeError)
        {
            //Valida que sea un número
            var valido = double.TryParse(ingreso, out valor);
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
        public static bool CantidadMinima(int cantidad, int stock, out string mensajeError)
        {
            if (cantidad > stock)
            {
                mensajeError = "La cantidad ingresada supera al stock del producto";
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
        public static bool RepetirContraseña(string contraseña, string contraseñaRepetida, string viejaContraseña, out string mensajeError)
        {
            if (!(contraseña == contraseñaRepetida))
            {
                mensajeError = "Las contraseñas no coinciden";
                return false;
            }
            else if(contraseña == viejaContraseña)
            {
                mensajeError = "Esta contraseña ya ha sido utilizada";
                return false;
            }
            mensajeError = null;
            return true;
        }
    }

}
