using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;
using PersistenciaWS;


namespace tpcai_electrhogar.Negocio
{
   
    public static class UsuarioNegocio
    {
        public static void Prueba()
        {
            UsuarioService prueba = new UsuarioService();
            prueba.prueba();
        }
        private static UsuarioService usuarioService = new UsuarioService();

        public static void CambiarPassword(UsuarioEnt usuarioEnt)
        {
            usuarioService.CambiarPassword(usuarioEnt);
        }

        public static void ActivarUsuario(UsuarioEnt id)
        {
            usuarioService.ActivarUsuario(id);
        }
    }
}
        
        


