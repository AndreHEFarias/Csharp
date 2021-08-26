using System;
using System.Globalization;

namespace caixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Numero da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta:");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial?[s/n]");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Saldo da conta:");
                double depIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depIni);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine("\nDados da conta:"+conta);
            Console.Write("Entre um valor para deposito:");
            double depQuantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(depQuantia);
            Console.WriteLine("Dados atualizados:"+conta);

            Console.Write("Entre um valor para saque:");
            double saqQuantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saqQuantia);
            Console.WriteLine("Dados atualizados:" + conta);
        }
    }
}
