using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;
using PersistenciaWS;


namespace tpcai_electrhogar.Negocio
{
    public class UsuarioNegocio
    {
        private UsuarioService usuarioService = new UsuarioService();

        public void CambiarPassword(UsuarioEnt usuarioEnt)
        {
            usuarioService.CambiarPassword(usuarioEnt);
        }

        public void ActivarUsuario(UsuarioEnt id)
        {
            usuarioService.ActivarUsuario(id);
        }
    }
}
        
        


