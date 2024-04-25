using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class ProveedorModificarEnt
    {
        //Atributos
        private Guid _id;
        private Guid _idProducto;
        private string _nombre;
        private DateTime _fechaAlta;
        private DateTime? _fechaBaja;
        private string _cuit;
        private string _email;
        private string _apellido;
        private Guid _idUsuario;

        //Propiedades
        public Guid Id { get { return _id; } set { _id = value; } }
        public Guid IdProducto {  get { return _idProducto; } set { _idProducto  = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public DateTime FechaAlta { get { return FechaAlta; } set { FechaAlta = value; } }
        public DateTime? FechaBaja { get { return FechaBaja; } set { FechaBaja = value; } }
        public string CUIT { get { return _cuit; } set { CUIT = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public Guid IdUsuario { get { return _idUsuario;} set { _idUsuario = value; } }


        //Constructor para todos los atributos
        public ProveedorModificarEnt(string nombre, string apellido, string email, string cuit)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Apellido = apellido;
            Email = email; 
            CUIT = cuit;
        }
    }
}
