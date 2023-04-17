using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Mascota_perdida : Mascota
    {
        public string Motivo { get; set; }
        public DateTime Fecha_perdida { get; set; }
        public void Mostrar_Mascota()
        {
            Console.WriteLine("\n Nombre_Mascota" + Nombre_Mascota +
                "\n Edad: " + Edad +
                "\n Raza: " + Raza +
                "\n Sexo: " + Sexo +
                "\n Motivo: " + Motivo +
                "\n Fecha_perdida: " + Fecha_perdida
                );
        }
    }
}
