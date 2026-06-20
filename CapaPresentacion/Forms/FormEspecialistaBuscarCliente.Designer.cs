namespace CapaPresentacion
{
    partial class FormEspecialistaBuscarCliente
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
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHistorialCita = new System.Windows.Forms.Button();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Maroon;
            this.btnListar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(241, 167);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(132, 41);
            this.btnListar.TabIndex = 87;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(153, 111);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(110, 22);
            this.txtDNI.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 28);
            this.label6.TabIndex = 85;
            this.label6.Text = "DNI";
            // 
            // btnHistorialCita
            // 
            this.btnHistorialCita.BackColor = System.Drawing.Color.Maroon;
            this.btnHistorialCita.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialCita.ForeColor = System.Drawing.Color.White;
            this.btnHistorialCita.Location = new System.Drawing.Point(705, 140);
            this.btnHistorialCita.Name = "btnHistorialCita";
            this.btnHistorialCita.Size = new System.Drawing.Size(135, 68);
            this.btnHistorialCita.TabIndex = 84;
            this.btnHistorialCita.Text = "Historial de cita";
            this.btnHistorialCita.UseVisualStyleBackColor = false;
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.LightCoral;
            this.btnActualizarDatos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDatos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Location = new System.Drawing.Point(398, 167);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(132, 41);
            this.btnActualizarDatos.TabIndex = 83;
            this.btnActualizarDatos.Text = "Buscar caso";
            this.btnActualizarDatos.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(75, 167);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 41);
            this.btnBuscar.TabIndex = 82;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(19, 230);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.Size = new System.Drawing.Size(811, 292);
            this.dgClientes.TabIndex = 81;
            this.dgClientes.SelectionChanged += new System.EventHandler(this.dgClientes_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 50);
            this.label1.TabIndex = 80;
            this.label1.Text = "Buscar clientes ";
            // 
            // FormEspecialistaBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 556);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHistorialCita);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.label1);
            this.Name = "FormEspecialistaBuscarCliente";
            this.Text = "FormEspecialistaBuscarCliente";
            this.Load += new System.EventHandler(this.FormEspecialistaBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHistorialCita;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Label label1;
    }
}