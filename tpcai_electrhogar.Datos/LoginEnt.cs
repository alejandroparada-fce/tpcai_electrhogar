using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcai_electrhogar.Datos
{
    public class LoginEnt
    {
        private string _UsuarioIngresado;
        private string _Contraseña;
        private string _ContraseñaDefault;
        private string _ContraseñaIngresada;
        private int _host;
        private bool _ExisteUsuario;
        private bool _CambioContraseña;
        private bool _Autenticado;
        private static List<string> _IngresosFallidos = new List<string>();
        private bool _Bloqueado;

        public bool ExisteUsuario 
        { 
            get { return _ExisteUsuario; } 
        }
        public bool Autenticado
        {
            get { return _Autenticado; }
            
        }

        public bool CambioContraseña
        {
            get { return _CambioContraseña; }
        }

        public LoginEnt(string usuarioIngresado, string contraseñaIngresada, string contraseñaDefault)
        {
            this._UsuarioIngresado = usuarioIngresado;
            this._ContraseñaIngresada = contraseñaIngresada;
            this._ContraseñaDefault = contraseñaDefault;
            CheckearUsuario(_UsuarioIngresado);
            Autenticar(_UsuarioIngresado, _ContraseñaIngresada);
            //this._Bloqueado = EstadoUsuario(_UsuarioIngresado);
            CambiarContraseña();

        }

        private void CheckearUsuario(string _UsuarioIngresado)
        {
            //Se revisa en capa de persistencia
            //String Contrseña
            //this._Contraseña = Contraseña;
            //this.host = host
            _Contraseña = "CAI20241";
            _ExisteUsuario = true;
        }

        public void Autenticar(string _UsuarioIngresado, string _ContraseñaIngresada)
        {
            if(_ContraseñaIngresada == _Contraseña)
            {
                _Autenticado = true;
                //_IngresosFallidos.RemoveAll(usuario => usuario == _UsuarioIngresado);
            }
            else
            {
                _Autenticado = false;
                //_IngresosFallidos.Add(_UsuarioIngresado);

            }

        }

        public void CambiarContraseña()
        {
            if(_Autenticado == true && _Contraseña == _ContraseñaDefault)
            {
                _CambioContraseña = true;
            }
            else
            {
                _CambioContraseña = false;
            }
        }


        /*
        public bool EstadoUsuario(string _UsuarioIngresado)
        {
            int intentos = 0;

            foreach (string usuario in _IngresosFallidos)
            {
                if(usuario == _UsuarioIngresado)
                {
                    intentos++;
                }
            }

            if (intentos >= 3)
            {
                //Poner fecha de baja en la capa de persistencia.
                return true;
            }
            else
            {
                return false;
            }

        }

        */


    }
}
