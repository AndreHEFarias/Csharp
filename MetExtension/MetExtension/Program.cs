using System;
using MetExtension.Extension;
namespace MetExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 16, 7, 55, 22);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
