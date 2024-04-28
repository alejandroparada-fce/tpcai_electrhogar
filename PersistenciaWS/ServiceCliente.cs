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
    public static class ServiceCliente
    {
        public static List<ClienteEnt> ListarClientes(out string error)
        {
            string path = "/api/Cliente/GetClientes";
            List<ClienteEnt> listadoClientes = new List<ClienteEnt>();
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
        public static void AgregarCliente(ClienteAgregarEnt cliente, out String error)
        {
            String path = "/api/Cliente/AgregarCliente";
            error = null;
            var jsonRequest = JsonConvert.SerializeObject(cliente);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
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


        public static void ModificarCliente(Guid id, String direccion, String telefono, String email, out string error)
        {
            error = null;
            String path = "/api/Cliente/PatchCliente";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("direccion", direccion);
            map.Add("telefono", telefono);
            map.Add("email", email);
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
        public static void EliminarCliente(Guid id, out string error)
        {
            error = null;
            String path = "/api/Cliente/BajaCliente?id=" + id;

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
