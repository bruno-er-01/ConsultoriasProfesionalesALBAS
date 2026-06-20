namespace CapaPresentacion
{
    partial class FormDashBoardIngresoCitas
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
            this.pnlRegresar = new System.Windows.Forms.Panel();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clClientes = new System.Windows.Forms.MonthCalendar();
            this.btnExportarGraficoExcel = new System.Windows.Forms.Button();
            this.btnMostrarGrafico = new System.Windows.Forms.Button();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgCitas = new System.Windows.Forms.DataGridView();
            this.pnlRegresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegresar
            // 
            this.pnlRegresar.Controls.Add(this.dgCitas);
            this.pnlRegresar.Controls.Add(this.cbArea);
            this.pnlRegresar.Controls.Add(this.label1);
            this.pnlRegresar.Controls.Add(this.clClientes);
            this.pnlRegresar.Controls.Add(this.btnExportarGraficoExcel);
            this.pnlRegresar.Controls.Add(this.btnMostrarGrafico);
            this.pnlRegresar.Controls.Add(this.cbTiempo);
            this.pnlRegresar.Controls.Add(this.label3);
            this.pnlRegresar.Controls.Add(this.label2);
            this.pnlRegresar.Controls.Add(this.btnSalir);
            this.pnlRegresar.Location = new System.Drawing.Point(5, 1);
            this.pnlRegresar.Name = "pnlRegresar";
            this.pnlRegresar.Size = new System.Drawing.Size(849, 554);
            this.pnlRegresar.TabIndex = 37;
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "Civil",
            "Familia",
            "Judicial",
            "Conciliación",
            "Todas"});
            this.cbArea.Location = new System.Drawing.Point(563, 94);
            this.cbArea.Margin = new System.Windows.Forms.Padding(2);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(156, 27);
            this.cbArea.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Área:";
            // 
            // clClientes
            // 
            this.clClientes.Location = new System.Drawing.Point(27, 50);
            this.clClientes.Margin = new System.Windows.Forms.Padding(7);
            this.clClientes.MaxSelectionCount = 1;
            this.clClientes.Name = "clClientes";
            this.clClientes.TabIndex = 32;
            // 
            // btnExportarGraficoExcel
            // 
            this.btnExportarGraficoExcel.BackColor = System.Drawing.Color.Maroon;
            this.btnExportarGraficoExcel.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarGraficoExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarGraficoExcel.Location = new System.Drawing.Point(541, 163);
            this.btnExportarGraficoExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportarGraficoExcel.Name = "btnExportarGraficoExcel";
            this.btnExportarGraficoExcel.Size = new System.Drawing.Size(212, 41);
            this.btnExportarGraficoExcel.TabIndex = 31;
            this.btnExportarGraficoExcel.Text = "Exportar gráfico en Excel";
            this.btnExportarGraficoExcel.UseVisualStyleBackColor = false;
            // 
            // btnMostrarGrafico
            // 
            this.btnMostrarGrafico.BackColor = System.Drawing.Color.Maroon;
            this.btnMostrarGrafico.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarGrafico.ForeColor = System.Drawing.Color.White;
            this.btnMostrarGrafico.Location = new System.Drawing.Point(290, 163);
            this.btnMostrarGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarGrafico.Name = "btnMostrarGrafico";
            this.btnMostrarGrafico.Size = new System.Drawing.Size(212, 41);
            this.btnMostrarGrafico.TabIndex = 30;
            this.btnMostrarGrafico.Text = "Mostrar gráfico";
            this.btnMostrarGrafico.UseVisualStyleBackColor = false;
            // 
            // cbTiempo
            // 
            this.cbTiempo.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Items.AddRange(new object[] {
            "Hoy",
            "Semana",
            "Mes"});
            this.cbTiempo.Location = new System.Drawing.Point(313, 94);
            this.cbTiempo.Margin = new System.Windows.Forms.Padding(2);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(159, 27);
            this.cbTiempo.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tiempo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Dashboard de clientes";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(754, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 35);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // dgCitas
            // 
            this.dgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCitas.Location = new System.Drawing.Point(27, 256);
            this.dgCitas.Margin = new System.Windows.Forms.Padding(2);
            this.dgCitas.Name = "dgCitas";
            this.dgCitas.RowHeadersWidth = 51;
            this.dgCitas.RowTemplate.Height = 24;
            this.dgCitas.Size = new System.Drawing.Size(325, 278);
            this.dgCitas.TabIndex = 40;
            // 
            // FormDashBoardIngresoCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 556);
            this.Controls.Add(this.pnlRegresar);
            this.Name = "FormDashBoardIngresoCitas";
            this.Text = "FormDashBoardIngresoCitas";
            this.pnlRegresar.ResumeLayout(false);
            this.pnlRegresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegresar;
        private System.Windows.Forms.DataGridView dgCitas;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar clClientes;
        private System.Windows.Forms.Button btnExportarGraficoExcel;
        private System.Windows.Forms.Button btnMostrarGrafico;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}