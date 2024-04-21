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
    public static class ClienteService
    {
        public static List<ClienteEnt> ListarClientes(out string error)
        {
            string path = "/api/Cliente/GetClientes";
            List<ClienteEnt> listadoClientes = new List<ClienteEnt>();
            error = null;
            HttpResponseMessage response = WebHelper.Get(path);

            try
            {
                if (!response.IsSuccessStatusCode)
                {
                    error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
                else
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    listadoClientes = JsonConvert.DeserializeObject<List<ClienteEnt>>(contentStream);
                    return listadoClientes;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return listadoClientes;

        }

    }
}
