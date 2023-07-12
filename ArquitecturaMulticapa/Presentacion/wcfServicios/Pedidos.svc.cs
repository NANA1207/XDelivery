using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;
using LogicaNegocios;

namespace wcfServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Pedidos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Pedidos.svc o Pedidos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Pedidos : IPedidos
    {
        public List<PedidoEntidad> DevolverListaPedio()
        {
            return PedidoNegocio.DevolverListaPedido();
        }

        public List<PedidoEntidad> DevolverListaPedidoCliente(string cliente)
        {

            return PedidoNegocio.DevolverListaPedidoCliente(cliente);
        }

        public PedidoEntidad GuardarPedido(string idCliente, string idRepartidor, string direccion, string estado, string fecha, string total, string eInicial)
        {
            PedidoEntidad pedido = new PedidoEntidad();
            pedido.IdClientePedido = Convert.ToInt32(idCliente);
            pedido.IdRepartidorPedido = Convert.ToInt32(idRepartidor);
            pedido.Direccion = direccion;
            pedido.EstadoPedido = estado;
            pedido.FechaPedido = fecha;
            pedido.TotalPedido = Convert.ToDouble(total);
            pedido.Estado = eInicial;
            return PedidoNegocio.GuardarPedido(pedido);
        }
        public PedidoEntidad GuardarPedidoGet(string idCliente, string idRepartidor, string direccion, string estado, string fecha, string total, string eInicial)
        {
            PedidoEntidad pedido = new PedidoEntidad();
            pedido.IdClientePedido = Convert.ToInt32(idCliente);
            pedido.IdRepartidorPedido = Convert.ToInt32(idRepartidor);
            pedido.Direccion = direccion;
            pedido.EstadoPedido = estado;
            pedido.FechaPedido = fecha;
            pedido.TotalPedido = Convert.ToDouble(total);
            pedido.Estado = eInicial;
            return PedidoNegocio.GuardarPedido(pedido);
        }
        //
        public PedidoEntidad ActualizarEstadoPedido(string estado, string pedido)
        {
            PedidoEntidad pedidoEntidad1 = new PedidoEntidad();
            pedidoEntidad1.IdPedido = Convert.ToInt32(pedido);
            pedidoEntidad1.EstadoPedido = estado;

            return PedidoNegocio.ActualizarEstadoPedido(pedidoEntidad1);
        }

        public PedidoEntidad AsignarRepartidor(string repartidor, string pedido)
        {
            PedidoEntidad pedidoEntidad = new PedidoEntidad();
            pedidoEntidad.IdRepartidorPedido = Convert.ToInt32(repartidor);
            pedidoEntidad.IdPedido = Convert.ToInt32(pedido);

            return PedidoNegocio.AsignarRepartidor(pedidoEntidad);
        }


        public List<ProductoEntidad> CargarPedidoDetalle(string pedido)
        {
            return PedidoNegocio.CargarPedidoDetalle(pedido);
        }


        public List<PedidoEntidad> CargarPedidosPorEstado(string estado)
        {
            return PedidoNegocio.CargarPedidosPorEstado(estado);
        }

        public PedidoEntidad ObtenerPedidoPorId(string id)
        {
            return PedidoNegocio.ObtenerPedidoPorId(Convert.ToInt32(id));
        }

        public DetallePedidoEntidad GuardarDetalle(string pedido, string producto, string cantidad)
        {
            DetallePedidoEntidad detalle = new DetallePedidoEntidad();
            detalle.IdPedido = Convert.ToInt32(pedido);
            detalle.IdProducto = Convert.ToInt32(producto);
            detalle.Cantidad = Convert.ToInt32(cantidad);
            return PedidoNegocio.GuardarDetalle(detalle);
        }

        public DetallePedidoEntidad GuardarDetalleGet(string pedido, string producto, string cantidad)
        {
            DetallePedidoEntidad detalle = new DetallePedidoEntidad();
            detalle.IdPedido = Convert.ToInt32(pedido);
            detalle.IdProducto = Convert.ToInt32(producto);
            detalle.Cantidad = Convert.ToInt32(cantidad);
            return PedidoNegocio.GuardarDetalle(detalle);
        }

        public PedidoEntidad DevolverListaPedidoAbierto(string cliente)
        {
            return PedidoNegocio.DevolverListaPedidoAbierto(cliente);
        }

        public PedidoEntidad ActualizarEstadoFinal(string estado, string fecha, string direccion, string pedido, string usuario)
        {
            PedidoEntidad pedidoEntidad1 = new PedidoEntidad();
            pedidoEntidad1.Estado = estado;
            pedidoEntidad1.FechaPedido = fecha;
            pedidoEntidad1.Direccion = direccion;
            pedidoEntidad1.IdPedido = Convert.ToInt32(pedido);
            pedidoEntidad1.IdClientePedido = Convert.ToInt32(usuario);

            return PedidoNegocio.ActualizarEstadoFinal(pedidoEntidad1);
        }

        public List<PedidoEntidad> CargarPedidosPorRepartidor(string repartidor)
        {
            return PedidoNegocio.CargarPedidosPorRepartidor(repartidor);
        }
    }
}
