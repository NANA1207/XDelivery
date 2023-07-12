using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;
using System.ServiceModel.Web;

namespace wcfServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IConsultas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConsultas
    {
        [OperationContract]
        [WebGet(UriTemplate = "ConsultaProductos?fechaInicial={fechaInicial}&fechaFinal={fechaFinal}&cantidad={cantidad}&filtro={filtro}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<ConsultasEntidad> ConsultaProductos(string fechaInicial, string fechaFinal, string cantidad, string filtro);

        [OperationContract]
        [WebGet(UriTemplate = "ConsultaClientes?fechaInicial={fechaInicial}&fechaFinal={fechaFinal}&cantidad={cantidad}&filtro={filtro}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<ConsultasEntidad> ConsultaClientes(string fechaInicial, string fechaFinal, string cantidad, string filtro);

        [OperationContract]
        [WebGet(UriTemplate = "ConsultaRepartidores?fechaInicial={fechaInicial}&fechaFinal={fechaFinal}&cantidad={cantidad}&filtro={filtro}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<ConsultasEntidad> ConsultaRepartidores(string fechaInicial, string fechaFinal, string cantidad, string filtro);
    }
}
