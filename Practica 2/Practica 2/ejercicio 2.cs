using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class ejercicio_2
    {
        static void Main(string[] args)
        {
            //Ejercicio 2
            string producto;
            uint canti;
            double iva, total, subtotal;
            float precio;
            Console.WriteLine("Ingrese el nombre del producto: ");
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de producto: ");
            canti = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto: ");
            precio = float.Parse(Console.ReadLine());
            subtotal = precio * canti;
            iva = subtotal * 0.13;
            total = subtotal - iva;
            Console.WriteLine("Subtotal: " + subtotal.ToString("c2"));
            Console.WriteLine("IVA: " + iva.ToString("c2"));
            Console.WriteLine("Total: " + total.ToString("c2"));
            Console.ReadKey();
        }
    }
}
