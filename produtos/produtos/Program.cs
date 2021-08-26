using System;
using System.Globalization;

namespace produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            produto p= new produto();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no Estoque:");
            p.Quantidade = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Dados do produto:"+p );

            Console.Write("Quantidade a ser adicionada ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionaProduto(qte);
            Console.WriteLine(p.Quantidade);

            Console.Write("Quantidade a ser Removida do estoque: ");
            int qte2 = int.Parse(Console.ReadLine());
            p.RemoveProdutos(qte2);
            Console.WriteLine(p.Quantidade);
        }
    }
}
