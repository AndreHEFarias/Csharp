using System;

namespace forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria","João","Pedro"};

            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("---------------------------");

            foreach(string nome in vect)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
