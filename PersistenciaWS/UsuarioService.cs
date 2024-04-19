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
    public class UsuarioService
    {
        public void CambiarPassword(UsuarioEnt usuarioEnt)
        {
            String path = "/api/Usuario/CambiarContraseña";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("nombreUsuario", usuarioEnt.Nombre.ToString());
            map.Add("contraseña", usuarioEnt.Contraseña.ToString());
            map.Add("contraseñaNueva", usuarioEnt.ContraseñaNueva.ToString());

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
        public void ActivarUsuario(UsuarioEnt id)
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
        public void prueba()
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
