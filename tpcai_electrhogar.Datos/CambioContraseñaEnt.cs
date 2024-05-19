using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class CambioContraseñaEnt
    {
        public Guid _id;
        private string _nombreUsuario;
        private string _contraseña;
        private DateTime _fecha;

        public Guid Guid { get { return _id; } set { _id = value; } }
        public string NombreUsuario {  get { return _nombreUsuario;} set { _nombreUsuario = value; } }
        public string Contraseña { get { return _contraseña; } set { _contraseña = value; } }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }

    }
}
