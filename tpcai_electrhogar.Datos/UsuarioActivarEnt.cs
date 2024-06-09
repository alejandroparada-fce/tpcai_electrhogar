
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class UsuarioActivarEnt
    {
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private Guid _id;

        public Guid Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        

        public UsuarioActivarEnt() { }
        public UsuarioActivarEnt(Guid id, string nombre, string apellido, string nombreUsuario)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _nombreUsuario = nombreUsuario;
        }
    }
}
