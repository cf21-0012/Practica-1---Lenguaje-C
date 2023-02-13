using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11___Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Programa que calcula calificaciones ");
            Console.Write("Introduzca nota practica:");
            double tp = double.Parse(Console.ReadLine());

            Console.Write("Introduzca nota del parcial 1:" );
            double pp1 = double.Parse(Console.ReadLine());

            Console.Write("Introduzca nota del parcial 2: ");
            double pp2 = double.Parse(Console.ReadLine());

            Console.Write("Introduzca nota del examen final: ");
            double ef = double.Parse(Console.ReadLine());

            double nf = (tp + (pp1 + pp2) / 2 + ef) / 3;

            if (nf >= 90)
            {
                Console.WriteLine("Su literal es A con la nota de " + nf);
            }
             else if (nf >= 80)
            {
                Console.WriteLine("Su literal es B con la nota de " + nf);
            }
            else if (nf >= 70)
            {
                Console.WriteLine("Su literal es C con la nota de " + nf);
            }
            else if (nf >= 60)
            {
                Console.WriteLine("Su literal es D con la nota de " + nf +", ha reprobado");
            }
            else if (nf >= 100 || nf < 0)
            {
                Console.WriteLine("Por favor introduzca los valores correctos");
            }
            else
            {
                Console.WriteLine("La nota" +nf +" es insuficiente, ha reprobado");
            }

            Console.Read();
        }
    }
}
