using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class IntentoFallidoEnt
    {
        private string _id;
        private string _nombreUsuario;
        private DateTime _fechaFallo;

        public string Id { get { return _id; } set { _id = value; } }
        public string NombreUsuario { get {  return _nombreUsuario; } set { _nombreUsuario = value; } }
        public DateTime _FechaFallo { get { return _fechaFallo;} set { _fechaFallo = value; } }
    }
}
