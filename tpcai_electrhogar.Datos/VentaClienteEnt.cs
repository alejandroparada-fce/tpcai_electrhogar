using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class VentaClienteEnt
    {
        private Guid _id;
        private int _cantidad;
        private DateTime _fechaAlta;
        private int _estado;

        public Guid Id {  get { return _id; } set { _id = value; } }
        public int Cantidad { get { return _cantidad; } set { _cantidad = value; } }
        public DateTime FechaAlta { get { return _fechaAlta; } set { _fechaAlta = value; } }
        public int Estado { get { return _estado; } set { _estado = value; } }

        public VentaClienteEnt(Guid id, int cantidad, DateTime fechaAlta, int estado)
        {
            this.Id = id;
            this.Cantidad = cantidad;
            this.FechaAlta = fechaAlta;
            this.Estado = estado;

        }

    }
}
