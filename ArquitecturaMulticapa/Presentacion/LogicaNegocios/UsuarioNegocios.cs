using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;

namespace LogicaNegocios
{
    public static class UsuarioNegocios
    {
        //Guarda el usuario si el USERNAME no se repite
        public static UsuarioEntidad GuardarUsuario(UsuarioEntidad usuario)
        {
            UsuarioEntidad usu = DatosUsuario.DevolverUsuarioPorUsername(usuario.Username);
            if (usuario.IdUsuario == 0)
            {
                if (usuario.Username.Equals(usu.Username))
                {
                    return null;
                }
                else
                {
                    return DatosUsuario.GuardarUsuario(usuario);
                }


            }
            else
            {
                //actualizar registro
                return DatosUsuario.ActualizarUsuario(usuario);
            }

        }

        public static UsuarioEntidad DevolverUsuarioPorId(int id)
        {
            return DatosUsuario.DevolverUsuarioPorId(id);
        }

        //Ingresa si cumple las 3 condiciones 
        public static Boolean Login(string usuario, string tipo, string contrasena)
        {
            UsuarioEntidad usu = DatosUsuario.DevolverUsuarioPorUsername(usuario);
            usu.EstadoUsuario = usu.EstadoUsuario.ToUpper();
            usu.TipoUsuario = usu.TipoUsuario.ToUpper();
            if (usu.IdUsuario != 0)
            {

                if (usu.EstadoUsuario.Equals("H") && usu.TipoUsuario.Equals(tipo.ToUpper()) && usu.Contrasena.Equals(contrasena))

                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /*  public static UsuarioEntidad ActualizarUsuario(UsuarioEntidad usuario)
           {
               return DatosUsuario.ActualizarUsuario(usuario);
           }*/
        public static UsuarioEntidad DevolverUsuarioPorUsername(string username)
        {
            return DatosUsuario.DevolverUsuarioPorUsername(username);
        }

        public static List<UsuarioEntidad> DevolverListaUsuariosPorTipo(string tipo)
        {
            return DatosUsuario.ListaUsuariosPorTipo(tipo);
        }

        public static List<UsuarioEntidad> BuscarUsuarioPorNombre(string nombre, string tipo)
        {
            return DatosUsuario.BuscarUsuarioPorNombre(nombre, tipo);
        }
        public static UsuarioEntidad ValidaValidarUsuario(UsuarioEntidad usuario)
        {
            return DatosUsuario.ValidarUsuario(usuario);
        }
    }
}
