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

namespace Atividade_2_POO_II___UNIP
{
    public partial class FormTelaCriar : Form
    {
        public FormTelaCriar()
        {
            InitializeComponent();
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(textoLogin.Text, textoSenha.Text, textoNome.Text);
            limparComponentes();
            if(new CadastrarUsuario().ExecutarOperacao(usuario))
            {
                MessageBox.Show("Sucesso! usuário adicionado");
                return;
            }
            MessageBox.Show("Houve um erro ao adicionar o usuário");
        }

        private void limparComponentes()
        {
            textoLogin.Text = string.Empty;
            textoNome.Text = string.Empty;
            textoSenha.Text = string.Empty;
        }
    }
}
