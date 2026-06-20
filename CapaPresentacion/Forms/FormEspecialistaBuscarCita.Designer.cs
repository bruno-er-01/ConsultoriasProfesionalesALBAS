namespace CapaPresentacion
{
    partial class FormEspecialistaBuscarCita
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
            this.btnListar = new System.Windows.Forms.Button();
            this.rtcDescripcion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnadirRecordatorio = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnOrdenarPorFecha = new System.Windows.Forms.Button();
            this.cbAsistencia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgCita = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCita)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Maroon;
            this.btnListar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(677, 306);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(205, 50);
            this.btnListar.TabIndex = 193;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // rtcDescripcion
            // 
            this.rtcDescripcion.BackColor = System.Drawing.Color.Snow;
            this.rtcDescripcion.Location = new System.Drawing.Point(733, 126);
            this.rtcDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtcDescripcion.Name = "rtcDescripcion";
            this.rtcDescripcion.Size = new System.Drawing.Size(369, 146);
            this.rtcDescripcion.TabIndex = 192;
            this.rtcDescripcion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(772, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 191;
            this.label3.Text = "Descripción:";
            // 
            // btnAnadirRecordatorio
            // 
            this.btnAnadirRecordatorio.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnadirRecordatorio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirRecordatorio.ForeColor = System.Drawing.Color.White;
            this.btnAnadirRecordatorio.Location = new System.Drawing.Point(911, 305);
            this.btnAnadirRecordatorio.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadirRecordatorio.Name = "btnAnadirRecordatorio";
            this.btnAnadirRecordatorio.Size = new System.Drawing.Size(193, 50);
            this.btnAnadirRecordatorio.TabIndex = 190;
            this.btnAnadirRecordatorio.Text = "Añadir recordatorio";
            this.btnAnadirRecordatorio.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(95, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 189;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Terminado",
            "Cancelado"});
            this.cbEstado.Location = new System.Drawing.Point(539, 196);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(145, 24);
            this.cbEstado.TabIndex = 188;
            // 
            // btnOrdenarPorFecha
            // 
            this.btnOrdenarPorFecha.BackColor = System.Drawing.Color.Maroon;
            this.btnOrdenarPorFecha.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarPorFecha.ForeColor = System.Drawing.Color.White;
            this.btnOrdenarPorFecha.Location = new System.Drawing.Point(445, 305);
            this.btnOrdenarPorFecha.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenarPorFecha.Name = "btnOrdenarPorFecha";
            this.btnOrdenarPorFecha.Size = new System.Drawing.Size(205, 50);
            this.btnOrdenarPorFecha.TabIndex = 187;
            this.btnOrdenarPorFecha.Text = "Ordenar por fecha";
            this.btnOrdenarPorFecha.UseVisualStyleBackColor = false;
            // 
            // cbAsistencia
            // 
            this.cbAsistencia.FormattingEnabled = true;
            this.cbAsistencia.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbAsistencia.Location = new System.Drawing.Point(539, 234);
            this.cbAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.cbAsistencia.Name = "cbAsistencia";
            this.cbAsistencia.Size = new System.Drawing.Size(145, 24);
            this.cbAsistencia.TabIndex = 186;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 185;
            this.label2.Text = "Asistencia:";
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(539, 156);
            this.tbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(145, 22);
            this.tbFecha.TabIndex = 184;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(539, 126);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(145, 22);
            this.tbId.TabIndex = 183;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 182;
            this.label6.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 28);
            this.label5.TabIndex = 181;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 28);
            this.label4.TabIndex = 180;
            this.label4.Text = "ID:";
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.Maroon;
            this.btnActualizarDatos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDatos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Location = new System.Drawing.Point(239, 306);
            this.btnActualizarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(176, 50);
            this.btnActualizarDatos.TabIndex = 179;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.UseVisualStyleBackColor = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(33, 306);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(176, 50);
            this.btnBuscar.TabIndex = 178;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgCita
            // 
            this.dgCita.BackgroundColor = System.Drawing.Color.Snow;
            this.dgCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCita.Location = new System.Drawing.Point(31, 374);
            this.dgCita.Margin = new System.Windows.Forms.Padding(4);
            this.dgCita.Name = "dgCita";
            this.dgCita.RowHeadersWidth = 51;
            this.dgCita.Size = new System.Drawing.Size(1081, 306);
            this.dgCita.TabIndex = 177;
            this.dgCita.SelectionChanged += new System.EventHandler(this.dgCita_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 50);
            this.label1.TabIndex = 176;
            this.label1.Text = "Buscar cita";
            // 
            // FormEspecialistaBuscarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 706);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.rtcDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnadirRecordatorio);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnOrdenarPorFecha);
            this.Controls.Add(this.cbAsistencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgCita);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEspecialistaBuscarCita";
            this.Text = "FormEspecialistaBuscarCita";
            this.Load += new System.EventHandler(this.FormEspecialistaBuscarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RichTextBox rtcDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnadirRecordatorio;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnOrdenarPorFecha;
        private System.Windows.Forms.ComboBox cbAsistencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgCita;
        private System.Windows.Forms.Label label1;
    }
}