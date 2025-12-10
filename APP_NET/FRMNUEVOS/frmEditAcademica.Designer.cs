namespace APP_NET.FRMNUEVOS
{
    partial class frmEditAcademica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAcademica));
            this.dgvInfoAcademica = new System.Windows.Forms.DataGridView();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnGuardarCambios = new Guna.UI2.WinForms.Guna2Button();
            this.btn_eliminaRegistro = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bordes_Boton2 = new APP_NET.Controls.Bordes_Boton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoAcademica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfoAcademica
            // 
            this.dgvInfoAcademica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoAcademica.Location = new System.Drawing.Point(55, 82);
            this.dgvInfoAcademica.Name = "dgvInfoAcademica";
            this.dgvInfoAcademica.Size = new System.Drawing.Size(617, 187);
            this.dgvInfoAcademica.TabIndex = 0;
            this.dgvInfoAcademica.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoAcademica_CellDoubleClick);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BorderRadius = 15;
            this.btnGuardarCambios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarCambios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarCambios.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(64, 295);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(201, 37);
            this.btnGuardarCambios.TabIndex = 18;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btn_eliminaRegistro
            // 
            this.btn_eliminaRegistro.BorderRadius = 15;
            this.btn_eliminaRegistro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminaRegistro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminaRegistro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminaRegistro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminaRegistro.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_eliminaRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminaRegistro.ForeColor = System.Drawing.Color.White;
            this.btn_eliminaRegistro.Location = new System.Drawing.Point(471, 295);
            this.btn_eliminaRegistro.Name = "btn_eliminaRegistro";
            this.btn_eliminaRegistro.Size = new System.Drawing.Size(201, 37);
            this.btn_eliminaRegistro.TabIndex = 19;
            this.btn_eliminaRegistro.Text = "Eliminar registro";
            this.btn_eliminaRegistro.Click += new System.EventHandler(this.btn_eliminaRegistro_Click);
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Edita tu Información Académica";
            // 
            // bordes_Boton2
            // 
            this.bordes_Boton2.BackColor = System.Drawing.Color.Transparent;
            this.bordes_Boton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bordes_Boton2.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.bordes_Boton2.BorderRadius = 15;
            this.bordes_Boton2.BorderSize = 0;
            this.bordes_Boton2.FlatAppearance.BorderSize = 0;
            this.bordes_Boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bordes_Boton2.ForeColor = System.Drawing.Color.White;
            this.bordes_Boton2.Image = ((System.Drawing.Image)(resources.GetObject("bordes_Boton2.Image")));
            this.bordes_Boton2.Location = new System.Drawing.Point(11, 11);
            this.bordes_Boton2.Margin = new System.Windows.Forms.Padding(2);
            this.bordes_Boton2.Name = "bordes_Boton2";
            this.bordes_Boton2.Size = new System.Drawing.Size(62, 37);
            this.bordes_Boton2.TabIndex = 17;
            this.bordes_Boton2.TextColor = System.Drawing.Color.White;
            this.bordes_Boton2.UseVisualStyleBackColor = false;
            this.bordes_Boton2.Click += new System.EventHandler(this.bordes_Boton2_Click);
            // 
            // frmEditAcademica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminaRegistro);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.bordes_Boton2);
            this.Controls.Add(this.dgvInfoAcademica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditAcademica";
            this.Text = "frmEditAcademica";
            this.Load += new System.EventHandler(this.frmEditAcademica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoAcademica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfoAcademica;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Controls.Bordes_Boton bordes_Boton2;
        private Guna.UI2.WinForms.Guna2Button btn_eliminaRegistro;
        private Guna.UI2.WinForms.Guna2Button btnGuardarCambios;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private System.Windows.Forms.Label label1;
    }
}