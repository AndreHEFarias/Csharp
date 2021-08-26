using System;
using System.Globalization;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for(int i = 0; i < n; i++)
            {
                int numb = i + 1;
                Console.Write("Nome #"+numb+": ");
                string name = Console.ReadLine();
                Console.Write("Preço #" + numb + ": ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double media = sum / n;
            Console.WriteLine("Preço medio="+media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
