using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Ingresos
    {
        public int PrecioAlquilerHabitacion = 400000;
        public int HabitacionesOcupadas { get; set; }
        public int ValorTotalIngresos{ get; set; }

        public int CalcularIngresosHotel()
        {
            ValorTotalIngresos = PrecioAlquilerHabitacion * HabitacionesOcupadas;
            return ValorTotalIngresos;
        }
        public override string ToString()
        {
            return $"{PrecioAlquilerHabitacion};{HabitacionesOcupadas};{ValorTotalIngresos}";
        }
    }
}
