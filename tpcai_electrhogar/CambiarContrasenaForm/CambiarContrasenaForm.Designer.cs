namespace tpcai_electrhogar
{
    partial class CambiarContrasenaForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContraseñaActual = new System.Windows.Forms.TextBox();
            this.cancelarContrasena = new System.Windows.Forms.Button();
            this.GuardarContrasena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.RepetirContrasena = new System.Windows.Forms.TextBox();
            this.ContrasenaNueva = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 261);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tpcai_electrhogar.Properties.Resources.Electro_Hogar_80x102;
            this.pictureBox2.Location = new System.Drawing.Point(34, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tpcai_electrhogar.Properties.Resources.Electro_Hogar_80x102;
            this.pictureBox1.Location = new System.Drawing.Point(52, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ContraseñaActual
            // 
            this.ContraseñaActual.Location = new System.Drawing.Point(317, 24);
            this.ContraseñaActual.Name = "ContraseñaActual";
            this.ContraseñaActual.Size = new System.Drawing.Size(216, 20);
            this.ContraseñaActual.TabIndex = 4;
            this.ContraseñaActual.TextChanged += new System.EventHandler(this.ContraseñaActual_TextChanged);
            // 
            // cancelarContrasena
            // 
            this.cancelarContrasena.Location = new System.Drawing.Point(403, 226);
            this.cancelarContrasena.Name = "cancelarContrasena";
            this.cancelarContrasena.Size = new System.Drawing.Size(75, 23);
            this.cancelarContrasena.TabIndex = 6;
            this.cancelarContrasena.Text = "Cancelar";
            this.cancelarContrasena.UseVisualStyleBackColor = true;
            this.cancelarContrasena.Click += new System.EventHandler(this.cancelarContrasena_Click);
            // 
            // GuardarContrasena
            // 
            this.GuardarContrasena.Location = new System.Drawing.Point(497, 226);
            this.GuardarContrasena.Name = "GuardarContrasena";
            this.GuardarContrasena.Size = new System.Drawing.Size(75, 23);
            this.GuardarContrasena.TabIndex = 7;
            this.GuardarContrasena.Text = "Guardar";
            this.GuardarContrasena.UseVisualStyleBackColor = true;
            this.GuardarContrasena.Click += new System.EventHandler(this.GuardarContrasena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(200, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(199, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña Nueva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(194, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Repetir Contraseña";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(297, 145);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 11;
            // 
            // RepetirContrasena
            // 
            this.RepetirContrasena.Location = new System.Drawing.Point(317, 100);
            this.RepetirContrasena.Name = "RepetirContrasena";
            this.RepetirContrasena.Size = new System.Drawing.Size(216, 20);
            this.RepetirContrasena.TabIndex = 12;
            // 
            // ContrasenaNueva
            // 
            this.ContrasenaNueva.Location = new System.Drawing.Point(317, 63);
            this.ContrasenaNueva.Name = "ContrasenaNueva";
            this.ContrasenaNueva.Size = new System.Drawing.Size(216, 20);
            this.ContrasenaNueva.TabIndex = 13;
            // 
            // CambiarContrasenaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(99)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.ContrasenaNueva);
            this.Controls.Add(this.RepetirContrasena);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuardarContrasena);
            this.Controls.Add(this.cancelarContrasena);
            this.Controls.Add(this.ContraseñaActual);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CambiarContrasenaForm";
            this.Text = "CambiarContrasenaForm";
            this.Load += new System.EventHandler(this.CambiarContrasenaForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ContraseñaActual;
        private System.Windows.Forms.Button cancelarContrasena;
        private System.Windows.Forms.Button GuardarContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox RepetirContrasena;
        private System.Windows.Forms.TextBox ContrasenaNueva;
    }
}