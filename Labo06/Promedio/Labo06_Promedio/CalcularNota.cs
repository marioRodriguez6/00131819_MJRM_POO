using System;
using System.Collections.Generic;

namespace Labo06_Promedio
{
    public class CalcularNota
    {

        public static double Calcular(List<Evaluacion> s)
        {
            double cantBuenas = 0, notaLabo = 0, notaTarea = 0, notaFinal = 0;
            
            
            foreach (var ds in s)
            {
                if (ds is Laboratorio )
                {
                    Console.WriteLine("digite nota obtenida en Laboratorio: ");
                    notaLabo = Convert.ToDouble(Console.ReadLine());

                    notaFinal += (double) (notaLabo * ds.Percentage2 );

                }else if (ds is Parcial)
                {
                    Console.WriteLine("digite cuantas preguntas correctas obtuvo: ");
                    cantBuenas = Convert.ToDouble(Console.ReadLine());

                    notaFinal += (double) ((cantBuenas / ds.CantPreguntas) * ds.Percentage1);

                }else 
                {
                    Console.WriteLine("digite nota obtenida en Tarea: ");
                    notaTarea = Convert.ToDouble(Console.ReadLine());

                    notaFinal += (double) (notaTarea * ds.Percentage1);

                }
            }
            
            return notaFinal;
        }


    }
}