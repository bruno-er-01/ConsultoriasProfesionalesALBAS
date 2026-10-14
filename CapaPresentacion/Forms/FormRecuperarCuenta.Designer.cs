namespace CapaPresentacion
{
    partial class FormRecuperarCuenta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresarLoginq = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnviarCodigo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnVerificarCodigo = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresarLoginq)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imgLogoOriginal;
            this.pictureBox1.Location = new System.Drawing.Point(175, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresarLoginq
            // 
            this.btnRegresarLoginq.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresarLoginq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresarLoginq.Image = global::CapaPresentacion.Properties.Resources.imgRegresar;
            this.btnRegresarLoginq.Location = new System.Drawing.Point(36, 36);
            this.btnRegresarLoginq.Name = "btnRegresarLoginq";
            this.btnRegresarLoginq.Size = new System.Drawing.Size(80, 51);
            this.btnRegresarLoginq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegresarLoginq.TabIndex = 22;
            this.btnRegresarLoginq.TabStop = false;
            this.btnRegresarLoginq.Click += new System.EventHandler(this.btnRegresarLoginq_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnEnviarCodigo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.btnVerificarCodigo);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(917, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 825);
            this.panel1.TabIndex = 24;
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.BackColor = System.Drawing.Color.IndianRed;
            this.btnEnviarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarCodigo.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCodigo.Location = new System.Drawing.Point(145, 383);
            this.btnEnviarCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.Size = new System.Drawing.Size(165, 32);
            this.btnEnviarCodigo.TabIndex = 18;
            this.btnEnviarCodigo.Text = "Enviar código";
            this.btnEnviarCodigo.UseVisualStyleBackColor = false;
            this.btnEnviarCodigo.Click += new System.EventHandler(this.btnEnviarCodigo_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(265, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 67);
            this.label4.TabIndex = 17;
            this.label4.Text = "Recuperar cuenta";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(145, 318);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(639, 47);
            this.txtCorreo.TabIndex = 11;
            // 
            // btnVerificarCodigo
            // 
            this.btnVerificarCodigo.BackColor = System.Drawing.Color.Maroon;
            this.btnVerificarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificarCodigo.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerificarCodigo.Location = new System.Drawing.Point(334, 639);
            this.btnVerificarCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerificarCodigo.Name = "btnVerificarCodigo";
            this.btnVerificarCodigo.Size = new System.Drawing.Size(285, 58);
            this.btnVerificarCodigo.TabIndex = 15;
            this.btnVerificarCodigo.Text = "Verificar código";
            this.btnVerificarCodigo.UseVisualStyleBackColor = false;
            this.btnVerificarCodigo.Click += new System.EventHandler(this.btnVerificarCodigo_Click_1);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(145, 516);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(639, 47);
            this.txtCodigo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(135, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 40);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingrese el código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(135, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "Correo:";
            // 
            // FormRecuperarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.imgFondoRecuperarCuenta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1900, 1051);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresarLoginq);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1918, 1098);
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "FormRecuperarCuenta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormRecuperarCuenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresarLoginq)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnRegresarLoginq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnviarCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnVerificarCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.Label label6;
    }
}