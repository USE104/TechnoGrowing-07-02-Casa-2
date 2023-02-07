
namespace InterfaceONGs
{
    partial class frmGerenciarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarUsuarios));
            this.txtNomeUsu = new System.Windows.Forms.TextBox();
            this.lblUsuariol = new System.Windows.Forms.Label();
            this.gpbDadosUsuarios = new System.Windows.Forms.GroupBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtSenhaUsu = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlOperacoes = new System.Windows.Forms.Panel();
            this.gpbDadosFuncionarios = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRegisto = new System.Windows.Forms.Label();
            this.cbbCodigo = new System.Windows.Forms.ComboBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.gpbDadosUsuarios.SuspendLayout();
            this.pnlOperacoes.SuspendLayout();
            this.gpbDadosFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeUsu
            // 
            this.txtNomeUsu.Location = new System.Drawing.Point(142, 37);
            this.txtNomeUsu.MaxLength = 50;
            this.txtNomeUsu.Name = "txtNomeUsu";
            this.txtNomeUsu.Size = new System.Drawing.Size(248, 26);
            this.txtNomeUsu.TabIndex = 3;
            // 
            // lblUsuariol
            // 
            this.lblUsuariol.AutoSize = true;
            this.lblUsuariol.Location = new System.Drawing.Point(72, 43);
            this.lblUsuariol.Name = "lblUsuariol";
            this.lblUsuariol.Size = new System.Drawing.Size(64, 20);
            this.lblUsuariol.TabIndex = 2;
            this.lblUsuariol.Text = "Usuário";
            // 
            // gpbDadosUsuarios
            // 
            this.gpbDadosUsuarios.Controls.Add(this.txtConfirmaSenha);
            this.gpbDadosUsuarios.Controls.Add(this.lblConfirmaSenha);
            this.gpbDadosUsuarios.Controls.Add(this.txtSenhaUsu);
            this.gpbDadosUsuarios.Controls.Add(this.lblSenha);
            this.gpbDadosUsuarios.Controls.Add(this.txtNomeUsu);
            this.gpbDadosUsuarios.Controls.Add(this.lblUsuariol);
            this.gpbDadosUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosUsuarios.Location = new System.Drawing.Point(12, 197);
            this.gpbDadosUsuarios.Name = "gpbDadosUsuarios";
            this.gpbDadosUsuarios.Size = new System.Drawing.Size(543, 180);
            this.gpbDadosUsuarios.TabIndex = 0;
            this.gpbDadosUsuarios.TabStop = false;
            this.gpbDadosUsuarios.Text = "Dados do usuário";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtConfirmaSenha.Location = new System.Drawing.Point(142, 130);
            this.txtConfirmaSenha.MaxLength = 20;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = 'l';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(248, 25);
            this.txtConfirmaSenha.TabIndex = 5;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(10, 136);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(126, 20);
            this.lblConfirmaSenha.TabIndex = 6;
            this.lblConfirmaSenha.Text = "Confirmar senha";
            // 
            // txtSenhaUsu
            // 
            this.txtSenhaUsu.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenhaUsu.Location = new System.Drawing.Point(142, 83);
            this.txtSenhaUsu.MaxLength = 20;
            this.txtSenhaUsu.Name = "txtSenhaUsu";
            this.txtSenhaUsu.PasswordChar = 'l';
            this.txtSenhaUsu.Size = new System.Drawing.Size(248, 25);
            this.txtSenhaUsu.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(80, 89);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(380, 26);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 35);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVoltar.Location = new System.Drawing.Point(471, 26);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 35);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisar.Location = new System.Drawing.Point(289, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 35);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.Location = new System.Drawing.Point(198, 26);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 35);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Location = new System.Drawing.Point(107, 26);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 35);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadastrar.Location = new System.Drawing.Point(13, 26);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 35);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pnlOperacoes
            // 
            this.pnlOperacoes.BackColor = System.Drawing.Color.Silver;
            this.pnlOperacoes.Controls.Add(this.btnLimpar);
            this.pnlOperacoes.Controls.Add(this.btnVoltar);
            this.pnlOperacoes.Controls.Add(this.btnPesquisar);
            this.pnlOperacoes.Controls.Add(this.btnExcluir);
            this.pnlOperacoes.Controls.Add(this.btnAlterar);
            this.pnlOperacoes.Controls.Add(this.btnCadastrar);
            this.pnlOperacoes.Location = new System.Drawing.Point(-1, 383);
            this.pnlOperacoes.Name = "pnlOperacoes";
            this.pnlOperacoes.Size = new System.Drawing.Size(575, 74);
            this.pnlOperacoes.TabIndex = 7;
            // 
            // gpbDadosFuncionarios
            // 
            this.gpbDadosFuncionarios.Controls.Add(this.lblNome);
            this.gpbDadosFuncionarios.Controls.Add(this.txtNome);
            this.gpbDadosFuncionarios.Controls.Add(this.lblRegisto);
            this.gpbDadosFuncionarios.Controls.Add(this.cbbCodigo);
            this.gpbDadosFuncionarios.Controls.Add(this.txtRegistro);
            this.gpbDadosFuncionarios.Controls.Add(this.lblCodigo);
            this.gpbDadosFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosFuncionarios.Location = new System.Drawing.Point(12, 84);
            this.gpbDadosFuncionarios.Name = "gpbDadosFuncionarios";
            this.gpbDadosFuncionarios.Size = new System.Drawing.Size(543, 107);
            this.gpbDadosFuncionarios.TabIndex = 0;
            this.gpbDadosFuncionarios.TabStop = false;
            this.gpbDadosFuncionarios.Text = "Dados do funcionário";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(87, 70);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(303, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblRegisto
            // 
            this.lblRegisto.AutoSize = true;
            this.lblRegisto.Location = new System.Drawing.Point(183, 31);
            this.lblRegisto.Name = "lblRegisto";
            this.lblRegisto.Size = new System.Drawing.Size(69, 20);
            this.lblRegisto.TabIndex = 11;
            this.lblRegisto.Text = "Registro";
            // 
            // cbbCodigo
            // 
            this.cbbCodigo.FormattingEnabled = true;
            this.cbbCodigo.ItemHeight = 20;
            this.cbbCodigo.Location = new System.Drawing.Point(91, 23);
            this.cbbCodigo.Name = "cbbCodigo";
            this.cbbCodigo.Size = new System.Drawing.Size(82, 28);
            this.cbbCodigo.TabIndex = 0;
            this.cbbCodigo.SelectedIndexChanged += new System.EventHandler(this.cbbCodigo_SelectedIndexChanged_1);
            // 
            // txtRegistro
            // 
            this.txtRegistro.Enabled = false;
            this.txtRegistro.Location = new System.Drawing.Point(256, 25);
            this.txtRegistro.MaxLength = 50;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(116, 26);
            this.txtRegistro.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(26, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código";
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(117, -9);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(328, 97);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 23;
            this.pctLogo.TabStop = false;
            // 
            // frmGerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 457);
            this.ControlBox = false;
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.gpbDadosFuncionarios);
            this.Controls.Add(this.gpbDadosUsuarios);
            this.Controls.Add(this.pnlOperacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmGerenciarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de  Usuários de Acesso ao Sistema";
            this.Load += new System.EventHandler(this.frmGerenciarUsuarios_Load);
            this.gpbDadosUsuarios.ResumeLayout(false);
            this.gpbDadosUsuarios.PerformLayout();
            this.pnlOperacoes.ResumeLayout(false);
            this.gpbDadosFuncionarios.ResumeLayout(false);
            this.gpbDadosFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeUsu;
        private System.Windows.Forms.Label lblUsuariol;
        private System.Windows.Forms.GroupBox gpbDadosUsuarios;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlOperacoes;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.TextBox txtSenhaUsu;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.GroupBox gpbDadosFuncionarios;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRegisto;
        private System.Windows.Forms.ComboBox cbbCodigo;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}