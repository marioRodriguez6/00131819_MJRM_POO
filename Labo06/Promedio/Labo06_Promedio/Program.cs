﻿using System;
using System.Collections.Generic;
using System.Security;

namespace Labo06_Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            var exams = new List<Evaluacion>();

                int opc = 0, opc1 = 0, opc2 = 0, cantPreguntas = 0, percentage = 0;
                String name = "", type = "", deletePar = "", deleteLab = "", deleteHmwk = "";

                var usCulture = new System.Globalization.CultureInfo("en-US");

            
                do
                {
                    try
                    {

                        Console.WriteLine(Menu());
                        Console.Write("digite la opcion deseada: ");
                        opc = Convert.ToInt32(Console.ReadLine());
                        if (opc <= 0)
                        {
                            throw new NegativeInputException("dato ingresado no valido.");
                        }

                        switch (opc)
                        {
                            case 1:

                                int totPercantage = 100;

                                foreach (var DS in exams)
                                {
                                    totPercantage -= DS.Percentage1;
                                    if (totPercantage <= 0)
                                        throw new MoreThanTenException("Se paso del limite de evaluacion");
                                }

                                Console.WriteLine(MenuExams());
                                Console.Write("digite la opcion deseada:  \n ");
                                opc1 = Convert.ToInt32(Console.ReadLine());
                                if (opc1 <= 0)
                                {
                                    throw new NegativeInputException("dato ingresado no valido.");
                                }

                                if (opc1 == 1)
                                {
                                    Console.WriteLine("Nombre del parcial a añadir?");
                                    name = Convert.ToString(Console.ReadLine());
                                    if (ItsNumber(name))
                                    {
                                        throw new WrongInputException("dato erroneo, No digite numero!");
                                    }

                                    Console.WriteLine("Cuanto es el porcentaje del parcial ?");
                                    percentage = Convert.ToInt32(Console.ReadLine());

                                    if (percentage <= 0)
                                    {
                                        throw new NegativeInputException("dato ingresado no valido.");
                                    }

                                    if (percentage > totPercantage)
                                    {
                                        throw new MoreThanTenException("No se puede agregar mas.");
                                    }

                                    Console.WriteLine("De cuantas preguntas es el parcial ?");
                                    cantPreguntas = Convert.ToInt32(Console.ReadLine());
                                    if (cantPreguntas <= 0)
                                    {
                                        throw new NegativeInputException("dato ingresado no valido.");
                                    }


                                    exams.Add(new Parcial(percentage, name, cantPreguntas));
                                }
                                else if (opc1 == 2)
                                {
                                    Console.WriteLine("Nombre del Laboratorio a añadir?");
                                    name = Convert.ToString(Console.ReadLine());
                                    if (ItsNumber(name))
                                    {
                                        throw new WrongInputException("dato erroneo, No digite numero!");
                                    }

                                    Console.WriteLine("Cuanto es el porcentaje del Laboratorio ?");
                                    percentage = Convert.ToInt32(Console.ReadLine());

                                    if (percentage <= 0 || percentage > 100)
                                    {
                                        throw new NegativeInputException("dato ingresado no valido.");
                                    }

                                    if (percentage > totPercantage)
                                    {
                                        throw new MoreThanTenException("No se puede agregar mas.");
                                    }

                                    Console.WriteLine("Tipo de laboratorio ?");
                                    type = Convert.ToString(Console.ReadLine());

                                    exams.Add(new Laboratorio(percentage, name, type));

                                }
                                else if (opc1 == 3)
                                {
                                    Console.WriteLine("Nombre de la tarea a añadir?");
                                    name = Convert.ToString(Console.ReadLine());
                                    if (ItsNumber(name))
                                    {
                                        throw new WrongInputException("dato erroneo, No digite numero!");
                                    }

                                    Console.WriteLine("Cuanto es el porcentaje de la tarea ?");
                                    percentage = Convert.ToInt32(Console.ReadLine());
                                    if (percentage <= 0)
                                    {
                                        throw new NegativeInputException("dato ingresado no valido.");
                                    }

                                    if (percentage > totPercantage)
                                    {
                                        throw new MoreThanTenException("No se puede agregar mas.");
                                    }

                                    Console.WriteLine("fecha de entrega de la tarea ?" +
                                                      usCulture.DateTimeFormat.ShortDatePattern);
                                    String fecha = Console.ReadLine();
                                    DateTime userDate;
                                    if (DateTime.TryParse(fecha, usCulture.DateTimeFormat,
                                        System.Globalization.DateTimeStyles.None, out userDate))
                                        exams.Add(new Tarea(percentage, name, Convert.ToDateTime(fecha)));
                                    else
                                    {
                                        Console.WriteLine("Fecha erronea, intente de nuevo.");
                                    }

                                    if (userDate <= DateTime.Today)
                                    {
                                        throw new WrongTimeExcepcion("Fecha Erronea");
                                    }

                                }
                                else
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
                                opc2 = Convert.ToInt32(Console.ReadLine());
                                if (opc2 <= 0)
                                {
                                    throw new NegativeInputException("dato ingresado no valido.");
                                }

                                if (opc2 == 1)
                                {
                                    Console.WriteLine("Nombre del Parcial que quieres eliminar. ");
                                    deletePar = Console.ReadLine();

                                    if (exams.Remove(exams.Find(s => s.Name1.Equals(deletePar))))
                                    {
                                        Console.WriteLine("Eliminado con exito.");
                                    }

                                    Console.WriteLine("No se encontro elemento.");

                                }
                                else if (opc2 == 2)
                                {
                                    Console.WriteLine("Nombre del Laboratorio que quieres eliminar. ");
                                    deleteLab = Convert.ToString(Console.ReadLine());

                                    if (exams.Remove(exams.Find(s => s.Name1.Equals(deleteLab))))
                                    {
                                        Console.WriteLine("Eliminado con exito.");
                                    }

                                    Console.WriteLine("No se encontro elemento.");
                                }
                                else if (opc2 == 3)
                                {
                                    Console.WriteLine("Nombre de la tarea que quieres eliminar. ");
                                    deleteHmwk = Convert.ToString(Console.ReadLine());

                                    if (exams.Remove(exams.Find(s => s.Name1.Equals(deleteHmwk))))
                                    {
                                        Console.WriteLine("Eliminado con exito.");
                                    }

                                    Console.WriteLine("No se encontro elemento.");
                                }
                                else
                                    Console.WriteLine("Opcion erronea! \n ");

                                break;
                            case 4:
                                try
                                {
                                    Console.WriteLine(
                                        " \n " + "su nota final es : " + CalcularNota.Calcular(exams) + " \n ");

                                    Console.Write("saliendo del menu...");
                                }
                                catch (MoreThanTenException fd)
                                {
                                    Console.WriteLine("Se excede de 10.");
                                    opc = 5;
                                }
                                catch (WrongInputException df)
                                {
                                    Console.WriteLine("dato ncorrecto.");
                                    opc = 5;
                                }
                                catch (FormatException sd)
                                {
                                    Console.WriteLine("dato ncorrecto.");
                                    opc = 5;
                                }

                                break;
                            default:
                                Console.Write("Opcion incorrecta. \n ");
                                break;
                        }
                    }
                    catch (NegativeInputException ds)
                    {
                        Console.WriteLine("dato erroneo!");
                    }
                    catch (WrongInputException ad)
                    {
                        Console.WriteLine("dato erroneo, No digite numero!");
                    }
                    catch (FormatException sc)
                    {
                        Console.WriteLine("dato erroneo !");
                    }
                    catch (MoreThanTenException sda)
                    {
                        Console.WriteLine("no se puede agregar mas.");
                    }
                    catch (WrongTimeExcepcion dde)
                    {
                        Console.WriteLine("Fecha Erronea.");

                    }

                } while (opc != 4);
        }

        static String Menu()
        {
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

        static bool ItsNumber(String num)
        {
            char[] chars = num.ToCharArray();

            foreach (var num1 in chars)
            {
                if (Char.IsDigit(num1))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
