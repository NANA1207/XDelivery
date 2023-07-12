using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace LogicaNegocios
{
    public class ConsultaNegocio
    {
        public static List<ConsultasEntidad> ConsultaProductos(DateTime fechaInicial, DateTime fechaFinal, int cantidad, string filtro)
        {
            return ConsultaDatos.ConsultaProductos(fechaInicial, fechaFinal, cantidad, filtro);
        }


        public static List<ConsultasEntidad> ConsultaClientes(DateTime fechaInicial, DateTime fechaFinal, int cantidad, string filtro)
        {
            return ConsultaDatos.ConsultaClientes(fechaInicial, fechaFinal, cantidad, filtro);
        }

        public static List<ConsultasEntidad> ConsultaRepartidores(DateTime fechaInicial, DateTime fechaFinal, int cantidad, string filtro)
        {
            return ConsultaDatos.ConsultaRepartidores(fechaInicial, fechaFinal, cantidad, filtro);
        }
    }
}
