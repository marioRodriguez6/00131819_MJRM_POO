using System;

namespace Labo_Ej01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el valor de n donde terminaremos: ");
            int lim = 0;
            lim = Convert.ToInt32(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;
            var reserv =0;

            if (lim == 1 ) {
                Console.Write("0. ");
            }
            else{
                Console.Write("0. 1. ");
                for (var i = 1; (i) < lim - 1; (i)++)
                {
                    reserv = n1;
                    n1 = n2;

                    n2 = n1 + reserv;
                    Console.Write(n2 + ". ");
                }
            }
        }
    }
}