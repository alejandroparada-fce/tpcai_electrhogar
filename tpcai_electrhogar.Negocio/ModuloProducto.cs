using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;
using PersistenciaWS;
using System.Net;

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

        public static List<ProductoEnt> ReporteStockCritico(out string error)
        {
         
            //Cargo lista de productos
            List<ProductoEnt> listaProductos = new List<ProductoEnt>();
            listaProductos = ServiceProducto.ListarProductos(out error);
            //Se considera critico tener menos del 25% del promedio de todos los items
            int cantidad = listaProductos.Count;
            int sumaItems = listaProductos.Sum(x => x.Stock);
            decimal promedio = sumaItems / cantidad;
            int puntoCritico = Convert.ToInt32(promedio - Decimal.Multiply(promedio, (75/100)));
            
            //Se genera lista filtrada por items que tengan un menos de 25% del promedio
            List<ProductoEnt> listaProductosCritico = new List<ProductoEnt>();
            listaProductosCritico = listaProductos.Where(x => x.Stock < puntoCritico).ToList();
            return listaProductosCritico;
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
        public static void AgregarProducto(int idCategoria, Guid idProveedor, string nombre, double precio, int stock, out string error)
        {
            ProductoAgregarEnt producto = new ProductoAgregarEnt(idCategoria, idUsuario2, idProveedor, nombre, precio, stock);
            error = null;
            ServiceProducto.AgregarProducto(producto, out error);
        }
    }

}
