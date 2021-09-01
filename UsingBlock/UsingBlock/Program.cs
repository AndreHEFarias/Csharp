using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\andre.farias\Documents\file1.txt";
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                
            }catch(Exception e)
            {
                Console.WriteLine("Erro: "+e.Message);
            }
        }
    }
}
