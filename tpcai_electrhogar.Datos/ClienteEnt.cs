using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class ClienteEnt
    {
        private Guid _id;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private string _email;
        private DateTime _fechaAlta;
        private DateTime _fechaNacimiento;
        private DateTime? _fechaBaja;
        private Guid _idUsuario;
        private string _host;
        private int _dni;

        public Guid Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido {  get { return _apellido; } set { _apellido = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public string Telefono {  get { return _telefono; } set { _telefono = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public DateTime FechaAlta { get { return _fechaAlta;} set { _fechaAlta = value; } }
        public DateTime FechaNacimiento { get {  return _fechaNacimiento; } set { _fechaAlta = value; } }   
        public DateTime? FechaBaja { get { return _fechaBaja;} set {  _fechaBaja = value; } }
        public Guid IdUsuario { get { return _idUsuario;} set { _idUsuario = value; } }
        public string Host { get { return _host; } set { _host = value; } }
        public int DNI { get { return _dni; } set { _dni = value;} }

        public ClienteEnt(string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, Guid idUsuario, string host, int dni)
        {
            Id = new Guid();
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaAlta = fechaAlta;
            FechaNacimiento = fechaNacimiento;
            FechaBaja = fechaBaja;
            IdUsuario = idUsuario;
            Host = host;
            DNI = dni;

        }
    }
}
