using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Digite um numero para descobir se é par ou impar");
             int num1= int.Parse(Console.ReadLine());

             if (num1 %2 == 0)
             {
                 Console.WriteLine("par");
             }
             else
             {
                 Console.WriteLine("impar");
             }
            */
            Console.WriteLine("Digite o horario:");
             int horario= int.Parse(Console.ReadLine());

             if (horario >= 0 && horario <= 5)
             {
                 Console.WriteLine("Boa madrugada");

             }
             else if (horario <=12)
             {
                 Console.WriteLine("Bom dia");

             }else if(horario <=18){
                 Console.WriteLine("Boa tarde");
             }
             else if(horario<=24){
                 Console.WriteLine("Boa noite");
             }
            else
            {
                Console.WriteLine("Erro de Horario");
            }
        }
    }
}
