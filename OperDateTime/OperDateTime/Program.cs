using System;

namespace OperDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2001, 5, 3, 13, 22, 15, 354);
            Console.WriteLine(d1);
            Console.WriteLine("Date: "+d1.Date);
            Console.WriteLine("Day: "+d1.Day);
            Console.WriteLine("Hour: "+d1.Hour);
            Console.WriteLine("Minute: "+d1.Minute);
            Console.WriteLine("Kind: " + d1.Kind);
            Console.WriteLine("Day of the Year :" + d1.DayOfYear);
            
            Console.WriteLine("Day of the Week: " + d1.DayOfWeek);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortTimeString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToString("yyyy-MM-dd H:mm.ss.fff"));
            
            DateTime d2 = d1.AddHours(2);
            DateTime d3 = d1.AddMinutes(2);
            DateTime d4 = d1.AddDays(2);

            Console.WriteLine(d2+"\n"+d3+"\n"+d4);

            DateTime df = new DateTime(2001, 5, 18);

            TimeSpan t = df.Subtract(d1);
            Console.WriteLine(t);

        }
    }
}
