﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;
using PersistenciaWS;
using System.Net.Http;

namespace tpcai_electrhogar.Negocio
{
    public static class ModuloProveedor
    {
        public static Guid idUsuario = ModuloLogueo.UsuarioAuntenticado.id;

        public static List<ProveedorEnt> ProveedorListar(out string error)
        {
            List<ProveedorEnt> proveedorListar = new List<ProveedorEnt>();
            proveedorListar = ServiceProveedor.ProveedorListar(out error);
            return proveedorListar;
        }

        public static void ProveedorAgregar(string nombre, string apellido, string email, string cuit, out string error)
        {
            ProveedorAgregarEnt proveedor = new ProveedorAgregarEnt(idUsuario, nombre, apellido, email, cuit);
            error = null;

            ServiceProveedor.ProveedorAgregar(proveedor, out error);
        }

        public static void ProveedorBaja(Guid idProveedor, out string error)
        {
            ServiceProveedor.ProveedorBaja(idUsuario, idProveedor, out error);

        }
        public static void ProveedorReactivar(Guid idProveedor, out string error)
        {
            ServiceProveedor.ProveedorReactivar(idUsuario, idProveedor, out error);
        }

        public static void ProveedorModificar(Guid idProveedor, string nombre, string apellido, string email, string cuit, out string error)
        {
            ServiceProveedor.ProveedorModificar(idUsuario, idProveedor, nombre, apellido, email, cuit, out error);
        }
    }
}
