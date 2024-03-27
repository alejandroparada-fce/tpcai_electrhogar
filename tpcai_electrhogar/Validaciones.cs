using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                catch { }
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
    }
}
