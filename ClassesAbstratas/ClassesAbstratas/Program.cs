using System;
using System.Collections.Generic;
using System.Globalization;
using ClassesAbstratas.Entities;
namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);*/

            List<Account> list1 = new List<Account>();

             list1.Add(new SavingsAccount(1001, "Alex",500.0,0.01));
             list1.Add(new BusinessAccount(1002, "Bob", 500.0, 300.0));
             list1.Add(new SavingsAccount(1003, "Maria", 500.0, 0.01));
             list1.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

             double sum = 0.0;
             foreach(Account acc in list1)
             {
                 sum += acc.Balance;
             }
             Console.WriteLine("Total Balance: "+sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list1)
            {
                acc.Withdraw(10.0);
            }
            foreach(Account acc in list1)
            {
                Console.WriteLine("Update balance account"
                    +acc.Number
                    +": "
                    +acc.Balance.ToString("F2",CultureInfo.InvariantCulture));

            }
        }
    }
}
