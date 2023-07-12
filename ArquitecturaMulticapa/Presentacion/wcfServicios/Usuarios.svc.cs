using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LogicaNegocios;


namespace wcfServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Usuarios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Usuarios.svc o Usuarios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Usuarios : IUsuarios
    {
        /*  public UsuarioEntidad ActualizarUsuario(UsuarioEntidad usuario)
          {
              return UsuarioNegocios.ActualizarUsuario(usuario);
          }*/

        public List<UsuarioEntidad> BuscarUsuarioPorNombre(string nombre, string tipo)
        {
            return UsuarioNegocios.BuscarUsuarioPorNombre(nombre, tipo);
        }

        public List<UsuarioEntidad> DevolverListaUsuariosPorTipo(string tipo)
        {
            return UsuarioNegocios.DevolverListaUsuariosPorTipo(tipo);
        }

        public UsuarioEntidad DevolverUsuarioPorId(string id)
        {

            return UsuarioNegocios.DevolverUsuarioPorId(Convert.ToInt32(id));
        }

        public UsuarioEntidad GuardarUsuario(string id, string username, string nombre, string apellido, string contrasena, string tipo, string estado)
        {
            UsuarioEntidad usuario = new UsuarioEntidad();
            usuario.IdUsuario = Convert.ToInt32(id);
            usuario.Username = username;
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Contrasena = contrasena;
            usuario.TipoUsuario = tipo;
            usuario.EstadoUsuario = estado;
            return UsuarioNegocios.GuardarUsuario(usuario);
        }
        public UsuarioEntidad GuardarUsuarioGet(string id, string username, string nombre, string apellido, string contrasena, string tipo, string estado)
        {
            UsuarioEntidad usuario = new UsuarioEntidad();
            usuario.IdUsuario = Convert.ToInt32(id);
            usuario.Username = username;
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Contrasena = contrasena;
            usuario.TipoUsuario = tipo;
            usuario.EstadoUsuario = estado;
            return UsuarioNegocios.GuardarUsuario(usuario);
        }

        public bool Login(string usuario, string tipo, string contrasena)
        {
            return UsuarioNegocios.Login(usuario, tipo, contrasena);
        }
        public UsuarioEntidad DevolverUsuarioPorUsername(string username)
        {
            return UsuarioNegocios.DevolverUsuarioPorUsername(username);
        }

        public UsuarioEntidad ValidarUsuario(string user, string clave)
        {
            UsuarioEntidad usuario = new UsuarioEntidad();
            usuario.Username = user;
            usuario.Contrasena = clave;
            return UsuarioNegocios.ValidaValidarUsuario(usuario);
        }
    }
}
