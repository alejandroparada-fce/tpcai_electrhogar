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
        public static string idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public static List<ProveedorEnt> ProveedorListar(out string error)
        {
            List<ProveedorEnt> proveedorListar = new List<ProveedorEnt>();
            proveedorListar = ServiceProveedor.ProveedorListar(out error);
            return proveedorListar;
        }

        public static void ProveedorEliminar(Guid id, out string error)
        {
            ServiceProveedor.ProveedorEliminar(id, out error);
        }

        public static void ProveedorAgregar(string nombre, string apellido, string email,  string cuit, out string error)
        {
            ProveedorAgregarEnt proveedor = new ProveedorAgregarEnt(idUsuario, nombre, apellido, email, cuit);
            error = null;

            ServiceProveedor.ProveedorAgregar(proveedor, out error);
        }

        public static void ProveedorReactivar(Guid id, out string error)
        {
            ServiceProveedor.ProveedorReactivar(id, out error);
        }

        public static void ProveedorModificar(Guid id, Guid idUsuario, string nombre, string apellido, string email, string cuit, out string error)
        {
            ServiceProveedor.ProveedorModificar(id, idUsuario, nombre, apellido, email, cuit, out error);
            

        }
    }

}
