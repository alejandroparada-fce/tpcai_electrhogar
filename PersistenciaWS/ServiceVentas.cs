using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;

namespace PersistenciaWS
{
    public static class ServiceVentas
    {
        public static List<VentaClienteEnt> ListarVentasCliente(Guid id, out string error)
        {
            string path = "/api/Venta/GetVentaByCliente?id=" + id;
            List<VentaClienteEnt> listadoVentasCliente = new List<VentaClienteEnt>();
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
                    listadoVentasCliente = JsonConvert.DeserializeObject<List<VentaClienteEnt>>(contentStream);
                    return listadoVentasCliente;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return listadoVentasCliente;
        }

        public static void DevolverVentas(Guid id, String idUsuario, out string error)
        {
            error = null;
            String path = "/api/Venta/DevolverVenta";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("idUsuario", idUsuario);       
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
    }
}