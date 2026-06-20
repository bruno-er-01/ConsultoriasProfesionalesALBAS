namespace CapaPresentacion
{
    partial class FormRegistrarCitas
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnHoraFin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgCita = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHoraInicio = new System.Windows.Forms.TextBox();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.clClientes = new System.Windows.Forms.MonthCalendar();
            this.btnAgregarRecordatorio = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAsistencia = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCita)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(763, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 86;
            this.label3.Text = "Descripción";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(507, 140);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(149, 24);
            this.cbEstado.TabIndex = 84;
            // 
            // btnHoraFin
            // 
            this.btnHoraFin.Location = new System.Drawing.Point(895, 142);
            this.btnHoraFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoraFin.Name = "btnHoraFin";
            this.btnHoraFin.Size = new System.Drawing.Size(149, 22);
            this.btnHoraFin.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 82;
            this.label2.Text = "Hora fin: ";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Maroon;
            this.btnRegistrar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(253, 338);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(160, 53);
            this.btnRegistrar.TabIndex = 78;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(419, 338);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 53);
            this.btnBuscar.TabIndex = 79;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.Maroon;
            this.btnActualizarDatos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDatos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Location = new System.Drawing.Point(584, 338);
            this.btnActualizarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(188, 53);
            this.btnActualizarDatos.TabIndex = 80;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.UseVisualStyleBackColor = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(759, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 77;
            this.label7.Text = "Hora inicio: ";
            // 
            // dgCita
            // 
            this.dgCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCita.Location = new System.Drawing.Point(48, 411);
            this.dgCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCita.Name = "dgCita";
            this.dgCita.RowHeadersWidth = 51;
            this.dgCita.Size = new System.Drawing.Size(1076, 375);
            this.dgCita.TabIndex = 71;
            this.dgCita.SelectionChanged += new System.EventHandler(this.dgCita_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 50);
            this.label1.TabIndex = 70;
            this.label1.Text = "Registrar citas";
            // 
            // cbHoraInicio
            // 
            this.cbHoraInicio.Location = new System.Drawing.Point(895, 100);
            this.cbHoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHoraInicio.Name = "cbHoraInicio";
            this.cbHoraInicio.Size = new System.Drawing.Size(149, 22);
            this.cbHoraInicio.TabIndex = 76;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.Color.Maroon;
            this.btnExportarExcel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Location = new System.Drawing.Point(964, 338);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(160, 53);
            this.btnExportarExcel.TabIndex = 72;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 73;
            this.label4.Text = "Modalidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 74;
            this.label5.Text = "Estado: ";
            // 
            // txtModalidad
            // 
            this.txtModalidad.Location = new System.Drawing.Point(507, 100);
            this.txtModalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.Size = new System.Drawing.Size(149, 22);
            this.txtModalidad.TabIndex = 75;
            // 
            // clClientes
            // 
            this.clClientes.Location = new System.Drawing.Point(48, 91);
            this.clClientes.Margin = new System.Windows.Forms.Padding(7);
            this.clClientes.MaxSelectionCount = 1;
            this.clClientes.Name = "clClientes";
            this.clClientes.TabIndex = 87;
            // 
            // btnAgregarRecordatorio
            // 
            this.btnAgregarRecordatorio.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregarRecordatorio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRecordatorio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRecordatorio.Location = new System.Drawing.Point(47, 341);
            this.btnAgregarRecordatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarRecordatorio.Name = "btnAgregarRecordatorio";
            this.btnAgregarRecordatorio.Size = new System.Drawing.Size(197, 53);
            this.btnAgregarRecordatorio.TabIndex = 88;
            this.btnAgregarRecordatorio.Text = "Añadir recordatorio";
            this.btnAgregarRecordatorio.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(507, 183);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 22);
            this.dateTimePicker1.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 90;
            this.label6.Text = "Fecha: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(769, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 28);
            this.label8.TabIndex = 91;
            this.label8.Text = "Asistencia: ";
            // 
            // cbAsistencia
            // 
            this.cbAsistencia.FormattingEnabled = true;
            this.cbAsistencia.Items.AddRange(new object[] {
            "Asistio",
            "Ausente"});
            this.cbAsistencia.Location = new System.Drawing.Point(895, 182);
            this.cbAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.cbAsistencia.Name = "cbAsistencia";
            this.cbAsistencia.Size = new System.Drawing.Size(147, 24);
            this.cbAsistencia.TabIndex = 92;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1017, 20);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 44);
            this.btnSalir.TabIndex = 93;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormRegistrarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 814);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbAsistencia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAgregarRecordatorio);
            this.Controls.Add(this.clClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnHoraFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHoraInicio);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModalidad);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRegistrarCitas";
            this.Text = "FormRegistrarCitas";
            ((System.ComponentModel.ISupportInitialize)(this.dgCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox btnHoraFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cbHoraInicio;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.MonthCalendar clClientes;
        private System.Windows.Forms.Button btnAgregarRecordatorio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAsistencia;
        private System.Windows.Forms.Button btnSalir;
    }
}