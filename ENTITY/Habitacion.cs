using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Habitacion
    {
        public int NumeroHabitacion { get; set; }
        public string Estado { get; set; }
        public int CostoHabitacion { get; set; }

        public override string ToString()
        {
            return $"{NumeroHabitacion};{Estado};{CostoHabitacion}";
        }

        //Habitación 101
        //Habitación 102
        //Habitación 103
        //Habitación 104
        //Habitación 201
        //Habtiación 202
        //Habitación 203
        //Habitación 204
        //Habitación 205
        //Habitación 301
        //Habitación 302
        //Habitación 303
        //Habitación 304
        //Habitación 305
    }
}
