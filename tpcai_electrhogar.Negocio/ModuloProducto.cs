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

    }
}
