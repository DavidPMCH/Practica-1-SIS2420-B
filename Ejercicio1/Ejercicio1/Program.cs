using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num;
            Console.WriteLine("Ingrese Un Numero: ");
            num = long.Parse(Console.ReadLine());
            Console.WriteLine("Parte Literal: ");
            Console.WriteLine(convertidor.convertir(num));

            Console.ReadKey();
        }
    }
}
