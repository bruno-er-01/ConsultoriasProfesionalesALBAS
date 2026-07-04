namespace CapaPresentacion
{
    partial class FormReportes
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
            this.btnDashBoardAntiguedadCasosPorAreas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenuReportes = new System.Windows.Forms.Panel();
            this.btnReporteAreasCasos = new System.Windows.Forms.Button();
            this.btnReporteCargaLaboralXEspecialista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDashBoardAntiguedadCasosPorAreas
            // 
            this.btnDashBoardAntiguedadCasosPorAreas.BackColor = System.Drawing.Color.Maroon;
            this.btnDashBoardAntiguedadCasosPorAreas.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashBoardAntiguedadCasosPorAreas.ForeColor = System.Drawing.Color.White;
            this.btnDashBoardAntiguedadCasosPorAreas.Location = new System.Drawing.Point(344, 58);
            this.btnDashBoardAntiguedadCasosPorAreas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashBoardAntiguedadCasosPorAreas.Name = "btnDashBoardAntiguedadCasosPorAreas";
            this.btnDashBoardAntiguedadCasosPorAreas.Size = new System.Drawing.Size(403, 70);
            this.btnDashBoardAntiguedadCasosPorAreas.TabIndex = 6;
            this.btnDashBoardAntiguedadCasosPorAreas.Text = "Dashboard de Antiguedad  de casos por Areas";
            this.btnDashBoardAntiguedadCasosPorAreas.UseVisualStyleBackColor = false;
            this.btnDashBoardAntiguedadCasosPorAreas.Click += new System.EventHandler(this.btnDashBoardAntiguedadCasosPorAreas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reportes";
            // 
            // pnlMenuReportes
            // 
            this.pnlMenuReportes.Location = new System.Drawing.Point(0, 167);
            this.pnlMenuReportes.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuReportes.Name = "pnlMenuReportes";
            this.pnlMenuReportes.Size = new System.Drawing.Size(1163, 646);
            this.pnlMenuReportes.TabIndex = 10;
            // 
            // btnReporteAreasCasos
            // 
            this.btnReporteAreasCasos.BackColor = System.Drawing.Color.Maroon;
            this.btnReporteAreasCasos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReporteAreasCasos.ForeColor = System.Drawing.Color.White;
            this.btnReporteAreasCasos.Location = new System.Drawing.Point(30, 58);
            this.btnReporteAreasCasos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteAreasCasos.Name = "btnReporteAreasCasos";
            this.btnReporteAreasCasos.Size = new System.Drawing.Size(266, 69);
            this.btnReporteAreasCasos.TabIndex = 11;
            this.btnReporteAreasCasos.Text = "Dashboard de Casos Por Área";
            this.btnReporteAreasCasos.UseVisualStyleBackColor = false;
            this.btnReporteAreasCasos.Click += new System.EventHandler(this.btnReporteAreasCasos_Click);
            // 
            // btnReporteCargaLaboralXEspecialista
            // 
            this.btnReporteCargaLaboralXEspecialista.BackColor = System.Drawing.Color.Maroon;
            this.btnReporteCargaLaboralXEspecialista.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReporteCargaLaboralXEspecialista.ForeColor = System.Drawing.Color.White;
            this.btnReporteCargaLaboralXEspecialista.Location = new System.Drawing.Point(796, 57);
            this.btnReporteCargaLaboralXEspecialista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteCargaLaboralXEspecialista.Name = "btnReporteCargaLaboralXEspecialista";
            this.btnReporteCargaLaboralXEspecialista.Size = new System.Drawing.Size(342, 70);
            this.btnReporteCargaLaboralXEspecialista.TabIndex = 13;
            this.btnReporteCargaLaboralXEspecialista.Text = "Dashboard de carga laboral por especialista";
            this.btnReporteCargaLaboralXEspecialista.UseVisualStyleBackColor = false;
            this.btnReporteCargaLaboralXEspecialista.Click += new System.EventHandler(this.btnReporteCargaLaboralXEspecialista_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 814);
            this.Controls.Add(this.btnReporteCargaLaboralXEspecialista);
            this.Controls.Add(this.btnReporteAreasCasos);
            this.Controls.Add(this.pnlMenuReportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDashBoardAntiguedadCasosPorAreas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDashBoardAntiguedadCasosPorAreas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenuReportes;
        private System.Windows.Forms.Button btnReporteAreasCasos;
        private System.Windows.Forms.Button btnReporteCargaLaboralXEspecialista;
    }
}