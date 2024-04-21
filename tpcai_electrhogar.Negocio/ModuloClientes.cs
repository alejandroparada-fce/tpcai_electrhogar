using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;
using PersistenciaWS;

namespace tpcai_electrhogar.Negocio
{
    public static class ModuloClientes
    {
        public static List<ClienteEnt> ConsultarClientes(out string error)
        {
            List<ClienteEnt> listaClientes = new List<ClienteEnt>();
            listaClientes = ClienteService.ListarClientes(out error);
            return listaClientes;
        }

        public static void AgregarCliente(Guid idUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, string fechaNacimiento, string host, out string error)
        {
            ClienteAgregarEnt cliente = new ClienteAgregarEnt(idUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, host);
            error = null;

            ClienteService.AgregarCliente(cliente, out error);
        }

    }
}
