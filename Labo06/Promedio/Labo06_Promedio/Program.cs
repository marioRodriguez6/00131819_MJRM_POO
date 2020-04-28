using System;

namespace Labo06_Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte opc = 0;
            
            do
            {
                Console.WriteLine(Menu());
                Console.Write("digite la opcion deseada: ");
                opc = Convert.ToByte(Console.ReadLine());

                switch (opc){
                    
                    case 1:

                        break;
                    
                    case 2:

                        break;
                    
                    case 3:

                        break;
                    
                    case 4:
                        
                        Console.Write("saliendo del menu...");
                        
                        break;
                    default:
                        Console.Write("Opcion incorrecta. \n ");
                        break;
                }
            } while (opc != 4);
        }

        static String Menu() {
            return " 1. agregar evaluacion \n 2. Mostrar evaluaciones almacenadas. \n" +
                   " 3. Eliminar evaluacion. \n 4. Terminar programa. \n ";
        }
    }
}