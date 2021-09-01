using System;
using Heranca.Entities;

namespace EnumAndCompo
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, 500.0, "Alex");
            Account acc2 = new SavingsAccount(2002, 500.0, "Erica", 0.01);

            acc1.Withdrawn(10.0);
            acc2.Withdrawn(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            /* Account acc = new Account(1002, 0.0, "Alex");
             BusinessAccount bacc = new BusinessAccount(1003, 0.0, "Maria", 500.0);

             Account acc1 = bacc;
             Account acc2 = new BusinessAccount(1005, 0.0, "Alexa", 200.0);
             Account acc3 = new BusinessAccount(1006, 0.0, "Bruna", 600.0);

             BusinessAccount acc4 = (BusinessAccount)acc2;
             acc4.Loan(100.0);
             //BusinessAccount acc5 = (BusinessAccount)acc3;->da erro de casting;

             if (acc3 is BusinessAccount)
             {
                 //BusinessAccount acc5 = (BusinessAccount)acc3;
                 BusinessAccount acc5 = acc3 as BusinessAccount;
                 acc5.Loan(200.0);
                 Console.WriteLine("Loan!");
             }
             if(acc3 is SavingsAccount)
             {
                 SavingsAccount acc5 = (SavingsAccount)acc3;
                 acc5.UpdateBalance();
                 Console.WriteLine("Update");
             }
            */


        }
    }
}
