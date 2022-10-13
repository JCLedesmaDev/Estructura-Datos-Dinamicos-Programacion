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

            //Console.WriteLine("Ingrese frase al alzar. Si ya no desea ingresar mas frases, no escriba nada y de ENTER.");
            //frase = Console.ReadLine();
            //Diccionario.Add(frase);

            //while (frase != "")
            //{
            //    frase = Console.ReadLine();

            //    Diccionario.Add(frase);

            //    if (Diccionario.Contains(frase))
            //    {
            //        Console.WriteLine("La frase ingresada, fue escrita anteriormente");
            //    }
            //    else
            //    {
            //        Console.WriteLine("La frase ingresada, NO fue escrita anteriormente");
            //    }

            //}

            //if (frase == "")
            //{
            //    Console.WriteLine("No ha escrito ninguna frase.");
            //}

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
