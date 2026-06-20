namespace CapaPresentacion
{
    partial class FormMenuRegistroUsuarios
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
            this.btnFormEspecialista = new System.Windows.Forms.Button();
            this.btnFormAdministrador = new System.Windows.Forms.Button();
            this.pnlMenuUsuarios = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registro de Usuarios";
            // 
            // btnFormEspecialista
            // 
            this.btnFormEspecialista.BackColor = System.Drawing.Color.Maroon;
            this.btnFormEspecialista.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFormEspecialista.ForeColor = System.Drawing.Color.White;
            this.btnFormEspecialista.Location = new System.Drawing.Point(178, 48);
            this.btnFormEspecialista.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormEspecialista.Name = "btnFormEspecialista";
            this.btnFormEspecialista.Size = new System.Drawing.Size(154, 48);
            this.btnFormEspecialista.TabIndex = 11;
            this.btnFormEspecialista.Text = "Especialista";
            this.btnFormEspecialista.UseVisualStyleBackColor = false;
            this.btnFormEspecialista.Click += new System.EventHandler(this.btnFormEspecialista_Click);
            // 
            // btnFormAdministrador
            // 
            this.btnFormAdministrador.BackColor = System.Drawing.Color.Maroon;
            this.btnFormAdministrador.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFormAdministrador.ForeColor = System.Drawing.Color.White;
            this.btnFormAdministrador.Location = new System.Drawing.Point(20, 48);
            this.btnFormAdministrador.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormAdministrador.Name = "btnFormAdministrador";
            this.btnFormAdministrador.Size = new System.Drawing.Size(154, 48);
            this.btnFormAdministrador.TabIndex = 10;
            this.btnFormAdministrador.Text = "Administrador";
            this.btnFormAdministrador.UseVisualStyleBackColor = false;
            this.btnFormAdministrador.Click += new System.EventHandler(this.btnFormAdministrador_Click);
            // 
            // pnlMenuUsuarios
            // 
            this.pnlMenuUsuarios.Location = new System.Drawing.Point(1, 96);
            this.pnlMenuUsuarios.Name = "pnlMenuUsuarios";
            this.pnlMenuUsuarios.Size = new System.Drawing.Size(871, 565);
            this.pnlMenuUsuarios.TabIndex = 13;
            // 
            // FormMenuRegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 661);
            this.Controls.Add(this.pnlMenuUsuarios);
            this.Controls.Add(this.btnFormEspecialista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFormAdministrador);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMenuRegistroUsuarios";
            this.Text = "FormMenuRegistroUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFormEspecialista;
        private System.Windows.Forms.Button btnFormAdministrador;
        private System.Windows.Forms.Panel pnlMenuUsuarios;
    }
}