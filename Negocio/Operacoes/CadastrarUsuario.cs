using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;

namespace Negocio
{
    public class CadastrarUsuario : IOperacaoBD
    {

        public bool ExecutarOperacao(Usuario usuario)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            if(AllNull(usuario.Login, usuario.Senha, usuario.Nome))
            {
                return false;
            }

            return usuarioBanco.AdicionarUsuario(usuario.Nome, usuario.Login, usuario.Senha);
        }


        private bool AllNull(params string[] strings)
        {
            return strings.All(s => s == null);
        }
    }
}
