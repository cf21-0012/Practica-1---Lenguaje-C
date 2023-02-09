using System;

namespace Ejercicio_4___Funciones_Trigonometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Bienvenido al programa de calculo de funciones trigonometricas");
            menu();
        }
        static void menu()
        {

            Console.WriteLine("1. Seno");
            Console.WriteLine("2. Coseno");
            Console.WriteLine("3. Tangente");
            Console.WriteLine("4. Cosecante");
            Console.WriteLine("5. Secante");
            Console.WriteLine("6. Cotangente");
            Console.WriteLine("7. Salir");
            Console.WriteLine("Seleccione la funcion que va a calcular:");
            int opc = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el angulo ");
            double a = double.Parse(Console.ReadLine());
            
            opciones(opc, a);
        }

       static void opciones(int opcion, double a)
        { double result = 0;
            switch (opcion)
            {
                case 1:
                    result = Math.Sin(a);

                    Console.WriteLine("El seno es " + result);
                    Console.WriteLine("-----------------------------------------");


                    menu();
                    break;


                case 2:
                    result = Math.Cos(a);

                    Console.WriteLine("El coseno es " + result);
                    Console.WriteLine("-----------------------------------------");


                    menu();
                    break;
                case 3:

                    result = Math.Tan(a);

                    Console.WriteLine("La tangente es " + result);
                    Console.WriteLine("-----------------------------------------");

                    menu();
                    break;

                case 4:
                    result = Math.Sin(a);

                    Console.WriteLine("La cosecante " + result);
                    Console.WriteLine("-----------------------------------------");

                    menu();
                    break;

                case 5:
                    result = Math.Acos(a);

                    Console.WriteLine("La secante es " + result);
                    Console.WriteLine("-----------------------------------------");

                    menu();
                    break;

                case 6:
                    result = Math.Atan(a);

                    Console.WriteLine("La cotangente es " + result);
                    Console.WriteLine("-----------------------------------------");

                    menu();
                    break;

                case 7:
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
