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
                    Console.WriteLine("digite nota obtenida en Laboratorio {0}: ", ds.Name1);
                    notaLabo = Convert.ToDouble(Console.ReadLine());
                    if (notaLabo > 10 || notaLabo < 0)
                    {
                        throw new MoreThanTenException("NO MAS DE 10 DE NOTA.");
                    }

                    
                    notaFinal += (double) (notaLabo * ds.Percentage1 )/100  ;

                }else if (ds is Parcial)
                {
                    Console.WriteLine("digite cuantas preguntas correctas obtuvo en el {0}: ",ds.Name1);
                    cantBuenas = Convert.ToDouble(Console.ReadLine());
                    if (cantBuenas<0  || cantBuenas>ds.CantPreguntas )
                    {
                        throw new WrongInputException("dato incorrecto");
                    }
                    
                        notaFinal += (double) ((cantBuenas / ds.CantPreguntas) * ds.Percentage1/10);

                }else 
                {
                    Console.WriteLine("digite nota obtenida en Tarea {0} : ",ds.Name1);
                    notaTarea = Convert.ToDouble(Console.ReadLine());
                    if (notaTarea > 10 || notaTarea<0)
                    {
                        throw new MoreThanTenException("Nota incorrecta.");
                    }

                    notaFinal += (double) (notaTarea * ds.Percentage1 )/100 ;

                }
            }
            return Math.Round(notaFinal);
        }
    }
}