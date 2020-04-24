using System;
using System.Collections.Generic;

namespace Labo05_Ej_05
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<char> vowels = new List<char>();

            Boolean checkvalid = true;

            while (checkvalid)
            {
                Console.Write("ingrese una letra: ");
                char letter = ' ';
                letter = Convert.ToChar(Console.ReadLine());

                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        vowels.Add(letter);
                        break;
                }

                Console.Write("Desea terminar ?  (s/n)");
                char check = ' ';
                check = Convert.ToChar(Console.ReadLine());
                checkvalid = check == 'n';
            }

            foreach (var vocals in vowels)
                Console.Write(vocals + " ");
        }
    }
}