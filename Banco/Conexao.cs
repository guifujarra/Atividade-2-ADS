using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banco
{
    public class Conexao
    {

        private static MySqlConnection conexao = new MySqlConnection(
            "server=localhost;port=3306;database=curso;uid=root;pwd=123456a;SslMode=none");


        public static MySqlConnection GetConexao()
        {
            return conexao;
        }
    }
}
