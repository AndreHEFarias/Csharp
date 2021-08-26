using System;

namespace ex1_obj
{
    class Program
    {
        static void Main(string[] args)
        {     
            pessoas p1, p2;
            p1 = new pessoas();
            p2 = new pessoas();

            Console.WriteLine("Digite um nome:");
            p1.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade:");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um outro nome:");
            p2.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade:");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine(p1.nome+" é mais velho(a)");
            }
            else
            {
                Console.WriteLine(p2.nome + " é mais velho(a)");
            }
        }
    }
}
