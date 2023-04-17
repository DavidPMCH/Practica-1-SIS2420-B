using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese Un Numero: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Serie 1: " );
            Series.serie1(num);
            Console.WriteLine(" ");
            Console.Write("Serie 2: " );
            Series.serie2(num);

            Console.ReadKey();
        }
    }
}
