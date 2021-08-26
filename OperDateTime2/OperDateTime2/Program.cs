using System;

namespace OperDateTime2
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Total Days: " + t.TotalDays);
            Console.WriteLine("Total hours: " + t.TotalHours);

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 30, 10);
            TimeSpan sum = t1.Add(t2);
            Console.WriteLine(sum);
            TimeSpan dif = t1.Subtract(t2);
            Console.WriteLine(dif);
            TimeSpan multi = t1.Multiply(2.0);
            Console.WriteLine(multi);
            TimeSpan div = t2.Divide(2);
            Console.WriteLine(div);

        }
        
    }
    
}
