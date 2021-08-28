using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleFactura
    {
        private int cantidad;

        public int Detalles_id { get; set; }
        public Pensionado pensionado { get; set; }
        public AdministradorDueno administradorDueno { get; set; }
        public int IdPensionado { get; set; }
        public  ServicioReserva servicioReserva { get; set; }
        public int IdCodigoReserva { get; set; }
        public int IdHabitacion { get; set; }
        public int IdCodigoServicioAlimentario { get; set; }
        public int SubTotalReserva { get; set; }
        public int SubTotalAlimentos { get; set; }
        public Habitacion habitacion { get; set; }
        public ServicioAlimentario servicioAlimentario { get; set; }

        public DetalleFactura(ServicioAlimentario servicioAlimentario, Pensionado pensionado)
        {
            IdPensionado = pensionado.Identificacion;
            IdCodigoReserva = servicioReserva.CodigoReserva;
            IdHabitacion = habitacion.NumeroHabitacion;
            IdCodigoServicioAlimentario = servicioAlimentario.CodigoServicioAlimentario;

            SubTotalReserva = servicioReserva.CostoReserva;
            SubTotalAlimentos = servicioAlimentario.ValorTotalComida;
        }

        public DetalleFactura(ServicioAlimentario servicioAlimentario, int cantidad)
        {
            this.servicioAlimentario = servicioAlimentario;
            this.cantidad = cantidad;
        }

        public int Subtotal
        {
            get
            {
                return SubTotalReserva + SubTotalAlimentos;
            }
        }

        public decimal Total
        {
            get
            {
                return Subtotal;
            }
        }

        public string Factura_Id { get; internal set; }
        public Factura Factura { get; internal set; }

        public override string ToString()
        {
            return ($" |Detalle: {Detalles_id} |Id Pencionado: {IdPensionado} |Nombre: {pensionado.Nombre} |Apellido: {pensionado.Apellido} " +
                $"| Sexo: { pensionado.Sexo} | Telefono: { pensionado.Telefono} | Carrera: { pensionado.Carrera}" +

                
                $"| Cantidad Personas: { administradorDueno.Identificacion} | NumeroHabitacion: { administradorDueno.Nombre}" +
                $" | Codigo Reserva: { administradorDueno.Direccion} " +

                $" | Codigo Reserva: { IdCodigoReserva} " +
                $"| Cantidad Personas: { servicioReserva.CantidadPersonas} | NumeroHabitacion: { IdHabitacion}" +
                $" | Estado: { habitacion.Estado} | Valor Habitacion: { habitacion.CostoHabitacion} " +
                $"| Fecha Ingreso: { servicioReserva.FechaIngreso} | Fecha Salida: { servicioReserva.FechaSalida}" +
                $" | numero Meses: { servicioReserva.numeroMeses} " +


                $"| Cantidad: { IdCodigoServicioAlimentario} | Tipo Comida: { servicioAlimentario.TipoComida}" +
                $" | Detalles Comida: { servicioAlimentario.DetallesComida} | Valor Comida: { servicioAlimentario.ValorComida} " +
                $"| Valor Total Comida: { servicioAlimentario.ValorTotalComida}" +
       

                $"|subtotal: {Subtotal}");

        }
    }
}
