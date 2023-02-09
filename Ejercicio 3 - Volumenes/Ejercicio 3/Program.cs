using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Bienvenido al programa de calculo de volumenes");
            menu();
        }
        static void menu()
        {

            Console.WriteLine("1. Cubo");
            Console.WriteLine("2. Esfera");
            Console.WriteLine("3. Cono");
            Console.WriteLine("4. Piramide");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione la figura que va a calcular:");
            int opcion = int.Parse(Console.ReadLine());
            double result = 0;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Introduzca cuanto mide la longitud");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca cuando mide el ancho");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca cuando mide la altura");
                    double c = double.Parse(Console.ReadLine());
                    result = a * b * c;

                    Console.WriteLine("El volumen del cubo es " + result + " m3");
                    Console.WriteLine("-----------------------------------------");


                    menu();
                    break;


                case 2:
                    Console.WriteLine("Introduzca cuanto mide el radio");
                    double r = double.Parse(Console.ReadLine());

                    result = (4 * Math.PI * Math.Pow(r, 3)/3);

                    Console.WriteLine("El volumen de la esfera es " + result + " m");
                    Console.WriteLine("-----------------------------------------");


                    menu();
                    break;
                case 3:
                    Console.WriteLine("Introduzca cuanto mide el radio");
                    double ra = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca cuanto mide la altura");
                    double al = double.Parse(Console.ReadLine());

                    result = (Math.PI * Math.Pow(ra,2) * al) / 3;

                    Console.WriteLine("El volumen del cono es " + result + " m");
                    Console.WriteLine("-----------------------------------------");

                    menu();
                    break;

                case 4:
                    Console.WriteLine("Introduzca cuanto mide la altura");
                    double alt = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca cuanto mide el lado");
                    double la = double.Parse(Console.ReadLine());

                    result = (alt * Math.Pow(la,2)) / 3;

                    Console.WriteLine("El volumen de la piramide es " + result + " m");
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

        }
    }
}
