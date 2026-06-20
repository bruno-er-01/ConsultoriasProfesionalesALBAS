namespace CapaPresentacion
{
    partial class FormDashBoardCitas1
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
            this.pnlRegresar = new System.Windows.Forms.Panel();
            this.clCita = new System.Windows.Forms.MonthCalendar();
            this.ExportarGrafcioExcel = new System.Windows.Forms.Button();
            this.btnMostrarGrafico = new System.Windows.Forms.Button();
            this.cbGrafico = new System.Windows.Forms.ComboBox();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlRegresar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegresar
            // 
            this.pnlRegresar.Controls.Add(this.clCita);
            this.pnlRegresar.Controls.Add(this.ExportarGrafcioExcel);
            this.pnlRegresar.Controls.Add(this.btnMostrarGrafico);
            this.pnlRegresar.Controls.Add(this.cbGrafico);
            this.pnlRegresar.Controls.Add(this.cbTiempo);
            this.pnlRegresar.Controls.Add(this.label4);
            this.pnlRegresar.Controls.Add(this.label3);
            this.pnlRegresar.Controls.Add(this.label2);
            this.pnlRegresar.Controls.Add(this.button4);
            this.pnlRegresar.Location = new System.Drawing.Point(0, 3);
            this.pnlRegresar.Name = "pnlRegresar";
            this.pnlRegresar.Size = new System.Drawing.Size(859, 551);
            this.pnlRegresar.TabIndex = 33;
            // 
            // clCita
            // 
            this.clCita.Location = new System.Drawing.Point(30, 53);
            this.clCita.Margin = new System.Windows.Forms.Padding(7);
            this.clCita.MaxSelectionCount = 1;
            this.clCita.Name = "clCita";
            this.clCita.TabIndex = 30;
            // 
            // ExportarGrafcioExcel
            // 
            this.ExportarGrafcioExcel.BackColor = System.Drawing.Color.Maroon;
            this.ExportarGrafcioExcel.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportarGrafcioExcel.ForeColor = System.Drawing.Color.White;
            this.ExportarGrafcioExcel.Location = new System.Drawing.Point(540, 147);
            this.ExportarGrafcioExcel.Margin = new System.Windows.Forms.Padding(2);
            this.ExportarGrafcioExcel.Name = "ExportarGrafcioExcel";
            this.ExportarGrafcioExcel.Size = new System.Drawing.Size(212, 41);
            this.ExportarGrafcioExcel.TabIndex = 29;
            this.ExportarGrafcioExcel.Text = "Exportar gráfico en Excel";
            this.ExportarGrafcioExcel.UseVisualStyleBackColor = false;
            // 
            // btnMostrarGrafico
            // 
            this.btnMostrarGrafico.BackColor = System.Drawing.Color.Maroon;
            this.btnMostrarGrafico.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarGrafico.ForeColor = System.Drawing.Color.White;
            this.btnMostrarGrafico.Location = new System.Drawing.Point(302, 147);
            this.btnMostrarGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarGrafico.Name = "btnMostrarGrafico";
            this.btnMostrarGrafico.Size = new System.Drawing.Size(206, 41);
            this.btnMostrarGrafico.TabIndex = 28;
            this.btnMostrarGrafico.Text = "Mostrar gráfico";
            this.btnMostrarGrafico.UseVisualStyleBackColor = false;
            // 
            // cbGrafico
            // 
            this.cbGrafico.FormattingEnabled = true;
            this.cbGrafico.Items.AddRange(new object[] {
            "Gráfico de barras",
            "Gráfico circular"});
            this.cbGrafico.Location = new System.Drawing.Point(565, 87);
            this.cbGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.cbGrafico.Name = "cbGrafico";
            this.cbGrafico.Size = new System.Drawing.Size(156, 24);
            this.cbGrafico.TabIndex = 27;
            // 
            // cbTiempo
            // 
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Items.AddRange(new object[] {
            "Hoy",
            "Semana",
            "Mes"});
            this.cbTiempo.Location = new System.Drawing.Point(324, 87);
            this.cbTiempo.Margin = new System.Windows.Forms.Padding(2);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(156, 24);
            this.cbTiempo.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(618, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Gráfico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tiempo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(18, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dashboard de citas";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(754, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 35);
            this.button4.TabIndex = 22;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FormDashBoardCitas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 556);
            this.Controls.Add(this.pnlRegresar);
            this.Name = "FormDashBoardCitas1";
            this.Text = "FormDashBoardCitas1";
            this.pnlRegresar.ResumeLayout(false);
            this.pnlRegresar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegresar;
        private System.Windows.Forms.MonthCalendar clCita;
        private System.Windows.Forms.Button ExportarGrafcioExcel;
        private System.Windows.Forms.Button btnMostrarGrafico;
        private System.Windows.Forms.ComboBox cbGrafico;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}