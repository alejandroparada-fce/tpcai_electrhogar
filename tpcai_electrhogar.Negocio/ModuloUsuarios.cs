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
        public static Guid idUsuario = ModuloLogueo.UsuarioAuntenticado.id;
        public static void AltaUsuario(int host, string nombre, string apellido, int dni,
            string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña, out string error)
        {
            error = null;
            UsuarioAgregarEnt usuario = new UsuarioAgregarEnt(idUsuario, host, nombre, apellido, dni, direccion, telefono, email,
                fechaNacimiento, nombreUsuario, contraseña);
            
            ServiceUsuario.AgregarUsuario(usuario, out error);
        }


        public static List<UsuarioConsultaEnt> ConsultarUsuarios(out string error)
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

        public static List<UsuarioConsultaEnt> BuscarUsuarios(string nombreUsuario, out string error)
        {
            List<UsuarioConsultaEnt> listaUsuarios = new List<UsuarioConsultaEnt>();
            listaUsuarios = ServiceUsuario.ListarUsuarios(idUsuario, out error);
            List<UsuarioConsultaEnt> listaFiltrada = listaUsuarios.Where(u => u.nombreUsuario.Contains(nombreUsuario)).ToList();
            return listaFiltrada;
        }

        public static void DeshabilitarUsuario(Guid id, string nombre, string apellido, string nombreUsuario, out string error)
        {
            error = null;
            ServiceUsuario.EliminarUsuario(id, idUsuario, out error);
            UsuarioActivarEnt usuarioBaja = new UsuarioActivarEnt(id, nombre, apellido, nombreUsuario);
            ArchivoLocal.AgregarUsuarioBaja(usuarioBaja);
            ArchivoLocal.GrabarUsuariosBaja();
        }

        public static void ActivarUsuario(Guid id, string nombreUsuario, out string error)
        {
            error = null;
            ServiceUsuario.ActivarUsuario(id, idUsuario, out error);
            ArchivoLocal.BorrarUsuarioDesactivados(nombreUsuario);
            ArchivoLocal.GrabarUsuariosBaja();
        }

        public static List<UsuarioActivarEnt> ConsultarUsuariosBaja()
        {
            return ArchivoLocal.ListarUsuariosBaja();
        }

        public static bool ConsultarUsuariosBajaLista()
        {
            return ArchivoLocal.UsuariosDesactivadosListaVacia();
        }
    }
}
