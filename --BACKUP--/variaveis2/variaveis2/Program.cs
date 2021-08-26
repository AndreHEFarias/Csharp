using System;

namespace variaveis2
{
    class Program
    {

        static void Main(string[] args)
        {
             int n1 = 10;
             int n2 = 3;
            double soma = (double) n1 / n2;

            double n3 = 6.7;
            float n4 = 7.9F;

            double a= 1, b= -3, c=-4;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta+"\n"+x1+"\n"+x2);

           // n2 += (float)n1;
            //Console.WriteLine(soma.ToString("F2"));
           // Console.WriteLine(n2);
            // n1 *=2;
            //Console.WriteLine(n1);
           //  n2 +=2;
           // Console.WriteLine(n2);
        }
    }
}
