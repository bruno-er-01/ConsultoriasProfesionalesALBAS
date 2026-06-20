namespace CapaPresentacion
{
    partial class FormRegistrarBuscarClientes
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
            this.btnRegistrarCaso = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lbGenero = new System.Windows.Forms.Label();
            this.cbAreaAtencion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarCaso
            // 
            this.btnRegistrarCaso.BackColor = System.Drawing.Color.LightCoral;
            this.btnRegistrarCaso.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCaso.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCaso.Location = new System.Drawing.Point(700, 262);
            this.btnRegistrarCaso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarCaso.Name = "btnRegistrarCaso";
            this.btnRegistrarCaso.Size = new System.Drawing.Size(160, 53);
            this.btnRegistrarCaso.TabIndex = 58;
            this.btnRegistrarCaso.Text = "Registrar Caso";
            this.btnRegistrarCaso.UseVisualStyleBackColor = false;
            this.btnRegistrarCaso.Click += new System.EventHandler(this.btnRegistrarCaso_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 28);
            this.label7.TabIndex = 57;
            this.label7.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 56;
            this.label3.Text = "Dirección:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(505, 170);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(149, 22);
            this.txtCorreo.TabIndex = 55;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(505, 118);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(149, 22);
            this.txtDireccion.TabIndex = 54;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbGenero.Location = new System.Drawing.Point(505, 78);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(149, 24);
            this.cbGenero.TabIndex = 53;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(377, 81);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(80, 28);
            this.lbGenero.TabIndex = 52;
            this.lbGenero.Text = "Género:";
            // 
            // cbAreaAtencion
            // 
            this.cbAreaAtencion.FormattingEnabled = true;
            this.cbAreaAtencion.Items.AddRange(new object[] {
            "Familiar",
            "Conciliación",
            "Judicial",
            "Civil"});
            this.cbAreaAtencion.Location = new System.Drawing.Point(875, 119);
            this.cbAreaAtencion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAreaAtencion.Name = "cbAreaAtencion";
            this.cbAreaAtencion.Size = new System.Drawing.Size(149, 24);
            this.cbAreaAtencion.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(677, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 50;
            this.label2.Text = "Área de atención:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(875, 79);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(149, 22);
            this.txtTelefono.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(752, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 28);
            this.label8.TabIndex = 46;
            this.label8.Text = "Télefono:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(165, 171);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(149, 22);
            this.txtDNI.TabIndex = 45;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(165, 119);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(149, 22);
            this.txtApellido.TabIndex = 44;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(165, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 22);
            this.txtNombre.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 28);
            this.label6.TabIndex = 38;
            this.label6.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 37;
            this.label5.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nombre:";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.Color.Maroon;
            this.btnExportarExcel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Location = new System.Drawing.Point(955, 262);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(160, 53);
            this.btnExportarExcel.TabIndex = 33;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.Maroon;
            this.btnActualizarDatos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDatos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Location = new System.Drawing.Point(369, 262);
            this.btnActualizarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(160, 53);
            this.btnActualizarDatos.TabIndex = 32;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.UseVisualStyleBackColor = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(204, 262);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 53);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Maroon;
            this.btnRegistrar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(39, 262);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(160, 53);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(39, 332);
            this.dgClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.Size = new System.Drawing.Size(1076, 453);
            this.dgClientes.TabIndex = 29;
            this.dgClientes.SelectionChanged += new System.EventHandler(this.dgClientes_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 45);
            this.label1.TabIndex = 27;
            this.label1.Text = "Registrar o buscar clientes ";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Maroon;
            this.btnListar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(535, 262);
            this.btnListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(160, 53);
            this.btnListar.TabIndex = 59;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FormRegistrarBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 814);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarCaso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAreaAtencion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDNI);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRegistrarBuscarClientes";
            this.Text = "FormRegistrarBuscarClientes";
            this.Load += new System.EventHandler(this.FormRegistrarBuscarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarCaso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.ComboBox cbAreaAtencion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListar;
    }
}