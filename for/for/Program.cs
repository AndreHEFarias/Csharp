using System;

namespace for1
{
    class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos numeros serão digitados?");
        int n1 = int.Parse(Console.ReadLine());

            int soma = 0;
        for(int i=1; i<=n1; i++)
        {
                Console.WriteLine($"Digite o valor #{i}:");
                int valor= int.Parse(Console.ReadLine());

                soma += valor;
             
        }
            Console.WriteLine("Soma é igual a: "+soma);
    }
}
}
