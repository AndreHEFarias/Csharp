using System;
using EstudandoClassesEx1.Entities;

namespace EstudandoClassesEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(033, "Andre", 058, "a@gmail.com");
            Professor p1 = new Professor(045, "José", "jose@Gmail.com");

            Console.WriteLine(a1.Nome+", "+a1.Email + ", " );
            Console.WriteLine(p1.Nome+","+p1.Email + ", " +p1.Cpf);
            
            p1.Cpf = 3;
            Console.WriteLine(p1.Nome + "," + p1.Email + ", " + p1.Cpf);



        }
    }
}
