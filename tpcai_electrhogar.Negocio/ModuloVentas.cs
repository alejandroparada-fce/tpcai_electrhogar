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
        public static Guid idUsuario = ModuloLogueo.UsuarioAuntenticado.id;
        public static List<VentaClienteEnt> ConsultarVentasCliente(Guid id, out string error)
        {
            List<VentaClienteEnt> listadoVentasCliente = new List<VentaClienteEnt>();
            listadoVentasCliente = ServiceVentas.ListarVentasCliente(id, out error);
            return listadoVentasCliente;
        }

        public static List<VentasPorMesEnt> GenerarReporteVentasMes(out string error)
        {
            error = null;
            //Se toma una lista de todos los clientes
            List<ClienteEnt> listadoClientes = new List<ClienteEnt>();
            listadoClientes = ServiceCliente.ListarClientes(out string error1);

            //Se genera una lista de todas las ventas
            List<VentaClienteEnt> Ventas = new List<VentaClienteEnt>();
            foreach(ClienteEnt cliente in listadoClientes)
            {
                List<VentaClienteEnt> VentasCliente = new List<VentaClienteEnt>();
                VentasCliente = ServiceVentas.ListarVentasCliente(cliente.id, out string error2);
                foreach(VentaClienteEnt venta in VentasCliente)
                {
                    Ventas.Add(venta);
                }
            }
            //Se usa LINQ para agrupar y sumar las ventas por mes y año de fecha de alta
            var ventasPorMesYAño = from venta in Ventas
                                             group venta by new { Mes = venta.FechaAlta.Month, Año = venta.FechaAlta.Year } into grupo
                                             select new VentasPorMesEnt
                                             {
                                                 Mes = grupo.Key.Mes,
                                                 Año = grupo.Key.Año,
                                                 TotalVentas = grupo.Sum(v => v.Cantidad)
                                             };
            //Convierto la secuencia a una lista
            var reporte = ventasPorMesYAño.ToList();
            
            //Ordeno el reporte
            reporte = reporte.OrderByDescending(r => r.Año)
                .ThenByDescending(r => r.Mes).ToList();
           
            //Retorno de la lista
            return reporte.ToList();
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
