using System;
using Microsoft.VisualBasic;

namespace Labo_05_Ej_02 {
    class Program{

        public static String Palindromo(String word)
        {
            char[] letter = word.ToCharArray();
            
            Array.Reverse(letter);
            return new string(letter);
        }

         static void Main(String[] args) {
            
            String word = "ara";

            if (word.Equals(Palindromo(word))) {
                Console.Write("es palindromo");
                
            }
            else
            {
                Console.Write("no es palindromo");
            }

        }
    }
}