namespace CapaPresentacion.Forms
{
    partial class FormDashBoardCitasAusentes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.cbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.txtAnchoBarra = new System.Windows.Forms.TextBox();
            this.chartAusencias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rtbInterpretacion = new System.Windows.Forms.RichTextBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAusencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(594, 100);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaInicio.TabIndex = 2;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(594, 141);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaFin.TabIndex = 3;
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.FormattingEnabled = true;
            this.cbOrdenarPor.Location = new System.Drawing.Point(278, 99);
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(121, 24);
            this.cbOrdenarPor.TabIndex = 4;
            // 
            // txtAnchoBarra
            // 
            this.txtAnchoBarra.Location = new System.Drawing.Point(278, 140);
            this.txtAnchoBarra.Name = "txtAnchoBarra";
            this.txtAnchoBarra.Size = new System.Drawing.Size(121, 22);
            this.txtAnchoBarra.TabIndex = 5;
            // 
            // chartAusencias
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAusencias.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAusencias.Legends.Add(legend2);
            this.chartAusencias.Location = new System.Drawing.Point(29, 230);
            this.chartAusencias.Name = "chartAusencias";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAusencias.Series.Add(series2);
            this.chartAusencias.Size = new System.Drawing.Size(783, 388);
            this.chartAusencias.TabIndex = 6;
            this.chartAusencias.Text = "chart1";
            // 
            // rtbInterpretacion
            // 
            this.rtbInterpretacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbInterpretacion.Location = new System.Drawing.Point(865, 292);
            this.rtbInterpretacion.Name = "rtbInterpretacion";
            this.rtbInterpretacion.ReadOnly = true;
            this.rtbInterpretacion.Size = new System.Drawing.Size(261, 268);
            this.rtbInterpretacion.TabIndex = 11;
            this.rtbInterpretacion.Text = "";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Maroon;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(943, 30);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(183, 53);
            this.btnGenerarReporte.TabIndex = 60;
            this.btnGenerarReporte.Text = "Actualizar Gráfico";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 28);
            this.label5.TabIndex = 69;
            this.label5.Text = "Ordenar por:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 28);
            this.label6.TabIndex = 70;
            this.label6.Text = "Anchura de las barras:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 28);
            this.label7.TabIndex = 71;
            this.label7.Text = "Fecha inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(495, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 28);
            this.label8.TabIndex = 72;
            this.label8.Text = "Fecha fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 50);
            this.label1.TabIndex = 73;
            this.label1.Text = "Pérdidas económicas por citas canceladas";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(26, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1100, 1);
            this.label16.TabIndex = 106;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(943, 95);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(183, 53);
            this.btnSalir.TabIndex = 107;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormDashBoardCitasAusentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.imgFondoGeneral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 650);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.rtbInterpretacion);
            this.Controls.Add(this.chartAusencias);
            this.Controls.Add(this.txtAnchoBarra);
            this.Controls.Add(this.cbOrdenarPor);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.MaximumSize = new System.Drawing.Size(1192, 697);
            this.MinimumSize = new System.Drawing.Size(1192, 697);
            this.Name = "FormDashBoardCitasAusentes";
            this.Text = "FormDashBoardCitasAusentes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartAusencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.ComboBox cbOrdenarPor;
        private System.Windows.Forms.TextBox txtAnchoBarra;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAusencias;
        private System.Windows.Forms.RichTextBox rtbInterpretacion;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSalir;
    }
}