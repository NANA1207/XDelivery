using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConsultasEntidad
    {
        public ConsultasEntidad(int iD, string nombre, int cantidad, double monto)
        {
            ID = iD;
            Nombre = nombre;
            Cantidad = cantidad;
            Monto = monto;
        }
        public ConsultasEntidad()
        {

        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Monto { get; set; }
    }
}
