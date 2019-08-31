using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class ejercicio_4
    {
        static void Main(string[] args)
        {
            //Ejercicio 4
            float alqur;
            double precio;
            string fecha, fechaa;
            DateTime fechaA, fechaB;
            Console.WriteLine("Fecha de inicio del alquiler");
            fecha = Console.ReadLine();
            Console.WriteLine("Fecha de devolucion del alquiler");
            fechaa = Console.ReadLine();
            fechaA = Convert.ToDateTime(fecha);
            fechaB = Convert.ToDateTime(fechaa);
            Console.WriteLine("Valor de alquiler por dia");
            alqur = float.Parse(Console.ReadLine());
            TimeSpan dias = fechaB - fechaA;
            precio = alqur * dias.Days;
            Console.WriteLine("Días de alquiler: " + dias.Days);
            Console.WriteLine("Precio a pagar: " + precio.ToString("C2"));
            Console.ReadKey();
            //Console.WriteLine("Fecha de devolucion del alquiler");
            //fechaD = Console.ReadLine(); 
            //string.Format("{0:00-00-0000}", fechaI)
            Console.ReadKey();
        }
        
    }
}
