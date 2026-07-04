namespace CapaPresentacion.Forms
{
    partial class FormDashboardCargaLaboralxEspecialista
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnExpoPDF = new System.Windows.Forms.Button();
            this.dgReportes = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInterpretacion = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ctAreas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEspecialistasDispo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMayorArea = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCasos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbOrden = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGrafico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctAreas)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Maroon;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(1138, 44);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(165, 48);
            this.btnGenerarReporte.TabIndex = 109;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(868, 722);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(165, 48);
            this.btnLimpiarCampos.TabIndex = 108;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // btnExpoPDF
            // 
            this.btnExpoPDF.BackColor = System.Drawing.Color.Maroon;
            this.btnExpoPDF.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpoPDF.ForeColor = System.Drawing.Color.White;
            this.btnExpoPDF.Location = new System.Drawing.Point(868, 660);
            this.btnExpoPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnExpoPDF.Name = "btnExpoPDF";
            this.btnExpoPDF.Size = new System.Drawing.Size(165, 48);
            this.btnExpoPDF.TabIndex = 107;
            this.btnExpoPDF.Text = "Exportar PDF";
            this.btnExpoPDF.UseVisualStyleBackColor = false;
            // 
            // dgReportes
            // 
            this.dgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportes.Location = new System.Drawing.Point(116, 621);
            this.dgReportes.Name = "dgReportes";
            this.dgReportes.RowHeadersWidth = 51;
            this.dgReportes.RowTemplate.Height = 24;
            this.dgReportes.Size = new System.Drawing.Size(730, 252);
            this.dgReportes.TabIndex = 106;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(133, 604);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(900, 1);
            this.label16.TabIndex = 105;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.lblInterpretacion);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(712, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 203);
            this.panel4.TabIndex = 102;
            // 
            // lblInterpretacion
            // 
            this.lblInterpretacion.Location = new System.Drawing.Point(17, 44);
            this.lblInterpretacion.Name = "lblInterpretacion";
            this.lblInterpretacion.Size = new System.Drawing.Size(227, 141);
            this.lblInterpretacion.TabIndex = 2;
            this.lblInterpretacion.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Interpretación:";
            // 
            // ctAreas
            // 
            chartArea1.Name = "ChartArea1";
            this.ctAreas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ctAreas.Legends.Add(legend1);
            this.ctAreas.Location = new System.Drawing.Point(1178, 288);
            this.ctAreas.Name = "ctAreas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ctAreas.Series.Add(series1);
            this.ctAreas.Size = new System.Drawing.Size(497, 260);
            this.ctAreas.TabIndex = 104;
            this.ctAreas.Text = "chart1";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(133, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(900, 1);
            this.label11.TabIndex = 103;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.lblEspecialistasDispo);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(712, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 45);
            this.panel3.TabIndex = 101;
            // 
            // lblEspecialistasDispo
            // 
            this.lblEspecialistasDispo.AutoSize = true;
            this.lblEspecialistasDispo.Location = new System.Drawing.Point(194, 16);
            this.lblEspecialistasDispo.Name = "lblEspecialistasDispo";
            this.lblEspecialistasDispo.Size = new System.Drawing.Size(11, 16);
            this.lblEspecialistasDispo.TabIndex = 1;
            this.lblEspecialistasDispo.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Especialistas disponibles:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.lblMayorArea);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(136, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 45);
            this.panel2.TabIndex = 100;
            // 
            // lblMayorArea
            // 
            this.lblMayorArea.AutoSize = true;
            this.lblMayorArea.Location = new System.Drawing.Point(194, 16);
            this.lblMayorArea.Name = "lblMayorArea";
            this.lblMayorArea.Size = new System.Drawing.Size(11, 16);
            this.lblMayorArea.TabIndex = 1;
            this.lblMayorArea.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Área con mayor demanda:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.lblTotalCasos);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(469, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 45);
            this.panel1.TabIndex = 99;
            // 
            // lblTotalCasos
            // 
            this.lblTotalCasos.AutoSize = true;
            this.lblTotalCasos.Location = new System.Drawing.Point(134, 16);
            this.lblTotalCasos.Name = "lblTotalCasos";
            this.lblTotalCasos.Size = new System.Drawing.Size(11, 16);
            this.lblTotalCasos.TabIndex = 1;
            this.lblTotalCasos.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total de casos: ";
            // 
            // cbOrden
            // 
            this.cbOrden.FormattingEnabled = true;
            this.cbOrden.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cbOrden.Location = new System.Drawing.Point(857, 171);
            this.cbOrden.Name = "cbOrden";
            this.cbOrden.Size = new System.Drawing.Size(121, 24);
            this.cbOrden.TabIndex = 98;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(748, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 97;
            this.label9.Text = "Ordenar Por:";
            // 
            // cbGrafico
            // 
            this.cbGrafico.FormattingEnabled = true;
            this.cbGrafico.Items.AddRange(new object[] {
            "Barras",
            "Circular"});
            this.cbGrafico.Location = new System.Drawing.Point(1259, 247);
            this.cbGrafico.Name = "cbGrafico";
            this.cbGrafico.Size = new System.Drawing.Size(163, 24);
            this.cbGrafico.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1175, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 95;
            this.label1.Text = "Gráfico:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(133, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(900, 1);
            this.label8.TabIndex = 94;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Todos"});
            this.cbEstado.Location = new System.Drawing.Point(607, 172);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(523, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 92;
            this.label7.Text = "Estado:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(395, 174);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaFin.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 90;
            this.label6.Text = "Hasta:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(199, 174);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaInicio.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(970, 35);
            this.label5.TabIndex = 87;
            this.label5.Text = "Analiza qué áreas concentran más casos y ayuda a tomar decisiones administrativas" +
    ". ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(72, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(769, 54);
            this.label2.TabIndex = 85;
            this.label2.Text = "Reporte de carga laboral por especialista";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(909, 787);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 35);
            this.btnSalir.TabIndex = 84;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // FormDashboardCargaLaboralxEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 936);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnExpoPDF);
            this.Controls.Add(this.dgReportes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ctAreas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbOrden);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbGrafico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.MaximumSize = new System.Drawing.Size(1759, 983);
            this.MinimumSize = new System.Drawing.Size(1759, 983);
            this.Name = "FormDashboardCargaLaboralxEspecialista";
            this.Text = "FormDashboardCargaLaboralxEspecialista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctAreas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnExpoPDF;
        private System.Windows.Forms.DataGridView dgReportes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInterpretacion;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.DataVisualization.Charting.Chart ctAreas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEspecialistasDispo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMayorArea;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalCasos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbGrafico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}