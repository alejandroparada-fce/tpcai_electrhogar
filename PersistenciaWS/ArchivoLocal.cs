using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;

namespace PersistenciaWS
{
    public static class ArchivoLocal
    {
        static List<IntentoFallidoEnt> intentosFallidos = new List<IntentoFallidoEnt>();
        static List<CambioContraseñaEnt> cambiosContraseña = new List<CambioContraseñaEnt>();

        //Siempre que se invoque a la clase se levantará el contenido de dos ficheros
        static ArchivoLocal()
        {
            //Si existe el fichero json se carga en una lista el contenido
            if (File.Exists("intentosFallidos.json"))
            {
                string contenidoIntentosFallidos = File.ReadAllText("intentosFallidos.json");
                intentosFallidos = JsonConvert.DeserializeObject<List<IntentoFallidoEnt>>(contenidoIntentosFallidos);
            }
            else
            {
                intentosFallidos = new List<IntentoFallidoEnt>();
            }

            //Si existe el fichero json se carga en una lista el contenido
            if (File.Exists("cambiosContraseña.json"))
            {
                string contenidoCambioContraseñas = File.ReadAllText("cambiosContraseña");
                cambiosContraseña = JsonConvert.DeserializeObject<List<CambioContraseñaEnt>>(contenidoCambioContraseñas);
            }
            else
            {
                cambiosContraseña = new List<CambioContraseñaEnt>();
            }

        }

        //Agregar usuario
        public static void AgregarUsuario(IntentoFallidoEnt intento)
        {
            intentosFallidos.Add(intento);
        }

        //Agregar cambio de  contraseña 
        public static void AgregarCambioContraseña(CambioContraseñaEnt cambioContraseña)
        {
            cambiosContraseña.Add(cambioContraseña);
        }

        //Chequear si el usuario está lockeado
        public static bool ChequearBloqueo(string usuario)
        {
            int conteo = intentosFallidos.Count(x => x.NombreUsuario == usuario);

            if (conteo >= 3)
            {
                return true;
            }
            return false;
        }

        //Chequear si el usuario tiene vencida la contraseña
        public static bool ChequearVencimiento(string usuario)
        {
            bool cambioExpirado = cambiosContraseña.Any(x => x.NombreUsuario == usuario && x.Fecha <= DateTime.Now.Date.Subtract(TimeSpan.FromDays(30)));
            if (cambioExpirado )
            {
                return true;
            }
            return false;
        }

        //Borra los intentos fallidos para un usuario en particular
        public static void BorrarIntentosFallidosUsuario(string usuario)
        {
            intentosFallidos.RemoveAll(x => x.NombreUsuario == usuario);
        }
        //Grabar intentos falllidos a un archivo serializando una lista
        public static void GrabarIntentosFallidos()
        {
            string contenidoIntentosFallidos = JsonConvert.SerializeObject(intentosFallidos);
            File.WriteAllText("intentosFallidos.json", contenidoIntentosFallidos);
        }

        //Grabar cambios de contraseña a un archivo serializando una lista
        public static void GrabarCambiosContraseña()
        {
            string contenidoCambioContraseñas = JsonConvert.SerializeObject(cambiosContraseña);
            File.WriteAllText("CambiosContraseña", contenidoCambioContraseñas);
        }
    }
}
