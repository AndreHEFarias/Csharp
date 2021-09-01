using System;
using System.IO;

namespace EstudosArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o Diretorio: ");
                string sourcePath = Console.ReadLine();

                Console.WriteLine("Digite a pasta a ser criada:");
                string pasta = Console.ReadLine();

                string targetPath = sourcePath + @"\" + pasta;

                Directory.CreateDirectory(targetPath);
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: "+e.Message);
            }

        }
    }
}
