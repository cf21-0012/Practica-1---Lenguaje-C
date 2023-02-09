using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___Operaciones_con_fracciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Bienvenido al programa de operaciones con fracciones");
            menu();
           
        }
        static void menu()
        {

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione la funcion que va a calcular:");
            int opc = int.Parse(Console.ReadLine());

            if (opc == 5)
            {
                Environment.Exit(0);
            }
            else
            {
                opciones(opc);
            }
      
        }

        static void opciones(int opcion)
        {
            double result = 0;
            Console.WriteLine("Digite las fracciones");
            Console.WriteLine("Numerador 1");
            double N1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Denominador 1");
            double D1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Numerador 2");
            double N2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Denominador 1");
            double D2 = double.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Suma(N1, N2, D1, D2);
                    Console.WriteLine("-----------------------------------------");
                    menu();
                    break;

                case 2:
                    Resta(N1, N2, D1, D2);
                    Console.WriteLine("-----------------------------------------");
                    menu();
                    break;

                case 3:
                    Multi(N1, N2, D1, D2);

                    Console.WriteLine("-----------------------------------------");
                    menu();
                    break;

                case 4:
                    Divi(N1, N2, D1, D2);

                    Console.WriteLine("-----------------------------------------");
                    menu();
                    break;


                case 5:
                    break;

                default:
                    Console.WriteLine("Por favor seleccione una opcion existente del menu");
                    Console.WriteLine("-----------------------------------------");
                    menu();

                    break;

            }
            void Suma(double n1, double n2, double d1, double d2)
            {
                double rd = 0; double rn = 0;
                if (d1 == d2)
                {
                    rn = (n1 * n2);
                                        
                    Console.WriteLine("El resultado es: " + rn +"/" +d1);

                }
                else
                {
                    rn = (n1 * d2) * (d1 * n2);
                    rd = (d1 * d2);
                    Console.WriteLine("El resultado es: " + rn + "/" + rd);
                }

            }

            void Resta(double n1, double n2, double d1, double d2)
            {
                double rd = 0; double rn = 0;
                if (d1 == d2)
                {
                    rn = (n1 * d2) - (d1 * n2);
                    rd = (d1 * d2);
                    Console.WriteLine("El resultado es: " + rn + "/" + d1);

                }
                else
                {
                    rn = n1 * n2;
                    rd = d1;
                    Console.WriteLine("El resultado es: " + rn + "/" + rd);
                }

            }

            void Multi(double n1, double n2, double d1, double d2)
            {
                double rd = 0; double rn = 0;

                rd = (n1 * n2);
                rn = (d1 * d2);
                Console.WriteLine("El resultado es: " + rn + "/" + rd);

            }

            void Divi(double n1, double n2, double d1, double d2)
            {
                double rd = 0; double rn = 0;

                rn = (n1 * d2);
                rd = (n2 * d1);

                Console.WriteLine("El resultado es: " + rn + "/" + rd);

            }

        }
    }
}
