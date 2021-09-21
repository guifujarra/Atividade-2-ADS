using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;

namespace Negocio
{
    public class ValidarLogin : IOperacaoBD
    {

        public bool ExecutarOperacao(Usuario usuario)
        {
            if (usuario.Login.Equals("") || usuario.Senha.Equals(""))
            {
                return false;
            }
            string senhaReal = new UsuarioBanco().GetSenhaUsuario(usuario.Login);

            return usuario.Senha.Equals(senhaReal);
        }
    }
}
