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
            this.btnListarTodo = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscarCita = new System.Windows.Forms.Button();
            this.cbAreaAtención = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgCaso = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCaso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.BackColor = System.Drawing.Color.Maroon;
            this.btnListarTodo.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodo.ForeColor = System.Drawing.Color.White;
            this.btnListarTodo.Location = new System.Drawing.Point(579, 190);
            this.btnListarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(176, 50);
            this.btnListarTodo.TabIndex = 140;
            this.btnListarTodo.Text = "Listar Todo";
            this.btnListarTodo.UseVisualStyleBackColor = false;
            this.btnListarTodo.Click += new System.EventHandler(this.btnListarTodo_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Familiar",
            "Conciliación",
            "Judicial",
            "Civil"});
            this.cbEstado.Location = new System.Drawing.Point(477, 122);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(145, 24);
            this.cbEstado.TabIndex = 139;
            // 
            // btnBuscarCita
            // 
            this.btnBuscarCita.BackColor = System.Drawing.Color.LightCoral;
            this.btnBuscarCita.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCita.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCita.Location = new System.Drawing.Point(808, 190);
            this.btnBuscarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCita.Name = "btnBuscarCita";
            this.btnBuscarCita.Size = new System.Drawing.Size(176, 50);
            this.btnBuscarCita.TabIndex = 138;
            this.btnBuscarCita.Text = "Buscar cita";
            this.btnBuscarCita.UseVisualStyleBackColor = false;
            // 
            // cbAreaAtención
            // 
            this.cbAreaAtención.FormattingEnabled = true;
            this.cbAreaAtención.Items.AddRange(new object[] {
            "Familiar",
            "Conciliación",
            "Judicial",
            "Civil"});
            this.cbAreaAtención.Location = new System.Drawing.Point(887, 122);
            this.cbAreaAtención.Margin = new System.Windows.Forms.Padding(4);
            this.cbAreaAtención.Name = "cbAreaAtención";
            this.cbAreaAtención.Size = new System.Drawing.Size(136, 24);
            this.cbAreaAtención.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(699, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 136;
            this.label2.Text = "Área de atención:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(139, 123);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(145, 22);
            this.tbId.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 134;
            this.label6.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 28);
            this.label4.TabIndex = 133;
            this.label4.Text = "ID:";
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.Maroon;
            this.btnActualizarDatos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDatos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Location = new System.Drawing.Point(117, 190);
            this.btnActualizarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(176, 50);
            this.btnActualizarDatos.TabIndex = 132;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.UseVisualStyleBackColor = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(348, 190);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(176, 50);
            this.btnBuscar.TabIndex = 131;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgCaso
            // 
            this.dgCaso.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgCaso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCaso.Location = new System.Drawing.Point(35, 284);
            this.dgCaso.Margin = new System.Windows.Forms.Padding(4);
            this.dgCaso.Name = "dgCaso";
            this.dgCaso.RowHeadersWidth = 51;
            this.dgCaso.Size = new System.Drawing.Size(1081, 358);
            this.dgCaso.TabIndex = 130;
            this.dgCaso.SelectionChanged += new System.EventHandler(this.dgCaso_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 50);
            this.label1.TabIndex = 129;
            this.label1.Text = "Buscar caso";
            // 
            // FormEspecialistaBuscarCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.btnListarTodo);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnBuscarCita);
            this.Controls.Add(this.cbAreaAtención);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgCaso);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEspecialistaBuscarCaso";
            this.Text = "FormEspecialistaBuscarCaso";
            this.Load += new System.EventHandler(this.FormEspecialistaBuscarCaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCaso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarTodo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnBuscarCita;
        private System.Windows.Forms.ComboBox cbAreaAtención;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgCaso;
        private System.Windows.Forms.Label label1;
    }
}