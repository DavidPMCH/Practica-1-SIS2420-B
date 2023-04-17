using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public static class convertidor
    {
        public static string convertir(long x)
        {
            string numero;
            if (x == 0) numero = "Cero";
            else if (x == 1) numero = "uno";
            else if (x == 2) numero = "dos";
            else if (x == 3) numero = "tres";
            else if (x == 4) numero = "cuatro";
            else if (x == 5) numero = "cinco";
            else if (x == 6) numero = "seis";
            else if (x == 7) numero = "siete";
            else if (x == 8) numero = "ocho";
            else if (x == 9) numero = "nueve";
            else if (x == 10) numero = "Diez";
            else if (x == 11) numero = "Once";
            else if (x == 12) numero = "Doce";
            else if (x == 13) numero = "Trece";
            else if (x == 14) numero = "Catorce";
            else if (x == 15) numero = "Quince";
            else if (x < 20) numero = "Dieci" + convertir(x - 10);
            else if (x == 20) numero = "Veinte";
            else if (x < 30) numero = "Veinti" + convertir(x - 20);
            else if (x == 30) numero = "Trenta";
            else if (x == 40) numero = "Cuarenta";
            else if (x == 50) numero = "Cincuenta";
            else if (x == 60) numero = "Sesenta";
            else if (x == 70) numero = "Setenta";
            else if (x == 80) numero = "Ochenta";
            else if (x == 90) numero = "Noventa";
            else if (x < 100) numero = convertir((x / 10) * 10) + " y " + convertir(x % 10);
            else if (x == 100) numero = "Cien";
            else if (x < 200) numero = "Ciento " + convertir(x - 100);
            else if ((x == 200) || (x == 300) || (x == 400) || (x == 600) || (x == 800)) numero = convertir((x / 100)) + "cientos";
            else if (x == 500) numero = "Quinientos";
            else if (x == 700) numero = "Setecientos";
            else if (x == 900) numero = "Novecientos";
            else if (x < 1000) numero = convertir((x / 100) * 100) + " " + convertir(x % 100);
            else if (x == 1000) numero = "Mil";
            else if (x < 2000) numero = "Mil " + convertir(x % 1000);
            else if (x < 1000000)
            {
                numero = convertir(x / 1000) + " mil";
                if ((x % 1000) > 0)
                {
                    numero = numero + " " + convertir(x % 1000);
                }
            }
            else if (x == 1000000)
            {
                numero = "un millon";
            }
            else if (x < 2000000)
            {
                numero = "un millon " + convertir(x % 1000000);
            }
            else if (x < 1000000000000)
            {
                numero = convertir((x / 1000000)) + " millones ";
                if ((x - (x / 1000000) * 1000000) > 0)
                {
                    numero = numero + " " + convertir(x - (x / 1000000) * 1000000);
                }
            }
            else if (x == 1000000000000) numero = "Un billon";
            else if (x < 2000000000000) numero = "Un billon " + convertir(x - (x / 1000000000000) * 1000000000000);
            else
            {
                numero = convertir(x / 1000000000000) + " billones";
                if ((x - (x / 1000000000000) * 1000000000000) > 0)
                {
                    numero = numero + " " + convertir(x - (x / 1000000000000) * 1000000000000);
                }
            }
            return numero;
        }
    }
}
