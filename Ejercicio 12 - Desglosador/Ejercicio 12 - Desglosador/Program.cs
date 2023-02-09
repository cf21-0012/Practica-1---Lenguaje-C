using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12___Desglosador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa desglosa billetes y monedas en DOP ");

            int[] montos = {2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1};
            int[] MonedasPapeletas = new int[10];

           
            Console.WriteLine("Digite la cantidad a desglosar (DOP):");
            int dinero = int.Parse(Console.ReadLine());

            Console.WriteLine("     Desglose del monto " +dinero);
            Console.WriteLine("---------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                MonedasPapeletas[i] = dinero / montos[i];
                dinero %= montos[i];
                if (montos[i] <= 25)
                {
                    Console.WriteLine(MonedasPapeletas[i] + " monedas" + " de $" + montos[i]);
                }
                if (montos[i] >= 50)
                {
                    Console.WriteLine(MonedasPapeletas[i] +" papeletas" + " de $" + montos[i]);
                }
            }
            Console.ReadLine();
        }
          
    }
}
