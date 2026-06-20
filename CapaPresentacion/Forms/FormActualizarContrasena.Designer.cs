namespace CapaPresentacion.Forms
{
    partial class FormActualizarContrasena
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegresarLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevaPassword = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.btnRegresarLogin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNuevaPassword);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.txtConfirmarPassword);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(333, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 540);
            this.panel2.TabIndex = 14;
            // 
            // btnRegresarLogin
            // 
            this.btnRegresarLogin.Location = new System.Drawing.Point(22, 25);
            this.btnRegresarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresarLogin.Name = "btnRegresarLogin";
            this.btnRegresarLogin.Size = new System.Drawing.Size(74, 26);
            this.btnRegresarLogin.TabIndex = 19;
            this.btnRegresarLogin.Text = "Regresar";
            this.btnRegresarLogin.UseVisualStyleBackColor = true;
            this.btnRegresarLogin.Click += new System.EventHandler(this.btnRegresarLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "Actualizar contraseña";
            // 
            // txtNuevaPassword
            // 
            this.txtNuevaPassword.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaPassword.Location = new System.Drawing.Point(31, 174);
            this.txtNuevaPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaPassword.Name = "txtNuevaPassword";
            this.txtNuevaPassword.Size = new System.Drawing.Size(462, 39);
            this.txtNuevaPassword.TabIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(134, 420);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(214, 47);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarPassword.Location = new System.Drawing.Point(31, 335);
            this.txtConfirmarPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.Size = new System.Drawing.Size(462, 39);
            this.txtConfirmarPassword.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 19F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vuelva a ingresar la nueva contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 19F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Escriba su nueva contraseña:";
            // 
            // FormActualizarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 556);
            this.Controls.Add(this.panel2);
            this.Name = "FormActualizarContrasena";
            this.Text = "FormActualizarContrasena";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegresarLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevaPassword;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}