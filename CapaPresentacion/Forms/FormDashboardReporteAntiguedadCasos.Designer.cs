namespace CapaPresentacion.Forms
{
    partial class FormDashboardReporteAntiguedadCasos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgCasos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalCasos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCasosCriticos = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblPromedioAntiguedad = new System.Windows.Forms.Label();
            this.titleAreaCasosCriticos = new System.Windows.Forms.Label();
            this.lblAreaCritica = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.lblTituloGrafico = new System.Windows.Forms.Label();
            this.gbCriteriosAntiguedad = new System.Windows.Forms.GroupBox();
            this.lblCriterioCritico = new System.Windows.Forms.Label();
            this.lblCriterioSeguimiento = new System.Windows.Forms.Label();
            this.lblCriterioReciente = new System.Windows.Forms.Label();
            this.pnlSeguimiento = new System.Windows.Forms.Panel();
            this.pnlCrítico = new System.Windows.Forms.Panel();
            this.pnlReciente = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chartAntiguedad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgCasos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbCriteriosAntiguedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAntiguedad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detecta qué áreas tienen más casos atrasados y cuáles deben atenderse primero.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 32);
            this.label3.TabIndex = 61;
            this.label3.Text = " Reporte de antiguedad de casos por áreas";
            // 
            // dgCasos
            // 
            this.dgCasos.AllowUserToAddRows = false;
            this.dgCasos.AllowUserToDeleteRows = false;
            this.dgCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCasos.Location = new System.Drawing.Point(12, 430);
            this.dgCasos.MultiSelect = false;
            this.dgCasos.Name = "dgCasos";
            this.dgCasos.ReadOnly = true;
            this.dgCasos.RowHeadersVisible = false;
            this.dgCasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCasos.Size = new System.Drawing.Size(575, 237);
            this.dgCasos.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.cbArea);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(27, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 109);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(5, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 103;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(5, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 102;
            this.label9.Text = "Área:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Todos",
            "Abierto",
            "En proceso"});
            this.cbEstado.Location = new System.Drawing.Point(69, 63);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(174, 25);
            this.cbEstado.TabIndex = 1;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // cbArea
            // 
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "Todas las áreas",
            "Familiar",
            "Civil",
            "Judicial",
            "Conciliación"});
            this.cbArea.Location = new System.Drawing.Point(69, 32);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(174, 25);
            this.cbArea.TabIndex = 0;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 86;
            this.label4.Text = "Total de casos abiertos:";
            // 
            // lblTotalCasos
            // 
            this.lblTotalCasos.AutoSize = true;
            this.lblTotalCasos.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.lblTotalCasos.Location = new System.Drawing.Point(71, 117);
            this.lblTotalCasos.Name = "lblTotalCasos";
            this.lblTotalCasos.Size = new System.Drawing.Size(12, 15);
            this.lblTotalCasos.TabIndex = 87;
            this.lblTotalCasos.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.label5.Location = new System.Drawing.Point(196, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 88;
            this.label5.Text = "Casos críticos:";
            // 
            // lblCasosCriticos
            // 
            this.lblCasosCriticos.AutoSize = true;
            this.lblCasosCriticos.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.lblCasosCriticos.Location = new System.Drawing.Point(228, 117);
            this.lblCasosCriticos.Name = "lblCasosCriticos";
            this.lblCasosCriticos.Size = new System.Drawing.Size(12, 15);
            this.lblCasosCriticos.TabIndex = 89;
            this.lblCasosCriticos.Text = "-";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.label.Location = new System.Drawing.Point(341, 98);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(141, 15);
            this.label.TabIndex = 90;
            this.label.Text = "Promedio de antiguedad:";
            // 
            // lblPromedioAntiguedad
            // 
            this.lblPromedioAntiguedad.AutoSize = true;
            this.lblPromedioAntiguedad.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.lblPromedioAntiguedad.Location = new System.Drawing.Point(390, 117);
            this.lblPromedioAntiguedad.Name = "lblPromedioAntiguedad";
            this.lblPromedioAntiguedad.Size = new System.Drawing.Size(12, 15);
            this.lblPromedioAntiguedad.TabIndex = 91;
            this.lblPromedioAntiguedad.Text = "-";
            // 
            // titleAreaCasosCriticos
            // 
            this.titleAreaCasosCriticos.AutoSize = true;
            this.titleAreaCasosCriticos.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.titleAreaCasosCriticos.Location = new System.Drawing.Point(533, 98);
            this.titleAreaCasosCriticos.Name = "titleAreaCasosCriticos";
            this.titleAreaCasosCriticos.Size = new System.Drawing.Size(155, 15);
            this.titleAreaCasosCriticos.TabIndex = 92;
            this.titleAreaCasosCriticos.Text = "Área con más casos críticos:";
            // 
            // lblAreaCritica
            // 
            this.lblAreaCritica.AutoSize = true;
            this.lblAreaCritica.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.lblAreaCritica.Location = new System.Drawing.Point(534, 117);
            this.lblAreaCritica.Name = "lblAreaCritica";
            this.lblAreaCritica.Size = new System.Drawing.Size(12, 15);
            this.lblAreaCritica.TabIndex = 93;
            this.lblAreaCritica.Text = "-";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(592, 501);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 43);
            this.btnLimpiar.TabIndex = 95;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(633, 11);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 41);
            this.btnSalir.TabIndex = 96;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.BackColor = System.Drawing.Color.Maroon;
            this.btnExportarPDF.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportarPDF.Location = new System.Drawing.Point(592, 548);
            this.btnExportarPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(119, 43);
            this.btnExportarPDF.TabIndex = 97;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = false;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // lblTituloGrafico
            // 
            this.lblTituloGrafico.AutoSize = true;
            this.lblTituloGrafico.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloGrafico.Location = new System.Drawing.Point(320, 138);
            this.lblTituloGrafico.Name = "lblTituloGrafico";
            this.lblTituloGrafico.Size = new System.Drawing.Size(335, 21);
            this.lblTituloGrafico.TabIndex = 98;
            this.lblTituloGrafico.Text = "Distribución de casos según su antigüedad";
            // 
            // gbCriteriosAntiguedad
            // 
            this.gbCriteriosAntiguedad.Controls.Add(this.lblCriterioCritico);
            this.gbCriteriosAntiguedad.Controls.Add(this.lblCriterioSeguimiento);
            this.gbCriteriosAntiguedad.Controls.Add(this.lblCriterioReciente);
            this.gbCriteriosAntiguedad.Controls.Add(this.pnlSeguimiento);
            this.gbCriteriosAntiguedad.Controls.Add(this.pnlCrítico);
            this.gbCriteriosAntiguedad.Controls.Add(this.pnlReciente);
            this.gbCriteriosAntiguedad.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.gbCriteriosAntiguedad.Location = new System.Drawing.Point(27, 271);
            this.gbCriteriosAntiguedad.Name = "gbCriteriosAntiguedad";
            this.gbCriteriosAntiguedad.Size = new System.Drawing.Size(251, 141);
            this.gbCriteriosAntiguedad.TabIndex = 99;
            this.gbCriteriosAntiguedad.TabStop = false;
            this.gbCriteriosAntiguedad.Text = "Criterios de antiguedad:";
            // 
            // lblCriterioCritico
            // 
            this.lblCriterioCritico.AutoSize = true;
            this.lblCriterioCritico.Location = new System.Drawing.Point(39, 97);
            this.lblCriterioCritico.Name = "lblCriterioCritico";
            this.lblCriterioCritico.Size = new System.Drawing.Size(147, 19);
            this.lblCriterioCritico.TabIndex = 4;
            this.lblCriterioCritico.Text = "Crítico: más de 30 días";
            // 
            // lblCriterioSeguimiento
            // 
            this.lblCriterioSeguimiento.AutoSize = true;
            this.lblCriterioSeguimiento.Location = new System.Drawing.Point(39, 63);
            this.lblCriterioSeguimiento.Name = "lblCriterioSeguimiento";
            this.lblCriterioSeguimiento.Size = new System.Drawing.Size(204, 19);
            this.lblCriterioSeguimiento.TabIndex = 3;
            this.lblCriterioSeguimiento.Text = "En seguimiento: de 16 a 30 días";
            // 
            // lblCriterioReciente
            // 
            this.lblCriterioReciente.AutoSize = true;
            this.lblCriterioReciente.Location = new System.Drawing.Point(39, 28);
            this.lblCriterioReciente.Name = "lblCriterioReciente";
            this.lblCriterioReciente.Size = new System.Drawing.Size(153, 19);
            this.lblCriterioReciente.TabIndex = 2;
            this.lblCriterioReciente.Text = "Reciente: de 0 a 15 días";
            // 
            // pnlSeguimiento
            // 
            this.pnlSeguimiento.BackColor = System.Drawing.Color.Yellow;
            this.pnlSeguimiento.Location = new System.Drawing.Point(15, 63);
            this.pnlSeguimiento.Name = "pnlSeguimiento";
            this.pnlSeguimiento.Size = new System.Drawing.Size(18, 18);
            this.pnlSeguimiento.TabIndex = 1;
            // 
            // pnlCrítico
            // 
            this.pnlCrítico.BackColor = System.Drawing.Color.Red;
            this.pnlCrítico.Location = new System.Drawing.Point(15, 98);
            this.pnlCrítico.Name = "pnlCrítico";
            this.pnlCrítico.Size = new System.Drawing.Size(18, 18);
            this.pnlCrítico.TabIndex = 1;
            // 
            // pnlReciente
            // 
            this.pnlReciente.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlReciente.Location = new System.Drawing.Point(15, 28);
            this.pnlReciente.Name = "pnlReciente";
            this.pnlReciente.Size = new System.Drawing.Size(18, 18);
            this.pnlReciente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(23, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(675, 1);
            this.label2.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(23, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(675, 1);
            this.label7.TabIndex = 101;
            // 
            // chartAntiguedad
            // 
            this.chartAntiguedad.BorderlineColor = System.Drawing.Color.LightGray;
            this.chartAntiguedad.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.Title = "Áreas";
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Cantidad de casos";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 66F;
            chartArea1.InnerPlotPosition.Width = 77F;
            chartArea1.InnerPlotPosition.X = 18F;
            chartArea1.InnerPlotPosition.Y = 10F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chartAntiguedad.ChartAreas.Add(chartArea1);
            this.chartAntiguedad.Location = new System.Drawing.Point(283, 168);
            this.chartAntiguedad.Margin = new System.Windows.Forms.Padding(2);
            this.chartAntiguedad.Name = "chartAntiguedad";
            this.chartAntiguedad.Size = new System.Drawing.Size(419, 243);
            this.chartAntiguedad.TabIndex = 94;
            this.chartAntiguedad.TabStop = false;
            this.chartAntiguedad.Text = "chart1";
            this.chartAntiguedad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartAntiguedad_MouseClick);
            this.chartAntiguedad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartAntiguedad_MouseMove);
            // 
            // FormDashboardReporteAntiguedadCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 679);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbCriteriosAntiguedad);
            this.Controls.Add(this.lblTituloGrafico);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.chartAntiguedad);
            this.Controls.Add(this.lblAreaCritica);
            this.Controls.Add(this.titleAreaCasosCriticos);
            this.Controls.Add(this.lblPromedioAntiguedad);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblCasosCriticos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalCasos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgCasos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboardReporteAntiguedadCasos";
            this.Text = "FormDashboardAntiguedadCasos";
            ((System.ComponentModel.ISupportInitialize)(this.dgCasos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCriteriosAntiguedad.ResumeLayout(false);
            this.gbCriteriosAntiguedad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAntiguedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgCasos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalCasos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCasosCriticos;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblPromedioAntiguedad;
        private System.Windows.Forms.Label titleAreaCasosCriticos;
        private System.Windows.Forms.Label lblAreaCritica;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTituloGrafico;
        private System.Windows.Forms.GroupBox gbCriteriosAntiguedad;
        private System.Windows.Forms.Panel pnlSeguimiento;
        private System.Windows.Forms.Panel pnlCrítico;
        private System.Windows.Forms.Panel pnlReciente;
        private System.Windows.Forms.Label lblCriterioCritico;
        private System.Windows.Forms.Label lblCriterioSeguimiento;
        private System.Windows.Forms.Label lblCriterioReciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartAntiguedad;
    }
}