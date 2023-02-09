using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Bienvenido al programa de calculo de areas");
            menu();
            }
        static void menu()
        {
            
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Circulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Hexagono");
            Console.WriteLine("5. Pentagono");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Seleccione la figura que va a calcular:");
            int opcion = int.Parse(Console.ReadLine());
            double result = 0;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Introduzca cuando mide el lado vertical");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca cuando mide el lado horizontal");
                    double b = double.Parse(Console.ReadLine());
                    result = a * b;

                    Console.WriteLine("El area del cuadrado es " + result + " m");
                    Console.WriteLine("-----------------------------------------");


                    menu();
                    break;


                case 2:
                    Console.WriteLine("Introduzca cuanto mide el radio");
                    double r = double.Parse(Console.ReadLine());

                    result = Math.PI * Math.Pow(r, 2);

                    Console.WriteLine("El area del circulo es " + result + " m");
                    Console.WriteLine("-----------------------------------------");


                    menu();
                    break;
                case 3:
                    Console.WriteLine("Introduzca cuanto mide la altura");
                    double al = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca cuanto mide la base");
                    double ba = double.Parse(Console.ReadLine());

                    result = (al * ba) / 2;

                    Console.WriteLine("El area del triangulo es " + result + " m");
                    Console.WriteLine("-----------------------------------------");

                    menu();
                    break;

                case 4:
                    Console.WriteLine("Introduzca cuanto mide el perimetro");
                    double per = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca cuanto mide el apotema");
                    double apo = double.Parse(Console.ReadLine());

                    result = (apo * per) / 2;

                    Console.WriteLine("El area del hexagono es " + result + " m");
                    Console.WriteLine("-----------------------------------------");

                    menu();
                    break;

                case 5:
                    Console.WriteLine("Introduzca cuanto mide el perimetro");
                    double pe = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca cuanto mide el apotema");
                    double ap = double.Parse(Console.ReadLine());

                    result = (ap * pe) / 2;

                    Console.WriteLine("El area del pentagono es " + result + " m");
                    Console.WriteLine("-----------------------------------------");

                    menu();
                    break;  
                case 6:
                    break;

                default:
                    Console.WriteLine("Por favor seleccione una opcion existente del menu");
                    Console.WriteLine("-----------------------------------------");
                    menu();
                    
                    break;

            }

        }
    }
}

