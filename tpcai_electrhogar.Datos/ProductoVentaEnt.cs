using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class ProductoVentaEnt
    {
        private int _idCategoria;
        private Guid _idProducto;
        private string _nombre;
        private double _precio;
        private int _stock;




        public int idCategoria { get { return _idCategoria; } set { _idCategoria = value; } }
        public Guid idProducto { get { return _idProducto; } set { _idProducto = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public double precio { get { return _precio; } set { _precio = value; } }
        public int stock { get { return _stock; } set { _stock = value; } }



        public ProductoVentaEnt(int idCategoria, Guid idProducto, string nombre, double precio, int stock)
        {
            this.idCategoria = idCategoria;
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        public ProductoVentaEnt()
        {
        }
    }
}
