namespace tpcai_electrhogar
{
    partial class RegistrarUsuariosForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuariosForm));
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDirección = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.comboBoxPerfil = new System.Windows.Forms.ComboBox();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreError = new System.Windows.Forms.Label();
            this.lblApellidoError = new System.Windows.Forms.Label();
            this.lblDNIError = new System.Windows.Forms.Label();
            this.lblDireccionError = new System.Windows.Forms.Label();
            this.lblTelefonoError = new System.Windows.Forms.Label();
            this.lblMailError = new System.Windows.Forms.Label();
            this.lblUsuarioError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(392, 383);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(100, 23);
            this.btnCrearUsuario.TabIndex = 0;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 450);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tpcai_electrhogar.Properties.Resources.Electro_Hogar_80x102;
            this.pictureBox1.Location = new System.Drawing.Point(39, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNombre.Location = new System.Drawing.Point(240, 22);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(173, 14);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.Text = "Nombre";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(470, 22);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(173, 14);
            this.textBoxApellido.TabIndex = 3;
            this.textBoxApellido.Text = "Apellido";
            // 
            // textBoxDirección
            // 
            this.textBoxDirección.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDirección.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDirección.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirección.Location = new System.Drawing.Point(240, 155);
            this.textBoxDirección.Name = "textBoxDirección";
            this.textBoxDirección.Size = new System.Drawing.Size(403, 14);
            this.textBoxDirección.TabIndex = 4;
            this.textBoxDirección.Text = "Dirección";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefono.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(240, 198);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(403, 14);
            this.textBoxTelefono.TabIndex = 5;
            this.textBoxTelefono.Text = "Teléfono";
            // 
            // textBoxMail
            // 
            this.textBoxMail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.Location = new System.Drawing.Point(240, 240);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(403, 14);
            this.textBoxMail.TabIndex = 6;
            this.textBoxMail.Text = "Correo Elecrónico";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(382, 107);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 3, 23, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 21);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2024, 3, 23, 0, 0, 0, 0);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(237, 113);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(124, 13);
            this.lblFechaNacimiento.TabIndex = 9;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDNI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.Location = new System.Drawing.Point(240, 63);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(403, 14);
            this.textBoxDNI.TabIndex = 10;
            this.textBoxDNI.Text = "DNI";
            // 
            // comboBoxPerfil
            // 
            this.comboBoxPerfil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPerfil.FormattingEnabled = true;
            this.comboBoxPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Supervisior",
            "Vendedor"});
            this.comboBoxPerfil.Location = new System.Drawing.Point(240, 324);
            this.comboBoxPerfil.Name = "comboBoxPerfil";
            this.comboBoxPerfil.Size = new System.Drawing.Size(403, 21);
            this.comboBoxPerfil.TabIndex = 11;
            this.comboBoxPerfil.Text = "Perfil";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(240, 283);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(403, 14);
            this.textBoxNombreUsuario.TabIndex = 12;
            this.textBoxNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblNombreError
            // 
            this.lblNombreError.AutoSize = true;
            this.lblNombreError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNombreError.Location = new System.Drawing.Point(237, 39);
            this.lblNombreError.Name = "lblNombreError";
            this.lblNombreError.Size = new System.Drawing.Size(0, 13);
            this.lblNombreError.TabIndex = 13;
            // 
            // lblApellidoError
            // 
            this.lblApellidoError.AutoSize = true;
            this.lblApellidoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblApellidoError.Location = new System.Drawing.Point(467, 39);
            this.lblApellidoError.Name = "lblApellidoError";
            this.lblApellidoError.Size = new System.Drawing.Size(0, 13);
            this.lblApellidoError.TabIndex = 14;
            // 
            // lblDNIError
            // 
            this.lblDNIError.AutoSize = true;
            this.lblDNIError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDNIError.Location = new System.Drawing.Point(237, 80);
            this.lblDNIError.Name = "lblDNIError";
            this.lblDNIError.Size = new System.Drawing.Size(0, 13);
            this.lblDNIError.TabIndex = 15;
            // 
            // lblDireccionError
            // 
            this.lblDireccionError.AutoSize = true;
            this.lblDireccionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDireccionError.Location = new System.Drawing.Point(237, 172);
            this.lblDireccionError.Name = "lblDireccionError";
            this.lblDireccionError.Size = new System.Drawing.Size(0, 13);
            this.lblDireccionError.TabIndex = 16;
            // 
            // lblTelefonoError
            // 
            this.lblTelefonoError.AutoSize = true;
            this.lblTelefonoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTelefonoError.Location = new System.Drawing.Point(237, 215);
            this.lblTelefonoError.Name = "lblTelefonoError";
            this.lblTelefonoError.Size = new System.Drawing.Size(0, 13);
            this.lblTelefonoError.TabIndex = 17;
            // 
            // lblMailError
            // 
            this.lblMailError.AutoSize = true;
            this.lblMailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMailError.Location = new System.Drawing.Point(237, 257);
            this.lblMailError.Name = "lblMailError";
            this.lblMailError.Size = new System.Drawing.Size(0, 13);
            this.lblMailError.TabIndex = 18;
            // 
            // lblUsuarioError
            // 
            this.lblUsuarioError.AutoSize = true;
            this.lblUsuarioError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUsuarioError.Location = new System.Drawing.Point(237, 300);
            this.lblUsuarioError.Name = "lblUsuarioError";
            this.lblUsuarioError.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioError.TabIndex = 19;
            // 
            // RegistrarUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(99)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuarioError);
            this.Controls.Add(this.lblMailError);
            this.Controls.Add(this.lblTelefonoError);
            this.Controls.Add(this.lblDireccionError);
            this.Controls.Add(this.lblDNIError);
            this.Controls.Add(this.lblApellidoError);
            this.Controls.Add(this.lblNombreError);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.comboBoxPerfil);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxDirección);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrearUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarUsuariosForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuarios";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDirección;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.ComboBox comboBoxPerfil;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label lblNombreError;
        private System.Windows.Forms.Label lblApellidoError;
        private System.Windows.Forms.Label lblDNIError;
        private System.Windows.Forms.Label lblDireccionError;
        private System.Windows.Forms.Label lblTelefonoError;
        private System.Windows.Forms.Label lblMailError;
        private System.Windows.Forms.Label lblUsuarioError;
    }
}

