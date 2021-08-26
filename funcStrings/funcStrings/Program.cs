using System;

namespace funcStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "a bc ABC dfg Hij abc";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: "+original);
            Console.WriteLine("------------------------------");

            Console.WriteLine("ToUpper: "+s1);
            Console.WriteLine("------------------------------");

            Console.WriteLine("ToLower: "+s2);
            Console.WriteLine("------------------------------");

            Console.WriteLine("Trim: " + s3);
            Console.WriteLine("------------------------------");

            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("------------------------------");

            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("------------------------------");

            Console.WriteLine("Substring: " + s4);
            Console.WriteLine("------------------------------");

            Console.WriteLine("Substring(5 caracteres): " + s5);
            Console.WriteLine("------------------------------");

            Console.WriteLine("Replace: " + s6);
            Console.WriteLine("------------------------------");

            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("------------------------------");
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
            Console.WriteLine("------------------------------");
        }
    }
}
