namespace MFTD
{
    partial class frmLogin
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
            this.lblControleAcesso = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtboxLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtboxSenha = new System.Windows.Forms.TextBox();
            this.pctboxLogo = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblControleAcesso
            // 
            this.lblControleAcesso.AutoSize = true;
            this.lblControleAcesso.BackColor = System.Drawing.Color.Transparent;
            this.lblControleAcesso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControleAcesso.ForeColor = System.Drawing.Color.Red;
            this.lblControleAcesso.Location = new System.Drawing.Point(348, 56);
            this.lblControleAcesso.Name = "lblControleAcesso";
            this.lblControleAcesso.Size = new System.Drawing.Size(176, 18);
            this.lblControleAcesso.TabIndex = 1;
            this.lblControleAcesso.Text = "Controle de Acesso";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Red;
            this.lblLogin.Location = new System.Drawing.Point(329, 101);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(52, 18);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.Location = new System.Drawing.Point(329, 122);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.Size = new System.Drawing.Size(233, 20);
            this.txtboxLogin.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Red;
            this.lblSenha.Location = new System.Drawing.Point(329, 160);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(58, 18);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txtboxSenha
            // 
            this.txtboxSenha.Location = new System.Drawing.Point(329, 181);
            this.txtboxSenha.Name = "txtboxSenha";
            this.txtboxSenha.Size = new System.Drawing.Size(233, 20);
            this.txtboxSenha.TabIndex = 5;
            this.txtboxSenha.TextChanged += new System.EventHandler(this.txtboxSenha_TextChanged);
            // 
            // pctboxLogo
            // 
            this.pctboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctboxLogo.Image = global::MFTD.Properties.Resources.logo_preto1;
            this.pctboxLogo.Location = new System.Drawing.Point(12, 56);
            this.pctboxLogo.Name = "pctboxLogo";
            this.pctboxLogo.Size = new System.Drawing.Size(297, 217);
            this.pctboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxLogo.TabIndex = 6;
            this.pctboxLogo.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Red;
            this.btnLogin.Location = new System.Drawing.Point(329, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 33);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(447, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 33);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(603, 341);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtboxSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtboxLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblControleAcesso);
            this.Controls.Add(this.pctboxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pctboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControleAcesso;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtboxLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtboxSenha;
        private System.Windows.Forms.PictureBox pctboxLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancelar;

    }
}