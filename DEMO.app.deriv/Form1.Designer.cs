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
            this.dtContratos = new System.Windows.Forms.DataGridView();
            this.cmbxUnderlying_symbol = new System.Windows.Forms.ComboBox();
            this.btnFiltrarContratoIndiceVolatividade = new System.Windows.Forms.Button();
            this.cmbxUpsDowns = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTickValue = new System.Windows.Forms.Label();
            this.cmbxMoeda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMoedaSelecionada = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnRaiseFail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtContratos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(124, 41);
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
            // dtContratos
            // 
            this.dtContratos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtContratos.Location = new System.Drawing.Point(374, 356);
            this.dtContratos.Name = "dtContratos";
            this.dtContratos.Size = new System.Drawing.Size(757, 0);
            this.dtContratos.TabIndex = 18;
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
            this.cmbxUnderlying_symbol.Size = new System.Drawing.Size(198, 25);
            this.cmbxUnderlying_symbol.TabIndex = 19;
            // 
            // btnFiltrarContratoIndiceVolatividade
            // 
            this.btnFiltrarContratoIndiceVolatividade.Location = new System.Drawing.Point(84, 65);
            this.btnFiltrarContratoIndiceVolatividade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrarContratoIndiceVolatividade.Name = "btnFiltrarContratoIndiceVolatividade";
            this.btnFiltrarContratoIndiceVolatividade.Size = new System.Drawing.Size(120, 30);
            this.btnFiltrarContratoIndiceVolatividade.TabIndex = 20;
            this.btnFiltrarContratoIndiceVolatividade.Text = "Filtrar";
            this.btnFiltrarContratoIndiceVolatividade.UseVisualStyleBackColor = true;
            this.btnFiltrarContratoIndiceVolatividade.Click += new System.EventHandler(this.btnFiltrarContratoIndiceVolatividade_Click);
            // 
            // cmbxUpsDowns
            // 
            this.cmbxUpsDowns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxUpsDowns.FormattingEnabled = true;
            this.cmbxUpsDowns.Items.AddRange(new object[] {
            "Rise/Fall Equal"});
            this.cmbxUpsDowns.Location = new System.Drawing.Point(6, 24);
            this.cmbxUpsDowns.Name = "cmbxUpsDowns";
            this.cmbxUpsDowns.Size = new System.Drawing.Size(198, 25);
            this.cmbxUpsDowns.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.lblTickValue);
            this.groupBox1.Controls.Add(this.cmbxUnderlying_symbol);
            this.groupBox1.Controls.Add(this.btnFiltrarContratoIndiceVolatividade);
            this.groupBox1.Location = new System.Drawing.Point(361, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 256);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contratos Volatility (1s)";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 65);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 30);
            this.btnStop.TabIndex = 32;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTickValue
            // 
            this.lblTickValue.AutoSize = true;
            this.lblTickValue.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickValue.Location = new System.Drawing.Point(210, 21);
            this.lblTickValue.Name = "lblTickValue";
            this.lblTickValue.Size = new System.Drawing.Size(220, 72);
            this.lblTickValue.TabIndex = 31;
            this.lblTickValue.Text = "Indice:";
            // 
            // cmbxMoeda
            // 
            this.cmbxMoeda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMoeda.FormattingEnabled = true;
            this.cmbxMoeda.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "AUD",
            "JPY",
            "CHF",
            "CAD"});
            this.cmbxMoeda.Location = new System.Drawing.Point(124, 370);
            this.cmbxMoeda.Name = "cmbxMoeda";
            this.cmbxMoeda.Size = new System.Drawing.Size(231, 25);
            this.cmbxMoeda.TabIndex = 25;
            this.cmbxMoeda.SelectedIndexChanged += new System.EventHandler(this.cmbxMoeda_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Moeda";
            // 
            // lblMoedaSelecionada
            // 
            this.lblMoedaSelecionada.AutoSize = true;
            this.lblMoedaSelecionada.Location = new System.Drawing.Point(121, 412);
            this.lblMoedaSelecionada.Name = "lblMoedaSelecionada";
            this.lblMoedaSelecionada.Size = new System.Drawing.Size(135, 17);
            this.lblMoedaSelecionada.TabIndex = 27;
            this.lblMoedaSelecionada.Text = "Moeda Selecionada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbxUpsDowns);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(19, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 62);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ups & Downs";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.btnFiltrar);
            this.groupBox3.Location = new System.Drawing.Point(19, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 62);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Higher & Lows";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Touch/No Touch"});
            this.comboBox1.Location = new System.Drawing.Point(6, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 25);
            this.comboBox1.TabIndex = 22;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(210, 20);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(120, 30);
            this.btnFiltrar.TabIndex = 23;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnRaiseFail
            // 
            this.btnRaiseFail.Location = new System.Drawing.Point(19, 370);
            this.btnRaiseFail.Name = "btnRaiseFail";
            this.btnRaiseFail.Size = new System.Drawing.Size(103, 57);
            this.btnRaiseFail.TabIndex = 30;
            this.btnRaiseFail.Text = "Raise/Fail";
            this.btnRaiseFail.UseVisualStyleBackColor = true;
            this.btnRaiseFail.Click += new System.EventHandler(this.btnRaiseFail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 272);
            this.Controls.Add(this.btnRaiseFail);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblMoedaSelecionada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbxMoeda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtContratos);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtContratos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dtContratos;
        private System.Windows.Forms.ComboBox cmbxUnderlying_symbol;
        private System.Windows.Forms.Button btnFiltrarContratoIndiceVolatividade;
        private System.Windows.Forms.ComboBox cmbxUpsDowns;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbxMoeda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMoedaSelecionada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnRaiseFail;
        private System.Windows.Forms.Label lblTickValue;
        private System.Windows.Forms.Button btnStop;
    }
}

