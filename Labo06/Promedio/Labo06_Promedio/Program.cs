using System;
using System.Collections.Generic;

namespace Labo06_Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            var exams = new List<Evaluacion>();

            Byte opc = 0, opc1 = 0, opc2 = 0;
            int cantPreguntas = 0, percentage = 0;
            String name = "", type = "", deletePar = "", deleteLab = "", deleteHmwk = "";
            
            var usCulture = new System.Globalization.CultureInfo("en-US");
            
            do{
                Console.WriteLine(Menu());
                Console.Write("digite la opcion deseada: ");
                opc = Convert.ToByte(Console.ReadLine());

                switch (opc){
                    case 1:
                        Console.WriteLine(MenuExams());
                        Console.Write("digite la opcion deseada:  \n ");
                        opc1 = Convert.ToByte(Console.ReadLine());

                        if (opc1 == 1)
                        {
                            Console.WriteLine("Nombre del parcial a añadir?");
                            name = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Cuanto es el porcentaje del parcial ?");
                            percentage = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("De cuantas preguntas es el parcial ?");
                            cantPreguntas = Convert.ToInt32(Console.ReadLine());


                            exams.Add(new Parcial(percentage, name, cantPreguntas));
                        }else if (opc1 == 2)
                        {
                            Console.WriteLine("Nombre del Laboratorio a añadir?");
                            name = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Cuanto es el porcentaje del Laboratorio ?");
                            percentage = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Tipo de laboratorio ?");
                            type = Convert.ToString(Console.ReadLine());
                            
                            exams.Add(new Laboratorio(percentage, name, type));
                            
                        }else if (opc1 == 3) {
                            Console.WriteLine("Nombre de la tarea a añadir?");
                            name = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Cuanto es el porcentaje de la tarea ?");
                            percentage = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("fecha de entrega de la tarea ?" + usCulture.DateTimeFormat.ShortDatePattern);
                            String fecha = Console.ReadLine();
                            DateTime userDate;
                            if (DateTime.TryParse(fecha, usCulture.DateTimeFormat, System.Globalization.DateTimeStyles.None, out userDate))
                                exams.Add(new Tarea(percentage, name, Convert.ToDateTime(fecha)));
                            else
                            {
                                Console.WriteLine("Fecha erronea, intente de nuevo.");
                            }

                        }else 
                            Console.WriteLine("Opcion erronea! \n ");
                        break;
                    
                    case 2:

                        foreach (var i in exams)
                        {
                            Console.Write(i.ToString());
                        }
                        break;
                    case 3:
                        
                        Console.WriteLine(MenuElimin());
                        Console.Write("digite la opcion deseada:  \n ");
                        opc2 = Convert.ToByte(Console.ReadLine());

                        if (opc2 == 1)
                        {
                            Console.WriteLine("Nombre del Parcial que quieres eliminar. ");
                            deletePar = Console.ReadLine();

                            exams.Remove(exams.Find(s => s.Name1.Equals(deletePar)));


                        }else if (opc2 == 2)
                        {
                            Console.WriteLine("Nombre del Laboratorio que quieres eliminar. ");
                            deleteLab = Convert.ToString(Console.ReadLine());
                            
                            exams.Remove(exams.Find(s => s.Name1.Equals(deleteLab)));

                        }else if (opc2 == 3) {
                            Console.WriteLine("Nombre de la tarea que quieres eliminar. ");
                            deleteHmwk = Convert.ToString(Console.ReadLine());

                            exams.Remove(exams.Find(s => s.Name1.Equals(deleteHmwk)));
                            
                        }else 
                            Console.WriteLine("Opcion erronea! \n ");

                        break;
                    case 4:

                       Console.WriteLine(" \n " + "su nota final es : " + CalcularNota.Calcular(exams) + " \n "); 
                        
                        Console.Write("saliendo del menu...");
                        
                        break;
                    default:
                        Console.Write("Opcion incorrecta. \n ");
                        break;
                }
            } while (opc != 4);
        }

        static String Menu() {
            return " \n 1. agregar evaluacion \n 2. Mostrar evaluaciones almacenadas. \n" +
                   " 3. Eliminar evaluacion. \n 4. Terminar programa. \n ";
        }

        static String MenuExams()
        {
            return " 1. Agregar Parcial. \n 2. Agregar Laboratorio. \n 3. Agregar Tarea. \n  ";
        }
        
        static String MenuElimin()
        {
            return " 1. Eliminar Parcial. \n 2. Eliminar Laboratorio. \n 3. Eliminar Tarea. \n  ";
        }
    }
}