using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            string Nombre;
            Console.WriteLine("Escriba un nombre");
            Nombre = Console.ReadLine();
            Nombre = Nombre.Replace("a", "#");
            Nombre = Nombre.Replace("e", "%");
            Nombre = Nombre.Replace("i", "$");
            Nombre = Nombre.Replace("o", "?");
            Nombre = Nombre.Replace("u", "*");
            Console.WriteLine(Nombre);
            Console.ReadKey(); 
        }
    }
}
