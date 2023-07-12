using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioEntidad
    {
        public UsuarioEntidad(int idUsuario, string username, string contrasena, string nombre, string apellido, string tipoUsuario, string estadoUsuario)
        {
            IdUsuario = idUsuario;
            Username = username;
            Contrasena = contrasena;
            Nombre = nombre;
            Apellido = apellido;
            TipoUsuario = tipoUsuario;
            EstadoUsuario = estadoUsuario;
        }
        public UsuarioEntidad()
        {

        }

        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Contrasena { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoUsuario { get; set; }
        public string EstadoUsuario { get; set; }
    }
}
