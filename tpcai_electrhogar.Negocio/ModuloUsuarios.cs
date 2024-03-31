using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;


namespace tpcai_electrhogar.Negocio
{
    internal class ModuloUsuarios
    {
        public static bool AltaUsuario(string nombre, string apellido, int dni, DateTime fechaNacimiento, string direccion,
            string telefono, string correoElectronico, string nombreUsuario, string contraseña,
            DateTime fechaAlta, DateTime? fechaBaja, int host)
        {
            
            UsuarioEnt usuario = new UsuarioEnt(nombre, apellido, dni, fechaNacimiento, direccion, telefono, correoElectronico,
                nombreUsuario, contraseña, fechaAlta, null, host, false);

            return usuario.ValidaUsuario();
        }

        public static void BajaUsuario(UsuarioEnt usuario)
        {
            usuario.BajaUsuario();
        }
    }
}
