using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;

namespace Negocio
{
    public class Usuario : Funcionario
    {

        public Usuario(string login, string senha, string nome)
            : base(nome)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
        }

        public Usuario(string login, string nome, char status) :
            base(nome, status)
        {
            Status = status;
            Nome = nome;
            Login = login;
        }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public Usuario(string login)
        {
            Login = login;
        }


        public string Login { get; set; }
        public string Senha { get; set; }

    }
}
