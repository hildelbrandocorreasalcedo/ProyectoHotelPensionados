using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ServicioReserva : Servicio
    {
        public int CodigoReserva{ get; set; }
        public int CantidadPersonas { get; set; }
        public Habitacion habitacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }

        public int numeroMeses;
        public int CostoReserva { get; set; }

        public string VerificarEstadoHabitacion(Habitacion habitacion)
        {
            //if(habitacion.NumeroHabitacion = )
            //{
                if (habitacion.Estado == "disponible")
                {
                    return "Habitacion disponible";
                }
                else
                {
                    return "Habitacion ocupada";
                }
        }
        public void CalcularCostoReserva(Habitacion habitacion)
        {
            TimeSpan DiferenciaTiempo = FechaIngreso - FechaSalida;
            int dias = DiferenciaTiempo.Days;
            if (dias <= 30)
            {
                numeroMeses = 1;
            }else
                 if (dias > 30 && dias <=60)
            {
                numeroMeses = 2;
            }
            else
                 if (dias > 60 && dias <= 90)
            {
                numeroMeses = 3;
            }
            else if (dias > 120 && dias <= 150)
            {
                numeroMeses = 4;
            }else if (dias > 150 && dias <= 180)
            {
                numeroMeses = 5;
            }
            else if (dias > 210 && dias <= 240)
            {
                numeroMeses = 6;
            }

            CostoReserva = numeroMeses * habitacion.CostoHabitacion;
        }
        public override string ToString()
        {
            return $"{CodigoReserva};{pensionado.Identificacion};{CantidadPersonas};{habitacion.NumeroHabitacion};{habitacion.Estado};" +
                $"{FechaIngreso};{FechaSalida};{numeroMeses};{habitacion.CostoHabitacion};{CostoReserva}";
        }
    }
}
