using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;
using PersistenciaWS;
using System.Net.Http;

namespace tpcai_electrhogar.Negocio
{
    public static class ModuloProveedor
    {
        public static List<ProveedorEnt> ProveedorListar(out string error)
        {
            List<ProveedorEnt> proveedoresListar = new List<ProveedorEnt>();
            proveedoresListar = ServiceProveedor.ProveedorListar(out error);
            return proveedoresListar;
        }

        public static void ProveedorEliminar(Guid id, out string error)
        {
            ServiceProveedor.ProveedorEliminar(id, out error);
        }

        public static void ProveedorAgregar(Guid idUsuario, string nombre, DateTime fechaAlta, DateTime? fechaBaja, string cuit, string email, string apellido, out string error)
        {
            ProveedorEnt proveedor = new ProveedorEnt(nombre, fechaAlta, fechaBaja, cuit, email, apellido);
            error = null;

            ServiceProveedor.ProveedorAgregar(proveedor, out error);

        }

        public static void ProveedorReactivar(Guid id, out string error)
        {
            ServiceProveedor.ProveedorReactivar(id, out error);
        }

        public static void ProveedorModificar(Guid id, string nombre, string apellido, string email, string cuit, out string error)
        {
            ServiceProveedor.ProveedorModificar(id, nombre, apellido, email, cuit, out error);
            

        }
    }

}
