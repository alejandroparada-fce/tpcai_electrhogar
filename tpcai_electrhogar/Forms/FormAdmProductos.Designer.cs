﻿namespace tpcai_electrhogar.Forms
{
    partial class FormAdmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmProductos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.categoria = new System.Windows.Forms.TextBox();
            this.lbldUsuario = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.btnTraerProductosCategoria = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 611);
            this.panel1.TabIndex = 106;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tpcai_electrhogar.Properties.Resources.Electro_Hogar_80x102;
            this.pictureBox1.Location = new System.Drawing.Point(62, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(283, 183);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(562, 284);
            this.dgvProductos.TabIndex = 119;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // categoria
            // 
            this.categoria.BackColor = System.Drawing.SystemColors.Window;
            this.categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoria.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.categoria.Location = new System.Drawing.Point(468, 74);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(183, 26);
            this.categoria.TabIndex = 1;
            // 
            // lbldUsuario
            // 
            this.lbldUsuario.AutoSize = true;
            this.lbldUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.lbldUsuario.Location = new System.Drawing.Point(350, 78);
            this.lbldUsuario.Name = "lbldUsuario";
            this.lbldUsuario.Size = new System.Drawing.Size(112, 19);
            this.lbldUsuario.TabIndex = 117;
            this.lbldUsuario.Text = "ID Categoria";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblCredits.Location = new System.Drawing.Point(809, 570);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(78, 16);
            this.lblCredits.TabIndex = 115;
            this.lblCredits.Text = "G6 Softwares";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblVersion.Location = new System.Drawing.Point(857, 586);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(30, 16);
            this.lblVersion.TabIndex = 116;
            this.lblVersion.Text = "v1.0";
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(851, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(15, 15);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 114;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(830, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 113;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(872, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 112;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(387, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(353, 38);
            this.lblTitle.TabIndex = 111;
            this.lblTitle.Text = "Administrar Productos";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.eliminarBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.eliminarBtn.FlatAppearance.BorderSize = 0;
            this.eliminarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.eliminarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.ForeColor = System.Drawing.Color.LightGray;
            this.eliminarBtn.Location = new System.Drawing.Point(705, 485);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(140, 40);
            this.eliminarBtn.TabIndex = 6;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.modificarBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.modificarBtn.FlatAppearance.BorderSize = 0;
            this.modificarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.modificarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarBtn.ForeColor = System.Drawing.Color.LightGray;
            this.modificarBtn.Location = new System.Drawing.Point(494, 485);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(140, 40);
            this.modificarBtn.TabIndex = 5;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = false;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(354, 106);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 124;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(394, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(340, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AgregarBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AgregarBtn.FlatAppearance.BorderSize = 0;
            this.AgregarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.AgregarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.ForeColor = System.Drawing.Color.LightGray;
            this.AgregarBtn.Location = new System.Drawing.Point(283, 485);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(140, 40);
            this.AgregarBtn.TabIndex = 4;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = false;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // btnTraerProductosCategoria
            // 
            this.btnTraerProductosCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnTraerProductosCategoria.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTraerProductosCategoria.FlatAppearance.BorderSize = 0;
            this.btnTraerProductosCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTraerProductosCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTraerProductosCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraerProductosCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerProductosCategoria.ForeColor = System.Drawing.Color.LightGray;
            this.btnTraerProductosCategoria.Location = new System.Drawing.Point(665, 67);
            this.btnTraerProductosCategoria.Name = "btnTraerProductosCategoria";
            this.btnTraerProductosCategoria.Size = new System.Drawing.Size(140, 40);
            this.btnTraerProductosCategoria.TabIndex = 2;
            this.btnTraerProductosCategoria.Text = "Traer Productos";
            this.btnTraerProductosCategoria.UseVisualStyleBackColor = false;
            this.btnTraerProductosCategoria.Click += new System.EventHandler(this.btnTraerProductosCategoria_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(431, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cargar todos los prodcutos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(899, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTraerProductosCategoria);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.lbldUsuario);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmProductos";
            this.Opacity = 0.95D;
            this.Text = "FormProductoBaja";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormProductoBaja_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox categoria;
        private System.Windows.Forms.Label lbldUsuario;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button btnTraerProductosCategoria;
        private System.Windows.Forms.Button button1;
    }
}