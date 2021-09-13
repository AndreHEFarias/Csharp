using System;
using System.Globalization;


namespace Estudando_08_09_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            try
            {

                int length= 15;
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("---------------");
                for (int i = 254; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception m)
            {

                Console.WriteLine("Error"+m.Message);
            }

       
        }

    }
}
    

