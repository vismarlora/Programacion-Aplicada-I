using System;

namespace CAP._1
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
                Console.WriteLine("\n\t2. Ejercicio 5 ");
                Console.WriteLine("\n\t3. Salir ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch(opcion)
                {
                    case 1 :
                        Console.WriteLine("\n\tVISMAR", Console.ForegroundColor = ConsoleColor.Yellow);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2 :
                        Console.WriteLine("\n\tVISMAR", Console.ForegroundColor = ConsoleColor.Yellow);
             
                        Console.WriteLine("\n\tHola! Bienvenido...", Console.ForegroundColor = ConsoleColor.Green);
                    
                        Console.WriteLine("\n\tGracias por estar aqui, hasta la proxima...", Console.ForegroundColor = ConsoleColor.Blue);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        break;
                    default:
                        Console.WriteLine("El numero esta fuera de rango...");
                        break;
                }

            } while (opcion != 3);


           
        }
    }
}
