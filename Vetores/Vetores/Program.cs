using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas alturas serão digitadas:");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                int number = i + 1;
                Console.Write("Altura #"+number+": ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for(int i = 0; i < n; i++)
            {
                soma += vect[i]; 
            }

            double media = soma / n;

            Console.WriteLine("Media de altura: "+media);

           /* int i = 1;

            while (i <= quanti)
            {
                Console.Write("Digite a altura #"+i+": ");
                Console.ReadLine();
                i++;
            }*/
        }
    }
}
