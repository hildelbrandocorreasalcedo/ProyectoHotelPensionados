using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Gastos
    {
        public int ConsumoElectricidad { get; set; }
        public int ConsumoAgua { get; set; }
        public int ConsumoGas { get; set; }
        public int ConsumoAlimentos { get; set; }
        public int ValorTotalGastos { get; set; }
        public int CalcularGastosHotel()
        {
            ValorTotalGastos = ConsumoElectricidad + ConsumoAgua + ConsumoGas + ConsumoAlimentos;
            return ValorTotalGastos;
        } 
        public override string ToString()
        {
            return $"{ConsumoElectricidad};{ConsumoAgua};{ConsumoGas};{ConsumoAlimentos};{ValorTotalGastos}";
        }

    }
}
