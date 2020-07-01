using System;
using System.Collections.Generic;

namespace Labo_10
{
    internal class Program
    {
        private delegate void Mydelegate(List<CuentaBancaria> ds);

        private static Mydelegate Accountmanagment;
        
        public static void Main(string[] args)
        {
            var users = new List<CuentaBancaria>();
            int opc1 = 0;
            string numTitular = "";
            double BalanceCuenta = 0;
            do
            {
                Console.WriteLine(menu1());
                Console.WriteLine("Digite la opcion deseada: ");
                opc1 = Int32.Parse(Console.ReadLine());
                switch (opc1)
                {
                    case 1:
                        Console.WriteLine("Ingrese una nueva cuenta bancaria.....");
                        Console.WriteLine("ingrese nombre del titular de la cuenta:  ");
                        numTitular = Console.ReadLine();
                        Console.WriteLine("Digite el saldo a ingresar en la cuenta: ");
                        BalanceCuenta = Int32.Parse(Console.ReadLine());
                        
                        users.Add(new CuentaBancaria(numTitular, BalanceCuenta));
                      
                      
                        break;
                    case 2:
                        Accountmanagment = showAccounts;
                        Accountmanagment.Invoke(users);
                        
                        break;
                    case 3:
                        //Delegate Explicito
                        Accountmanagment = showAccounts;
                        Accountmanagment += showSalary;
                        
                        Accountmanagment.Invoke(users);
                        break;
                    case 4:
                        //Action

                        Console.WriteLine("---------");
                        
                        Action<List<CuentaBancaria>> MyAccountAction = (maa) =>
                        {
                            maa.ForEach(account =>
                            {
                                    Console.WriteLine($"Nombre: {account._name}, Saldo: ${account._ActualBalance}");
                            });
                        };

                        MyAccountAction += maas =>
                        {
                            double salary = 0;

                            maas.ForEach(account =>
                            {
                                salary += account._ActualBalance;
                            });
                            
                            Console.WriteLine($"Suma de salarios: ${salary}");
                        };
                        MyAccountAction.Invoke(users);

                        MyAccountAction = voc =>
                        {
                            voc.ForEach(titular =>
                            {
                                if (titular._name[0].Equals('a')  || titular._name[0].Equals('e')
                                    || titular._name[0].Equals('i') || titular._name[0].Equals('o')
                                    || titular._name[0].Equals('u'))
                                {
                                    Console.WriteLine("\n inicia con vocal..");
                                    Console.WriteLine($"Nombre: {titular._name}, Saldo: ${titular._ActualBalance}");
                                }
                                else
                                {
                                    Console.WriteLine(" ");
                                }
                            });
                        };
                        MyAccountAction.Invoke(users);
                        
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del menu.....");
                        break;
                }
                
            } while (opc1 != 5);
        }
        
        //case 2 function
        public static void showAccounts(List<CuentaBancaria> sa)
        {
            sa.ForEach(accounts =>
            {
                Console.WriteLine($"Name: {accounts._name}, ${accounts._ActualBalance}");
            });
        }
        
        public static void showSalary(List<CuentaBancaria> salary)
        {
            double salarios = 0;

            salary.ForEach(userSalary =>
            {
                salarios += userSalary._ActualBalance;
            });

            Console.WriteLine($"Suma de salarios: ${salarios}");
        }
        
        public static string menu1()
        {
            return "----Iniciando menu---- \n 1. Agregar cuenta. \n 2. Ver cuentas almacenadas. \n 3. Ver cuentas " +
                   "almacenadas y el total de las cuentas. \n 4. Ver cuentas almacenadas, el total de las cuentas, y " +
                   "las cuentas de las personas que su nombre inicie con una vocal \n 5. salir";
        }
    }
}