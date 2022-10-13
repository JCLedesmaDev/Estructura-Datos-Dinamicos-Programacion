using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            string frase;
            SortedList<string, string> Diccionario = new SortedList<string, string>();

            Diccionario.Add("hello", "hola");
            Diccionario.Add("good bye", "adios");
            Diccionario.Add("I am", "yo soy");
            Diccionario.Add("beutiful", "hermoso");
            Diccionario.Add("farher", "padre");
            Diccionario.Add("brother", "hermano");
            Diccionario.Add("dog", "perro");
            Diccionario.Add("cat", "gato");

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
