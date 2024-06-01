using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using tpcai_electrhogar.Datos;

namespace PersistenciaWS
{
    public static class ServiceUsuario
    {
        public static void AgregarUsuario(UsuarioAgregarEnt usuario, out String error)
        {
            String path = "/api/Usuario/AgregarUsuario";
            error = null;
            var jsonRequest = JsonConvert.SerializeObject(usuario);

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

        public static List<UsuarioConsultaEnt> ListarUsuarios(Guid idUsuario, out string error)
        {
            List<UsuarioConsultaEnt> listadoUsuarios = new List<UsuarioConsultaEnt>();
            string path = "/api/Usuario/TraerUsuariosActivos?id=";
            error = null;

            try
            {
                HttpResponseMessage response = WebHelper.Get(path + idUsuario);
                if (!response.IsSuccessStatusCode)
                {
                    error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
                else
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    listadoUsuarios = JsonConvert.DeserializeObject<List<UsuarioConsultaEnt>>(contentStream);
                    return listadoUsuarios;
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return listadoUsuarios;

        }

        public static void CambiarPassword(string nombreUsuario, string contraseña, string contraseñaNueva, out string error)
        {
            error = null;
            String path = "/api/Usuario/CambiarContraseña";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("nombreUsuario", nombreUsuario);
            map.Add("contraseña", contraseña);
            map.Add("contraseñaNueva", contraseñaNueva);

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
            }
            catch (Exception ex)
            {
                error = $"Exception: {ex.Message}";
            }
        }
        public static void ActivarUsuario(UsuarioEnt id)
        {
            String path = "/api/Usuario/ReactivarUsuario";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("idUsuario", id.ToString());
            map.Add("id", id.ToString());

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public static void EliminarUsuario(Guid id, Guid idUsuario, out string error)
        {
            error = null;
            String path = "/api/Usuario/BajaUsuario";
            Dictionary<String, Guid> map = new Dictionary<string, Guid>();
            map.Add("id", id);
            map.Add("idUsuario", idUsuario);

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);
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

        public static bool Autenticacion(string nombreUsuario, string contraseña, out string respuesta)
        {
            respuesta = null;
            String path = "/api/Usuario/Login";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("nombreUsuario", nombreUsuario);
            map.Add("contraseña", contraseña);
            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (!response.IsSuccessStatusCode)
                {
                    respuesta = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                    return false;
                }
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);

                respuesta = reader.ReadToEnd();

                return true;

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return false;

        }
        public static void prueba()
        {
            String path = "/api/Cliente/PatchCliente";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", "bdddf28b-3c47-4fc3-944f-107a67078640");
            map.Add("direccion", "calle 123");
            map.Add("telefono", "479999999");
            map.Add("email", "mail@mail");

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
