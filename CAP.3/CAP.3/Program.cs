using System;

namespace CAP._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            int numero;
            string dia;

            do
            {
                Console.WriteLine("\n\n\tMENU");
                Console.WriteLine("\n\tSelecciona un numero: ");
                Console.WriteLine("\n\t1. Ejercicio 1 ");
                Console.WriteLine("\n\t2. Ejercicio 4 ");
                Console.WriteLine("\n\t3. Salir ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduzca un numero: ");

                        int num = int.Parse(Console.ReadLine());
                        if (num % 2 == 0)
                        {
                            Console.Write("\nEl numero " + num + " es Par");

                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("\nEl numero " + num + " es Impar");

                            Console.ReadKey();
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:

                        Console.Write("Introduzca un numero del 1 al 7: ");
                        dia = Console.ReadLine();
                        numero = int.Parse(dia);

                        switch (numero)
                        {
                            case 1:
                                Console.WriteLine("\nEl numero de ha introducido corresponde al dia: LUNES");
                                break;

                            case 2:
                                Console.WriteLine("\nEl numero de ha introducido corresponde al dia: MARTES");
                                break;

                            case 3:
                                Console.WriteLine("\nEl numero de ha introducido corresponde al dia: MIERCOLES");
                                break;

                            case 4:
                                Console.WriteLine("\nEl numero de ha introducido corresponde al dia: JUEVES");
                                break;

                            case 5:
                                Console.WriteLine("\nEl numero de ha introducido corresponde al dia: VIERNES");
                                break;

                            case 6:
                                Console.WriteLine("\nEl numero de ha introducido corresponde al dia: SABADO");
                                break;

                            case 7:
                                Console.WriteLine("\nEl numero de ha introducido corresponde al dia: DOMINGO");
                                break;
                            default:

                                Console.WriteLine("\nEl numero que ha introducido esta fuera del 1 al 7... ");
                                break;
                        }
                        Console.ReadKey();
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



