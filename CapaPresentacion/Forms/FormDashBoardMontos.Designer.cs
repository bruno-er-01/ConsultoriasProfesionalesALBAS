namespace CapaPresentacion.Forms
{
    partial class FormDashBoardMontos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnExpoPDF = new System.Windows.Forms.Button();
            this.dgReportes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInterpretacion = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMesMejorMonto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblModalidadMayorDemanda = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCitas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbOrden = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbModalidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbAreaAtencion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctMontoscitas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPieModalidadMontos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctMontoscitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieModalidadMontos)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Maroon;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(39, 153);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(165, 70);
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(209, 153);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(165, 70);
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
            this.btnExpoPDF.Location = new System.Drawing.Point(380, 153);
            this.btnExpoPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExpoPDF.Name = "btnExpoPDF";
            this.btnExpoPDF.Size = new System.Drawing.Size(165, 70);
            this.btnExpoPDF.TabIndex = 107;
            this.btnExpoPDF.Text = "Exportar PDF";
            this.btnExpoPDF.UseVisualStyleBackColor = false;
            this.btnExpoPDF.Click += new System.EventHandler(this.btnExpoPDF_Click);
            // 
            // dgReportes
            // 
            this.dgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportes.Location = new System.Drawing.Point(44, 228);
            this.dgReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgReportes.Name = "dgReportes";
            this.dgReportes.RowHeadersWidth = 51;
            this.dgReportes.RowTemplate.Height = 24;
            this.dgReportes.Size = new System.Drawing.Size(667, 281);
            this.dgReportes.TabIndex = 106;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.lblInterpretacion);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(51, 358);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(852, 135);
            this.panel4.TabIndex = 102;
            // 
            // lblInterpretacion
            // 
            this.lblInterpretacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterpretacion.Location = new System.Drawing.Point(23, 39);
            this.lblInterpretacion.Name = "lblInterpretacion";
            this.lblInterpretacion.Size = new System.Drawing.Size(815, 76);
            this.lblInterpretacion.TabIndex = 2;
            this.lblInterpretacion.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Interpretación:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.lblMesMejorMonto);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(1049, 826);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 46);
            this.panel3.TabIndex = 101;
            // 
            // lblMesMejorMonto
            // 
            this.lblMesMejorMonto.AutoSize = true;
            this.lblMesMejorMonto.Location = new System.Drawing.Point(236, 16);
            this.lblMesMejorMonto.Name = "lblMesMejorMonto";
            this.lblMesMejorMonto.Size = new System.Drawing.Size(11, 16);
            this.lblMesMejorMonto.TabIndex = 1;
            this.lblMesMejorMonto.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mes con mejor monto recaudado:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.lblModalidadMayorDemanda);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(816, 766);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 46);
            this.panel2.TabIndex = 100;
            // 
            // lblModalidadMayorDemanda
            // 
            this.lblModalidadMayorDemanda.AutoSize = true;
            this.lblModalidadMayorDemanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidadMayorDemanda.Location = new System.Drawing.Point(335, 17);
            this.lblModalidadMayorDemanda.Name = "lblModalidadMayorDemanda";
            this.lblModalidadMayorDemanda.Size = new System.Drawing.Size(15, 20);
            this.lblModalidadMayorDemanda.TabIndex = 1;
            this.lblModalidadMayorDemanda.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(274, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Modalidad con mayor demanda es: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.lblTotalCitas);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(1283, 766);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 46);
            this.panel1.TabIndex = 99;
            // 
            // lblTotalCitas
            // 
            this.lblTotalCitas.AutoSize = true;
            this.lblTotalCitas.Location = new System.Drawing.Point(149, 16);
            this.lblTotalCitas.Name = "lblTotalCitas";
            this.lblTotalCitas.Size = new System.Drawing.Size(11, 16);
            this.lblTotalCitas.TabIndex = 1;
            this.lblTotalCitas.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total de citas: ";
            // 
            // cbOrden
            // 
            this.cbOrden.FormattingEnabled = true;
            this.cbOrden.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cbOrden.Location = new System.Drawing.Point(1151, 18);
            this.cbOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrden.Name = "cbOrden";
            this.cbOrden.Size = new System.Drawing.Size(121, 24);
            this.cbOrden.TabIndex = 98;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1020, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 97;
            this.label9.Text = "Ordenar Por:";
            // 
            // cbModalidad
            // 
            this.cbModalidad.FormattingEnabled = true;
            this.cbModalidad.Items.AddRange(new object[] {
            "Presencial",
            "Virtual"});
            this.cbModalidad.Location = new System.Drawing.Point(884, 17);
            this.cbModalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbModalidad.Name = "cbModalidad";
            this.cbModalidad.Size = new System.Drawing.Size(121, 24);
            this.cbModalidad.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(773, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 92;
            this.label7.Text = "Modalidad:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(312, 20);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaFin.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 23);
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
            this.dtpFechaInicio.Location = new System.Drawing.Point(105, 21);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaInicio.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 52);
            this.label5.TabIndex = 87;
            this.label5.Text = "Distribución del monto total generado \r\n          según modalidad de cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(29, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 50);
            this.label2.TabIndex = 85;
            this.label2.Text = " Reporte de montos recaudados ";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1557, 23);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 60);
            this.btnSalir.TabIndex = 84;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cbAreaAtencion);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cbModalidad);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.cbOrden);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.dtpFechaFin);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.dtpFechaInicio);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(195, 82);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1293, 64);
            this.panel5.TabIndex = 110;
            // 
            // cbAreaAtencion
            // 
            this.cbAreaAtencion.FormattingEnabled = true;
            this.cbAreaAtencion.Items.AddRange(new object[] {
            "Todos"});
            this.cbAreaAtencion.Location = new System.Drawing.Point(645, 20);
            this.cbAreaAtencion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAreaAtencion.Name = "cbAreaAtencion";
            this.cbAreaAtencion.Size = new System.Drawing.Size(121, 24);
            this.cbAreaAtencion.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "Area de atención:";
            // 
            // ctMontoscitas
            // 
            chartArea3.Name = "ChartArea1";
            this.ctMontoscitas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ctMontoscitas.Legends.Add(legend3);
            this.ctMontoscitas.Location = new System.Drawing.Point(59, 54);
            this.ctMontoscitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctMontoscitas.Name = "ctMontoscitas";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ctMontoscitas.Series.Add(series3);
            this.ctMontoscitas.Size = new System.Drawing.Size(829, 300);
            this.ctMontoscitas.TabIndex = 111;
            this.ctMontoscitas.Text = "chart1";
            // 
            // chartPieModalidadMontos
            // 
            this.chartPieModalidadMontos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            chartArea4.Name = "ChartArea1";
            this.chartPieModalidadMontos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPieModalidadMontos.Legends.Add(legend4);
            this.chartPieModalidadMontos.Location = new System.Drawing.Point(11, 66);
            this.chartPieModalidadMontos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartPieModalidadMontos.Name = "chartPieModalidadMontos";
            this.chartPieModalidadMontos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPieModalidadMontos.Series.Add(series4);
            this.chartPieModalidadMontos.Size = new System.Drawing.Size(635, 329);
            this.chartPieModalidadMontos.TabIndex = 112;
            this.chartPieModalidadMontos.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.chartPieModalidadMontos);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(45, 529);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(665, 402);
            this.panel6.TabIndex = 113;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.ctMontoscitas);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Location = new System.Drawing.Point(737, 219);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(962, 516);
            this.panel7.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 26);
            this.label1.TabIndex = 87;
            this.label1.Text = "Evolución de ingresos según modalidad de cita en un periodo determinado";
            // 
            // FormDashBoardMontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.imgFondoGeneral;
            this.ClientSize = new System.Drawing.Size(1740, 934);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnExpoPDF);
            this.Controls.Add(this.dgReportes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1758, 981);
            this.MinimumSize = new System.Drawing.Size(1758, 981);
            this.Name = "FormDashBoardMontos";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctMontoscitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieModalidadMontos)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnExpoPDF;
        private System.Windows.Forms.DataGridView dgReportes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInterpretacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMesMejorMonto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblModalidadMayorDemanda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalCitas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbModalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbAreaAtencion;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataVisualization.Charting.Chart ctMontoscitas;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartPieModalidadMontos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
    }
}