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


        public static List<UsuarioConsultaEnt> ConsultarUsuarios(Guid idUsuario, out string error)
        {
            List<UsuarioConsultaEnt> listaUsuarios = new List<UsuarioConsultaEnt>();
            listaUsuarios = ServiceUsuario.ListarUsuarios(idUsuario, out error);
            return listaUsuarios;
        }
        public static void CambiarPassword(string nombreUsuario, string contraseña, string contraseñaNueva, out string error)
        {
            //Se cambia el password y se lo registra en el archivo
            ServiceUsuario.CambiarPassword(nombreUsuario, contraseña, contraseñaNueva, out error);
            CambioContraseñaEnt cambiocontraseña = new CambioContraseñaEnt(nombreUsuario, contraseñaNueva);
            ArchivoLocal.AgregarCambioContraseña(cambiocontraseña);
            ArchivoLocal.GrabarCambiosContraseña();
        }

        public static List<UsuarioConsultaEnt> BuscarUsuarios(Guid idUsuario, string nombreUsuario, out string error)
        {
            List<UsuarioConsultaEnt> listaUsuarios = new List<UsuarioConsultaEnt>();
            listaUsuarios = ServiceUsuario.ListarUsuarios(idUsuario, out error);
            List<UsuarioConsultaEnt> listaFiltrada = listaUsuarios.Where(u => u.nombreUsuario.Contains(nombreUsuario)).ToList();
            return listaFiltrada;
        }

        public static void DeshabilitarUsuario(Guid id, Guid idUsuario, out string error)
        {
            error = null;
            ServiceUsuario.EliminarUsuario(id, idUsuario, out error);
        }


    }
}
