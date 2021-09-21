using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Negocio.Operacoes;

namespace Atividade_2_POO_II___UNIP
{
    public partial class FormTelaListar : Form
    {
        public FormTelaListar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new BuscarUsuario().GetUsuario(textoLogin.Text);
            if(usuario == null)
            {
                MessageBox.Show("Usuário não encontrado.");
                return;
            }
            atualizarComponentes(true);
            preencherComponentes(usuario);
        }



        private void atualizarComponentes(bool status)
        {
            textoNomeResultado.Enabled = status;
            textoStatusResultado.Enabled = status;
            botaoSalvar.Enabled = status;
            botaoDeletar.Enabled = status;
        }

        private void limparComponentes()
        {
            textoNomeResultado.Text = string.Empty;
            textoLoginResultado.Text = string.Empty;
            textoStatusResultado.Text = string.Empty;
        }
        

        private void preencherComponentes(Usuario usuario)
        {
            textoLoginResultado.Text = usuario.Login;
            textoNomeResultado.Text = usuario.Nome;
            textoStatusResultado.Text = usuario.Status.ToString();

        }

        private void botaoDeletar_Click(object sender, EventArgs e)
        {
            DeletarUsuario deletarUsuario = new DeletarUsuario();
            Usuario usuario = new Usuario(textoLoginResultado.Text);
            if (!new DeletarUsuario().ExecutarOperacao(usuario))
            {
                MessageBox.Show("Não foi possível deletar o usuário informado.");
                return;
            }
            MessageBox.Show("Usuário deletado com sucesso!");
            limparComponentes();
            atualizarComponentes(false);
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(textoLoginResultado.Text, textoNomeResultado.Text, Char.Parse(textoStatusResultado.Text));
            if(!new AlterarUsuario().ExecutarOperacao(usuario))
            {
                MessageBox.Show("Não foi possível alterar os dados, verifique os dados informados e tente novamente.");
                return;
            }

            MessageBox.Show("Usuário editado com sucesso!");
        }
    }
}
