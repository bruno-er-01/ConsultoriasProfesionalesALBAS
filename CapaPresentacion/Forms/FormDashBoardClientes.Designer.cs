namespace CapaPresentacion
{
    partial class FormDashBoardClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.clClientes = new System.Windows.Forms.MonthCalendar();
            this.btnExportarGraficoExcel = new System.Windows.Forms.Button();
            this.btnMostrarGrafico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGraficoEstadistico = new System.Windows.Forms.Panel();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.cbGrafico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Área";
            // 
            // clClientes
            // 
            this.clClientes.Location = new System.Drawing.Point(54, 60);
            this.clClientes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.clClientes.MaxSelectionCount = 1;
            this.clClientes.Name = "clClientes";
            this.clClientes.TabIndex = 32;
            // 
            // btnExportarGraficoExcel
            // 
            this.btnExportarGraficoExcel.BackColor = System.Drawing.Color.Maroon;
            this.btnExportarGraficoExcel.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarGraficoExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarGraficoExcel.Location = new System.Drawing.Point(598, 179);
            this.btnExportarGraficoExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportarGraficoExcel.Name = "btnExportarGraficoExcel";
            this.btnExportarGraficoExcel.Size = new System.Drawing.Size(224, 43);
            this.btnExportarGraficoExcel.TabIndex = 31;
            this.btnExportarGraficoExcel.Text = "Exportar gráfico en Excel";
            this.btnExportarGraficoExcel.UseVisualStyleBackColor = false;
            // 
            // btnMostrarGrafico
            // 
            this.btnMostrarGrafico.BackColor = System.Drawing.Color.Maroon;
            this.btnMostrarGrafico.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarGrafico.ForeColor = System.Drawing.Color.White;
            this.btnMostrarGrafico.Location = new System.Drawing.Point(427, 179);
            this.btnMostrarGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarGrafico.Name = "btnMostrarGrafico";
            this.btnMostrarGrafico.Size = new System.Drawing.Size(156, 43);
            this.btnMostrarGrafico.TabIndex = 30;
            this.btnMostrarGrafico.Text = "Mostrar gráfico";
            this.btnMostrarGrafico.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Dashboard de clientes";
            // 
            // pnlGraficoEstadistico
            // 
            this.pnlGraficoEstadistico.Location = new System.Drawing.Point(135, 243);
            this.pnlGraficoEstadistico.Name = "pnlGraficoEstadistico";
            this.pnlGraficoEstadistico.Size = new System.Drawing.Size(573, 262);
            this.pnlGraficoEstadistico.TabIndex = 35;
            // 
            // cbTiempo
            // 
            this.cbTiempo.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Items.AddRange(new object[] {
            "Hoy",
            "Semana",
            "Mes"});
            this.cbTiempo.Location = new System.Drawing.Point(350, 89);
            this.cbTiempo.Margin = new System.Windows.Forms.Padding(2);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(113, 20);
            this.cbTiempo.TabIndex = 36;
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "Civil",
            "Familia",
            "Judicial",
            "Conciliación",
            "Todas"});
            this.cbArea.Location = new System.Drawing.Point(690, 89);
            this.cbArea.Margin = new System.Windows.Forms.Padding(2);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(113, 20);
            this.cbArea.TabIndex = 37;
            // 
            // cbGrafico
            // 
            this.cbGrafico.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrafico.FormattingEnabled = true;
            this.cbGrafico.Items.AddRange(new object[] {
            "Gráfico de barras",
            "Gráfico circular"});
            this.cbGrafico.Location = new System.Drawing.Point(529, 89);
            this.cbGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.cbGrafico.Name = "cbGrafico";
            this.cbGrafico.Size = new System.Drawing.Size(113, 20);
            this.cbGrafico.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Gráfico";
            // 
            // FormDashBoardClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 526);
            this.Controls.Add(this.cbGrafico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.pnlGraficoEstadistico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportarGraficoExcel);
            this.Controls.Add(this.clClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostrarGrafico);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDashBoardClientes";
            this.Text = "FormDashBoardClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar clClientes;
        private System.Windows.Forms.Button btnExportarGraficoExcel;
        private System.Windows.Forms.Button btnMostrarGrafico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlGraficoEstadistico;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.ComboBox cbGrafico;
        private System.Windows.Forms.Label label4;
    }
}