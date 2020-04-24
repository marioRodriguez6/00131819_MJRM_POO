  using System;

namespace Labo05_Ej04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digiste la frase que quiere cambiar.");
            String phrase = "";
            phrase = Console.ReadLine();

            if (phrase != null) phrase = phrase.Replace("a", "b");
            
            Console.Write(phrase);
        }
    }
}