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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProductos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProductos
    {
        [OperationContract]
        [WebGet(UriTemplate = "DevolverListadoProductos", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ProductoEntidad> DevolverLista();

        [OperationContract]
        [WebGet(UriTemplate = "DevolverProductoPorId?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ProductoEntidad DevolverProductoPorId(string id);
    }
}
