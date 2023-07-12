using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;
namespace wcfServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuarios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarios
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GuardarUsuarioGet?id={id}&username={username}&nombre={nombre}&apellido={apellido}&contrasena={contrasena}&tipo={tipo}&estado={estado}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        UsuarioEntidad GuardarUsuarioGet(string id, string username, string nombre, string apellido, string contrasena,
            string tipo, string estado);
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "GuardarUsuario?id={id}&username={username}&nombre={nombre}&apellido={apellido}&contrasena={contrasena}&tipo={tipo}&estado={estado}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        UsuarioEntidad GuardarUsuario(string id, string username, string nombre, string apellido, string contrasena,
            string tipo, string estado);

        [OperationContract]
        [WebGet(UriTemplate = "DevolverUsuarioPorId?id={id}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        UsuarioEntidad DevolverUsuarioPorId(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Login?usuario={usuario}&tipo={tipo}&contrasena={contrasena}", Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        //[WebGet(UriTemplate = "Login/{usuario}/{tipo}/{contrasena}")]
        Boolean Login(string usuario, string tipo, string contrasena);

        /*  [OperationContract]
          [WebInvoke(Method = "GET", UriTemplate = "ActualizarUsuario/{username}/{nombre}/{apellido}/{contrasena}/{tipo}/{estado}", RequestFormat = WebMessageFormat.Json,
              ResponseFormat = WebMessageFormat.Json)]
          UsuarioEntidad ActualizarUsuario(UsuarioEntidad usuario);*/

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "DevolverListadoUsuarios?tipo={tipo}",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<UsuarioEntidad> DevolverListaUsuariosPorTipo(string tipo);

        [OperationContract]
        [WebGet(UriTemplate = "DevolverUsuarioPorNombre?nombre={nombre}&tipo={tipo}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<UsuarioEntidad> BuscarUsuarioPorNombre(string nombre, string tipo);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "DevolverUsername?username={username}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        UsuarioEntidad DevolverUsuarioPorUsername(string username);

        [OperationContract]
        [WebGet(UriTemplate = "validarUsuario?user={user}&clave={clave}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        UsuarioEntidad ValidarUsuario(string user, string clave);

    }
}
