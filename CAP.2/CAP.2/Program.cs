using System;

namespace CAP._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("\n\n\tMENU");
                Console.WriteLine("\n\tSelecciona un numero: ");
                Console.WriteLine("\n\t1. Ejercicio 1 ");
                Console.WriteLine("\n\t2. Ejercicio 3 ");
                Console.WriteLine("\n\t3. Ejercicio 5 ");
                Console.WriteLine("\n\t4. Salir ");

                opcion = Convert.ToInt32(Console.ReadLine());
                int lados = 0;
                float medlado = 0, perimetro = 0;

                double grados = 0, radianes = 0, pi = 3.1416;
                string valor = "";

                float canteuro = 0.00f, conversion = 0.00f;
                float dolar = 0.00f;

                switch (opcion)
                {
                    case 1:


                        Console.Write("Introduzca la cantidad de lados de la figura: ");
                        lados = Int32.Parse(Console.ReadLine());

                        Console.Write("Introduzca la medida de un lado: ");
                        medlado = Single.Parse(Console.ReadLine());

                        perimetro = lados * medlado;

                        Console.Write("\nEl perimetro es: {0} ", perimetro);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:

                        Console.Write("Introduzca la cantidad de grados que quieres convertir: ");
                        valor = Console.ReadLine();
                        grados = Convert.ToDouble(valor);

                        radianes = gradosRadianes(grados, pi);

                        Console.Write("\n{0}° equivalen a {1} radianes", grados, radianes);

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:

                        /*Console.Write("Introduzca la tasa actual del dolar: ");
                        valor = Console.ReadLine();
                        cantdolar = Convert.ToDouble(valor);*/

                        Console.Write("Introduzca la tasa actual del euro: ");
                        canteuro = Single.Parse(Console.ReadLine());

                        Console.Write("Introduzca la cantidad de dolar que desea convertir a Euro: ");
                        dolar = Single.Parse(Console.ReadLine());

                        conversion = canteuro * dolar;
                        //euro = conversion * canteuro;

                        Console.Write($"\nLa cantidad de dolares equivalente a euros es: {conversion}");
                        Console.ReadKey();
                        break;

                    case 4:

                        break;
                    default:
                        Console.WriteLine("El numero esta fuera de rango...");
                        break;
                }

            } while (opcion != 4);



        }
        static double gradosRadianes(double n1, double n2)
        {
            double r = 0.0;

            r = (n1 * n2) / 180;

            return r;


        }
    }
}
