using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8___Ecuaciones_Segundo_Grado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa resuelve ecuaciones de segundo grado");

            double x1, x2;

            Console.WriteLine("Introduzca a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca c");
            double c = double.Parse(Console.ReadLine());


            double raiz = (b*b) - (4 * a * c);
           
            if (raiz >= 1) { 
             x1 = -b + Math.Sqrt(raiz) / 2 * a;
             x2 = -b - Math.Sqrt(raiz) / 2 * a;

             Console.WriteLine("El valor de x1 es: " + x1);
             Console.WriteLine("El valor de x1 es: " + x2);
            }if (raiz == 0)
            {
                x1 = x2 = -b / (2 * a);
            }
            else
            {
                Console.WriteLine("La solucion no se encuentra dentro de los numeros naturales");
            }

        }


    }
}
