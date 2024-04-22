namespace tpcai_electrhogar
{
    partial class ListadoClientesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancelarContrasena = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.direccionLbl = new System.Windows.Forms.Label();
            this.direccionCambio = new System.Windows.Forms.TextBox();
            this.telefonoLbl = new System.Windows.Forms.Label();
            this.telefonoCambio = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailCambio = new System.Windows.Forms.TextBox();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClientes.Location = new System.Drawing.Point(0, 211);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(784, 150);
            this.dgvClientes.TabIndex = 25;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(556, 176);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnCancelarContrasena
            // 
            this.btnCancelarContrasena.BackColor = System.Drawing.Color.Red;
            this.btnCancelarContrasena.FlatAppearance.BorderSize = 0;
            this.btnCancelarContrasena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelarContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarContrasena.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarContrasena.Location = new System.Drawing.Point(21, 166);
            this.btnCancelarContrasena.Name = "btnCancelarContrasena";
            this.btnCancelarContrasena.Size = new System.Drawing.Size(120, 30);
            this.btnCancelarContrasena.TabIndex = 3;
            this.btnCancelarContrasena.Text = "Cancelar";
            this.btnCancelarContrasena.UseVisualStyleBackColor = false;
            this.btnCancelarContrasena.Click += new System.EventHandler(this.btnCancelarContrasena_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(28, 130);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 21;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(347, -4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 38);
            this.lblTitle.TabIndex = 85;
            this.lblTitle.Text = "Modificar Usuario";
            // 
            // direccionLbl
            // 
            this.direccionLbl.AutoSize = true;
            this.direccionLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionLbl.ForeColor = System.Drawing.Color.Transparent;
            this.direccionLbl.Location = new System.Drawing.Point(17, 10);
            this.direccionLbl.Name = "direccionLbl";
            this.direccionLbl.Size = new System.Drawing.Size(84, 19);
            this.direccionLbl.TabIndex = 84;
            this.direccionLbl.Text = "Direccion";
            // 
            // direccionCambio
            // 
            this.direccionCambio.BackColor = System.Drawing.SystemColors.Window;
            this.direccionCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direccionCambio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionCambio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.direccionCambio.Location = new System.Drawing.Point(107, 10);
            this.direccionCambio.Multiline = true;
            this.direccionCambio.Name = "direccionCambio";
            this.direccionCambio.Size = new System.Drawing.Size(173, 23);
            this.direccionCambio.TabIndex = 83;
            // 
            // telefonoLbl
            // 
            this.telefonoLbl.AutoSize = true;
            this.telefonoLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoLbl.ForeColor = System.Drawing.Color.Transparent;
            this.telefonoLbl.Location = new System.Drawing.Point(17, 47);
            this.telefonoLbl.Name = "telefonoLbl";
            this.telefonoLbl.Size = new System.Drawing.Size(75, 19);
            this.telefonoLbl.TabIndex = 87;
            this.telefonoLbl.Text = "Telefono";
            // 
            // telefonoCambio
            // 
            this.telefonoCambio.BackColor = System.Drawing.SystemColors.Window;
            this.telefonoCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonoCambio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoCambio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.telefonoCambio.Location = new System.Drawing.Point(105, 47);
            this.telefonoCambio.Multiline = true;
            this.telefonoCambio.Name = "telefonoCambio";
            this.telefonoCambio.Size = new System.Drawing.Size(173, 23);
            this.telefonoCambio.TabIndex = 86;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.Transparent;
            this.emailLbl.Location = new System.Drawing.Point(16, 86);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(53, 19);
            this.emailLbl.TabIndex = 89;
            this.emailLbl.Text = "Email";
            // 
            // emailCambio
            // 
            this.emailCambio.BackColor = System.Drawing.SystemColors.Window;
            this.emailCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailCambio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCambio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.emailCambio.Location = new System.Drawing.Point(105, 91);
            this.emailCambio.Multiline = true;
            this.emailCambio.Name = "emailCambio";
            this.emailCambio.Size = new System.Drawing.Size(173, 23);
            this.emailCambio.TabIndex = 88;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.Color.LightGray;
            this.btnModificarCliente.Location = new System.Drawing.Point(162, 166);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(142, 33);
            this.btnModificarCliente.TabIndex = 90;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // ListadoClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.emailCambio);
            this.Controls.Add(this.telefonoLbl);
            this.Controls.Add(this.telefonoCambio);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.direccionLbl);
            this.Controls.Add(this.direccionCambio);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelarContrasena);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoClientesForm";
            this.Opacity = 0.9D;
            this.Text = "ListadoClientesForm";
            this.Load += new System.EventHandler(this.ListadoClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancelarContrasena;
        private System.Windows.Forms.Button modificarCliente_Click;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label direccionLbl;
        private System.Windows.Forms.TextBox direccionCambio;
        private System.Windows.Forms.Label telefonoLbl;
        private System.Windows.Forms.TextBox telefonoCambio;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailCambio;
        private System.Windows.Forms.Button btnModificarCliente;
    }
}