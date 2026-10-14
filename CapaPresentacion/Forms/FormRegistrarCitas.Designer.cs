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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarCitas));
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgCita = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clCitas = new System.Windows.Forms.MonthCalendar();
            this.btnAgregarRecordatorio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.rtbObservacion = new System.Windows.Forms.RichTextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cbModalidad = new System.Windows.Forms.ComboBox();
            this.chkAsistencia = new System.Windows.Forms.CheckBox();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTituloCaso = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEspecialista = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCita)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1040, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 86;
            this.label3.Text = "Observación:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Reprogramado",
            "Atendido",
            "Cancelado"});
            this.cbEstado.Location = new System.Drawing.Point(526, 200);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(160, 24);
            this.cbEstado.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(761, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 82;
            this.label2.Text = "Hora fin: ";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Maroon;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(55, 375);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(133, 53);
            this.btnRegistrar.TabIndex = 78;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(194, 375);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(182, 53);
            this.btnBuscar.TabIndex = 79;
            this.btnBuscar.Text = "Buscar por estado";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.Maroon;
            this.btnActualizarDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarDatos.BackgroundImage")));
            this.btnActualizarDatos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDatos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Location = new System.Drawing.Point(509, 375);
            this.btnActualizarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(163, 53);
            this.btnActualizarDatos.TabIndex = 80;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.UseVisualStyleBackColor = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(738, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 77;
            this.label7.Text = "Hora inicio: ";
            // 
            // dgCita
            // 
            this.dgCita.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCita.Location = new System.Drawing.Point(58, 457);
            this.dgCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCita.Name = "dgCita";
            this.dgCita.RowHeadersWidth = 51;
            this.dgCita.Size = new System.Drawing.Size(1186, 395);
            this.dgCita.TabIndex = 71;
            this.dgCita.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCita_ColumnHeaderMouseClick);
            this.dgCita.SelectionChanged += new System.EventHandler(this.dgCita_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(82, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 50);
            this.label1.TabIndex = 70;
            this.label1.Text = "Registrar citas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 74;
            this.label5.Text = "Estado: ";
            // 
            // clCitas
            // 
            this.clCitas.Location = new System.Drawing.Point(91, 140);
            this.clCitas.Margin = new System.Windows.Forms.Padding(7);
            this.clCitas.MaxSelectionCount = 1;
            this.clCitas.Name = "clCitas";
            this.clCitas.TabIndex = 87;
            this.clCitas.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.clCitas_DateSelected);
            // 
            // btnAgregarRecordatorio
            // 
            this.btnAgregarRecordatorio.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregarRecordatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarRecordatorio.BackgroundImage")));
            this.btnAgregarRecordatorio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRecordatorio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRecordatorio.Location = new System.Drawing.Point(1045, 375);
            this.btnAgregarRecordatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarRecordatorio.Name = "btnAgregarRecordatorio";
            this.btnAgregarRecordatorio.Size = new System.Drawing.Size(197, 53);
            this.btnAgregarRecordatorio.TabIndex = 88;
            this.btnAgregarRecordatorio.Text = "Añadir recordatorio";
            this.btnAgregarRecordatorio.UseVisualStyleBackColor = false;
            this.btnAgregarRecordatorio.Click += new System.EventHandler(this.btnAgregarRecordatorio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 90;
            this.label6.Text = "Fecha: ";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1153, 21);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 49);
            this.btnSalir.TabIndex = 93;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(871, 149);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(147, 22);
            this.dtpHoraInicio.TabIndex = 94;
            // 
            // rtbObservacion
            // 
            this.rtbObservacion.Location = new System.Drawing.Point(1045, 161);
            this.rtbObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.rtbObservacion.Name = "rtbObservacion";
            this.rtbObservacion.Size = new System.Drawing.Size(199, 186);
            this.rtbObservacion.TabIndex = 96;
            this.rtbObservacion.Text = "";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(526, 247);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(160, 22);
            this.txtFecha.TabIndex = 97;
            this.txtFecha.Text = "Seleccione la fecha";
            // 
            // cbModalidad
            // 
            this.cbModalidad.FormattingEnabled = true;
            this.cbModalidad.Items.AddRange(new object[] {
            "Presencial",
            "Virtual"});
            this.cbModalidad.Location = new System.Drawing.Point(526, 149);
            this.cbModalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cbModalidad.Name = "cbModalidad";
            this.cbModalidad.Size = new System.Drawing.Size(160, 24);
            this.cbModalidad.TabIndex = 98;
            // 
            // chkAsistencia
            // 
            this.chkAsistencia.AutoSize = true;
            this.chkAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.chkAsistencia.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.chkAsistencia.Location = new System.Drawing.Point(410, 304);
            this.chkAsistencia.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.chkAsistencia.Name = "chkAsistencia";
            this.chkAsistencia.Size = new System.Drawing.Size(181, 27);
            this.chkAsistencia.TabIndex = 99;
            this.chkAsistencia.Text = "Confirmó asistencia";
            this.chkAsistencia.UseVisualStyleBackColor = false;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(871, 198);
            this.dtpHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(147, 22);
            this.dtpHoraFin.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 28);
            this.label8.TabIndex = 101;
            this.label8.Text = "Caso: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(466, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 28);
            this.label9.TabIndex = 102;
            this.label9.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 73;
            this.label4.Text = "Modalidad:";
            // 
            // lblTituloCaso
            // 
            this.lblTituloCaso.AutoSize = true;
            this.lblTituloCaso.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCaso.Location = new System.Drawing.Point(529, 39);
            this.lblTituloCaso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCaso.Name = "lblTituloCaso";
            this.lblTituloCaso.Size = new System.Drawing.Size(11, 16);
            this.lblTituloCaso.TabIndex = 103;
            this.lblTituloCaso.Text = "-";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Location = new System.Drawing.Point(553, 65);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(11, 16);
            this.lblCliente.TabIndex = 104;
            this.lblCliente.Text = "-";
            // 
            // lblEspecialista
            // 
            this.lblEspecialista.AutoSize = true;
            this.lblEspecialista.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialista.Location = new System.Drawing.Point(600, 91);
            this.lblEspecialista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialista.Name = "lblEspecialista";
            this.lblEspecialista.Size = new System.Drawing.Size(11, 16);
            this.lblEspecialista.TabIndex = 106;
            this.lblEspecialista.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(466, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 28);
            this.label11.TabIndex = 105;
            this.label11.Text = "Especialista:";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Maroon;
            this.btnListar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListar.BackgroundImage")));
            this.btnListar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(807, 375);
            this.btnListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(124, 53);
            this.btnListar.TabIndex = 107;
            this.btnListar.Text = "Listar citas";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(382, 375);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 53);
            this.btnEliminar.TabIndex = 108;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(678, 375);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(123, 53);
            this.btnLimpiar.TabIndex = 109;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormRegistrarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.imgFondoGeneral;
            this.ClientSize = new System.Drawing.Size(1316, 891);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblEspecialista);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTituloCaso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.chkAsistencia);
            this.Controls.Add(this.cbModalidad);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.rtbObservacion);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregarRecordatorio);
            this.Controls.Add(this.clCitas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1334, 938);
            this.MinimumSize = new System.Drawing.Size(1334, 938);
            this.Name = "FormRegistrarCitas";
            this.Text = "FormRegistrarCitas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar clCitas;
        private System.Windows.Forms.Button btnAgregarRecordatorio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.RichTextBox rtbObservacion;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cbModalidad;
        private System.Windows.Forms.CheckBox chkAsistencia;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTituloCaso;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEspecialista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}