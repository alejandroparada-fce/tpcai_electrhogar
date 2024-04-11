
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class ProductoEnt
    {
        private Guid _id;
        private Guid _idproducto;
        private string _nombre;
        private DateTime _fechaAlta;
        private DateTime? _fechaBaja;
        private double _precio;
        private int _stock;
        private Guid _idUsuario;
        private Guid _idProveedor;

        public Guid Id {get {return _id;} set { _id = value; } }
        public Guid IdProducto { get { return _idproducto; } set { _idproducto = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public DateTime FechaAlta { get { return _fechaAlta; } set { _fechaAlta = value; } }
        public DateTime? FechaBaja { get { return _fechaBaja;} set { _fechaBaja = value; } }
        public double Precio { get { return _precio; } set { _precio = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        public Guid IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public Guid IdProveedor { get { return _idProveedor; } set { _idProveedor = value; } }




        //Constructor
        public ProductoEnt(string Nombre, DateTime FechaAlta, double Precio, int stock) 
        {
            _id = new Guid();
            _nombre = Nombre;
            _fechaAlta = FechaAlta;
            _precio = Precio;
            _stock = stock;
            _idUsuario = new Guid();
            _idProveedor = new Guid();
        }

    }
}
