namespace InterfaceONGs
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblBemvindo = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSAC = new System.Windows.Forms.Button();
            this.btnLoja = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBemvindo
            // 
            this.lblBemvindo.AutoSize = true;
            this.lblBemvindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBemvindo.Location = new System.Drawing.Point(175, 136);
            this.lblBemvindo.Name = "lblBemvindo";
            this.lblBemvindo.Size = new System.Drawing.Size(204, 31);
            this.lblBemvindo.TabIndex = 1;
            this.lblBemvindo.Text = "Seja Bem-vindo";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.Location = new System.Drawing.Point(74, 222);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(122, 86);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSAC
            // 
            this.btnSAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSAC.Image = ((System.Drawing.Image)(resources.GetObject("btnSAC.Image")));
            this.btnSAC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSAC.Location = new System.Drawing.Point(219, 222);
            this.btnSAC.Name = "btnSAC";
            this.btnSAC.Size = new System.Drawing.Size(120, 86);
            this.btnSAC.TabIndex = 1;
            this.btnSAC.Text = "SAC";
            this.btnSAC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSAC.UseVisualStyleBackColor = true;
            this.btnSAC.Click += new System.EventHandler(this.btnSAC_Click);
            // 
            // btnLoja
            // 
            this.btnLoja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLoja.Image = ((System.Drawing.Image)(resources.GetObject("btnLoja.Image")));
            this.btnLoja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoja.Location = new System.Drawing.Point(359, 222);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(116, 86);
            this.btnLoja.TabIndex = 2;
            this.btnLoja.Text = "Loja";
            this.btnLoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoja.UseVisualStyleBackColor = true;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Location = new System.Drawing.Point(220, 363);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(74, 1);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(395, 132);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 8;
            this.pctLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(227, 187);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 25);
            this.lblWelcome.TabIndex = 9;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 413);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLoja);
            this.Controls.Add(this.btnSAC);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblBemvindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBemvindo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSAC;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblWelcome;
    }
}