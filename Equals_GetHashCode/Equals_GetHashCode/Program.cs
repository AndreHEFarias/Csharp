using Equals_GetHashCode.Entities;
using System;

namespace Equals_GetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Jonas", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Maria", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a==b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());



        }
    }
}
