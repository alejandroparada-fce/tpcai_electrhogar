using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpcai_electrhogar.Forms;

namespace tpcai_electrhogar
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormLogin());
            //Application.Run(new FormBienvenida());
            Application.Run(new FormMenuPrincipal());
            //Application.Run(new FormUsuarioRegistrar());
            //Application.Run(new FormClienteListar());
            //Application.Run(new FormClienteRegistrar());
            //Application.Run(new FormProveedorListar());
            //Application.Run(new FormProveedorRegistrar());
            //Application.Run(new FormAdmProductos());
            //Application.Run(new FormProductoRegistrar());
            //Application.Run(new FormUsuarioBuscarBaja());
            //Application.Run(new FormVentaDevolucion());
            //Application.Run(new FormVentaRegistrar());
            //Application.Run(new FormAgregarProducto());
        }
    }
}
