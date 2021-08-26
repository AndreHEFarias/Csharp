using System;
using System.Globalization;

namespace valorRaio
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o seu raio");
            double raio= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calculadora.Cincurf(raio);
            double vol = calculadora.Volume(raio);
            Console.WriteLine("A cincurferencia é:"+circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O volume é: "+vol.ToString("F2", CultureInfo.InvariantCulture)+"\n Valor é Pi="+calculadora.Pi.ToString("F2",CultureInfo.InvariantCulture));
        }
       
    }
}
