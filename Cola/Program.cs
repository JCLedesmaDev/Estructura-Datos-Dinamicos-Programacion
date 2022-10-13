using System;
using System.Collections.Generic;

namespace Cola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string nombre = "";
            string apellido = "";

            while (queue.Count > 3)
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
            
                Console.WriteLine($"{nombre}, ingresa tu apellido");
                apellido = Console.ReadLine();

                while (nombre == "" || apellido == "")
                {

                    Console.WriteLine("Le ha faltado ingresar un dato.");

                    if (nombre == "")
                    {
                        Console.WriteLine("Ingrese nuevamente su nombre");
                        nombre = Console.ReadLine();
                    }

                    if (apellido == "")
                    {
                        Console.WriteLine("Ingrese nuevamente su apellido");
                        apellido = Console.ReadLine();
                    }
                }

            }

            queue.Enqueue(nombre + " " + apellido);

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.ReadKey();

        }
    }
}
