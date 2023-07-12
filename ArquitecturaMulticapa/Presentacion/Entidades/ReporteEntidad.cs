using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteEntidad
    {
        public ReporteEntidad(DateTime fechaInicio, DateTime fechaFin, DateTime fechaReporte, string titulo)
        {
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            FechaReporte = fechaReporte;
            Titulo = titulo;
        }

        public ReporteEntidad()
        {

        }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaReporte { get; set; }

        public string Titulo { get; set; }
    }
}
