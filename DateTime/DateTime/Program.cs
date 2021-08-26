using System;
using System.Globalization;

namespace DateTime2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018, 11, 23);
            DateTime d2 = new DateTime(2018, 11, 23, 20, 45, 12);
            
            DateTime d3 = DateTime.Now;
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;

            Console.WriteLine(d2+"\n"+d3 + "\n" +d4 + "\n" +d5);
            DateTime d6 = DateTime.Parse("2001-05-03");
            DateTime d7 = DateTime.Parse("2001-05-03 14:08:55");

            Console.WriteLine(d6 + "\n" +d7);

            DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d8);
            DateTime d9 = DateTime.ParseExact("2000-08-15 13:08:55", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d9);
        }
    }
}
