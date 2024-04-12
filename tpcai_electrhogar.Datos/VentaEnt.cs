using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class VentaEnt
    {
        private Guid _id;
        private Guid _idCliente;
        private Guid _idProducto;
        private int _cantidad;
        private DateTime _fechaAlta;
        private int _estado;
        private Guid _idUsuario;

        public Guid Id {  get { return _id; } set { _id = value; } }
        public Guid IdCliente { get { return _idCliente; } set { _idCliente = value; } }
        public Guid IdProducto { get { return _idProducto; } set { _idProducto = value; } }
        public int Cantidad { get { return _cantidad; } set { _cantidad = value; } }
        public DateTime FechaAlta { get { return _fechaAlta; } set { _fechaAlta = value; } }
        public int Estado { get { return _estado; } set { _estado = value; } }
        public Guid IdUsuario { get {  return _idUsuario; } set { _idUsuario = value; } }

        public VentaEnt(Guid idCliente, Guid idProducto, int cantidad, DateTime fechaAlta, 
            int estado, Guid idUsuario)
        {
            _id = Guid.NewGuid();
            _idCliente = idCliente;
            _idProducto = idProducto;
            _cantidad = cantidad;
            _fechaAlta = fechaAlta;
            _estado = estado;
            _idUsuario = idUsuario;

        }

    }
}
