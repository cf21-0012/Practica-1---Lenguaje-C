using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa que imprime la sucesion Fibonacci");
            Console.WriteLine("Introduce la cantidad de numeros que imprimira la sucesion ");
            int suces = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;


            for (int i = 0; i < suces; i++)
            {

                Console.WriteLine(c);
                a = b;
                b = c;
                c = a + b;
            }
            Console.Write("El ultimo numero de la sucesión fue " + b);
            Console.Read();
        }
    }
}
