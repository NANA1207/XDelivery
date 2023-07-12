using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Datos;
using Entidades;

namespace LogicaNegocios
{
    public class ProductoNegocio
    {
        public static List<ProductoEntidad> DevolverLista()
        {
            return ProductoDatos.ListaProductos();
        }
        public static ProductoEntidad DevolverProductoPorId(int id)
        {
            return ProductoDatos.DevolverProductoPorId(id);
        }
    }


}
