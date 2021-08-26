using System;
using System.Globalization;

namespace PerguntarMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dolar?");
            double dolar= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar?");
            double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago:");

            double conv = ConversorMoeda.Moeda(real,dolar);
            Console.WriteLine("R$"+conv.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
