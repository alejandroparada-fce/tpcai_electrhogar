using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class UsuarioEnt
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private DateTime _fechaNacimiento;
        private string _direccion;
        private string _telefono;
        private string _correoElectronico;
        private string _nombreUsuario;
        private string _contraseña;
        private DateTime _fechaAlta;
        private DateTime? _fechaBaja;
        private int _host;
        private Guid _id;
        private bool _estado;
        private string _contraseñaNueva;

        public string Nombre { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public string ContraseñaNueva { get => _contraseñaNueva; set => _contraseñaNueva = value; }

        public UsuarioEnt() { }
        public UsuarioEnt(string nombre, string apellido, int dni, DateTime fechaNacimiento, string direccion,
            string telefono, string correoElectronico, string nombreUsuario, string contraseña,
            DateTime fechaAlta, DateTime? fechaBaja, int host, bool estado)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _fechaNacimiento = fechaNacimiento;
            _direccion = direccion;
            _telefono = telefono;
            _correoElectronico = correoElectronico;
            _nombreUsuario = nombreUsuario;
            _contraseña = contraseña;
            _fechaAlta = fechaAlta;
            _fechaBaja = fechaBaja;
            _host = host;
            _id = Guid.NewGuid();
            _estado = estado;
        }

        public bool ValidaUsuario()
        {
            if(_id == Guid.Empty) return false;
            if(_fechaNacimiento > DateTime.Now) return false;
            if(_fechaAlta > DateTime.Now) return false;
            if(_fechaNacimiento > _fechaAlta) return false;
            return true;
        }
        public void EstablecerContraseña(string contraseña)
        {
            _contraseña = contraseña;
        }
        public void BajaUsuario()
        {
            _estado = false;
        }
    }
}
