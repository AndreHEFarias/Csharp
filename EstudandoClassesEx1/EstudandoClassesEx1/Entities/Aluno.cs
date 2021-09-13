using System;
using System.Collections.Generic;
using System.Text;

namespace EstudandoClassesEx1.Entities
{
    class Aluno
    {
        public int Cpf { private get;  set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Email { get; set; }

        public Aluno(int cpf, string nome, int matricula, string email)
        {
            Cpf = cpf;
            Nome = nome;
            Matricula = matricula;
            Email = email;
        }

       
    }
}
