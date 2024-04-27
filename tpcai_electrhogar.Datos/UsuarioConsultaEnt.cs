using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class UsuarioConsultaEnt
    {
        private Guid _id;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _nombreUsuario;
        private int _host;

        public Guid id { get { return _id; } set { _id = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string apellido { get { return _apellido; } set { _apellido = value; } }
        public int dni { get { return _dni; } set { _dni = value; } }
        public string nombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value;} }
        public int host { get { return _host; } set { _host = value; } }
    }
}
