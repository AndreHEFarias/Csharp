using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divisão por 0 não é permitido("+e.Message+").");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Só são permitidos numeros("+e.Message+").");

            }
        }
    }
}
