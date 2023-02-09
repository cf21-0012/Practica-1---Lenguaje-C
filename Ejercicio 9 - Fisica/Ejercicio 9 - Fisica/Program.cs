using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9___Fisica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Bienvenido al programa de calculo de velocidad(m/s), tiempo(s) y desplazamiento(m)");
            menu();

        }
        static void menu()
        {
            int opci = 0;
            Console.WriteLine("1. Velocidad");
            Console.WriteLine("2. Desplazamiento");
            Console.WriteLine("3. Tiempo");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione la funcion que va a calcular:");
            opci = int.Parse(Console.ReadLine());

            opciones(opci);

         }

        static void opciones(int opc)
        {
            double v, t, d, resul;

            if (opc == 1)
            {
                Console.WriteLine("Digite el tiempo");
                t = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el desplazamiento");
                d = double.Parse(Console.ReadLine());

                resul = d / t;
                Console.WriteLine("La velocidad es " + resul + " m/s");
                Console.WriteLine("-------------------------------------");
                menu();

            }
            if (opc == 2) 
            {
                Console.WriteLine("Digite la velocidad");
                v = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el tiempo");
                t = double.Parse(Console.ReadLine());

                resul = v * t;
                Console.WriteLine("El desplazamiento es " + resul + " mts");
                Console.WriteLine("-------------------------------------");
                menu();
            }
            if (opc == 3) 
            {
                Console.WriteLine("Digite la distancia");
                d = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el velocidad");
                v = double.Parse(Console.ReadLine());

                resul = d / v;
                Console.WriteLine("El tiempo es " + resul +" s");
                Console.WriteLine("-------------------------------------");
                menu();
            }
            if (opc == 4)
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
