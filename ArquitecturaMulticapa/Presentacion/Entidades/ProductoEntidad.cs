using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoEntidad
    {
        public ProductoEntidad(int idProducto, string nombreProducto, double precioProducto, int cantidad)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            PrecioProducto = precioProducto;
            Cantidad = cantidad;
        }

        public ProductoEntidad()
        {

        }

        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public double PrecioProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
