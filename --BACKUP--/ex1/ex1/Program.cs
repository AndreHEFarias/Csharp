using System;
using System.Globalization;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos anos você tem?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o seu saldo");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine("Entre com seu ultimo nome, idade e altura(mesma linha)");
             string[] info = Console.ReadLine().Split(' ');

             string ar1 = info[0];
             string ar2 = info[1];
             string ar3 = info[2];
             Console.WriteLine(nome);
             Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(ar1+"\n"+ar2 + "\n" +ar3);
        }
    }
}

