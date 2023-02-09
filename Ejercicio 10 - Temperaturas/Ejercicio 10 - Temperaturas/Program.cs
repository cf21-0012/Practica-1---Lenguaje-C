using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10___Temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Bienvenido al programa de calculo de temperaturas");
            menu();

        }
        static void menu()
        {
            int opci = 0;
            Console.WriteLine("1. Celsius a Kelvin ");
            Console.WriteLine("2. Kelvin a Fahrenheit ");
            Console.WriteLine("3. Fahrenheit a Celsius ");
            Console.WriteLine("4. Kelvin a Celsius ");
            Console.WriteLine("5. Salir ");
            Console.WriteLine("Seleccione la funcion que va a calcular:");
            opci = int.Parse(Console.ReadLine());

            opciones(opci);

        }

        static void opciones(int opc)
        {
            double c, k, f, resul;

            if (opc == 1)
            {
                Console.WriteLine("Digite la temperatura en Celsius");
                c = double.Parse(Console.ReadLine());

                resul = c + 273.15;
                
                Console.WriteLine("La temperatura en kelvin es " + resul + " grados");
                Console.WriteLine("-------------------------------------");
                menu();

            }
            if (opc == 2)
            {
                Console.WriteLine("Digitela en kelvin");
                k = double.Parse(Console.ReadLine());

                resul = k - 273.15;

                Console.WriteLine("La temperatura en fahrenheit " + resul + " grados");
                Console.WriteLine("-------------------------------------");
                menu();
            }
            if (opc == 3)
            {
                Console.WriteLine("Digitela en fahrenheit");
                f = double.Parse(Console.ReadLine());

                resul = (5 / 9) * (f + 32);
                Console.WriteLine("La temperatura en Celsius es" + resul + " grados");
                Console.WriteLine("-------------------------------------");
                menu();
            }
            if (opc == 4)
            {
                Console.WriteLine("Digitela en Kelvin");
                k = double.Parse(Console.ReadLine());

                resul = k - 273;
                
                Console.WriteLine("La temperatura en Celsius es de " + resul + " grados");
                Console.WriteLine("-------------------------------------");
                menu();
            }
            if (opc == 5)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Por favor, seleccione una opcion que exista");
                Console.WriteLine("-------------------------------------");
                menu();
            }
        }
    }
}
