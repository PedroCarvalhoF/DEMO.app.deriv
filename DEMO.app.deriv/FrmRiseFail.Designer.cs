namespace DEMO.app.deriv
{
    partial class FrmRiseFail
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
            this.txtSaldoFinal = new System.Windows.Forms.TextBox();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTickValue = new System.Windows.Forms.Label();
            this.grpVolatilities = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.cmbxUnderlying_symbol = new System.Windows.Forms.ComboBox();
            this.btnFiltrarContratoIndiceVolatividade = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtPingMs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRiseTickCompra = new System.Windows.Forms.Label();
            this.easyPanel9 = new DEMO.app.deriv.Controles.Helpers.EasyPanel();
            this.btnFall = new System.Windows.Forms.Button();
            this.btnRise = new System.Windows.Forms.Button();
            this.easyPanel6 = new DEMO.app.deriv.Controles.Helpers.EasyPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.easyPanel7 = new DEMO.app.deriv.Controles.Helpers.EasyPanel();
            this.easyPanel8 = new DEMO.app.deriv.Controles.Helpers.EasyPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.easyPanel3 = new DEMO.app.deriv.Controles.Helpers.EasyPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTick = new System.Windows.Forms.Button();
            this.lblQtdTick = new System.Windows.Forms.Label();
            this.btnRemoveTick = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.easyPanel5 = new DEMO.app.deriv.Controles.Helpers.EasyPanel();
            this.easyPanel4 = new DEMO.app.deriv.Controles.Helpers.EasyPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.easyPanel1 = new DEMO.app.deriv.Controles.Helpers.EasyPanel();
            this.easyPanel2 = new DEMO.app.deriv.Controles.Helpers.EasyPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.grpVolatilities.SuspendLayout();
            this.easyPanel9.SuspendLayout();
            this.easyPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.easyPanel8.SuspendLayout();
            this.easyPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.easyPanel4.SuspendLayout();
            this.easyPanel1.SuspendLayout();
            this.easyPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.Location = new System.Drawing.Point(773, 6);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.txtSaldoFinal.ReadOnly = true;
            this.txtSaldoFinal.Size = new System.Drawing.Size(101, 25);
            this.txtSaldoFinal.TabIndex = 18;
            this.txtSaldoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(609, 6);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.ReadOnly = true;
            this.txtSaldoInicial.Size = new System.Drawing.Size(77, 25);
            this.txtSaldoInicial.TabIndex = 17;
            this.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Saldo Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Saldo Inicial";
            // 
            // lblTickValue
            // 
            this.lblTickValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTickValue.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickValue.Location = new System.Drawing.Point(601, 21);
            this.lblTickValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblTickValue.Name = "lblTickValue";
            this.lblTickValue.Size = new System.Drawing.Size(268, 45);
            this.lblTickValue.TabIndex = 32;
            this.lblTickValue.Text = "Indice:";
            this.lblTickValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpVolatilities
            // 
            this.grpVolatilities.Controls.Add(this.btnStop);
            this.grpVolatilities.Controls.Add(this.lblTickValue);
            this.grpVolatilities.Controls.Add(this.cmbxUnderlying_symbol);
            this.grpVolatilities.Controls.Add(this.btnFiltrarContratoIndiceVolatividade);
            this.grpVolatilities.Location = new System.Drawing.Point(8, 37);
            this.grpVolatilities.Name = "grpVolatilities";
            this.grpVolatilities.Size = new System.Drawing.Size(872, 69);
            this.grpVolatilities.TabIndex = 33;
            this.grpVolatilities.TabStop = false;
            this.grpVolatilities.Text = "Contratos Volatility";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(312, 29);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 30);
            this.btnStop.TabIndex = 32;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            this.cmbxUnderlying_symbol.Size = new System.Drawing.Size(195, 25);
            this.cmbxUnderlying_symbol.TabIndex = 19;
            // 
            // btnFiltrarContratoIndiceVolatividade
            // 
            this.btnFiltrarContratoIndiceVolatividade.Location = new System.Drawing.Point(207, 29);
            this.btnFiltrarContratoIndiceVolatividade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrarContratoIndiceVolatividade.Name = "btnFiltrarContratoIndiceVolatividade";
            this.btnFiltrarContratoIndiceVolatividade.Size = new System.Drawing.Size(99, 30);
            this.btnFiltrarContratoIndiceVolatividade.TabIndex = 20;
            this.btnFiltrarContratoIndiceVolatividade.Text = "Inciar";
            this.btnFiltrarContratoIndiceVolatividade.UseVisualStyleBackColor = true;
            this.btnFiltrarContratoIndiceVolatividade.Click += new System.EventHandler(this.btnFiltrarContratoIndiceVolatividade_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(8, 6);
            this.txtToken.Name = "txtToken";
            this.txtToken.ReadOnly = true;
            this.txtToken.Size = new System.Drawing.Size(382, 25);
            this.txtToken.TabIndex = 34;
            this.txtToken.Text = "Token";
            // 
            // txtPingMs
            // 
            this.txtPingMs.Location = new System.Drawing.Point(452, 6);
            this.txtPingMs.Name = "txtPingMs";
            this.txtPingMs.ReadOnly = true;
            this.txtPingMs.Size = new System.Drawing.Size(66, 25);
            this.txtPingMs.TabIndex = 35;
            this.txtPingMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "ping";
            // 
            // lblRiseTickCompra
            // 
            this.lblRiseTickCompra.AutoSize = true;
            this.lblRiseTickCompra.Location = new System.Drawing.Point(278, 130);
            this.lblRiseTickCompra.Name = "lblRiseTickCompra";
            this.lblRiseTickCompra.Size = new System.Drawing.Size(109, 17);
            this.lblRiseTickCompra.TabIndex = 37;
            this.lblRiseTickCompra.Text = "Rise Tick Compra";
            // 
            // easyPanel9
            // 
            this.easyPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.easyPanel9.BorderColor = System.Drawing.Color.White;
            this.easyPanel9.BorderThickness = 1.5F;
            this.easyPanel9.Controls.Add(this.button3);
            this.easyPanel9.Controls.Add(this.btnFall);
            this.easyPanel9.Controls.Add(this.btnRise);
            this.easyPanel9.CornerRadius = 8;
            this.easyPanel9.CornerRadiusBottomLeft = 8;
            this.easyPanel9.CornerRadiusBottomRight = 8;
            this.easyPanel9.CornerRadiusTopLeft = 8;
            this.easyPanel9.CornerRadiusTopRight = 8;
            this.easyPanel9.Location = new System.Drawing.Point(8, 417);
            this.easyPanel9.Name = "easyPanel9";
            this.easyPanel9.ShadowColor = System.Drawing.Color.Gray;
            this.easyPanel9.ShadowSize = 5;
            this.easyPanel9.Size = new System.Drawing.Size(264, 173);
            this.easyPanel9.TabIndex = 3;
            // 
            // btnFall
            // 
            this.btnFall.BackColor = System.Drawing.Color.Crimson;
            this.btnFall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFall.FlatAppearance.BorderSize = 0;
            this.btnFall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFall.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFall.ForeColor = System.Drawing.Color.White;
            this.btnFall.Location = new System.Drawing.Point(6, 120);
            this.btnFall.Name = "btnFall";
            this.btnFall.Size = new System.Drawing.Size(251, 43);
            this.btnFall.TabIndex = 1;
            this.btnFall.Text = "Fall";
            this.btnFall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFall.UseVisualStyleBackColor = false;
            this.btnFall.Click += new System.EventHandler(this.btnFall_Click);
            // 
            // btnRise
            // 
            this.btnRise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            this.btnRise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRise.FlatAppearance.BorderSize = 0;
            this.btnRise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRise.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRise.ForeColor = System.Drawing.Color.White;
            this.btnRise.Location = new System.Drawing.Point(6, 25);
            this.btnRise.Name = "btnRise";
            this.btnRise.Size = new System.Drawing.Size(251, 43);
            this.btnRise.TabIndex = 0;
            this.btnRise.Text = "Rise";
            this.btnRise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRise.UseVisualStyleBackColor = false;
            this.btnRise.Click += new System.EventHandler(this.btnRise_Click);
            // 
            // easyPanel6
            // 
            this.easyPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.easyPanel6.BorderColor = System.Drawing.Color.White;
            this.easyPanel6.BorderThickness = 1.5F;
            this.easyPanel6.Controls.Add(this.tableLayoutPanel3);
            this.easyPanel6.Controls.Add(this.tableLayoutPanel4);
            this.easyPanel6.CornerRadius = 8;
            this.easyPanel6.CornerRadiusBottomLeft = 8;
            this.easyPanel6.CornerRadiusBottomRight = 8;
            this.easyPanel6.CornerRadiusTopLeft = 8;
            this.easyPanel6.CornerRadiusTopRight = 8;
            this.easyPanel6.Location = new System.Drawing.Point(8, 315);
            this.easyPanel6.Name = "easyPanel6";
            this.easyPanel6.ShadowColor = System.Drawing.Color.Gray;
            this.easyPanel6.ShadowSize = 5;
            this.easyPanel6.Size = new System.Drawing.Size(264, 96);
            this.easyPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtValorEntrada, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 50);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(251, 39);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValorEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEntrada.Location = new System.Drawing.Point(86, 5);
            this.txtValorEntrada.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(77, 29);
            this.txtValorEntrada.TabIndex = 3;
            this.txtValorEntrada.Text = "0,35";
            this.txtValorEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.easyPanel7, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.easyPanel8, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(251, 32);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // easyPanel7
            // 
            this.easyPanel7.BackColor = System.Drawing.Color.White;
            this.easyPanel7.BorderColor = System.Drawing.Color.White;
            this.easyPanel7.BorderThickness = 1.5F;
            this.easyPanel7.CornerRadius = 0;
            this.easyPanel7.CornerRadiusBottomLeft = 0;
            this.easyPanel7.CornerRadiusBottomRight = 8;
            this.easyPanel7.CornerRadiusTopLeft = 0;
            this.easyPanel7.CornerRadiusTopRight = 8;
            this.easyPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyPanel7.Location = new System.Drawing.Point(125, 0);
            this.easyPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.easyPanel7.Name = "easyPanel7";
            this.easyPanel7.ShadowColor = System.Drawing.Color.Gray;
            this.easyPanel7.ShadowSize = 5;
            this.easyPanel7.Size = new System.Drawing.Size(126, 32);
            this.easyPanel7.TabIndex = 1;
            // 
            // easyPanel8
            // 
            this.easyPanel8.BackColor = System.Drawing.Color.White;
            this.easyPanel8.BorderColor = System.Drawing.Color.White;
            this.easyPanel8.BorderThickness = 1.5F;
            this.easyPanel8.Controls.Add(this.label4);
            this.easyPanel8.CornerRadius = 0;
            this.easyPanel8.CornerRadiusBottomLeft = 8;
            this.easyPanel8.CornerRadiusBottomRight = null;
            this.easyPanel8.CornerRadiusTopLeft = 8;
            this.easyPanel8.CornerRadiusTopRight = null;
            this.easyPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyPanel8.Location = new System.Drawing.Point(0, 0);
            this.easyPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.easyPanel8.Name = "easyPanel8";
            this.easyPanel8.Padding = new System.Windows.Forms.Padding(3);
            this.easyPanel8.ShadowColor = System.Drawing.Color.Gray;
            this.easyPanel8.ShadowSize = 5;
            this.easyPanel8.Size = new System.Drawing.Size(125, 32);
            this.easyPanel8.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Entrada";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // easyPanel3
            // 
            this.easyPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.easyPanel3.BorderColor = System.Drawing.Color.White;
            this.easyPanel3.BorderThickness = 1.5F;
            this.easyPanel3.Controls.Add(this.tableLayoutPanel2);
            this.easyPanel3.Controls.Add(this.tableLayoutPanel1);
            this.easyPanel3.CornerRadius = 8;
            this.easyPanel3.CornerRadiusBottomLeft = 8;
            this.easyPanel3.CornerRadiusBottomRight = 8;
            this.easyPanel3.CornerRadiusTopLeft = 8;
            this.easyPanel3.CornerRadiusTopRight = 8;
            this.easyPanel3.Location = new System.Drawing.Point(8, 206);
            this.easyPanel3.Name = "easyPanel3";
            this.easyPanel3.ShadowColor = System.Drawing.Color.Gray;
            this.easyPanel3.ShadowSize = 5;
            this.easyPanel3.Size = new System.Drawing.Size(264, 103);
            this.easyPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddTick, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblQtdTick, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveTick, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(251, 39);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnAddTick
            // 
            this.btnAddTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddTick.FlatAppearance.BorderSize = 0;
            this.btnAddTick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTick.Location = new System.Drawing.Point(169, 3);
            this.btnAddTick.Name = "btnAddTick";
            this.btnAddTick.Size = new System.Drawing.Size(79, 33);
            this.btnAddTick.TabIndex = 2;
            this.btnAddTick.Text = "+";
            this.btnAddTick.UseVisualStyleBackColor = true;
            this.btnAddTick.Click += new System.EventHandler(this.btnAddTick_Click);
            // 
            // lblQtdTick
            // 
            this.lblQtdTick.AutoSize = true;
            this.lblQtdTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdTick.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdTick.Location = new System.Drawing.Point(86, 0);
            this.lblQtdTick.Name = "lblQtdTick";
            this.lblQtdTick.Size = new System.Drawing.Size(77, 39);
            this.lblQtdTick.TabIndex = 3;
            this.lblQtdTick.Text = "1 Ticks";
            this.lblQtdTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemoveTick
            // 
            this.btnRemoveTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveTick.FlatAppearance.BorderSize = 0;
            this.btnRemoveTick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTick.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveTick.Name = "btnRemoveTick";
            this.btnRemoveTick.Size = new System.Drawing.Size(77, 33);
            this.btnRemoveTick.TabIndex = 1;
            this.btnRemoveTick.Text = "-";
            this.btnRemoveTick.UseVisualStyleBackColor = true;
            this.btnRemoveTick.Click += new System.EventHandler(this.btnRemoveTick_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.easyPanel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.easyPanel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // easyPanel5
            // 
            this.easyPanel5.BackColor = System.Drawing.Color.White;
            this.easyPanel5.BorderColor = System.Drawing.Color.White;
            this.easyPanel5.BorderThickness = 1.5F;
            this.easyPanel5.CornerRadius = 0;
            this.easyPanel5.CornerRadiusBottomLeft = 0;
            this.easyPanel5.CornerRadiusBottomRight = 8;
            this.easyPanel5.CornerRadiusTopLeft = 0;
            this.easyPanel5.CornerRadiusTopRight = 8;
            this.easyPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyPanel5.Location = new System.Drawing.Point(125, 0);
            this.easyPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.easyPanel5.Name = "easyPanel5";
            this.easyPanel5.ShadowColor = System.Drawing.Color.Gray;
            this.easyPanel5.ShadowSize = 5;
            this.easyPanel5.Size = new System.Drawing.Size(126, 32);
            this.easyPanel5.TabIndex = 1;
            // 
            // easyPanel4
            // 
            this.easyPanel4.BackColor = System.Drawing.Color.White;
            this.easyPanel4.BorderColor = System.Drawing.Color.White;
            this.easyPanel4.BorderThickness = 1.5F;
            this.easyPanel4.Controls.Add(this.label3);
            this.easyPanel4.CornerRadius = 0;
            this.easyPanel4.CornerRadiusBottomLeft = 8;
            this.easyPanel4.CornerRadiusBottomRight = null;
            this.easyPanel4.CornerRadiusTopLeft = 8;
            this.easyPanel4.CornerRadiusTopRight = null;
            this.easyPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyPanel4.Location = new System.Drawing.Point(0, 0);
            this.easyPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.easyPanel4.Name = "easyPanel4";
            this.easyPanel4.Padding = new System.Windows.Forms.Padding(3);
            this.easyPanel4.ShadowColor = System.Drawing.Color.Gray;
            this.easyPanel4.ShadowSize = 5;
            this.easyPanel4.Size = new System.Drawing.Size(125, 32);
            this.easyPanel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ticks";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // easyPanel1
            // 
            this.easyPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.easyPanel1.BorderColor = System.Drawing.Color.White;
            this.easyPanel1.BorderThickness = 1.5F;
            this.easyPanel1.Controls.Add(this.easyPanel2);
            this.easyPanel1.CornerRadius = 8;
            this.easyPanel1.CornerRadiusBottomLeft = null;
            this.easyPanel1.CornerRadiusBottomRight = null;
            this.easyPanel1.CornerRadiusTopLeft = null;
            this.easyPanel1.CornerRadiusTopRight = null;
            this.easyPanel1.Location = new System.Drawing.Point(8, 112);
            this.easyPanel1.Name = "easyPanel1";
            this.easyPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.easyPanel1.ShadowSize = 5;
            this.easyPanel1.Size = new System.Drawing.Size(264, 88);
            this.easyPanel1.TabIndex = 0;
            // 
            // easyPanel2
            // 
            this.easyPanel2.BackColor = System.Drawing.Color.White;
            this.easyPanel2.BorderColor = System.Drawing.Color.White;
            this.easyPanel2.BorderThickness = 1.5F;
            this.easyPanel2.Controls.Add(this.label2);
            this.easyPanel2.Controls.Add(this.pictureBox1);
            this.easyPanel2.CornerRadius = 8;
            this.easyPanel2.CornerRadiusBottomLeft = null;
            this.easyPanel2.CornerRadiusBottomRight = null;
            this.easyPanel2.CornerRadiusTopLeft = null;
            this.easyPanel2.CornerRadiusTopRight = null;
            this.easyPanel2.Location = new System.Drawing.Point(6, 6);
            this.easyPanel2.Name = "easyPanel2";
            this.easyPanel2.ShadowColor = System.Drawing.Color.Gray;
            this.easyPanel2.ShadowSize = 5;
            this.easyPanel2.Size = new System.Drawing.Size(251, 72);
            this.easyPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rase/Fall";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DEMO.app.deriv.Properties.Resources.chart_com_seta;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(7, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Rise 10x";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmRiseFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 643);
            this.Controls.Add(this.lblRiseTickCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPingMs);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.grpVolatilities);
            this.Controls.Add(this.txtSaldoFinal);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.easyPanel9);
            this.Controls.Add(this.easyPanel6);
            this.Controls.Add(this.easyPanel3);
            this.Controls.Add(this.easyPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRiseFail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rise/Fail";
            this.Load += new System.EventHandler(this.FrmRiseFail_Load);
            this.grpVolatilities.ResumeLayout(false);
            this.easyPanel9.ResumeLayout(false);
            this.easyPanel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.easyPanel8.ResumeLayout(false);
            this.easyPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.easyPanel4.ResumeLayout(false);
            this.easyPanel1.ResumeLayout(false);
            this.easyPanel2.ResumeLayout(false);
            this.easyPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.Helpers.EasyPanel easyPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controles.Helpers.EasyPanel easyPanel2;
        private System.Windows.Forms.Label label2;
        private Controles.Helpers.EasyPanel easyPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controles.Helpers.EasyPanel easyPanel4;
        private Controles.Helpers.EasyPanel easyPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddTick;
        private System.Windows.Forms.Button btnRemoveTick;
        private System.Windows.Forms.Label lblQtdTick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controles.Helpers.EasyPanel easyPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Controles.Helpers.EasyPanel easyPanel7;
        private Controles.Helpers.EasyPanel easyPanel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorEntrada;
        private Controles.Helpers.EasyPanel easyPanel9;
        private System.Windows.Forms.Button btnFall;
        private System.Windows.Forms.Button btnRise;
        private System.Windows.Forms.TextBox txtSaldoFinal;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTickValue;
        private System.Windows.Forms.GroupBox grpVolatilities;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cmbxUnderlying_symbol;
        private System.Windows.Forms.Button btnFiltrarContratoIndiceVolatividade;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtPingMs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRiseTickCompra;
        private System.Windows.Forms.Button button3;
    }
}