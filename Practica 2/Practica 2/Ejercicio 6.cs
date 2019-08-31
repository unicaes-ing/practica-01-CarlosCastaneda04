using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
            //Ejercicio 6
            DateTime Hoy = DateTime.Now;
            DateTime Hora = DateTime.Now;
            Console.WriteLine("Today is {0} {1} of the month {2} of {3} and it is {4}", Hoy.DayOfWeek, Hoy.Day, Hoy.Month, Hoy.Year, Hora.ToString("hh:mm"));
            Console.ReadKey();
        }
    }
}
