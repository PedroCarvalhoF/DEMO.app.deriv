namespace DEMO.app.deriv
{
    partial class FrmTickTeste
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
            this.lblTickValue = new System.Windows.Forms.Label();
            this.cmbxUnderlying_symbol = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTickValue);
            this.groupBox1.Controls.Add(this.cmbxUnderlying_symbol);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 256);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contratos Volatility (1s)";
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
            this.cmbxUnderlying_symbol.Size = new System.Drawing.Size(198, 21);
            this.cmbxUnderlying_symbol.TabIndex = 19;
            // 
            // FrmTickTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTickTeste";
            this.Text = "FrmTickTeste";
            this.Load += new System.EventHandler(this.FrmTickTeste_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTickValue;
        private System.Windows.Forms.ComboBox cmbxUnderlying_symbol;
    }
}