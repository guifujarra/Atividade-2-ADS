using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Negocio;

namespace Atividade_2_POO_II___UNIP
{
    public partial class FormTelaLogin : Form
    {
        Thread t1;
        public FormTelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(textoLogin.Text, textoSenha.Text);
            if (new ValidarLogin().ExecutarOperacao(usuario))
            {
                
                this.Close();
                t1 = new Thread(abrirTelaPrincipal);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
                return;
            }
            MessageBox.Show("Login ou senha inválido");
            textoLogin.Clear();
            textoSenha.Clear();
            textoLogin.Focus();

        }
        private void abrirTelaPrincipal()
        {
            Application.Run(new FormTelaInicial());
        }
    }
    
}
