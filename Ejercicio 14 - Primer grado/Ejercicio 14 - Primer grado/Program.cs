using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14___Primer_grado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa resuelve ecuaciones lineales de primer grado, siguiendo esta formula ax + b = 0");
            Console.WriteLine("Digite el termino a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el temrino b:");
            double b = Convert.ToDouble(Console.ReadLine());

            double resul = ResolverEcuacion(a, b);

            if (Double.IsInfinity(resul))
            {
                Console.WriteLine("Esta ecuacion puede tener soluciones infinitas");
            }
            else if (Double.IsNaN(resul))
            {
                Console.WriteLine("Esta ecuacion no puede ser resuelta");
            }
            else
            {
                Console.WriteLine("El valor de x es: x = " + resul);
            }
        }

        static double ResolverEcuacion(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return Double.PositiveInfinity;
                }
                else
                {
                    return Double.NaN;
                }
            }
            else
            {
                return -b / a;
            }
        }
    }
}
