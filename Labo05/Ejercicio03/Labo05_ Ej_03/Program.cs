using System;

namespace Labo05__Ej_03
{
    class Program
    {

        static void Recursividad(int num, int n, Boolean check) {
            if (check) {
                if (num < n)
                {
                    Console.Write(num + " ");
                    num++;
                    Recursividad(num, n, true);
                }
                else if (num == n)
                {
                    Console.Write(num + " ");
                    num--;
                    Recursividad(num, n, false);
                }
            }else {
                    if (num > 1)
                    {
                        Console.Write(num + " ");
                        num--;
                        Recursividad(num, n, check);
                    }else if (num == 1)
                    {
                        Console.Write(num);
                    }
                }
        }
        
        
        public static void Main(string[] args) {
            Console.Write("digitar numero para recorrido. ");

            var n = Convert.ToInt32(Console.ReadLine());

            if (n > 0) {
              Recursividad(num: 1, n: n, check: true);
            }else     
                Console.Write("el numero no se puede ejecutar.");

        }
    }
}