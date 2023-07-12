using System;
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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPedidos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPedidos
    {
        [OperationContract]
        [WebGet(UriTemplate = "DevolverListadoPedidos", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<PedidoEntidad> DevolverListaPedio();

        [OperationContract]
        [WebGet(UriTemplate = "DevolverListadoPedidosCliente?cliente={cliente}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<PedidoEntidad> DevolverListaPedidoCliente(string cliente);

        [OperationContract]
        [WebInvoke(UriTemplate = "GuardarPedido?idCliente={idCliente}&idRepartidor={idRepartidor}&direccion={direccion}&estado={estado}&fecha={fecha}&total={total}&eInicial={eInicial}", Method ="POST" ,RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        PedidoEntidad GuardarPedido(string idCliente, string idRepartidor, string direccion, string estado, string fecha, string total, string eInicial);

        [OperationContract]
        [WebGet(UriTemplate = "GuardarPedidoGet?idCliente={idCliente}&idRepartidor={idRepartidor}&direccion={direccion}&estado={estado}&fecha={fecha}&total={total}&eInicial={eInicial}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        PedidoEntidad GuardarPedidoGet(string idCliente, string idRepartidor, string direccion, string estado, string fecha, string total, string eInicial);

        //
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "cargarPedidosPorEstado?estado={estado}", RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        List<PedidoEntidad> CargarPedidosPorEstado(string estado);


        [OperationContract]
        [WebGet(UriTemplate = "cargarPedidosDetalle?pedido={pedido}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ProductoEntidad> CargarPedidoDetalle(string pedido);


        [OperationContract]
        [WebGet(UriTemplate = "AsignarRepartidor?repartidor={repartidor}&pedido={pedido}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        PedidoEntidad AsignarRepartidor(string repartidor, string pedido);

        [OperationContract]
        [WebGet(UriTemplate = "ActualizarEstadoPedido?estado={estado}&pedido={pedido}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        PedidoEntidad ActualizarEstadoPedido(string estado, string pedido);


        [OperationContract]
        [WebGet(UriTemplate = "ObtenerPedidoPorId?id={id}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        PedidoEntidad ObtenerPedidoPorId(string id);


        [OperationContract]
        [WebInvoke(UriTemplate = "GuardarDetalle?pedido={pedido}&producto={producto}&cantidad={cantidad}", Method ="POST" ,RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]

        DetallePedidoEntidad GuardarDetalle(string pedido, string producto, string cantidad);

        [OperationContract]
        [WebGet(UriTemplate = "GuardarDetalleGet?pedido={pedido}&producto={producto}&cantidad={cantidad}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]

        DetallePedidoEntidad GuardarDetalleGet(string pedido, string producto, string cantidad);

        [OperationContract]
        [WebInvoke(UriTemplate = "PedidoAbierto?cliente={cliente}", Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        PedidoEntidad DevolverListaPedidoAbierto(string cliente);

        [OperationContract]
        [WebGet(UriTemplate = "ActualizarEstadoFinal?estado={estado}&fecha={fecha}&direccion={direccion}&pedido={pedido}&usuario={usuario}",RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        PedidoEntidad ActualizarEstadoFinal(string estado, string fecha, string direccion, string pedido, string usuario);

        [OperationContract]
        [WebGet(UriTemplate = "cargarPedidosPorRepartidor?repartidor={repartidor}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<PedidoEntidad> CargarPedidosPorRepartidor(string repartidor);

    }
}
