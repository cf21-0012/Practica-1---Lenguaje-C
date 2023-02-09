using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6___Permutaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula permutaciones con repeticion y sin repeticion");
            Programa();
        }

        static void Programa()
        {
            
            Console.WriteLine("Digite el número de elementos del conjunto:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el número de elementos a elegir:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Con repeticion");
            Console.WriteLine("2. Sin repetición");
            int opc = Convert.ToInt32(Console.ReadLine());

            double resul = 1;
            if (opc == 1)
            {
                for (int i = 0; i < k; i++)
                {
                    resul *= num;
                }
                Console.WriteLine("La cantidad de permutaciones con repetición es " + resul);
            }
            else if (opc == 2)
            {
                for (int i = num; i > num - k; i--)
                {
                    resul *= i;
                }
                Console.WriteLine("La cantidad permutaciones sin repetición es " + resul);
            }
            else
            {
                Console.WriteLine("Esta opcion no existe, por favor eliga la opcion 1 o 2");
                Programa();
            }
        }
    }
}
