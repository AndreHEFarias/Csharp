using System;

namespace ISO_DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58Z");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            /*Console.WriteLine(d1);
            Console.WriteLine(d1.Kind);
            Console.WriteLine(d1.ToLocalTime());
            Console.WriteLine(d1.ToUniversalTime());
            */
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));//Cuidado
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));


        }
    }
}
