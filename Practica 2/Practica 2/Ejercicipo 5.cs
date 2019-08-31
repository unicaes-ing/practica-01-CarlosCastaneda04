using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Ejercicipo_5
    {
        static void Main(string[] args)
        {
            //Ejercicio 5
            string telefono;
            double dife;
            decimal valor, prec;
            Console.Write("Número de teléfono: ");
            telefono = Console.ReadLine();
            Console.Write("Hora de inicio de la llamada: ");
            TimeSpan hI = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Hora de finalización de la llamada: ");
            TimeSpan hF = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Valor de por minuto: ");
            valor = Convert.ToDecimal(Console.ReadLine());
            dife = hF.TotalMinutes - hI.TotalMinutes;
            prec = Convert.ToDecimal(dife) * valor;
            Console.WriteLine("Minutos trascurridos de la llamada: " + dife);
            Console.WriteLine("Total a Pagar: " + prec.ToString("C2"));
            Console.ReadKey();
        }
    }
}
