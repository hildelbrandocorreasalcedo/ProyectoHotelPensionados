using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ServicioAlimentario : Servicio
    {
        public int CodigoServicioAlimentario { get; set; }
        public string TipoComida { get; set; }
        public string Cantidad { get; set; }
        public int DetallesComida { get; set; }
        public int ValorComida { get; set; }
        public int CantidadComida { get; set; }

        public int ValorTotalComida; 

        public override string ToString()
        {
            return $"{pensionado.Identificacion};{CodigoServicioAlimentario};{TipoComida};{DetallesComida};{ValorComida};{CantidadComida};{ValorTotalComida}";
        }
    }
}
