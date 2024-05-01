using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;

namespace tpcai_electrhogar.Negocio
{

    public static class ModuloLogueo

    {
        public static LoginEnt logueo;
        public static List<string> LogueosFallidos = new List<string>();
        //public LoginEnt = Loguearse(usuario, contraseña, contraseñaDefault);


        public static void Loguearse(string usuario, string contraseña, string contraseñaDefault)
        {
            LoginEnt logueoAux = new LoginEnt(usuario, contraseña, contraseñaDefault);
            ModuloLogueo.logueo = logueoAux;
            if (logueo.Autenticado == true )
            {
                LogueosFallidos.RemoveAll(u => u == usuario);
            }
            else
            {
                LogueosFallidos.Add(usuario);
            }

        }
        

        public static bool ExisteUsuario()
        {

            return ModuloLogueo.logueo.ExisteUsuario;
        }

        public static bool Autenticado()
        {
            return ModuloLogueo.logueo.Autenticado;
        }

        public static bool CambioContraseña()
        {

            return ModuloLogueo.logueo.CambioContraseña;
        }

        public static bool ChequearBloqueo(string usuario)
        {
            int count = 0;
            foreach (string usuarioFalla in LogueosFallidos)
            {
                if(usuario == usuarioFalla)
                {
                    count++;
                }
            }
            if(count >= 3)
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
