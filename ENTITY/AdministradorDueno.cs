using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class AdministradorDueno: Persona
    {
        public string Direccion = "Fundadores, Transversal, 27a#19a55";

        public int GananciasHotel { get; set; }
        private int ValorTotalIngresos { get; set; }
        private int ValorTotalGastos { get; set; }

        public int CalcularGanancias(Gastos gastos, Ingresos ingresos)
        {
            ValorTotalIngresos = gastos.CalcularGastosHotel();
            ValorTotalGastos = ingresos.CalcularIngresosHotel();
            GananciasHotel = ValorTotalIngresos - ValorTotalGastos;
            return GananciasHotel;
        }

        public override string ToString()
        {
            return $"{Identificacion = 1234};{Nombre = "Carmen Severiche"};{Direccion};{ValorTotalIngresos};{ValorTotalGastos};{GananciasHotel}";
        }
    }
}
