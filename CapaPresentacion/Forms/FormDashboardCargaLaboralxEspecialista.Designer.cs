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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnExpoPDF = new System.Windows.Forms.Button();
            this.dgReportes = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInterpretacion = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ctCasos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumEspecialista = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCasos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbOrden = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGrafico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblEspecialistaSaturado = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctCasos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Maroon;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(1077, 44);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(165, 48);
            this.btnGenerarReporte.TabIndex = 109;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(1432, 44);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(165, 48);
            this.btnLimpiarCampos.TabIndex = 108;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnExpoPDF
            // 
            this.btnExpoPDF.BackColor = System.Drawing.Color.Maroon;
            this.btnExpoPDF.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpoPDF.ForeColor = System.Drawing.Color.White;
            this.btnExpoPDF.Location = new System.Drawing.Point(1255, 44);
            this.btnExpoPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnExpoPDF.Name = "btnExpoPDF";
            this.btnExpoPDF.Size = new System.Drawing.Size(165, 48);
            this.btnExpoPDF.TabIndex = 107;
            this.btnExpoPDF.Text = "Exportar PDF";
            this.btnExpoPDF.UseVisualStyleBackColor = false;
            this.btnExpoPDF.Click += new System.EventHandler(this.btnExpoPDF_Click);
            // 
            // dgReportes
            // 
            this.dgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportes.Location = new System.Drawing.Point(116, 454);
            this.dgReportes.Name = "dgReportes";
            this.dgReportes.RowHeadersWidth = 51;
            this.dgReportes.RowTemplate.Height = 24;
            this.dgReportes.Size = new System.Drawing.Size(793, 421);
            this.dgReportes.TabIndex = 106;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(115, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(900, 1);
            this.label16.TabIndex = 105;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.lblInterpretacion);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(1077, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(628, 246);
            this.panel4.TabIndex = 102;
            // 
            // lblInterpretacion
            // 
            this.lblInterpretacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterpretacion.Location = new System.Drawing.Point(17, 49);
            this.lblInterpretacion.Name = "lblInterpretacion";
            this.lblInterpretacion.Size = new System.Drawing.Size(590, 171);
            this.lblInterpretacion.TabIndex = 2;
            this.lblInterpretacion.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Interpretación:";
            // 
            // ctCasos
            // 
            chartArea6.Name = "ChartArea1";
            this.ctCasos.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ctCasos.Legends.Add(legend6);
            this.ctCasos.Location = new System.Drawing.Point(942, 454);
            this.ctCasos.Name = "ctCasos";
            this.ctCasos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.ctCasos.Series.Add(series6);
            this.ctCasos.Size = new System.Drawing.Size(763, 421);
            this.ctCasos.TabIndex = 104;
            this.ctCasos.Text = "chartCasos";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(113, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(900, 1);
            this.label11.TabIndex = 103;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.lblNumEspecialista);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(545, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 45);
            this.panel3.TabIndex = 101;
            // 
            // lblNumEspecialista
            // 
            this.lblNumEspecialista.AutoSize = true;
            this.lblNumEspecialista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEspecialista.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumEspecialista.Location = new System.Drawing.Point(276, 13);
            this.lblNumEspecialista.Name = "lblNumEspecialista";
            this.lblNumEspecialista.Size = new System.Drawing.Size(16, 20);
            this.lblNumEspecialista.TabIndex = 1;
            this.lblNumEspecialista.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(13, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Número de especialistas:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.lblTotalCasos);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(282, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 45);
            this.panel1.TabIndex = 99;
            // 
            // lblTotalCasos
            // 
            this.lblTotalCasos.AutoSize = true;
            this.lblTotalCasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCasos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalCasos.Location = new System.Drawing.Point(168, 13);
            this.lblTotalCasos.Name = "lblTotalCasos";
            this.lblTotalCasos.Size = new System.Drawing.Size(16, 20);
            this.lblTotalCasos.TabIndex = 1;
            this.lblTotalCasos.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(17, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total de casos: ";
            // 
            // cbOrden
            // 
            this.cbOrden.FormattingEnabled = true;
            this.cbOrden.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cbOrden.Location = new System.Drawing.Point(774, 225);
            this.cbOrden.Name = "cbOrden";
            this.cbOrden.Size = new System.Drawing.Size(135, 24);
            this.cbOrden.TabIndex = 98;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(649, 227);
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
            this.cbGrafico.Location = new System.Drawing.Point(1200, 398);
            this.cbGrafico.Name = "cbGrafico";
            this.cbGrafico.Size = new System.Drawing.Size(163, 24);
            this.cbGrafico.TabIndex = 96;
            this.cbGrafico.SelectedIndexChanged += new System.EventHandler(this.cbGrafico_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1116, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 95;
            this.label1.Text = "Gráfico:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(115, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(900, 1);
            this.label8.TabIndex = 94;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(510, 225);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaFin.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 225);
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
            this.dtpFechaInicio.Location = new System.Drawing.Point(314, 225);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaInicio.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(760, 35);
            this.label5.TabIndex = 87;
            this.label5.Text = "Mide la productividad individual de los especialistas o sobrecarga.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(110, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 53);
            this.label2.TabIndex = 85;
            this.label2.Text = "Reporte de carga laboral por especialista";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1612, 44);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 48);
            this.btnSalir.TabIndex = 84;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.Controls.Add(this.lblEspecialistaSaturado);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(140, 377);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(757, 45);
            this.panel5.TabIndex = 102;
            // 
            // lblEspecialistaSaturado
            // 
            this.lblEspecialistaSaturado.AutoSize = true;
            this.lblEspecialistaSaturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialistaSaturado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEspecialistaSaturado.Location = new System.Drawing.Point(407, 12);
            this.lblEspecialistaSaturado.Name = "lblEspecialistaSaturado";
            this.lblEspecialistaSaturado.Size = new System.Drawing.Size(16, 20);
            this.lblEspecialistaSaturado.TabIndex = 1;
            this.lblEspecialistaSaturado.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(14, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(264, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Especialista con mayor carga:";
            // 
            // FormDashboardCargaLaboralxEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 936);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnExpoPDF);
            this.Controls.Add(this.dgReportes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ctCasos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbOrden);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbGrafico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
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
            ((System.ComponentModel.ISupportInitialize)(this.ctCasos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        public System.Windows.Forms.DataVisualization.Charting.Chart ctCasos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumEspecialista;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalCasos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbGrafico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblEspecialistaSaturado;
        private System.Windows.Forms.Label label17;
    }
}