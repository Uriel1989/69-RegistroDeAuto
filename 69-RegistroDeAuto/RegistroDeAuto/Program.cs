using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroDeAuto
{
    class Program
    {
        static void Main(string[] args)
        {

            List<DatosDelVehiculo> ListAutos = new List<DatosDelVehiculo>();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.CursorLeft = 30;

            Console.WriteLine("Bienvenido al registro de autos");

            Console.WriteLine("Ingrese 'S' para el ingreso de datos o 'N' para cerrar el programa:");

            string acceso = Console.ReadLine();

            while (acceso == "s")
            {
                DatosDelVehiculo coche = new DatosDelVehiculo();

                Console.WriteLine("ingresa la marca :");

                coche.Marca = Console.ReadLine();

                Console.WriteLine("Ingrese el modelo:");

                coche.Modelo = Console.ReadLine();

                Console.WriteLine("Tipo de combustible:");

                coche.TipoCombustible = Console.ReadLine();

                Console.WriteLine("Cantidad de puertas:");

                coche.CantPuertas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("¿Desea ingresar mas vehiculos? s/n:");

                acceso = Console.ReadLine();

                ListAutos.Add(coche);
            }

            for ( int i = 0; i< ListAutos.Count; i++)
            {
                DatosDelVehiculo datos = ListAutos[i];

                Console.WriteLine(datos.presentacion());
            }

            Console.ReadKey();
        }
    }
}
