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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Productos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Productos.svc o Productos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Productos : IProductos
    {
        public List<ProductoEntidad> DevolverLista()
        {
            return ProductoNegocio.DevolverLista();
        }

        public ProductoEntidad DevolverProductoPorId(string id)
        {
            return ProductoNegocio.DevolverProductoPorId(Convert.ToInt32(id));
        }
    }
}

