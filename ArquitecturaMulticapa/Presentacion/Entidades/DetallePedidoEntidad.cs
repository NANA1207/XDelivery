using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallePedidoEntidad
    {
        public DetallePedidoEntidad(int idPedido, int cantidad, int idProducto)
        {
            IdPedido = idPedido;
            Cantidad = cantidad;
            IdProducto = idProducto;
        }

        public DetallePedidoEntidad()
        {

        }

        public int IdPedido { get; set; }
        public int Cantidad { get; set; }
        public int IdProducto { get; set; }
    }


}
