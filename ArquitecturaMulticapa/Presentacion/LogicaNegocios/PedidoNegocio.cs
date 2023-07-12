using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;

namespace LogicaNegocios
{
    public class PedidoNegocio
    {
        public static PedidoEntidad GuardarPedido(PedidoEntidad pedido)
        {
            return PedidoDatos.NuevoPedido(pedido);
        }
        public static DetallePedidoEntidad GuardarDetalle(DetallePedidoEntidad detalle)
        {
            return PedidoDatos.GuardarDetalle(detalle);
        }
        public static List<PedidoEntidad> DevolverListaPedido()
        {
            return PedidoDatos.ListaPedidos();
        }

        public static PedidoEntidad DevolverListaPedidoAbierto(string cliente)
        {
            return PedidoDatos.ListaPedidosAbierto(cliente);
        }

        public static List<PedidoEntidad> DevolverListaPedidoCliente(string cliente)
        {
            return PedidoDatos.ListaPedidosClientes(cliente);
        }
        //
        public static List<PedidoEntidad> CargarPedidosPorEstado(string estado)
        {
            return PedidoDatos.CargarPedidosPorEstado(estado);
        }

        public static List<ProductoEntidad> CargarPedidoDetalle(string pedido)
        {
            return PedidoDatos.CargarPedidoDetalle(pedido);
        }

        public static PedidoEntidad AsignarRepartidor(PedidoEntidad pedidoEntidad)
        {
            return PedidoDatos.AsignarRepartidor(pedidoEntidad);
        }

        public static PedidoEntidad ActualizarEstadoPedido(PedidoEntidad pedidoEntidad)
        {
            return PedidoDatos.ActualizarEstadoPedido(pedidoEntidad);
        }
        public static PedidoEntidad ObtenerPedidoPorId(int id)
        {
            return PedidoDatos.ObtenerPedidoPorId(id);
        }

        public static PedidoEntidad ActualizarEstadoFinal(PedidoEntidad pedidoEntidad)
        {
            return PedidoDatos.ActualizarEstadoFinal(pedidoEntidad);
        }

        public static List<PedidoEntidad> CargarPedidosPorRepartidor(string repartidor)
        {
            return PedidoDatos.CargarPedidosPorRepartidor(repartidor);
        }

    }
}
