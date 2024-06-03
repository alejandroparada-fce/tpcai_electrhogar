using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class ProveedorAgregarEnt
    {
        //Atributos
        private string _idUsuario;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _cuit;


        //Propiedades
        public string IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string CUIT { get { return _cuit; } set { _cuit = value; } }


        //Constructor para todos los atributos
        public ProveedorAgregarEnt(string idUsuario, string nombre, string apellido, string email, string cuit)
        {
            this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.CUIT = cuit;
        }
    }
}
