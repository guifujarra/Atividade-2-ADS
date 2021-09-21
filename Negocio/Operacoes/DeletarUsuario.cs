using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;

namespace Negocio.Operacoes
{
    public class DeletarUsuario : IOperacaoBD
    {
        public bool ExecutarOperacao(Usuario usuario)
        {
            if (usuario.Login.Equals("admin"))
            {
                return false;
            }

            return new UsuarioBanco().DeletarUsuario(usuario.Login);
        }
    }
}
