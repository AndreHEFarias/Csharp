using System;
using System.IO;

namespace ClassePath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\andre.farias\Documents\file1.txt";
            Console.WriteLine("DirectorySeparatorChar: "+Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryBame: "+Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName " + Path.GetFileName(path));
            Console.WriteLine("GetExtension " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath " + Path.GetTempPath());
            Console.WriteLine("GetFileNameWithoutExtension " + Path.GetFileNameWithoutExtension(path));
        
        
        
        }
    }
}
