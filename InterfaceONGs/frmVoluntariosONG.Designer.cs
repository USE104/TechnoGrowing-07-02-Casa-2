namespace InterfaceONGs
{
    partial class frmVoluntariosONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoluntariosONG));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEXP = new System.Windows.Forms.Label();
            this.cboEXP = new System.Windows.Forms.ComboBox();
            this.lblRedesocial = new System.Windows.Forms.Label();
            this.cboSocias = new System.Windows.Forms.ComboBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.mkdCPF = new System.Windows.Forms.MaskedTextBox();
            this.mkdCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.cbbCodigoFunc = new System.Windows.Forms.ComboBox();
            this.txtnomeFunc = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cboVoluntarios = new System.Windows.Forms.ComboBox();
            this.lblcodVolutario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(93, 112);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(432, 34);
            this.lblInfo.TabIndex = 28;
            this.lblInfo.Text = "Cadastro de Voluntários ONG";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFuncionario.Location = new System.Drawing.Point(108, 148);
            this.lblFuncionario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(209, 25);
            this.lblFuncionario.TabIndex = 25;
            this.lblFuncionario.Text = "Código do Funcionário";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(59, -6);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(483, 135);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 24;
            this.pctLogo.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(183, 220);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(254, 19);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNome.Location = new System.Drawing.Point(109, 216);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 25);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(186, 292);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 19);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEmail.Location = new System.Drawing.Point(109, 286);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 25);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "E-mail";
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSenha.Location = new System.Drawing.Point(186, 326);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(177, 19);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSenha.Location = new System.Drawing.Point(109, 322);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 25);
            this.lblSenha.TabIndex = 33;
            this.lblSenha.Text = "Senha";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCPF.Location = new System.Drawing.Point(109, 359);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(52, 25);
            this.lblCPF.TabIndex = 35;
            this.lblCPF.Text = "CPF";
            // 
            // lblEXP
            // 
            this.lblEXP.AutoSize = true;
            this.lblEXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEXP.Location = new System.Drawing.Point(109, 433);
            this.lblEXP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEXP.Name = "lblEXP";
            this.lblEXP.Size = new System.Drawing.Size(114, 25);
            this.lblEXP.TabIndex = 39;
            this.lblEXP.Text = "Experiência";
            // 
            // cboEXP
            // 
            this.cboEXP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEXP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEXP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboEXP.FormatString = "text";
            this.cboEXP.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Avançado",
            "Não Possuí"});
            this.cboEXP.Location = new System.Drawing.Point(245, 433);
            this.cboEXP.Name = "cboEXP";
            this.cboEXP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboEXP.Size = new System.Drawing.Size(118, 28);
            this.cboEXP.TabIndex = 7;
            this.cboEXP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboEXP_KeyDown);
            // 
            // lblRedesocial
            // 
            this.lblRedesocial.AutoSize = true;
            this.lblRedesocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRedesocial.Location = new System.Drawing.Point(109, 479);
            this.lblRedesocial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRedesocial.Name = "lblRedesocial";
            this.lblRedesocial.Size = new System.Drawing.Size(117, 25);
            this.lblRedesocial.TabIndex = 41;
            this.lblRedesocial.Text = "Rede Social";
            // 
            // cboSocias
            // 
            this.cboSocias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSocias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSocias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboSocias.FormattingEnabled = true;
            this.cboSocias.Items.AddRange(new object[] {
            "Facebook",
            "Instagram",
            "Linkdlin",
            "Twiter",
            "Github"});
            this.cboSocias.Location = new System.Drawing.Point(245, 479);
            this.cboSocias.Name = "cboSocias";
            this.cboSocias.Size = new System.Drawing.Size(100, 28);
            this.cboSocias.TabIndex = 8;
            this.cboSocias.SelectedIndexChanged += new System.EventHandler(this.cboSocias_SelectedIndexChanged);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeletar.Location = new System.Drawing.Point(441, 557);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(85, 35);
            this.btnDeletar.TabIndex = 14;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlterar.Location = new System.Drawing.Point(259, 557);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 35);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCriar.Location = new System.Drawing.Point(79, 557);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(85, 35);
            this.btnCriar.TabIndex = 10;
            this.btnCriar.Text = "Criar";
            this.btnCriar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // mkdCPF
            // 
            this.mkdCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkdCPF.Location = new System.Drawing.Point(186, 360);
            this.mkdCPF.Mask = "000,000,000-00";
            this.mkdCPF.Name = "mkdCPF";
            this.mkdCPF.Size = new System.Drawing.Size(134, 26);
            this.mkdCPF.TabIndex = 5;
            this.mkdCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkdCPF_KeyDown);
            // 
            // mkdCelular
            // 
            this.mkdCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkdCelular.Location = new System.Drawing.Point(186, 396);
            this.mkdCelular.Mask = "(000)00000-0000";
            this.mkdCelular.Name = "mkdCelular";
            this.mkdCelular.Size = new System.Drawing.Size(132, 26);
            this.mkdCelular.TabIndex = 6;
            this.mkdCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkdCelular_KeyDown);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCelular.Location = new System.Drawing.Point(109, 397);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(74, 25);
            this.lblCelular.TabIndex = 50;
            this.lblCelular.Text = "Celular";
            // 
            // Voltar
            // 
            this.Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Voltar.Location = new System.Drawing.Point(3, 598);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(85, 35);
            this.Voltar.TabIndex = 14;
            this.Voltar.Text = "Voltar";
            this.Voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtpNasc
            // 
            this.dtpNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNasc.Location = new System.Drawing.Point(299, 247);
            this.dtpNasc.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpNasc.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(125, 26);
            this.dtpNasc.TabIndex = 2;
            this.dtpNasc.Value = new System.DateTime(2023, 2, 7, 0, 0, 0, 0);
            this.dtpNasc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpNasc_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(109, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Data de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(109, 514);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Link";
            // 
            // txtURL
            // 
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtURL.Location = new System.Drawing.Point(167, 515);
            this.txtURL.Margin = new System.Windows.Forms.Padding(5);
            this.txtURL.MaxLength = 50;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(289, 19);
            this.txtURL.TabIndex = 9;
            // 
            // cbbCodigoFunc
            // 
            this.cbbCodigoFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbCodigoFunc.DropDownWidth = 57;
            this.cbbCodigoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCodigoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbCodigoFunc.FormattingEnabled = true;
            this.cbbCodigoFunc.ItemHeight = 20;
            this.cbbCodigoFunc.Location = new System.Drawing.Point(325, 149);
            this.cbbCodigoFunc.MaxLength = 2;
            this.cbbCodigoFunc.Name = "cbbCodigoFunc";
            this.cbbCodigoFunc.Size = new System.Drawing.Size(57, 28);
            this.cbbCodigoFunc.TabIndex = 0;
            this.cbbCodigoFunc.SelectedIndexChanged += new System.EventHandler(this.cbbCodigo_SelectedIndexChanged);
            // 
            // txtnomeFunc
            // 
            this.txtnomeFunc.Cursor = System.Windows.Forms.Cursors.No;
            this.txtnomeFunc.Enabled = false;
            this.txtnomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeFunc.Location = new System.Drawing.Point(397, 149);
            this.txtnomeFunc.MaxLength = 20;
            this.txtnomeFunc.Name = "txtnomeFunc";
            this.txtnomeFunc.Size = new System.Drawing.Size(156, 26);
            this.txtnomeFunc.TabIndex = 57;
            this.txtnomeFunc.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(168, 557);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 35);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(350, 557);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 35);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cboVoluntarios
            // 
            this.cboVoluntarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboVoluntarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVoluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboVoluntarios.FormattingEnabled = true;
            this.cboVoluntarios.ItemHeight = 20;
            this.cboVoluntarios.Location = new System.Drawing.Point(325, 186);
            this.cboVoluntarios.Name = "cboVoluntarios";
            this.cboVoluntarios.Size = new System.Drawing.Size(97, 28);
            this.cboVoluntarios.TabIndex = 58;
            this.cboVoluntarios.SelectedIndexChanged += new System.EventHandler(this.cboVoluntarios_SelectedIndexChanged);
            this.cboVoluntarios.TextChanged += new System.EventHandler(this.cboVoluntarios_TextChanged);
            // 
            // lblcodVolutario
            // 
            this.lblcodVolutario.AutoSize = true;
            this.lblcodVolutario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblcodVolutario.Location = new System.Drawing.Point(110, 185);
            this.lblcodVolutario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcodVolutario.Name = "lblcodVolutario";
            this.lblcodVolutario.Size = new System.Drawing.Size(190, 25);
            this.lblcodVolutario.TabIndex = 59;
            this.lblcodVolutario.Text = "Histórico Voluntários";
            // 
            // frmVoluntariosONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 635);
            this.Controls.Add(this.cboVoluntarios);
            this.Controls.Add(this.lblcodVolutario);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtnomeFunc);
            this.Controls.Add(this.cbbCodigoFunc);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.mkdCelular);
            this.Controls.Add(this.mkdCPF);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.cboSocias);
            this.Controls.Add(this.lblRedesocial);
            this.Controls.Add(this.cboEXP);
            this.Controls.Add(this.lblEXP);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.pctLogo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVoluntariosONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro - Usuarios para ONG";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEXP;
        private System.Windows.Forms.ComboBox cboEXP;
        private System.Windows.Forms.Label lblRedesocial;
        private System.Windows.Forms.ComboBox cboSocias;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.MaskedTextBox mkdCPF;
        private System.Windows.Forms.MaskedTextBox mkdCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ComboBox cbbCodigoFunc;
        private System.Windows.Forms.TextBox txtnomeFunc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cboVoluntarios;
        private System.Windows.Forms.Label lblcodVolutario;
    }
}