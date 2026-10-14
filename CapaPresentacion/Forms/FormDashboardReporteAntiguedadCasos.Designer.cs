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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detecta qué áreas tienen más casos atrasados y cuáles deben atenderse primero.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(28, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(615, 41);
            this.label3.TabIndex = 61;
            this.label3.Text = " Reporte de antiguedad de casos por áreas";
            // 
            // dgCasos
            // 
            this.dgCasos.AllowUserToAddRows = false;
            this.dgCasos.AllowUserToDeleteRows = false;
            this.dgCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCasos.Location = new System.Drawing.Point(36, 493);
            this.dgCasos.Margin = new System.Windows.Forms.Padding(4);
            this.dgCasos.MultiSelect = false;
            this.dgCasos.Name = "dgCasos";
            this.dgCasos.ReadOnly = true;
            this.dgCasos.RowHeadersVisible = false;
            this.dgCasos.RowHeadersWidth = 51;
            this.dgCasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCasos.Size = new System.Drawing.Size(769, 375);
            this.dgCasos.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.cbArea);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 227);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(370, 226);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(7, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 103;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
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
            this.cbEstado.Location = new System.Drawing.Point(92, 78);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(231, 36);
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
            this.cbArea.Location = new System.Drawing.Point(92, 39);
            this.cbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(231, 36);
            this.cbArea.TabIndex = 0;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 28);
            this.label4.TabIndex = 86;
            this.label4.Text = "Total de casos abiertos:";
            // 
            // lblTotalCasos
            // 
            this.lblTotalCasos.AutoSize = true;
            this.lblTotalCasos.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCasos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCasos.Location = new System.Drawing.Point(306, 125);
            this.lblTotalCasos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCasos.Name = "lblTotalCasos";
            this.lblTotalCasos.Size = new System.Drawing.Size(20, 28);
            this.lblTotalCasos.TabIndex = 87;
            this.lblTotalCasos.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 88;
            this.label5.Text = "Casos críticos:";
            // 
            // lblCasosCriticos
            // 
            this.lblCasosCriticos.AutoSize = true;
            this.lblCasosCriticos.BackColor = System.Drawing.Color.Transparent;
            this.lblCasosCriticos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasosCriticos.Location = new System.Drawing.Point(558, 125);
            this.lblCasosCriticos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCasosCriticos.Name = "lblCasosCriticos";
            this.lblCasosCriticos.Size = new System.Drawing.Size(20, 28);
            this.lblCasosCriticos.TabIndex = 89;
            this.lblCasosCriticos.Text = "-";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(682, 125);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(234, 28);
            this.label.TabIndex = 90;
            this.label.Text = "Promedio de antiguedad:";
            // 
            // lblPromedioAntiguedad
            // 
            this.lblPromedioAntiguedad.AutoSize = true;
            this.lblPromedioAntiguedad.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedioAntiguedad.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioAntiguedad.Location = new System.Drawing.Point(924, 125);
            this.lblPromedioAntiguedad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioAntiguedad.Name = "lblPromedioAntiguedad";
            this.lblPromedioAntiguedad.Size = new System.Drawing.Size(20, 28);
            this.lblPromedioAntiguedad.TabIndex = 91;
            this.lblPromedioAntiguedad.Text = "-";
            // 
            // titleAreaCasosCriticos
            // 
            this.titleAreaCasosCriticos.AutoSize = true;
            this.titleAreaCasosCriticos.BackColor = System.Drawing.Color.Transparent;
            this.titleAreaCasosCriticos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAreaCasosCriticos.Location = new System.Drawing.Point(1088, 125);
            this.titleAreaCasosCriticos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleAreaCasosCriticos.Name = "titleAreaCasosCriticos";
            this.titleAreaCasosCriticos.Size = new System.Drawing.Size(252, 28);
            this.titleAreaCasosCriticos.TabIndex = 92;
            this.titleAreaCasosCriticos.Text = "Área con más casos críticos:";
            // 
            // lblAreaCritica
            // 
            this.lblAreaCritica.AutoSize = true;
            this.lblAreaCritica.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaCritica.Location = new System.Drawing.Point(1365, 125);
            this.lblAreaCritica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaCritica.Name = "lblAreaCritica";
            this.lblAreaCritica.Size = new System.Drawing.Size(20, 28);
            this.lblAreaCritica.TabIndex = 93;
            this.lblAreaCritica.Text = "-";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(1010, 745);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(159, 53);
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
            this.btnSalir.Location = new System.Drawing.Point(1371, 16);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 50);
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
            this.btnExportarPDF.Location = new System.Drawing.Point(1199, 745);
            this.btnExportarPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(159, 53);
            this.btnExportarPDF.TabIndex = 97;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = false;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // lblTituloGrafico
            // 
            this.lblTituloGrafico.AutoSize = true;
            this.lblTituloGrafico.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloGrafico.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloGrafico.Location = new System.Drawing.Point(947, 268);
            this.lblTituloGrafico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloGrafico.Name = "lblTituloGrafico";
            this.lblTituloGrafico.Size = new System.Drawing.Size(411, 28);
            this.lblTituloGrafico.TabIndex = 98;
            this.lblTituloGrafico.Text = "Distribución de casos según su antigüedad";
            // 
            // gbCriteriosAntiguedad
            // 
            this.gbCriteriosAntiguedad.BackColor = System.Drawing.Color.Transparent;
            this.gbCriteriosAntiguedad.Controls.Add(this.lblCriterioCritico);
            this.gbCriteriosAntiguedad.Controls.Add(this.lblCriterioSeguimiento);
            this.gbCriteriosAntiguedad.Controls.Add(this.lblCriterioReciente);
            this.gbCriteriosAntiguedad.Controls.Add(this.pnlSeguimiento);
            this.gbCriteriosAntiguedad.Controls.Add(this.pnlCrítico);
            this.gbCriteriosAntiguedad.Controls.Add(this.pnlReciente);
            this.gbCriteriosAntiguedad.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCriteriosAntiguedad.Location = new System.Drawing.Point(442, 242);
            this.gbCriteriosAntiguedad.Margin = new System.Windows.Forms.Padding(4);
            this.gbCriteriosAntiguedad.Name = "gbCriteriosAntiguedad";
            this.gbCriteriosAntiguedad.Padding = new System.Windows.Forms.Padding(4);
            this.gbCriteriosAntiguedad.Size = new System.Drawing.Size(363, 211);
            this.gbCriteriosAntiguedad.TabIndex = 99;
            this.gbCriteriosAntiguedad.TabStop = false;
            this.gbCriteriosAntiguedad.Text = "Criterios de antiguedad:";
            // 
            // lblCriterioCritico
            // 
            this.lblCriterioCritico.AutoSize = true;
            this.lblCriterioCritico.Location = new System.Drawing.Point(52, 119);
            this.lblCriterioCritico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterioCritico.Name = "lblCriterioCritico";
            this.lblCriterioCritico.Size = new System.Drawing.Size(207, 28);
            this.lblCriterioCritico.TabIndex = 4;
            this.lblCriterioCritico.Text = "Crítico: más de 30 días";
            // 
            // lblCriterioSeguimiento
            // 
            this.lblCriterioSeguimiento.AutoSize = true;
            this.lblCriterioSeguimiento.Location = new System.Drawing.Point(52, 78);
            this.lblCriterioSeguimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterioSeguimiento.Name = "lblCriterioSeguimiento";
            this.lblCriterioSeguimiento.Size = new System.Drawing.Size(286, 28);
            this.lblCriterioSeguimiento.TabIndex = 3;
            this.lblCriterioSeguimiento.Text = "En seguimiento: de 16 a 30 días";
            // 
            // lblCriterioReciente
            // 
            this.lblCriterioReciente.AutoSize = true;
            this.lblCriterioReciente.Location = new System.Drawing.Point(52, 34);
            this.lblCriterioReciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterioReciente.Name = "lblCriterioReciente";
            this.lblCriterioReciente.Size = new System.Drawing.Size(215, 28);
            this.lblCriterioReciente.TabIndex = 2;
            this.lblCriterioReciente.Text = "Reciente: de 0 a 15 días";
            // 
            // pnlSeguimiento
            // 
            this.pnlSeguimiento.BackColor = System.Drawing.Color.Yellow;
            this.pnlSeguimiento.Location = new System.Drawing.Point(20, 78);
            this.pnlSeguimiento.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSeguimiento.Name = "pnlSeguimiento";
            this.pnlSeguimiento.Size = new System.Drawing.Size(24, 22);
            this.pnlSeguimiento.TabIndex = 1;
            // 
            // pnlCrítico
            // 
            this.pnlCrítico.BackColor = System.Drawing.Color.Red;
            this.pnlCrítico.Location = new System.Drawing.Point(20, 121);
            this.pnlCrítico.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCrítico.Name = "pnlCrítico";
            this.pnlCrítico.Size = new System.Drawing.Size(24, 22);
            this.pnlCrítico.TabIndex = 1;
            // 
            // pnlReciente
            // 
            this.pnlReciente.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlReciente.Location = new System.Drawing.Point(20, 34);
            this.pnlReciente.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReciente.Name = "pnlReciente";
            this.pnlReciente.Size = new System.Drawing.Size(24, 22);
            this.pnlReciente.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.GrayText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1414, 1);
            this.label7.TabIndex = 101;
            // 
            // chartAntiguedad
            // 
            this.chartAntiguedad.BorderlineColor = System.Drawing.Color.LightGray;
            this.chartAntiguedad.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.Title = "Áreas";
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Cantidad de casos";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 66F;
            chartArea3.InnerPlotPosition.Width = 77F;
            chartArea3.InnerPlotPosition.X = 18F;
            chartArea3.InnerPlotPosition.Y = 10F;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 100F;
            chartArea3.Position.Width = 100F;
            this.chartAntiguedad.ChartAreas.Add(chartArea3);
            this.chartAntiguedad.Location = new System.Drawing.Point(840, 305);
            this.chartAntiguedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartAntiguedad.Name = "chartAntiguedad";
            this.chartAntiguedad.Size = new System.Drawing.Size(616, 352);
            this.chartAntiguedad.TabIndex = 94;
            this.chartAntiguedad.TabStop = false;
            this.chartAntiguedad.Text = "chart1";
            this.chartAntiguedad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartAntiguedad_MouseClick);
            this.chartAntiguedad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartAntiguedad_MouseMove);
            // 
            // FormDashboardReporteAntiguedadCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.imgFondoGeneral;
            this.ClientSize = new System.Drawing.Size(1501, 891);
            this.Controls.Add(this.label7);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1519, 938);
            this.MinimumSize = new System.Drawing.Size(1519, 938);
            this.Name = "FormDashboardReporteAntiguedadCasos";
            this.Text = "FormDashboardAntiguedadCasos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartAntiguedad;
    }
}