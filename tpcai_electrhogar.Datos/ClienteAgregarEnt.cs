using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class ClienteAgregarEnt
    {
        private Guid _idUsuario;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _direccion;
        private string _telefono;
        private string _email;
        private DateTime _fechaNacimiento;
        private string _host;



        public Guid idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string apellido { get { return _apellido; } set { _apellido = value; } }
        public int dni { get { return _dni; } set { _dni = value; } }
        public string direccion { get { return _direccion; } set { _direccion = value; } }
        public string telefono {  get { return _telefono; } set { _telefono = value; } }
        public string email { get { return _email; } set { _email = value; } }
        public DateTime fechaNacimiento { get { return _fechaNacimiento; } set { _fechaNacimiento = value; } }
        public string host { get { return _host; } set { _host = value; } }


        public ClienteAgregarEnt(Guid idUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.host = host;
        }
    }
}
