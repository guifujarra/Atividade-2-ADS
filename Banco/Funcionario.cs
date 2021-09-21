using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Funcionario
    {

        public Funcionario(string nome, char status)
        {
            Nome = nome;
            Status = status;
        }

        public Funcionario(string nome)
        {
            Nome = nome;
        }

        public Funcionario() { }

        public string Nome { get; set; }
        public char Status { get; set; }
    }
}
