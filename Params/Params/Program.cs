using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int s1 = Soma.Sum(new int[] { 2, 2, 80 });//dessa forma
            int s2 = Soma.Sum(3, 3, 3, 7);//e dessa utilizando o prams na classe soma
            


            Console.WriteLine(s1);
            Console.WriteLine(s2);*/

            Console.WriteLine("Digite um numero");
            int a=int.Parse(Console.ReadLine());
            int b = a;
            int trip;
            Calculator.Triple(ref a);
            Calculator.TripleOut(b,out trip);

            Console.WriteLine("O triplo é(ref) "+a);
            Console.WriteLine("O triplo é(out)"+trip);

        }
    }
}
