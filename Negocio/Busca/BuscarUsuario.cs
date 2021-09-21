using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;

namespace Negocio
{
    public class BuscarUsuario
    {
        public Usuario GetUsuario(string login)
        {
            if(login == null)
            {
                return null;
            }
            Funcionario funcionario = new UsuarioBanco().GetFuncionario(login);
            if(funcionario == null)
            {
                return null;
            }
            Usuario usuario = new Usuario(login, funcionario.Nome, funcionario.Status);
            return usuario;
        }
    }
}
