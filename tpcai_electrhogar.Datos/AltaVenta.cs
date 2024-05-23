using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class AltaVenta
    {
        private Guid _idCliente;
        private Guid _idUsuario;
        private Guid _idProducto;
        private int _cantidad;

        public Guid idCliente { get { return _idCliente; } set { _idCliente = value; } }
        public Guid idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public Guid idProducto { get { return _idProducto; } set { _idProducto = value; } }

        public int Cantidad { get { return _cantidad; } set { _cantidad = value; } }

        public AltaVenta (Guid idCliente ,Guid idUsuario, Guid idProducto, int cantidad)
        {
            this.idCliente = _idCliente;
            this.idUsuario = _idUsuario;
            this.idProducto = _idProducto;
            this.Cantidad = cantidad;
           

        }

        public AltaVenta()
        {
        }
    }
}
