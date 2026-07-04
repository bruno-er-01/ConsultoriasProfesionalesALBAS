namespace CapaPresentacion
{
    partial class FormRegistrarCaso
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgCaso = new System.Windows.Forms.DataGridView();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnDocumento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnFechaFin = new System.Windows.Forms.TextBox();
            this.cbFechaInicio = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnListarTodo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCaso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 50);
            this.label1.TabIndex = 27;
            this.label1.Text = "Registrar o casos y citas";
            // 
            // dgCaso
            // 
            this.dgCaso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCaso.Location = new System.Drawing.Point(39, 332);
            this.dgCaso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCaso.Name = "dgCaso";
            this.dgCaso.RowHeadersWidth = 51;
            this.dgCaso.Size = new System.Drawing.Size(1076, 453);
            this.dgCaso.TabIndex = 29;
            this.dgCaso.SelectionChanged += new System.EventHandler(this.dgCaso_SelectionChanged);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.Color.Maroon;
            this.btnExportarExcel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Location = new System.Drawing.Point(973, 262);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(142, 53);
            this.btnExportarExcel.TabIndex = 33;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Titulo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 37;
            this.label5.Text = "Estado: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 81);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 22);
            this.txtNombre.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 28);
            this.label7.TabIndex = 57;
            this.label7.Text = "Fecha inicio: ";
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.BackColor = System.Drawing.Color.LightCoral;
            this.btnRegistrarCita.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCita.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCita.Location = new System.Drawing.Point(826, 262);
            this.btnRegistrarCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(141, 53);
            this.btnRegistrarCita.TabIndex = 62;
            this.btnRegistrarCita.Text = "Registrar Cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = false;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Maroon;
            this.btnRegistrar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(39, 262);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(138, 53);
            this.btnRegistrar.TabIndex = 59;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(183, 262);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 53);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.Maroon;
            this.btnActualizarDatos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDatos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Location = new System.Drawing.Point(320, 262);
            this.btnActualizarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(160, 53);
            this.btnActualizarDatos.TabIndex = 61;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.UseVisualStyleBackColor = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fecha fin: ";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Abierto",
            "En proceso"});
            this.cbEstado.Location = new System.Drawing.Point(137, 122);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(5);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(149, 24);
            this.cbEstado.TabIndex = 66;
            // 
            // btnDocumento
            // 
            this.btnDocumento.BackColor = System.Drawing.Color.DarkGray;
            this.btnDocumento.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumento.ForeColor = System.Drawing.Color.White;
            this.btnDocumento.Location = new System.Drawing.Point(596, 180);
            this.btnDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocumento.Name = "btnDocumento";
            this.btnDocumento.Size = new System.Drawing.Size(160, 53);
            this.btnDocumento.TabIndex = 67;
            this.btnDocumento.Text = "Documento";
            this.btnDocumento.UseVisualStyleBackColor = false;
            this.btnDocumento.Click += new System.EventHandler(this.btnDocumento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(672, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 68;
            this.label3.Text = "Descripción";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(808, 81);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(305, 126);
            this.richTextBox1.TabIndex = 69;
            this.richTextBox1.Text = "";
            // 
            // btnFechaFin
            // 
            this.btnFechaFin.Location = new System.Drawing.Point(480, 123);
            this.btnFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechaFin.Name = "btnFechaFin";
            this.btnFechaFin.Size = new System.Drawing.Size(149, 22);
            this.btnFechaFin.TabIndex = 64;
            // 
            // cbFechaInicio
            // 
            this.cbFechaInicio.Location = new System.Drawing.Point(480, 81);
            this.cbFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFechaInicio.Name = "cbFechaInicio";
            this.cbFechaInicio.Size = new System.Drawing.Size(149, 22);
            this.cbFechaInicio.TabIndex = 55;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(181, 197);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(381, 22);
            this.txtDocumento.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 71;
            this.label6.Text = "Documento: ";
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.BackColor = System.Drawing.Color.Maroon;
            this.btnListarTodo.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodo.ForeColor = System.Drawing.Color.White;
            this.btnListarTodo.Location = new System.Drawing.Point(486, 262);
            this.btnListarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(139, 53);
            this.btnListarTodo.TabIndex = 72;
            this.btnListarTodo.Text = "Listar Todo";
            this.btnListarTodo.UseVisualStyleBackColor = false;
            this.btnListarTodo.Click += new System.EventHandler(this.btnListarTodo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(631, 262);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 53);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormRegistrarCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 808);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListarTodo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDocumento);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnFechaFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrarCita);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgCaso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFechaInicio);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRegistrarCaso";
            this.Text = "FormRegistrarCaso";
            this.Load += new System.EventHandler(this.FormRegistrarCaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCaso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCaso;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox btnFechaFin;
        private System.Windows.Forms.TextBox cbFechaInicio;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnListarTodo;
        private System.Windows.Forms.Button btnEliminar;
    }
}