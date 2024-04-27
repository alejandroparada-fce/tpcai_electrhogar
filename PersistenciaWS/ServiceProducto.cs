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
        public static void ModificarProducto(Guid id, String idUsuario, double precio, int stock, out string error)
        {
            error = null;
            String path = "/api/Producto/ModificarProducto";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("idUsuario", idUsuario.ToString());
            map.Add("precio", precio.ToString());
            map.Add("stock", stock.ToString());
            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (!response.IsSuccessStatusCode)
                {
                    error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

        }

        public static void EliminarProducto(Guid id, String idUsuario, out string error)
        {
            error = null;
            String path = "/api/Producto/BajaProducto?id=" + id +idUsuario;
            //No se como agregar la id usuario al path, tirar error
            try
            {
                HttpResponseMessage response = WebHelper.Delete(path);
                if (!response.IsSuccessStatusCode)
                {
                    error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }


        }
    }
}
