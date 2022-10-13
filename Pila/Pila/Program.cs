using System;
using System.Collections.Generic;

namespace Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Pila = new Stack<string>();


            Console.WriteLine("Ingresa tu nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine($"{nombre} ingresa tu apellido");
            string apellido = Console.ReadLine();

            Console.WriteLine("Indique su lugar de trabajo");
            string direccion = Console.ReadLine();

            Pila.Push(nombre);
            Pila.Push(apellido);
            Pila.Push(direccion);

            int Max = Pila.Count;

            for (int i = 0; i < Max; i++)
            {
                string Dato = Pila.Pop();
                Console.WriteLine(Dato);
            }
        }
    }
}