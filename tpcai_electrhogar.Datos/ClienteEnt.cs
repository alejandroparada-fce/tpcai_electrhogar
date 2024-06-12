using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class ClienteEnt : ClienteBaseEnt
    {

        //private Guid _id;
        private string _nombre;
        private string _apellido;
        //private string _direccion;
        //private string _telefono;
        //private string _email;
        private DateTime _fechaAlta;
        private DateTime _fechaNacimiento;
        private DateTime? _fechaBaja;
        //private Guid _idUsuario;
        private string _host;
        private int _dni;

        //public Guid Id { get { return _id; } set { _id = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string apellido { get { return _apellido; } set { _apellido = value; } }
        //public string Direccion { get { return _direccion; } set { _direccion = value; } }
        //public string Telefono {  get { return _telefono; } set { _telefono = value; } }
        //public string Email { get { return _email; } set { _email = value; } }
        public DateTime fechaAlta { get { return _fechaAlta; } set { _fechaAlta = value; } }
        public DateTime fechaNacimiento { get { return _fechaNacimiento; } set { _fechaNacimiento = value; } }
        public DateTime? fechaBaja { get { return _fechaBaja; } set { _fechaBaja = value; } }
        //public Guid idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public string host { get { return _host; } set { _host = value; } }
        public int dni { get { return _dni; } set { _dni = value; } }

        public ClienteEnt(Guid id, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, string host, int dni)
            : base(id, direccion, telefono, email)

        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaAlta = fechaAlta;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaBaja = fechaBaja;
            this.host = host;
            this.dni = dni;


        }
        

    }
}
