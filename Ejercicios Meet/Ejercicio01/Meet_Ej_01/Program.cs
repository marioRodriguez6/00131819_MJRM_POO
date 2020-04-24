using System;
using System.Collections.Generic;

namespace Meet_Ej_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            var p = new List<Persona>();

            p.Add(new Persona("mario", "Rodriguez", 19));
            p.Add(new Persona("Luis", edad: 20));
            p.Add(new Persona(edad: 22));
            p.Add(new Persona(apellido: "Morales"));


            String buscar = "walter";
            buscar = Console.ReadLine();
            
            p.ForEach(it => {
                if (buscar != null && buscar.Equals(it.Nombre))
                {
                    Console.WriteLine("Nuevo nombre: ");
                    it.Nombre = Console.ReadLine();
                    Console.WriteLine(it.ToString());
                }
            });

            int añadir = 12;
            int arbol = 14;
        }
    }
}