using System;
using System.IO;

namespace StreamWriter2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\andre.farias\Documents\file1.txt";
            string targetPath = @"C:\Users\andre.farias\Documents\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw= File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
