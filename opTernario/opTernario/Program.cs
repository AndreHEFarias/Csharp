using System;
using System.Globalization;

namespace opTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor: ");
           double val= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double op = (val < 20) ? val * 0.05 : val * 0.10;
            Console.WriteLine(op);
        }
    }
}
