using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String>list=new List<string>();
            //List<string> list2 = new List<string> { "Maria", "João" };
            list.Add("Maria");
            list.Add("João");
            list.Add("Jeymison Lucas");
            list.Add("Hagar");
            list.Insert(3, "Gabriel");
            list.Insert(1, "Jessica");

            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("Numero de itens na lista: "+list.Count);

            string find1 = list.Find(x=>x[0]=='J');
            Console.WriteLine("Primeira pessoa com J: "+find1);

            string find2 = list.FindLast(x => x[0] == 'J');
            Console.WriteLine("Ultima pessoa com J: "+find2);

            int pos1 = list.FindIndex(x => x[0] == 'J');
            Console.WriteLine("Primeira posição de quem comça com J:"+pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'J');
            Console.WriteLine("Ultima posição de quem começa com J: "+pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            list.Remove("Hagar");
            //list.RemoveAt(3);
            list.RemoveRange(0,2);//0- a partir de qual e 2- quantidade a ser removida;
            Console.WriteLine("---------------------------------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'J');
            Console.WriteLine("---------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
        
    }
}
