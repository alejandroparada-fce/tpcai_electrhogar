﻿using PersistenciaWS;
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
        public static UsuarioConsultaEnt UsuarioAuntenticado = new UsuarioConsultaEnt();
        public static string Pass;



        public static int Loguearse(string usuario, string contraseña, string contraseñaDefault)
        {

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
                ArchivoLocal.BorrarIntentosFallidosUsuario(usuario);
                ArchivoLocal.GrabarIntentosFallidos();
                return 3;
            }
            else if (resultado && (contraseña != contraseñaDefault))
            {
                UsuarioAuntenticado = usuarios.Find(x => x.nombreUsuario == usuario);
                ArchivoLocal.BorrarIntentosFallidosUsuario(usuario);
                ArchivoLocal.GrabarIntentosFallidos();
                return 4;
            }
            else
            {
                IntentoFallidoEnt intento = new IntentoFallidoEnt(usuario);
                ArchivoLocal.AgregarUsuario(intento);
                ArchivoLocal.GrabarIntentosFallidos();
                return 5;
            }
        }
    }
}
