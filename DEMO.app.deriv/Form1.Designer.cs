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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPingMs = new System.Windows.Forms.TextBox();
            this.cmbxUnderlying_symbol = new System.Windows.Forms.ComboBox();
            this.btnFiltrarContratoIndiceVolatividade = new System.Windows.Forms.Button();
            this.grpVolatilities = new System.Windows.Forms.GroupBox();
            this.lblTickManual = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTickManual = new System.Windows.Forms.Button();
            this.lblTickValue = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.button1 = new System.Windows.Forms.Button();
            this.grpVolatilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(124, 41);
            this.txtToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(231, 25);
            this.txtToken.TabIndex = 0;
            this.txtToken.Text = "5a7J4zG40xIUAZe";
            this.txtToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(16, 44);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(46, 17);
            this.lblToken.TabIndex = 1;
            this.lblToken.Text = "Token";
            // 
            // btnExibirOcultarToken
            // 
            this.btnExibirOcultarToken.Location = new System.Drawing.Point(19, 238);
            this.btnExibirOcultarToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExibirOcultarToken.Name = "btnExibirOcultarToken";
            this.btnExibirOcultarToken.Size = new System.Drawing.Size(99, 30);
            this.btnExibirOcultarToken.TabIndex = 2;
            this.btnExibirOcultarToken.Text = "exibir/ocultar";
            this.btnExibirOcultarToken.UseVisualStyleBackColor = true;
            this.btnExibirOcultarToken.Click += new System.EventHandler(this.btnExibirOcultarToken_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(124, 238);
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
            this.label1.Location = new System.Drawing.Point(16, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saldo Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saldo Final :";
            // 
            // lblFullNome
            // 
            this.lblFullNome.AutoSize = true;
            this.lblFullNome.Location = new System.Drawing.Point(16, 73);
            this.lblFullNome.Name = "lblFullNome";
            this.lblFullNome.Size = new System.Drawing.Size(51, 17);
            this.lblFullNome.TabIndex = 7;
            this.lblFullNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(16, 139);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(51, 17);
            this.lblConta.TabIndex = 9;
            this.lblConta.Text = "Conta:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(124, 74);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(231, 25);
            this.txtFullName.TabIndex = 10;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(231, 25);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(124, 140);
            this.txtConta.Name = "txtConta";
            this.txtConta.ReadOnly = true;
            this.txtConta.Size = new System.Drawing.Size(231, 25);
            this.txtConta.TabIndex = 12;
            this.txtConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(124, 173);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.ReadOnly = true;
            this.txtSaldoInicial.Size = new System.Drawing.Size(231, 25);
            this.txtSaldoInicial.TabIndex = 13;
            this.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.Location = new System.Drawing.Point(124, 206);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.txtSaldoFinal.ReadOnly = true;
            this.txtSaldoFinal.Size = new System.Drawing.Size(231, 25);
            this.txtSaldoFinal.TabIndex = 14;
            this.txtSaldoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ping (ms):";
            // 
            // txtPingMs
            // 
            this.txtPingMs.Location = new System.Drawing.Point(124, 12);
            this.txtPingMs.Name = "txtPingMs";
            this.txtPingMs.ReadOnly = true;
            this.txtPingMs.Size = new System.Drawing.Size(231, 25);
            this.txtPingMs.TabIndex = 16;
            this.txtPingMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbxUnderlying_symbol
            // 
            this.cmbxUnderlying_symbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxUnderlying_symbol.FormattingEnabled = true;
            this.cmbxUnderlying_symbol.Items.AddRange(new object[] {
            "R_10",
            "R_25",
            "R_50",
            "R_75",
            "R_100",
            "R_150",
            "R_250"});
            this.cmbxUnderlying_symbol.Location = new System.Drawing.Point(6, 33);
            this.cmbxUnderlying_symbol.Name = "cmbxUnderlying_symbol";
            this.cmbxUnderlying_symbol.Size = new System.Drawing.Size(324, 25);
            this.cmbxUnderlying_symbol.TabIndex = 19;
            this.cmbxUnderlying_symbol.SelectedIndexChanged += new System.EventHandler(this.cmbxUnderlying_symbol_SelectedIndexChanged);
            // 
            // btnFiltrarContratoIndiceVolatividade
            // 
            this.btnFiltrarContratoIndiceVolatividade.Location = new System.Drawing.Point(84, 65);
            this.btnFiltrarContratoIndiceVolatividade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrarContratoIndiceVolatividade.Name = "btnFiltrarContratoIndiceVolatividade";
            this.btnFiltrarContratoIndiceVolatividade.Size = new System.Drawing.Size(246, 30);
            this.btnFiltrarContratoIndiceVolatividade.TabIndex = 20;
            this.btnFiltrarContratoIndiceVolatividade.Text = "Tick";
            this.btnFiltrarContratoIndiceVolatividade.UseVisualStyleBackColor = true;
            this.btnFiltrarContratoIndiceVolatividade.Click += new System.EventHandler(this.btnFiltrarContratoIndiceVolatividade_Click);
            // 
            // grpVolatilities
            // 
            this.grpVolatilities.Controls.Add(this.lblTickManual);
            this.grpVolatilities.Controls.Add(this.btnStop);
            this.grpVolatilities.Controls.Add(this.cmbxUnderlying_symbol);
            this.grpVolatilities.Controls.Add(this.btnTickManual);
            this.grpVolatilities.Controls.Add(this.btnFiltrarContratoIndiceVolatividade);
            this.grpVolatilities.Enabled = false;
            this.grpVolatilities.Location = new System.Drawing.Point(19, 286);
            this.grpVolatilities.Name = "grpVolatilities";
            this.grpVolatilities.Size = new System.Drawing.Size(336, 137);
            this.grpVolatilities.TabIndex = 24;
            this.grpVolatilities.TabStop = false;
            this.grpVolatilities.Text = "Contratos Volatility";
            // 
            // lblTickManual
            // 
            this.lblTickManual.AutoSize = true;
            this.lblTickManual.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickManual.Location = new System.Drawing.Point(5, 104);
            this.lblTickManual.Name = "lblTickManual";
            this.lblTickManual.Size = new System.Drawing.Size(103, 22);
            this.lblTickManual.TabIndex = 33;
            this.lblTickManual.Text = "TickManual";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(6, 65);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 30);
            this.btnStop.TabIndex = 32;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnTickManual
            // 
            this.btnTickManual.Enabled = false;
            this.btnTickManual.Location = new System.Drawing.Point(132, 103);
            this.btnTickManual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTickManual.Name = "btnTickManual";
            this.btnTickManual.Size = new System.Drawing.Size(198, 25);
            this.btnTickManual.TabIndex = 32;
            this.btnTickManual.Text = "Get Tick Manual";
            this.btnTickManual.UseVisualStyleBackColor = true;
            this.btnTickManual.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTickValue
            // 
            this.lblTickValue.AutoSize = true;
            this.lblTickValue.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickValue.Location = new System.Drawing.Point(601, 9);
            this.lblTickValue.Name = "lblTickValue";
            this.lblTickValue.Size = new System.Drawing.Size(220, 72);
            this.lblTickValue.TabIndex = 31;
            this.lblTickValue.Text = "Indice:";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(380, 106);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(751, 316);
            this.cartesianChart1.TabIndex = 32;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 54);
            this.button1.TabIndex = 33;
            this.button1.Text = "Rise/Fall";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.lblTickValue);
            this.Controls.Add(this.grpVolatilities);
            this.Controls.Add(this.txtPingMs);
            this.Controls.Add(this.label3);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpVolatilities.ResumeLayout(false);
            this.grpVolatilities.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPingMs;
        private System.Windows.Forms.ComboBox cmbxUnderlying_symbol;
        private System.Windows.Forms.Button btnFiltrarContratoIndiceVolatividade;
        private System.Windows.Forms.GroupBox grpVolatilities;
        private System.Windows.Forms.Label lblTickValue;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnTickManual;
        private System.Windows.Forms.Label lblTickManual;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button button1;
    }
}

