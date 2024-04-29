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
        public static void CambiarPassword(UsuarioEnt usuarioEnt)
        {
            ServiceUsuario.CambiarPassword(usuarioEnt);
        }

        public static List<UsuarioConsultaEnt> BuscararUsuarios(Guid idUsuario, string nombreUsuario, out string error)
        {
            List<UsuarioConsultaEnt> listaUsuarios = new List<UsuarioConsultaEnt>();
            listaUsuarios = ServiceUsuario.ListarUsuarios(idUsuario, out error);
            List<UsuarioConsultaEnt> listaFiltrada = listaUsuarios.Where(u => u.nombreUsuario.Contains(nombreUsuario)).ToList();
            return listaFiltrada;
        }

        public static void DeshabilitarUsuario(Guid id, Guid idusuario, out string error)
        {
            error = null;
            ServiceUsuario.EliminarUsuario(id, idusuario, out error);
        }

        /*
        public static void BajaUsuario(UsuarioEnt usuario)
        {
            usuario.BajaUsuario();
        }
        */
    }
}
