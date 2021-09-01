using System;
using System.IO;

namespace ManipuArqui
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\andre.farias\Documents\file1.txt";
            string targetPath = @"C:\Users\andre.farias\Documents\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                Console.WriteLine("Sucess");
            }
            catch(IOException e)
            {
                Console.WriteLine( "An error ocurred:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
