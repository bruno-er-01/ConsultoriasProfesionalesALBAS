namespace CapaPresentacion.Forms
{
    partial class FormDashBoardReportesCitasCanceladasAusencias
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.chartPerdidas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerdidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 535);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 32);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chartPerdidas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPerdidas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPerdidas.Legends.Add(legend1);
            this.chartPerdidas.Location = new System.Drawing.Point(132, 136);
            this.chartPerdidas.Name = "chartPerdidas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPerdidas.Series.Add(series1);
            this.chartPerdidas.Size = new System.Drawing.Size(563, 300);
            this.chartPerdidas.TabIndex = 1;
            this.chartPerdidas.Text = "chart1";
            // 
            // FormDashBoardReportesCitasCanceladasAusencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 594);
            this.Controls.Add(this.chartPerdidas);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormDashBoardReportesCitasCanceladasAusencias";
            this.Text = "FormDashBoardReportesCitasCanceladasAusencias";
            ((System.ComponentModel.ISupportInitialize)(this.chartPerdidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPerdidas;
    }
}