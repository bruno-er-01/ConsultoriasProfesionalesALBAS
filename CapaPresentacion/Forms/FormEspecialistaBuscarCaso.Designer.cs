namespace CapaPresentacion
{
    partial class FormEspecialistaBuscarCaso
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
            this.txtDataCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBorrarFiltro = new System.Windows.Forms.Button();
            this.cbEstadoCaso = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnDetalleCaso = new System.Windows.Forms.Button();
            this.dgCasos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCasos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataCliente
            // 
            this.txtDataCliente.Location = new System.Drawing.Point(484, 173);
            this.txtDataCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataCliente.Name = "txtDataCliente";
            this.txtDataCliente.Size = new System.Drawing.Size(198, 22);
            this.txtDataCliente.TabIndex = 135;
            this.txtDataCliente.TextChanged += new System.EventHandler(this.txtDataCliente_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 16);
            this.label5.TabIndex = 143;
            this.label5.Text = "Casos asignados al especialista";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1100, 1);
            this.label3.TabIndex = 142;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(20, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 41);
            this.label7.TabIndex = 141;
            this.label7.Text = "MIS CASOS";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(24, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1100, 1);
            this.label8.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 145;
            this.label1.Text = "Filtros:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 146;
            this.label9.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(351, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 147;
            this.label10.Text = "Cliente / DNI:";
            // 
            // btnBorrarFiltro
            // 
            this.btnBorrarFiltro.BackColor = System.Drawing.Color.Maroon;
            this.btnBorrarFiltro.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnBorrarFiltro.Location = new System.Drawing.Point(862, 429);
            this.btnBorrarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarFiltro.Name = "btnBorrarFiltro";
            this.btnBorrarFiltro.Size = new System.Drawing.Size(202, 39);
            this.btnBorrarFiltro.TabIndex = 148;
            this.btnBorrarFiltro.Text = "Borrar Filtro";
            this.btnBorrarFiltro.UseVisualStyleBackColor = false;
            this.btnBorrarFiltro.Click += new System.EventHandler(this.btnBorrarFiltro_Click);
            // 
            // cbEstadoCaso
            // 
            this.cbEstadoCaso.FormattingEnabled = true;
            this.cbEstadoCaso.Items.AddRange(new object[] {
            "Todos",
            "Abierto",
            "En proceso",
            "Anulado",
            "Cerrado",
            "Archivado"});
            this.cbEstadoCaso.Location = new System.Drawing.Point(150, 173);
            this.cbEstadoCaso.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstadoCaso.Name = "cbEstadoCaso";
            this.cbEstadoCaso.Size = new System.Drawing.Size(136, 24);
            this.cbEstadoCaso.TabIndex = 149;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(839, 157);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 40);
            this.btnBuscar.TabIndex = 150;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.Color.Maroon;
            this.btnExportarExcel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Location = new System.Drawing.Point(862, 374);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(202, 38);
            this.btnExportarExcel.TabIndex = 151;
            this.btnExportarExcel.Text = "Exportar en Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnDetalleCaso
            // 
            this.btnDetalleCaso.BackColor = System.Drawing.Color.Maroon;
            this.btnDetalleCaso.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleCaso.ForeColor = System.Drawing.Color.White;
            this.btnDetalleCaso.Location = new System.Drawing.Point(862, 324);
            this.btnDetalleCaso.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetalleCaso.Name = "btnDetalleCaso";
            this.btnDetalleCaso.Size = new System.Drawing.Size(202, 42);
            this.btnDetalleCaso.TabIndex = 152;
            this.btnDetalleCaso.Text = "Ver detalle del caso";
            this.btnDetalleCaso.UseVisualStyleBackColor = false;
            this.btnDetalleCaso.Click += new System.EventHandler(this.btnDetalleCaso_Click);
            // 
            // dgCasos
            // 
            this.dgCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCasos.Location = new System.Drawing.Point(35, 245);
            this.dgCasos.Name = "dgCasos";
            this.dgCasos.RowHeadersWidth = 51;
            this.dgCasos.RowTemplate.Height = 24;
            this.dgCasos.Size = new System.Drawing.Size(806, 339);
            this.dgCasos.TabIndex = 154;
            // 
            // FormEspecialistaBuscarCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.dgCasos);
            this.Controls.Add(this.btnDetalleCaso);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbEstadoCaso);
            this.Controls.Add(this.btnBorrarFiltro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEspecialistaBuscarCaso";
            this.Text = "FormEspecialistaBuscarCaso";
            ((System.ComponentModel.ISupportInitialize)(this.dgCasos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDataCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBorrarFiltro;
        private System.Windows.Forms.ComboBox cbEstadoCaso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnDetalleCaso;
        private System.Windows.Forms.DataGridView dgCasos;
    }
}