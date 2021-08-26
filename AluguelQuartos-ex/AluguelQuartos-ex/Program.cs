using System;

namespace AluguelQuartos_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            aluno[] aluVect = new aluno[9];

            for(int i = 0; i < n; i++)
            {

                int numb = i + 1; 
                Console.Write("Nome do aluno #" + numb + ": ");
                string nome=Console.ReadLine();
                Console.Write("Email do aluno #" + numb + ": ");
                string email=Console.ReadLine();
                Console.Write("Quarto escolhido #"+numb+": ");
                int quarto=int.Parse(Console.ReadLine());

                if (aluVect[quarto] == null)
                {
                    aluVect[quarto] = new aluno { Name = nome, Email = email, Quarto = quarto };
                    Console.WriteLine("Sucesso: "+aluVect[quarto]+","+quarto);
                }
                else
                {
                    Console.WriteLine("Quarto ocupado");
                }

            }
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if (aluVect[i]!=null)
                {
                    Console.WriteLine(i+":"+aluVect[i]);
                }
            }
           
            
        }
    }
}
