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
