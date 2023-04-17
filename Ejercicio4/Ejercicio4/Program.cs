using Ejercicio4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4y5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mascota_adoptada> listaMascota = new List<Mascota_adoptada>();
            listaMascota.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Rufus",
                Edad = 2,
                Raza = "Beagle",
                Sexo = "Macho",
                Nombre_Dueño = "Jorge",
                Pago_Mascota = 102.50m,
                Fecha_Adopcion = DateTime.Parse("10/05/2023")

            });
            listaMascota.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "chispas",
                Edad = 3,
                Raza = "Chihuahua",
                Sexo = "Macho",
                Nombre_Dueño = "Raul",
                Pago_Mascota = 299.99m,
                Fecha_Adopcion = DateTime.Parse("09/04/2023")

            });
            listaMascota.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Rocco",
                Edad = 1,
                Raza = "Mastin Tibetano",
                Sexo = "Macho",
                Nombre_Dueño = "Jose",
                Pago_Mascota = 400.00m,
                Fecha_Adopcion = DateTime.Parse("01/01/2022")

            });
            listaMascota.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Hachiko",
                Edad = 3,
                Raza = "Husky Siberiano",
                Sexo = "Macho",
                Nombre_Dueño = "Alfred",
                Pago_Mascota = 320.50m,
                Fecha_Adopcion = DateTime.Parse("03/01/2023")

            });
            listaMascota.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Nala",
                Edad = 1,
                Raza = "Pastor Aleman",
                Sexo = "Hembra",
                Nombre_Dueño = "Anna",
                Pago_Mascota = 450.50m,
                Fecha_Adopcion = DateTime.Parse("03/06/2023")

            });
            listaMascota.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Toto",
                Edad = 3,
                Raza = "Doberman",
                Sexo = "Macho",
                Nombre_Dueño = "George",
                Pago_Mascota = 150.50m,
                Fecha_Adopcion = DateTime.Parse("10/11/2023")

            });
            listaMascota.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "perla",
                Edad = 2,
                Raza = "Chihuahua",
                Sexo = "Hembra",
                Nombre_Dueño = "Gabriel",
                Pago_Mascota = 200.00m,
                Fecha_Adopcion = DateTime.Parse("11/09/2023")

            });
            listaMascota.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "rimi",
                Edad = 3,
                Raza = "Chihuahua",
                Sexo = "Hembra",
                Nombre_Dueño = "Maria",
                Pago_Mascota = 190.00m,
                Fecha_Adopcion = DateTime.Parse("10/07/2022")

            });
            listaMascota.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Aniquilador",
                Edad = 4,
                Raza = "Rottweiler",
                Sexo = "Macho",
                Nombre_Dueño = "Pablo",
                Pago_Mascota = 350.50m,
                Fecha_Adopcion = DateTime.Parse("06/12/2023")

            });
            listaMascota.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Bobi",
                Edad = 2,
                Raza = "Rottweiler",
                Sexo = "Macho",
                Nombre_Dueño = "Viviana",
                Pago_Mascota = 400.50m,
                Fecha_Adopcion = DateTime.Parse("09/10/2023")

            });

            double promedioEdad = Prom_Mascotas(listaMascota);
            Console.WriteLine("\nEl promedio de las edades de las mascotas es: " + promedioEdad);
            double promedioPago = Prom_Pago(listaMascota);
            Console.WriteLine("\nEl promedio de Pagos de las mascotas es: " + promedioPago);
            Raza_Chiwawa(listaMascota);
            Edad_Mascota(listaMascota);
           
            Console.ReadKey();

        }

        private static void Edad_Mascota(List<Mascota_adoptada> listaMascota)
        {
            var mostrar = (from Mascota_adoptada in listaMascota
                           where Mascota_adoptada.Edad < 2
                           select Mascota_adoptada.Nombre_Mascota);
            Console.WriteLine("\n--------Mascotas con edad menor aa 2 años--------");
            foreach (var i in mostrar)
            {
                Console.WriteLine(i);
            }
        }

        private static void Raza_Chiwawa(List<Mascota_adoptada> listaMascota)
        {
            var mostrar = (from Mascota_adoptada in listaMascota
                           where Mascota_adoptada.Raza == "Chihuahua" && Mascota_adoptada.Sexo == "Hembra"
                           select Mascota_adoptada.Nombre_Mascota);
            Console.WriteLine("\n--------Mascotas de raza Chihuahua de sexo Hembra--------");
            foreach (var i in mostrar)
            {
                Console.WriteLine(i);
            }
        }

        private static double Prom_Pago(List<Mascota_adoptada> listaMascota)
        {
            decimal totalPagos = listaMascota.Sum(pago => pago.Pago_Mascota);
            int totalMascotas = listaMascota.Count;
            return (double)totalPagos / totalMascotas;
        }

        private static double Prom_Mascotas(List<Mascota_adoptada> listaMascota)
        {
            int totalEdades = listaMascota.Sum(edad => edad.Edad);
            int totalMascotas = listaMascota.Count;
            return (double)totalEdades / totalMascotas;
        }
    }
}
