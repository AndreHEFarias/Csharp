using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double saldo = 32.8761 ;
        string nome = "André";
        int idade = 20;
        string cidade = "Fortaleza";

        Console.WriteLine("{0} tem {1} anos e mora em {2}",nome, idade, cidade);
        Console.WriteLine($"{nome} tem {idade} anos, mora em {cidade} e tem {saldo:F2} reais de saldo");
        Console.WriteLine(nome + " tem " + idade + " anos, mora em " + cidade + " e tem " + saldo.ToString("F2",CultureInfo.InvariantCulture) + " reais de saldo");
       // Console.WriteLine(saldo.ToString("F1"));
       // Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


    }
}

