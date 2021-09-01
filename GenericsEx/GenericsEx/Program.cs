using System;

namespace GenericsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> ps = new PrintService<string>();
            Console.WriteLine("Quantos valores?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os valores:");

            for(int i= 0; i < n; i++)
            {
                string x = Console.ReadLine();
                ps.AddValue(x);
            }
            ps.Print();
            Console.WriteLine("\nPrimeiro: "+ps.First());
        }
    }
}
