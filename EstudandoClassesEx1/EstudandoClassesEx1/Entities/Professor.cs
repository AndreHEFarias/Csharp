using System;
using System.Collections.Generic;
using System.Text;

namespace EstudandoClassesEx1.Entities
{
    class Professor
    {
        public int Cpf { get;  set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Professor(int cpf, string nome, string email)
        {
            Cpf = cpf;
            Nome = nome;
            Email = email;
        }
        
    }
}
