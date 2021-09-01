using System;
using System.Collections.Generic;
using Ex2Funcio.Entities;
using System.Globalization;

namespace Virt_Overr_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list1 = new List<Employee>();
            Console.Write("Numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Funcionario #"+i+": ");
                Console.Write("É tercerizado?(y/n)");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Horas:");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double Vph = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(ch == 'y')
                {
                    Console.Write("Valor extra: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list1.Add(new OutSourcedEmployee(name, hours, Vph, addCharge));

                }
                else
                {
                    list1.Add(new Employee(name, hours, Vph));
                }

                

            }
            Console.Write("\nPagamentos: ");
            foreach (Employee emp in list1)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
