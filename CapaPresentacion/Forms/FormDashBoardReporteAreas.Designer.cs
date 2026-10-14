namespace CapaPresentacion
{
    partial class FormDashBoardReporteAreas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInterpretacion = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgReportes = new System.Windows.Forms.DataGridView();
            this.btnExpoPDF = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ctAreas)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // ctAreas
            // 
            chartArea3.Name = "ChartArea1";
            this.ctAreas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ctAreas.Legends.Add(legend3);
            this.ctAreas.Location = new System.Drawing.Point(77, 277);
            this.ctAreas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctAreas.Name = "ctAreas";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ctAreas.Series.Add(series3);
            this.ctAreas.Size = new System.Drawing.Size(653, 324);
            this.ctAreas.TabIndex = 78;
            this.ctAreas.Text = "chart1";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(137, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1000, 1);
            this.label11.TabIndex = 77;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.lblEspecialistasDispo);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(772, 193);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 46);
            this.panel3.TabIndex = 76;
            // 
            // lblEspecialistasDispo
            // 
            this.lblEspecialistasDispo.AutoSize = true;
            this.lblEspecialistasDispo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEspecialistasDispo.Location = new System.Drawing.Point(195, 16);
            this.lblEspecialistasDispo.Name = "lblEspecialistasDispo";
            this.lblEspecialistasDispo.Size = new System.Drawing.Size(11, 16);
            this.lblEspecialistasDispo.TabIndex = 1;
            this.lblEspecialistasDispo.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(17, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Especialistas disponibles:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.lblMayorArea);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(208, 193);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 46);
            this.panel2.TabIndex = 75;
            // 
            // lblMayorArea
            // 
            this.lblMayorArea.AutoSize = true;
            this.lblMayorArea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMayorArea.Location = new System.Drawing.Point(195, 16);
            this.lblMayorArea.Name = "lblMayorArea";
            this.lblMayorArea.Size = new System.Drawing.Size(11, 16);
            this.lblMayorArea.TabIndex = 1;
            this.lblMayorArea.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(23, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Área con mayor demanda:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lblTotalCasos);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(529, 193);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 46);
            this.panel1.TabIndex = 74;
            // 
            // lblTotalCasos
            // 
            this.lblTotalCasos.AutoSize = true;
            this.lblTotalCasos.Location = new System.Drawing.Point(133, 16);
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
            this.cbOrden.Location = new System.Drawing.Point(1001, 137);
            this.cbOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrden.Name = "cbOrden";
            this.cbOrden.Size = new System.Drawing.Size(121, 24);
            this.cbOrden.TabIndex = 73;
            this.cbOrden.SelectedIndexChanged += new System.EventHandler(this.cbOrden_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(862, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 22);
            this.label9.TabIndex = 72;
            this.label9.Text = "Ordenar Por:";
            // 
            // cbGrafico
            // 
            this.cbGrafico.FormattingEnabled = true;
            this.cbGrafico.Items.AddRange(new object[] {
            "Barras",
            "Circular"});
            this.cbGrafico.Location = new System.Drawing.Point(929, 291);
            this.cbGrafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGrafico.Name = "cbGrafico";
            this.cbGrafico.Size = new System.Drawing.Size(181, 24);
            this.cbGrafico.TabIndex = 71;
            this.cbGrafico.SelectedIndexChanged += new System.EventHandler(this.cbGrafico_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(863, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Gráfico:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(137, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1000, 1);
            this.label8.TabIndex = 69;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Todos"});
            this.cbEstado.Location = new System.Drawing.Point(707, 135);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(615, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 67;
            this.label7.Text = "Estado:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(459, 133);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaFin.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 65;
            this.label6.Text = "Hasta:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(243, 133);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaInicio.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(756, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = "Analiza qué áreas concentran más casos y ayuda a tomar decisiones administrativas" +
    ". ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(137, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1000, 1);
            this.label4.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 41);
            this.label2.TabIndex = 60;
            this.label2.Text = " Reporte de demanda por área de consultoría ";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(208, 757);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 44);
            this.btnSalir.TabIndex = 59;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.lblInterpretacion);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(769, 330);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 214);
            this.panel4.TabIndex = 76;
            // 
            // lblInterpretacion
            // 
            this.lblInterpretacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterpretacion.Location = new System.Drawing.Point(30, 52);
            this.lblInterpretacion.Name = "lblInterpretacion";
            this.lblInterpretacion.Size = new System.Drawing.Size(385, 142);
            this.lblInterpretacion.TabIndex = 2;
            this.lblInterpretacion.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Interpretación:";
            // 
            // dgReportes
            // 
            this.dgReportes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportes.Location = new System.Drawing.Point(468, 618);
            this.dgReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgReportes.Name = "dgReportes";
            this.dgReportes.RowHeadersWidth = 51;
            this.dgReportes.RowTemplate.Height = 24;
            this.dgReportes.Size = new System.Drawing.Size(812, 280);
            this.dgReportes.TabIndex = 80;
            // 
            // btnExpoPDF
            // 
            this.btnExpoPDF.BackColor = System.Drawing.Color.Maroon;
            this.btnExpoPDF.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpoPDF.ForeColor = System.Drawing.Color.White;
            this.btnExpoPDF.Location = new System.Drawing.Point(270, 686);
            this.btnExpoPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExpoPDF.Name = "btnExpoPDF";
            this.btnExpoPDF.Size = new System.Drawing.Size(165, 48);
            this.btnExpoPDF.TabIndex = 81;
            this.btnExpoPDF.Text = "Exportar PDF";
            this.btnExpoPDF.UseVisualStyleBackColor = false;
            this.btnExpoPDF.Click += new System.EventHandler(this.btnExpoPDF_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(82, 686);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(165, 48);
            this.btnLimpiarCampos.TabIndex = 82;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Maroon;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(1044, 27);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(165, 48);
            this.btnGenerarReporte.TabIndex = 83;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1316, 25);
            this.toolStrip1.TabIndex = 84;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormDashBoardReporteAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.imgFondoGeneral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1316, 908);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnExpoPDF);
            this.Controls.Add(this.dgReportes);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1334, 955);
            this.MinimumSize = new System.Drawing.Size(1334, 955);
            this.Name = "FormDashBoardReporteAreas";
            this.Text = "FormDashboardDemandaArea";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashBoardReporteAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctAreas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInterpretacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgReportes;
        private System.Windows.Forms.Button btnExpoPDF;
        private System.Windows.Forms.Button btnLimpiarCampos;
        public System.Windows.Forms.DataVisualization.Charting.Chart ctAreas;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}