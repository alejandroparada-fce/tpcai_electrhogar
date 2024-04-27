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
    public static class ServiceProveedor
    {

        public static List<ProveedorEnt> ProveedorListar(out string error)
        {
            string path = "/api/Proveedor/TraerProveedor";
            //string path = "/api/Proveedor/TraerProveedor";
            List<ProveedorEnt> proveedorLista = new List<ProveedorEnt>();
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
                    proveedorLista = JsonConvert.DeserializeObject<List<ProveedorEnt>>(contentStream);
                    return proveedorLista;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return proveedorLista;

        }

        public static void ProveedorEliminar(Guid id, out string error)
        {
            error = null;
            String path = "/api/Proveedor/BajaProveedor?id=" + id;

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

        public static void ProveedorAgregar(ProveedorAgregarEnt proveedor, out string error)
        {
            String path = "/api/Proveedor/AgregarProveedor";
            //String path = "​/api/Proveedor/AgregarProveedor";
            error = null;
            var jsonRequest = JsonConvert.SerializeObject(proveedor);

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

        public static void ProveedorReactivar(Guid id, out string error)
        {
            error = null;
            String path = "/api/Proveedor/ReactivarProveedor?id=" + id;

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

        public static void ProveedorModificar(Guid id, Guid idUsuario, String nombre, String apellido, String email, String cuit, out string error)
        {
            error = null;
            String path = "/api/Proveedor/ModificarProveedor";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("idUsuario", idUsuario.ToString());
            map.Add("nombre", nombre);
            map.Add("apellido", apellido);
            map.Add("email", email);
            map.Add("cuit", cuit);
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
