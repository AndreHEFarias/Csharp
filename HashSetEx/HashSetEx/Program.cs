using System;
using System.Collections.Generic;
namespace HashSetEx
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Noteebook"));
            foreach (String p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
