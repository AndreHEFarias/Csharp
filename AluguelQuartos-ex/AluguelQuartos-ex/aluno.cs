using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelQuartos_ex
{
    class aluno
    {
        public string Name{ get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
