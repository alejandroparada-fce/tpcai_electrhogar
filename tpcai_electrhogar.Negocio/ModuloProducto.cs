using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;
using PersistenciaWS;

namespace tpcai_electrhogar.Negocio
{
    public static class ModuloProducto
    {
        public static string idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
        public static Guid idUsuario2 = new Guid ("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        public static List<ProductoEnt> ConsultarProductos(out string error)
        {
            List<ProductoEnt> listaProductos = new List<ProductoEnt>();
            listaProductos = ServiceProducto.ListarProductos(out error);
            return listaProductos;
        }

        public static List<ProductoEnt> ConsultarProductosCategoria(int idCategoria,out string error)
        {
            List<ProductoEnt> listaProductosCategoria = new List<ProductoEnt>();
            listaProductosCategoria = ServiceProducto.ListarProductosCategoria(idCategoria,out error);
            return listaProductosCategoria;
        }
        public static void ModificarProducto(int stock, double precio, Guid id,  out string error)
        {
            ServiceProducto.ModificarProducto(id, idUsuario, precio, stock, out error);
        }
        public static void EliminarProducto(Guid id, out string error)
        {
            ServiceProducto.EliminarProducto(id, idUsuario2, out error);
        }
    }
}
