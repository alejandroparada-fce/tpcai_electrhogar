using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class ProductoAgregarEnt
    {
        private int _idCategoria;
        private Guid _idUsuario;
        private Guid _idProveedor;
        private string _nombre;
        private double _precio;
        private int _stock;




        public int idCategoria { get { return _idCategoria; } set { _idCategoria = value; } }
        public Guid idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public Guid idProveedor { get { return _idProveedor; } set { _idProveedor = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public double precio { get { return _precio; } set { _precio = value; } }
        public int stock { get { return _stock; } set { _stock = value; } }





        public ProductoAgregarEnt(int idCategoria, Guid idUsuario, Guid idProveedor, string nombre, double precio, int stock)
        {
            this.idCategoria = idCategoria;
            this.idUsuario = idUsuario;
            this.idProveedor = idProveedor;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
