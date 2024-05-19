using PersistenciaWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;

namespace tpcai_electrhogar.Negocio
{

    public static class ModuloLogueo

    {
        public static LoginEnt logueo;
        public static List<string> LogueosFallidos = new List<string>();
        //public LoginEnt = Loguearse(usuario, contraseña, contraseñaDefault);


        public static int Loguearse(string usuario, string contraseña, string contraseñaDefault)
        {
            /*LoginEnt logueoAux = new LoginEnt(usuario, contraseña, contraseñaDefault);
            ModuloLogueo.logueo = logueoAux;
            if (logueo.Autenticado == true )
            {
                LogueosFallidos.RemoveAll(u => u == usuario);
            }
            else
            {
                LogueosFallidos.Add(usuario);
            }
            */
            List<UsuarioConsultaEnt> usuarios = ServiceUsuario.ListarUsuarios(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), out string error);
            bool existeUsuario = usuarios.Any(x => x.nombreUsuario == usuario);
            bool bloqueo = ArchivoLocal.ChequearBloqueo(usuario);
            bool expirado = ArchivoLocal.ChequearVencimiento(usuario);
            bool resultado = ServiceUsuario.Autenticacion(usuario, contraseña, out string respuesta);

            //Se chequea que exista el usuario, si esta bloqueado, si está vencido y si la contraseña coincide con la default
            if (!existeUsuario)
            {
               
                return 0;
            }
            else if (bloqueo)
            {
                return 1;
            }
            else if (expirado)
            {
                return 2;
            }
            else if(resultado && (contraseña == contraseñaDefault))
            {
                return 3;
            }
            else if (resultado && (contraseña != contraseñaDefault))
            {
                return 4;
            }
            else
            {
                IntentoFallidoEnt intento = new IntentoFallidoEnt(usuario);
                ArchivoLocal.AgregarUsuario(intento);
                return 5;
            }

        }
        

        public static bool ExisteUsuario()
        {

            return ModuloLogueo.logueo.ExisteUsuario;
        }

        public static bool Autenticado()
        {
            return ModuloLogueo.logueo.Autenticado;
        }

        public static bool CambioContraseña()
        {

            return ModuloLogueo.logueo.CambioContraseña;
        }

        public static bool ChequearBloqueo(string usuario)
        {
            int count = 0;
            foreach (string usuarioFalla in LogueosFallidos)
            {
                if(usuario == usuarioFalla)
                {
                    count++;
                }
            }
            if(count >= 3)
            {
                return true;
            }
            else 
            { 
                return false;
            }


        }
    }
}
