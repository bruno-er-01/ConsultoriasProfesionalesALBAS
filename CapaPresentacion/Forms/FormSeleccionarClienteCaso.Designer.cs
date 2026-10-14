namespace CapaPresentacion.Forms
{
    partial class FormSeleccionarClienteCaso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeleccionarClienteCaso));
            this.btnListarTodoClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgClientesCasos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lbGenero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.btnRegistrarCaso = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientesCasos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarTodoClientes
            // 
            this.btnListarTodoClientes.BackColor = System.Drawing.Color.Maroon;
            this.btnListarTodoClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListarTodoClientes.BackgroundImage")));
            this.btnListarTodoClientes.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodoClientes.ForeColor = System.Drawing.Color.White;
            this.btnListarTodoClientes.Location = new System.Drawing.Point(93, 300);
            this.btnListarTodoClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarTodoClientes.Name = "btnListarTodoClientes";
            this.btnListarTodoClientes.Size = new System.Drawing.Size(160, 53);
            this.btnListarTodoClientes.TabIndex = 84;
            this.btnListarTodoClientes.Text = "Listar todo";
            this.btnListarTodoClientes.UseVisualStyleBackColor = false;
            this.btnListarTodoClientes.Click += new System.EventHandler(this.btnListarTodoClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 45);
            this.label1.TabIndex = 62;
            this.label1.Text = "Buscar clientes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(574, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 28);
            this.label7.TabIndex = 81;
            this.label7.Text = "Correo:";
            // 
            // dgClientesCasos
            // 
            this.dgClientesCasos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgClientesCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientesCasos.Location = new System.Drawing.Point(93, 382);
            this.dgClientesCasos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgClientesCasos.Name = "dgClientesCasos";
            this.dgClientesCasos.RowHeadersWidth = 51;
            this.dgClientesCasos.Size = new System.Drawing.Size(1133, 477);
            this.dgClientesCasos.TabIndex = 63;
            this.dgClientesCasos.SelectionChanged += new System.EventHandler(this.dgClientesCasos_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 80;
            this.label3.Text = "Dirección:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(675, 191);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(188, 22);
            this.tbCorreo.TabIndex = 79;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(675, 152);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(188, 22);
            this.tbDireccion.TabIndex = 78;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbGenero.Location = new System.Drawing.Point(675, 110);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(188, 24);
            this.cbGenero.TabIndex = 77;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.BackColor = System.Drawing.Color.Transparent;
            this.lbGenero.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(574, 106);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(85, 28);
            this.lbGenero.TabIndex = 76;
            this.lbGenero.Text = "Género:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 28);
            this.label4.TabIndex = 68;
            this.label4.Text = "Nombre (obligatorio):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 69;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 28);
            this.label6.TabIndex = 70;
            this.label6.Text = "DNI(obligatorio):";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(1026, 110);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(200, 22);
            this.tbTelefono.TabIndex = 75;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(303, 112);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(192, 22);
            this.tbNombre.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(912, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 28);
            this.label8.TabIndex = 74;
            this.label8.Text = "Télefono:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(303, 155);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(192, 22);
            this.tbApellido.TabIndex = 72;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(303, 193);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(192, 22);
            this.tbDNI.TabIndex = 73;
            // 
            // btnRegistrarCaso
            // 
            this.btnRegistrarCaso.BackColor = System.Drawing.Color.LightCoral;
            this.btnRegistrarCaso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCaso.BackgroundImage")));
            this.btnRegistrarCaso.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCaso.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCaso.Location = new System.Drawing.Point(1066, 300);
            this.btnRegistrarCaso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarCaso.Name = "btnRegistrarCaso";
            this.btnRegistrarCaso.Size = new System.Drawing.Size(160, 53);
            this.btnRegistrarCaso.TabIndex = 85;
            this.btnRegistrarCaso.Text = "Registrar Caso";
            this.btnRegistrarCaso.UseVisualStyleBackColor = false;
            this.btnRegistrarCaso.Click += new System.EventHandler(this.btnRegistrarCaso_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(387, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 28);
            this.label11.TabIndex = 126;
            this.label11.Text = "Buscar:";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(479, 252);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(356, 22);
            this.txtBuscarCliente.TabIndex = 125;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(272, 300);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(160, 53);
            this.btnLimpiar.TabIndex = 127;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormSeleccionarClienteCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.imgFondoGeneral;
            this.ClientSize = new System.Drawing.Size(1316, 891);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.btnRegistrarCaso);
            this.Controls.Add(this.btnListarTodoClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgClientesCasos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbDNI);
            this.MaximumSize = new System.Drawing.Size(1334, 938);
            this.MinimumSize = new System.Drawing.Size(1334, 938);
            this.Name = "FormSeleccionarClienteCaso";
            this.Text = "FormSeleccionarClienteCaso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgClientesCasos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarTodoClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgClientesCasos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Button btnRegistrarCaso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnLimpiar;
    }
}