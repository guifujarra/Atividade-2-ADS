namespace Atividade_2_POO_II___UNIP
{
    partial class FormTelaListar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoDeletar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoStatusResultado = new System.Windows.Forms.TextBox();
            this.textoNomeResultado = new System.Windows.Forms.TextBox();
            this.textoLoginResultado = new System.Windows.Forms.TextBox();
            this.textoLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoDeletar);
            this.groupBox1.Controls.Add(this.botaoSalvar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoStatusResultado);
            this.groupBox1.Controls.Add(this.textoNomeResultado);
            this.groupBox1.Controls.Add(this.textoLoginResultado);
            this.groupBox1.Controls.Add(this.textoLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(67, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // botaoDeletar
            // 
            this.botaoDeletar.Enabled = false;
            this.botaoDeletar.Location = new System.Drawing.Point(358, 252);
            this.botaoDeletar.Name = "botaoDeletar";
            this.botaoDeletar.Size = new System.Drawing.Size(75, 23);
            this.botaoDeletar.TabIndex = 10;
            this.botaoDeletar.Text = "Deletar";
            this.botaoDeletar.UseVisualStyleBackColor = true;
            this.botaoDeletar.Click += new System.EventHandler(this.botaoDeletar_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Enabled = false;
            this.botaoSalvar.Location = new System.Drawing.Point(205, 252);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(75, 23);
            this.botaoSalvar.TabIndex = 9;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // textoStatusResultado
            // 
            this.textoStatusResultado.Enabled = false;
            this.textoStatusResultado.Location = new System.Drawing.Point(418, 206);
            this.textoStatusResultado.MaxLength = 1;
            this.textoStatusResultado.Name = "textoStatusResultado";
            this.textoStatusResultado.Size = new System.Drawing.Size(100, 20);
            this.textoStatusResultado.TabIndex = 5;
            // 
            // textoNomeResultado
            // 
            this.textoNomeResultado.Enabled = false;
            this.textoNomeResultado.Location = new System.Drawing.Point(269, 206);
            this.textoNomeResultado.Name = "textoNomeResultado";
            this.textoNomeResultado.Size = new System.Drawing.Size(100, 20);
            this.textoNomeResultado.TabIndex = 4;
            // 
            // textoLoginResultado
            // 
            this.textoLoginResultado.Enabled = false;
            this.textoLoginResultado.Location = new System.Drawing.Point(113, 206);
            this.textoLoginResultado.Name = "textoLoginResultado";
            this.textoLoginResultado.Size = new System.Drawing.Size(100, 20);
            this.textoLoginResultado.TabIndex = 3;
            // 
            // textoLogin
            // 
            this.textoLogin.Location = new System.Drawing.Point(255, 61);
            this.textoLogin.Name = "textoLogin";
            this.textoLogin.Size = new System.Drawing.Size(152, 20);
            this.textoLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login para busca";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTelaListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormTelaListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de gerenciamento de usuário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textoLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textoStatusResultado;
        private System.Windows.Forms.TextBox textoNomeResultado;
        private System.Windows.Forms.TextBox textoLoginResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoDeletar;
        private System.Windows.Forms.Button botaoSalvar;
    }
}