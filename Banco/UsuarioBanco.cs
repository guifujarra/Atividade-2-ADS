using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banco
{
    public class UsuarioBanco
    {

        public string GetSenhaUsuario(string login)
        {
            MySqlConnection conexao = Conexao.GetConexao();
            MySqlDataReader reader = null;

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT senha FROM tbusuario WHERE login = @a";
                comando.Parameters.AddWithValue("@a", login);
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetString("senha");
                }
            }catch(MySqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conexao.Close();
                reader.Close();
            }
            return null;
        }

        public bool AdicionarUsuario(string nome, string login, string senha)
        {

            MySqlConnection conexao = Conexao.GetConexao();

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO tbusuario values (@a, @b, @c, @d, @e)";
                comando.Parameters.AddWithValue("@a", login);
                comando.Parameters.AddWithValue("@b", nome);
                comando.Parameters.AddWithValue("@c", senha);
                comando.Parameters.AddWithValue("@d", 'A');
                comando.Parameters.AddWithValue("@e", DateTime.Now);
                comando.ExecuteNonQuery();
                return true;

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conexao.Close();
            }
            return false;

        }

        public Funcionario GetFuncionario(string login)
        {

            MySqlConnection conexao = Conexao.GetConexao();
            MySqlDataReader reader = null;

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT nomeUsuario, status FROM tbusuario WHERE login = @a";
                comando.Parameters.AddWithValue("@a", login);
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.Nome = reader.GetString("nomeUsuario");
                    funcionario.Status = reader.GetChar("status");
                    return funcionario;
                }
                
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                reader.Close();
                conexao.Close();
            }
            return null;
        }

        public bool DeletarUsuario(string login)
        {

            MySqlConnection conexao = Conexao.GetConexao();

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "DELETE FROM tbUsuario WHERE login = @a";
                comando.Parameters.AddWithValue("@a", login);
                if (comando.ExecuteNonQuery() >= 1)
                {
                    return true;
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conexao.Close();
            }
            return false;
        }

        public bool AtualizarFuncionario(string login, string nome, char status)
        {

            MySqlConnection conexao = Conexao.GetConexao();

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "UPDATE tbusuario SET nomeUsuario = @a, status = @b, dataUltimaAtualizacao = @c WHERE login = @d";
                comando.Parameters.AddWithValue("@a", nome);
                comando.Parameters.AddWithValue("@b", status);
                comando.Parameters.AddWithValue("@c", DateTime.Now);
                comando.Parameters.AddWithValue("@d", login);
                if (comando.ExecuteNonQuery() >= 1)
                {
                    return true;
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conexao.Close();
            }
            return false;
        }


    }

    
}

