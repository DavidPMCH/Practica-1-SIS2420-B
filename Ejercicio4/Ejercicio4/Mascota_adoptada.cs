using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Mascota_adoptada : Mascota
    {
        public string Nombre_Dueño { get; set; }
        public decimal Pago_Mascota { get; set; }
        public DateTime Fecha_Adopcion { get; set; }
        public void Mostrar_Mascota()
        {
            Console.WriteLine("\n Nombre_Mascota" + Nombre_Mascota +
                "\n Edad: " + Edad +
                "\n Raza: " + Raza +
                "\n Sexo: " + Sexo +
                "\n Nombre_Dueño: " + Nombre_Dueño +
                "\n Pago_Mascota: " + Pago_Mascota +
                "\n Fecha_Adopcion: " + Fecha_Adopcion
                );
        }
    }
}
