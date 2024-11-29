namespace DEMO.app.deriv
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.btnExibirOcultarToken = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFullNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.txtSaldoFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(124, 79);
            this.txtToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(231, 25);
            this.txtToken.TabIndex = 0;
            this.txtToken.Text = "meMSIVnpvvReid2";
            this.txtToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(16, 82);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(46, 17);
            this.lblToken.TabIndex = 1;
            this.lblToken.Text = "Token";
            // 
            // btnExibirOcultarToken
            // 
            this.btnExibirOcultarToken.Location = new System.Drawing.Point(361, 75);
            this.btnExibirOcultarToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExibirOcultarToken.Name = "btnExibirOcultarToken";
            this.btnExibirOcultarToken.Size = new System.Drawing.Size(163, 30);
            this.btnExibirOcultarToken.TabIndex = 2;
            this.btnExibirOcultarToken.Text = "exibir/ocultar";
            this.btnExibirOcultarToken.UseVisualStyleBackColor = true;
            this.btnExibirOcultarToken.Click += new System.EventHandler(this.btnExibirOcultarToken_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(124, 276);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(231, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saldo Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saldo Final :";
            // 
            // lblFullNome
            // 
            this.lblFullNome.AutoSize = true;
            this.lblFullNome.Location = new System.Drawing.Point(16, 111);
            this.lblFullNome.Name = "lblFullNome";
            this.lblFullNome.Size = new System.Drawing.Size(51, 17);
            this.lblFullNome.TabIndex = 7;
            this.lblFullNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(16, 177);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(51, 17);
            this.lblConta.TabIndex = 9;
            this.lblConta.Text = "Conta:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(124, 112);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(231, 25);
            this.txtFullName.TabIndex = 10;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(231, 25);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(124, 178);
            this.txtConta.Name = "txtConta";
            this.txtConta.ReadOnly = true;
            this.txtConta.Size = new System.Drawing.Size(231, 25);
            this.txtConta.TabIndex = 12;
            this.txtConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(124, 211);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.ReadOnly = true;
            this.txtSaldoInicial.Size = new System.Drawing.Size(231, 25);
            this.txtSaldoInicial.TabIndex = 13;
            this.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.Location = new System.Drawing.Point(124, 244);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.txtSaldoFinal.ReadOnly = true;
            this.txtSaldoFinal.Size = new System.Drawing.Size(231, 25);
            this.txtSaldoFinal.TabIndex = 14;
            this.txtSaldoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 323);
            this.Controls.Add(this.txtSaldoFinal);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExibirOcultarToken);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.txtToken);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Button btnExibirOcultarToken;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFullNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.TextBox txtSaldoFinal;
    }
}

