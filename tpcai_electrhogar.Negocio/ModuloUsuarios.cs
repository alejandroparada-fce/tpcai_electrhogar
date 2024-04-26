using PersistenciaWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;


namespace tpcai_electrhogar.Negocio
{
    public static class ModuloUsuarios
    {
        public static void AltaUsuario(Guid idUsuario, int host, string nombre, string apellido, int dni,
            string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña, out string error)
        {
            error = null;
            UsuarioAgregarEnt usuario = new UsuarioAgregarEnt(idUsuario, host, nombre, apellido, dni, direccion, telefono, email,
                fechaNacimiento, nombreUsuario, contraseña);
            
            ServiceUsuario.AgregarUsuario(usuario, out error);
        }
            

        /*
        public static void BajaUsuario(UsuarioEnt usuario)
        {
            usuario.BajaUsuario();
        }
        */
    }
}
