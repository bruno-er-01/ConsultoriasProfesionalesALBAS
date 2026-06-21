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
            this.btnDashBoardIngresoCitas = new System.Windows.Forms.Button();
            this.btnDashBoardClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenuReportes = new System.Windows.Forms.Panel();
            this.btnReporteAreasCasos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDashBoardIngresoCitas
            // 
            this.btnDashBoardIngresoCitas.BackColor = System.Drawing.Color.Maroon;
            this.btnDashBoardIngresoCitas.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashBoardIngresoCitas.ForeColor = System.Drawing.Color.White;
            this.btnDashBoardIngresoCitas.Location = new System.Drawing.Point(305, 73);
            this.btnDashBoardIngresoCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashBoardIngresoCitas.Name = "btnDashBoardIngresoCitas";
            this.btnDashBoardIngresoCitas.Size = new System.Drawing.Size(252, 74);
            this.btnDashBoardIngresoCitas.TabIndex = 6;
            this.btnDashBoardIngresoCitas.Text = "Dashboard de ingreso de citas";
            this.btnDashBoardIngresoCitas.UseVisualStyleBackColor = false;
            // 
            // btnDashBoardClientes
            // 
            this.btnDashBoardClientes.BackColor = System.Drawing.Color.Maroon;
            this.btnDashBoardClientes.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashBoardClientes.ForeColor = System.Drawing.Color.White;
            this.btnDashBoardClientes.Location = new System.Drawing.Point(563, 73);
            this.btnDashBoardClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashBoardClientes.Name = "btnDashBoardClientes";
            this.btnDashBoardClientes.Size = new System.Drawing.Size(252, 74);
            this.btnDashBoardClientes.TabIndex = 7;
            this.btnDashBoardClientes.Text = "Dashboard de clientes";
            this.btnDashBoardClientes.UseVisualStyleBackColor = false;
            this.btnDashBoardClientes.Click += new System.EventHandler(this.btnDashBoardClientes_Click);
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
            this.pnlMenuReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenuReportes.Name = "pnlMenuReportes";
            this.pnlMenuReportes.Size = new System.Drawing.Size(1163, 646);
            this.pnlMenuReportes.TabIndex = 10;
            // 
            // btnReporteAreasCasos
            // 
            this.btnReporteAreasCasos.BackColor = System.Drawing.Color.Maroon;
            this.btnReporteAreasCasos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReporteAreasCasos.ForeColor = System.Drawing.Color.White;
            this.btnReporteAreasCasos.Location = new System.Drawing.Point(38, 73);
            this.btnReporteAreasCasos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteAreasCasos.Name = "btnReporteAreasCasos";
            this.btnReporteAreasCasos.Size = new System.Drawing.Size(252, 74);
            this.btnReporteAreasCasos.TabIndex = 11;
            this.btnReporteAreasCasos.Text = "Dashboard de Casos Por Área";
            this.btnReporteAreasCasos.UseVisualStyleBackColor = false;
            this.btnReporteAreasCasos.Click += new System.EventHandler(this.btnReporteAreasCasos_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 814);
            this.Controls.Add(this.btnReporteAreasCasos);
            this.Controls.Add(this.pnlMenuReportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDashBoardIngresoCitas);
            this.Controls.Add(this.btnDashBoardClientes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDashBoardIngresoCitas;
        private System.Windows.Forms.Button btnDashBoardClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenuReportes;
        private System.Windows.Forms.Button btnReporteAreasCasos;
    }
}