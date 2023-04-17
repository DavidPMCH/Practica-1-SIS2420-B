using Ejercicio4y5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    abstract class Mascota
    {
        public string Nombre_Mascota { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }

        public void Mostrar_Mascota()
        {
            Console.WriteLine("\n Nombre_Mascota" + Nombre_Mascota +
                "\n Edad: " + Edad +
                "\n Raza: " + Raza +
                "\n Sexo: " + Sexo 
                );
        }
      

    }
}

