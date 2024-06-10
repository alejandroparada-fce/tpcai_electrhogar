using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;
using PersistenciaWS;
using System.Runtime.CompilerServices;

namespace tpcai_electrhogar.Negocio
{
    public static class ModuloClientes
    {
        public static Guid idUsuario = ModuloLogueo.UsuarioAuntenticado.id;
        public static String host = "Grupo 6";
        public static List<ClienteEnt> ConsultarClientes(out string error)
        {
            List<ClienteEnt> listaClientes = new List<ClienteEnt>();
            listaClientes = ServiceCliente.ListarClientes(out error);
            return listaClientes;
        }
        //Revisar Agregar Cliente
        public static void AgregarCliente( string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, out string error)
        {
           
            ClienteAgregarEnt cliente = new ClienteAgregarEnt(idUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, host);
            error = null;
            ServiceCliente.AgregarCliente(cliente, out error);

        }
        public static void ModificarCliente(Guid id, string direccion, string telefono, string email, out string error)
        {
            ServiceCliente.ModificarCliente(id, direccion, telefono, email, out error);
        }

        public static void EliminarCliente(Guid id, out string error)
        {
            ServiceCliente.EliminarCliente(id, out error);
        }
    }

}
