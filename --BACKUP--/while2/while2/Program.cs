using System;
using System.Globalization;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite um numero: ");
           double n1 =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            while (n1 >= 0.0) {
                double raiz1 = Math.Sqrt(n1);
                Console.WriteLine(raiz1.ToString("F3", CultureInfo.InvariantCulture));

                Console.WriteLine("Digite outro numero: ");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Numero negativo");
        }
    }
}
