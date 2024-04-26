using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;

namespace PersistenciaWS
{
    public static class ServiceProducto
    {
        public static List<ProductoEnt> ListarProductos(out string error)
        {
            string path = "/api/Producto/TraerProductos";
            List<ProductoEnt> listadoProductos = new List<ProductoEnt>();
            error = null;

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (!response.IsSuccessStatusCode)
                {
                    error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
                else
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    listadoProductos = JsonConvert.DeserializeObject<List<ProductoEnt>>(contentStream);
                    return listadoProductos;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return listadoProductos;
        }

        public static List<ProductoEnt> ListarProductosCategoria(int idCategoria, out string error)
        { 
        string path = "/api/Producto/TraerProductosPorCategoria?catnum=" + idCategoria;
            List<ProductoEnt> listadoProductosCategoria = new List<ProductoEnt>();
            error = null;
            
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (!response.IsSuccessStatusCode)
                {
                    error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
                else
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    listadoProductosCategoria = JsonConvert.DeserializeObject<List<ProductoEnt>>(contentStream);
                    return listadoProductosCategoria;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return listadoProductosCategoria;
        }
    
    
    }
}
