using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PedidoEntidad
    {
        public PedidoEntidad(int idPedido, string fechaPedido, int idClientePedido, string nombreC, int idRepartidorPedido, string nombreR, double totalPedido, string estadoPedido, string direccion, string estado)
        {
            IdPedido = idPedido;
            FechaPedido = fechaPedido;
            IdClientePedido = idClientePedido;
            NombreC = nombreC;
            IdRepartidorPedido = idRepartidorPedido;
            NombreR = nombreR;
            TotalPedido = totalPedido;
            EstadoPedido = estadoPedido;
            Direccion = direccion;
            Estado = estado;
        }

        public PedidoEntidad()
        {

        }
        public string Estado { get; set; }
        public int IdPedido { get; set; }
        public string FechaPedido { get; set; }
        public int IdClientePedido { get; set; }
        public int IdRepartidorPedido { get; set; }
        public double TotalPedido { get; set; }
        public string EstadoPedido { get; set; }
        public string Direccion { get; set; }
        public string NombreC { get; set; }
        public string NombreR { get; set; }


        public PedidoEntidad(int idPedido, string nombreC, string fechaPedido, string estadoPedido, string direccion, double totalPedido, string eInicial)
        {
            IdPedido = idPedido;
            NombreC = nombreC;
            EstadoPedido = estadoPedido;
            FechaPedido = fechaPedido;
            TotalPedido = totalPedido;
            Direccion = direccion;
            Estado = eInicial;
        }

    }
}
