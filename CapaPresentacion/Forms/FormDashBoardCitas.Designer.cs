namespace CapaPresentacion
{
    partial class FormDashBoardCitas
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
            this.clCita = new System.Windows.Forms.MonthCalendar();
            this.btnExportarGraficoExcel = new System.Windows.Forms.Button();
            this.btnMostrarGrafico = new System.Windows.Forms.Button();
            this.cbGrafico = new System.Windows.Forms.ComboBox();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGraficoEstadistico = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // clCita
            // 
            this.clCita.Location = new System.Drawing.Point(72, 74);
            this.clCita.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.clCita.MaxSelectionCount = 1;
            this.clCita.Name = "clCita";
            this.clCita.TabIndex = 20;
            // 
            // btnExportarGraficoExcel
            // 
            this.btnExportarGraficoExcel.BackColor = System.Drawing.Color.Maroon;
            this.btnExportarGraficoExcel.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarGraficoExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarGraficoExcel.Location = new System.Drawing.Point(797, 220);
            this.btnExportarGraficoExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportarGraficoExcel.Name = "btnExportarGraficoExcel";
            this.btnExportarGraficoExcel.Size = new System.Drawing.Size(296, 53);
            this.btnExportarGraficoExcel.TabIndex = 19;
            this.btnExportarGraficoExcel.Text = "Exportar gráfico en Excel";
            this.btnExportarGraficoExcel.UseVisualStyleBackColor = false;
            // 
            // btnMostrarGrafico
            // 
            this.btnMostrarGrafico.BackColor = System.Drawing.Color.Maroon;
            this.btnMostrarGrafico.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarGrafico.ForeColor = System.Drawing.Color.White;
            this.btnMostrarGrafico.Location = new System.Drawing.Point(569, 220);
            this.btnMostrarGrafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarGrafico.Name = "btnMostrarGrafico";
            this.btnMostrarGrafico.Size = new System.Drawing.Size(208, 53);
            this.btnMostrarGrafico.TabIndex = 18;
            this.btnMostrarGrafico.Text = "Mostrar gráfico";
            this.btnMostrarGrafico.UseVisualStyleBackColor = false;
            // 
            // cbGrafico
            // 
            this.cbGrafico.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrafico.FormattingEnabled = true;
            this.cbGrafico.Items.AddRange(new object[] {
            "Gráfico de barras",
            "Gráfico circular"});
            this.cbGrafico.Location = new System.Drawing.Point(705, 110);
            this.cbGrafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGrafico.Name = "cbGrafico";
            this.cbGrafico.Size = new System.Drawing.Size(149, 25);
            this.cbGrafico.TabIndex = 17;
            // 
            // cbTiempo
            // 
            this.cbTiempo.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Items.AddRange(new object[] {
            "Hoy",
            "Semana",
            "Mes"});
            this.cbTiempo.Location = new System.Drawing.Point(465, 110);
            this.cbTiempo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(149, 25);
            this.cbTiempo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(733, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gráfico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(24)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 41);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dashboard de citas";
            // 
            // pnlGraficoEstadistico
            // 
            this.pnlGraficoEstadistico.Location = new System.Drawing.Point(180, 299);
            this.pnlGraficoEstadistico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGraficoEstadistico.Name = "pnlGraficoEstadistico";
            this.pnlGraficoEstadistico.Size = new System.Drawing.Size(764, 322);
            this.pnlGraficoEstadistico.TabIndex = 21;
            // 
            // FormDashBoardCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 647);
            this.Controls.Add(this.pnlGraficoEstadistico);
            this.Controls.Add(this.clCita);
            this.Controls.Add(this.btnExportarGraficoExcel);
            this.Controls.Add(this.btnMostrarGrafico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGrafico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDashBoardCitas";
            this.Text = "FormDashBoardCitas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar clCita;
        private System.Windows.Forms.Button btnExportarGraficoExcel;
        private System.Windows.Forms.Button btnMostrarGrafico;
        private System.Windows.Forms.ComboBox cbGrafico;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlGraficoEstadistico;
    }
}