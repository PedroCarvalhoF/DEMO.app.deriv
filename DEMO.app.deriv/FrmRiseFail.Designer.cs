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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.lblPreco = new System.Windows.Forms.Label();
            this.flStatusPrecoContrato = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTempoExecucao = new System.Windows.Forms.Label();
            this.lblTick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 3);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(460, 282);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(478, 9);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(150, 58);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "label1";
            // 
            // flStatusPrecoContrato
            // 
            this.flStatusPrecoContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flStatusPrecoContrato.BackColor = System.Drawing.Color.White;
            this.flStatusPrecoContrato.Location = new System.Drawing.Point(12, 286);
            this.flStatusPrecoContrato.Name = "flStatusPrecoContrato";
            this.flStatusPrecoContrato.Size = new System.Drawing.Size(935, 218);
            this.flStatusPrecoContrato.TabIndex = 4;
            // 
            // lblTempoExecucao
            // 
            this.lblTempoExecucao.AutoSize = true;
            this.lblTempoExecucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoExecucao.Location = new System.Drawing.Point(483, 118);
            this.lblTempoExecucao.Name = "lblTempoExecucao";
            this.lblTempoExecucao.Size = new System.Drawing.Size(221, 25);
            this.lblTempoExecucao.TabIndex = 5;
            this.lblTempoExecucao.Text = "Tempo de Execução: ";
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTick.Location = new System.Drawing.Point(483, 78);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(58, 25);
            this.lblTick.TabIndex = 6;
            this.lblTick.Text = "Tick:";
            // 
            // FrmRiseFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 516);
            this.Controls.Add(this.lblTick);
            this.Controls.Add(this.lblTempoExecucao);
            this.Controls.Add(this.flStatusPrecoContrato);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "FrmRiseFail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRiseFail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRiseFail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.FlowLayoutPanel flStatusPrecoContrato;
        private System.Windows.Forms.Label lblTempoExecucao;
        private System.Windows.Forms.Label lblTick;
    }
}