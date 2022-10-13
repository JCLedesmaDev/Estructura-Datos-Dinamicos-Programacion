using System;
using System.Collections.Generic;
using System.Linq;


namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Frase;
            int Numero;
            List<string> Lista = new List<string>();

            Frase = Console.ReadLine();

            while (Frase != "")
            {
                Lista.Add(Frase);
                Console.WriteLine("Ingrese la proxima palabra");
                Frase = Console.ReadLine();
            }

            Console.WriteLine("Ingrese la posición de la palabra que desea obtener");
            Numero = Convert.ToInt32(Console.ReadLine());

            while (Numero != 0)
            {
                if (Numero > Lista.Count())
                {
                    Console.WriteLine("No hay datos en esta posicion, ingrese otra posicion");
                    Numero = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Numero--;
                    Console.WriteLine(Lista[Numero]);
                    Numero = Convert.ToInt32(Console.ReadLine());
                }

            }

        }
    }
}
