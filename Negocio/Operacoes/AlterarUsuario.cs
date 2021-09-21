using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;

namespace Negocio.Operacoes
{
    public class AlterarUsuario : IOperacaoBD
    {
        public bool ExecutarOperacao(Usuario usuario)
        {
            if (!usuario.Status.Equals('A') && !usuario.Status.Equals('I'))
            {
                return false;
            }
            if (usuario.Nome.Equals(string.Empty))
            {
                return false;
            }

            return new UsuarioBanco().AtualizarFuncionario(usuario.Login, usuario.Nome, usuario.Status);
        }
    }
}
