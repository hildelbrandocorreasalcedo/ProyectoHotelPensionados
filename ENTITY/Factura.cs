using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public long Factura_Id { get; set; }
        public DateTime FechaFactura { get; set; }
        public Pensionado pensionado { get; set; }
        public ServicioReserva servicioReserva { get; set; }
        public ServicioAlimentario servicioAlimentario { get; set; }

        private readonly List<DetalleFactura> detalleFactura;
 
            public decimal Subtotal
            {
                get
                {
                    return detallesFactura.Sum(d => d.Subtotal);
                }
            }
           

            public decimal Total
            {
            get
            {
                return Subtotal  + servicioReserva.CostoReserva;
            }
            }

            private List<DetalleFactura> detallesFactura;

            public Factura()
            {
                detallesFactura = new List<DetalleFactura>();
            }

            public DetalleFactura AgregarDetallesFactura(ServicioAlimentario servicioAlimentario, int cantidad)
            {
                if (cantidad <= 0)
                {
                    return null;
                }
                DetalleFactura detalleFactura = new DetalleFactura(servicioAlimentario, cantidad);
                detalleFactura.Factura_Id = GenerarId().ToString();
                detalleFactura.Factura = this;
                detallesFactura.Add(detalleFactura);
                return detalleFactura;

            }

            public List<DetalleFactura> GetDetallesFactura()
            {
                return detallesFactura;

            }

            public int GenerarId()
            {

                return detallesFactura.Count > 0 ? Int32.Parse(detallesFactura.Max(d => d.Factura_Id)) + 1 : 1;
            }


            public override string ToString()
            {
                return $"Pensionado:{pensionado.Identificacion} Nombre:{pensionado.Nombre}Apellido:{pensionado.Apellido} Factura:{Factura_Id} " +
                $"Fecha:{FechaFactura} Subtotal:{Subtotal} total:{Total}";

            }


        
        
    }
}
