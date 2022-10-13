using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet_y_HashSet
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string frase;
            //SortedSet<string> Diccionario = new SortedSet<string>();

            //Diccionario.Add("hola");
            //Diccionario.Add("adios");
            //Diccionario.Add("yo soy");
            //Diccionario.Add("hermoso");
            //Diccionario.Add("padre");
            //Diccionario.Add("hermano");
            //Diccionario.Add("perro");
            //Diccionario.Add("gato");

            //Console.WriteLine("Ingresa una frase");
            //frase = Console.ReadLine();

            //if (Diccionario.Contains(frase))
            //{
            //    Console.WriteLine($"La frase {frase}, se encuentra en el diccionario");
            //}
            //else
            //{
            //    Console.WriteLine($"No se ha encontrado la frase '{frase}' en el Diccionario");
            //}

            ////conbsola mantenga abierta
            //Console.ReadKey(); 
            
            ///// =============================== /////////////
            
            string frase;
            HashSet<string> Diccionario = new HashSet<string>();

            Console.WriteLine("Ingrese frase al alzar. Si ya no desea ingresar mas frases, no escriba nada y de ENTER.");
            frase = Console.ReadLine();
            Diccionario.Add(frase);

            while (frase != "")
            {
                frase = Console.ReadLine();

                Diccionario.Add(frase);

                if (Diccionario.Contains(frase))
                {
                    Console.WriteLine("La frase ingresada, fue escrita anteriormente");
                }else
                {
                    Console.WriteLine("La frase ingresada, NO fue escrita anteriormente");
                }

            }

            if (frase == "")
            {
                Console.WriteLine("No ha escrito ninguna frase.");
            }

            Console.ReadKey();
        }
    }
}
