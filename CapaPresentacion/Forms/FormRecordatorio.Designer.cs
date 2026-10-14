namespace CapaPresentacion
{
    partial class FormRecordatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecordatorio));
            this.cbTiempoAnticipacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblFechaCita = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.dgRecordatorio = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.txtDNIEspecialista = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificarRecordatorio = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelarRecordatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecordatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTiempoAnticipacion
            // 
            this.cbTiempoAnticipacion.FormattingEnabled = true;
            this.cbTiempoAnticipacion.Items.AddRange(new object[] {
            "5 minutos",
            "10 minutos",
            "15 minutos",
            "20 minutos",
            "25 minutos",
            "30 minutos",
            "60 minutos"});
            this.cbTiempoAnticipacion.Location = new System.Drawing.Point(320, 302);
            this.cbTiempoAnticipacion.Margin = new System.Windows.Forms.Padding(4);
            this.cbTiempoAnticipacion.Name = "cbTiempoAnticipacion";
            this.cbTiempoAnticipacion.Size = new System.Drawing.Size(212, 24);
            this.cbTiempoAnticipacion.TabIndex = 143;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 28);
            this.label6.TabIndex = 142;
            this.label6.Text = "Tiempo de anticipación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 141;
            this.label4.Text = "DNI Cliente:";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Maroon;
            this.btnAñadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAñadir.BackgroundImage")));
            this.btnAñadir.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(37, 713);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(112, 55);
            this.btnAñadir.TabIndex = 140;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(667, 15);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 55);
            this.btnSalir.TabIndex = 137;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 50);
            this.label1.TabIndex = 136;
            this.label1.Text = "Añadir recordatorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 144;
            this.label2.Text = "Fecha de cita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 145;
            this.label3.Text = "Modalidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 146;
            this.label5.Text = "Hora de inicio: ";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(315, 165);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(20, 28);
            this.lblHoraInicio.TabIndex = 147;
            this.lblHoraInicio.Text = "-";
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCita.Location = new System.Drawing.Point(315, 208);
            this.lblFechaCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(20, 28);
            this.lblFechaCita.TabIndex = 148;
            this.lblFechaCita.Text = "-";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidad.Location = new System.Drawing.Point(313, 255);
            this.lblModalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(20, 28);
            this.lblModalidad.TabIndex = 150;
            this.lblModalidad.Text = "-";
            // 
            // dgRecordatorio
            // 
            this.dgRecordatorio.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgRecordatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecordatorio.Location = new System.Drawing.Point(37, 350);
            this.dgRecordatorio.Margin = new System.Windows.Forms.Padding(4);
            this.dgRecordatorio.Name = "dgRecordatorio";
            this.dgRecordatorio.RowHeadersWidth = 51;
            this.dgRecordatorio.Size = new System.Drawing.Size(725, 332);
            this.dgRecordatorio.TabIndex = 151;
            this.dgRecordatorio.SelectionChanged += new System.EventHandler(this.dgRecordatorio_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 28);
            this.label7.TabIndex = 152;
            this.label7.Text = "DNI Especialista:";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(320, 85);
            this.txtDNICliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(223, 22);
            this.txtDNICliente.TabIndex = 154;
            // 
            // txtDNIEspecialista
            // 
            this.txtDNIEspecialista.Location = new System.Drawing.Point(320, 126);
            this.txtDNIEspecialista.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIEspecialista.Name = "txtDNIEspecialista";
            this.txtDNIEspecialista.Size = new System.Drawing.Size(223, 22);
            this.txtDNIEspecialista.TabIndex = 155;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(651, 284);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 55);
            this.btnLimpiar.TabIndex = 156;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificarRecordatorio
            // 
            this.btnModificarRecordatorio.BackColor = System.Drawing.Color.Maroon;
            this.btnModificarRecordatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarRecordatorio.BackgroundImage")));
            this.btnModificarRecordatorio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRecordatorio.ForeColor = System.Drawing.Color.White;
            this.btnModificarRecordatorio.Location = new System.Drawing.Point(181, 713);
            this.btnModificarRecordatorio.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarRecordatorio.Name = "btnModificarRecordatorio";
            this.btnModificarRecordatorio.Size = new System.Drawing.Size(192, 55);
            this.btnModificarRecordatorio.TabIndex = 157;
            this.btnModificarRecordatorio.Text = "Modificar recordatorio";
            this.btnModificarRecordatorio.UseVisualStyleBackColor = false;
            this.btnModificarRecordatorio.Click += new System.EventHandler(this.btnModificarRecordatorio_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(633, 713);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 55);
            this.btnBuscar.TabIndex = 158;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelarRecordatorio
            // 
            this.btnCancelarRecordatorio.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelarRecordatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarRecordatorio.BackgroundImage")));
            this.btnCancelarRecordatorio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRecordatorio.ForeColor = System.Drawing.Color.White;
            this.btnCancelarRecordatorio.Location = new System.Drawing.Point(408, 713);
            this.btnCancelarRecordatorio.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarRecordatorio.Name = "btnCancelarRecordatorio";
            this.btnCancelarRecordatorio.Size = new System.Drawing.Size(192, 55);
            this.btnCancelarRecordatorio.TabIndex = 159;
            this.btnCancelarRecordatorio.Text = "Cancelar recordatorio";
            this.btnCancelarRecordatorio.UseVisualStyleBackColor = false;
            this.btnCancelarRecordatorio.Click += new System.EventHandler(this.btnCancelarRecordatorio_Click);
            // 
            // FormRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.imgFondoGeneral;
            this.ClientSize = new System.Drawing.Size(795, 783);
            this.Controls.Add(this.btnCancelarRecordatorio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificarRecordatorio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtDNIEspecialista);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgRecordatorio);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.lblFechaCita);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTiempoAnticipacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(813, 830);
            this.MinimumSize = new System.Drawing.Size(813, 830);
            this.Name = "FormRecordatorio";
            this.Text = "FormRecordatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgRecordatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTiempoAnticipacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.DataGridView dgRecordatorio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.TextBox txtDNIEspecialista;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificarRecordatorio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelarRecordatorio;
    }
}