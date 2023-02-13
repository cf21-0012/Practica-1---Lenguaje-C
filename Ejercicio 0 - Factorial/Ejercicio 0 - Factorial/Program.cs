using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_0___Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime el factorial de un numero");
            Console.WriteLine("Introduzca el numero:");
            int fac = 1; int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }

            Console.WriteLine("El factorial es " +fac);
            Console.ReadLine();
        }
    }
}
