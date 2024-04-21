using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace tpcai_electrhogar.Datos
{
    public class ClienteBaseEnt
    {
        private Guid _id;
        private string _direccion;
        private string _telefono;
        private string _email;

        public Guid id { get { return _id; } set { _id = value; } }
        public string direccion { get { return _direccion; } set { _direccion = value; } }
        public string telefono {  get { return _telefono; } set { _telefono = value; } }
        public string email { get { return _email; } set { _email = value; } }
        public ClienteBaseEnt(Guid id, string direccion, string telefono, string email)
        {
            this.id = id;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;

        }
    }
}
