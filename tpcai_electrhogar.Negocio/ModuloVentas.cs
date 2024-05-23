using PersistenciaWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;
using PersistenciaWS;
using System.Runtime.CompilerServices;
using System.IO;

namespace tpcai_electrhogar.Negocio
{
    public static class ModuloVentas
    {
        public static string idUsuario = "2355f8c3-bd38-48c9-8f5d-22c1f88a59d6";
        public static List<VentaClienteEnt> ConsultarVentasCliente(Guid id, out string error)
        {
            List<VentaClienteEnt> listadoVentasCliente = new List<VentaClienteEnt>();
            listadoVentasCliente = ServiceVentas.ListarVentasCliente(id, out error);
            return listadoVentasCliente;
        }

        public static void DevolverVentas(Guid id, out string error)
        {
            ServiceVentas.DevolverVentas(id, idUsuario, out error);
        }

        public static void AgregarVenta(AltaVenta venta, out string error)
        {
            ServiceVentas.AgregarVenta(venta , out error);
        }
    }

}
