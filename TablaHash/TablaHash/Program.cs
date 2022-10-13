using System;
using System.Collections.Generic;

namespace TablaHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Diccionario = new Dictionary<string, string>();
            string frase;

            Diccionario.Add("hello", "hola");
            Diccionario.Add("good bye", "adios");
            Diccionario.Add("I am", "yo soy");
            Diccionario.Add("beutiful", "hermoso");
            Diccionario.Add("farher", "padre");
            Diccionario.Add("brother", "hermano");

            Console.WriteLine("Ingresa una frase en ingles");
            frase = Console.ReadLine();

            if (Diccionario.ContainsKey(frase))
            {
                Console.WriteLine($"La frase {frase}, se traduce como: {Diccionario[frase]}");
            }
            else
            {
                Console.WriteLine($"No se ha encontrado la frase '{frase}' en el Diccionario");
            }

            //conbsola mantenga abierta
            Console.ReadKey();
        }
    }
}
