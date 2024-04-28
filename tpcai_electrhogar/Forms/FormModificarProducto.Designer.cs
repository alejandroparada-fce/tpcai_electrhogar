namespace tpcai_electrhogar.Forms
{
    partial class FormModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarProducto));
            this.stockLbl = new System.Windows.Forms.Label();
            this.stockCambio = new System.Windows.Forms.TextBox();
            this.precioLbl = new System.Windows.Forms.Label();
            this.precioCambio = new System.Windows.Forms.TextBox();
            this.cambiarBtn = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.ForeColor = System.Drawing.Color.Transparent;
            this.stockLbl.Location = new System.Drawing.Point(42, 93);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(53, 19);
            this.stockLbl.TabIndex = 93;
            this.stockLbl.Text = "Stock";
            // 
            // stockCambio
            // 
            this.stockCambio.BackColor = System.Drawing.SystemColors.Window;
            this.stockCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockCambio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCambio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.stockCambio.Location = new System.Drawing.Point(123, 84);
            this.stockCambio.Multiline = true;
            this.stockCambio.Name = "stockCambio";
            this.stockCambio.Size = new System.Drawing.Size(175, 28);
            this.stockCambio.TabIndex = 92;
            // 
            // precioLbl
            // 
            this.precioLbl.AutoSize = true;
            this.precioLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLbl.ForeColor = System.Drawing.Color.Transparent;
            this.precioLbl.Location = new System.Drawing.Point(42, 37);
            this.precioLbl.Name = "precioLbl";
            this.precioLbl.Size = new System.Drawing.Size(57, 19);
            this.precioLbl.TabIndex = 91;
            this.precioLbl.Text = "Precio";
            // 
            // precioCambio
            // 
            this.precioCambio.BackColor = System.Drawing.SystemColors.Window;
            this.precioCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioCambio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioCambio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.precioCambio.Location = new System.Drawing.Point(123, 28);
            this.precioCambio.Multiline = true;
            this.precioCambio.Name = "precioCambio";
            this.precioCambio.Size = new System.Drawing.Size(175, 28);
            this.precioCambio.TabIndex = 90;
            // 
            // cambiarBtn
            // 
            this.cambiarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cambiarBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cambiarBtn.FlatAppearance.BorderSize = 0;
            this.cambiarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cambiarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cambiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambiarBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarBtn.ForeColor = System.Drawing.Color.LightGray;
            this.cambiarBtn.Location = new System.Drawing.Point(208, 189);
            this.cambiarBtn.Name = "cambiarBtn";
            this.cambiarBtn.Size = new System.Drawing.Size(140, 40);
            this.cambiarBtn.TabIndex = 127;
            this.cambiarBtn.Text = "Cambiar";
            this.cambiarBtn.UseVisualStyleBackColor = false;
            this.cambiarBtn.Click += new System.EventHandler(this.cambiarBtn_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(31, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 40);
            this.btnCancelar.TabIndex = 128;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(43, 121);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 129;
            // 
            // FormModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(407, 251);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cambiarBtn);
            this.Controls.Add(this.stockLbl);
            this.Controls.Add(this.stockCambio);
            this.Controls.Add(this.precioLbl);
            this.Controls.Add(this.precioCambio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificarProducto";
            this.Opacity = 0.9D;
            this.Text = "FormModificarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.TextBox stockCambio;
        private System.Windows.Forms.Label precioLbl;
        private System.Windows.Forms.TextBox precioCambio;
        private System.Windows.Forms.Button cambiarBtn;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblError;
    }
}