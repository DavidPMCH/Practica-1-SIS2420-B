using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public static class Series
    {
        public static void serie1(int x)
        {
            int n = x;
            int num=1;
            for (int i = 2;i < n+2;i++)
            {
                Console.Write(num + " ");
                num = num * i;
            }
        }
        public static void serie2(int x)
        {
            int n = x;
            int num = 1;
            for (int i = 0; i < n + 2; i++)
            {
                Console.Write(num + " ");
                num = num * 2;
            }
        }
    }
}
