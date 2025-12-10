namespace APP_NET.FRMNUEVOS
{
    partial class frmEditExpe
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bordes_Boton2 = new APP_NET.Controls.Bordes_Boton();
            this.btn_eliminaRegistro_exp = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardarCambiosExp = new Guna.UI2.WinForms.Guna2Button();
            this.dgvExperienciaLaboral = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperienciaLaboral)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Edita tu Experiencia Laboral";
            // 
            // bordes_Boton2
            // 
            this.bordes_Boton2.BackColor = System.Drawing.Color.Black;
            this.bordes_Boton2.BackgroundColor = System.Drawing.Color.Black;
            this.bordes_Boton2.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.bordes_Boton2.BorderRadius = 15;
            this.bordes_Boton2.BorderSize = 0;
            this.bordes_Boton2.FlatAppearance.BorderSize = 0;
            this.bordes_Boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bordes_Boton2.ForeColor = System.Drawing.Color.Black;
            this.bordes_Boton2.Location = new System.Drawing.Point(31, 14);
            this.bordes_Boton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bordes_Boton2.Name = "bordes_Boton2";
            this.bordes_Boton2.Size = new System.Drawing.Size(83, 46);
            this.bordes_Boton2.TabIndex = 21;
            this.bordes_Boton2.TextColor = System.Drawing.Color.Black;
            this.bordes_Boton2.UseVisualStyleBackColor = false;
            this.bordes_Boton2.Click += new System.EventHandler(this.bordes_Boton2_Click);
            // 
            // btn_eliminaRegistro_exp
            // 
            this.btn_eliminaRegistro_exp.BorderRadius = 15;
            this.btn_eliminaRegistro_exp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminaRegistro_exp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminaRegistro_exp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminaRegistro_exp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminaRegistro_exp.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_eliminaRegistro_exp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminaRegistro_exp.ForeColor = System.Drawing.Color.White;
            this.btn_eliminaRegistro_exp.Location = new System.Drawing.Point(701, 373);
            this.btn_eliminaRegistro_exp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminaRegistro_exp.Name = "btn_eliminaRegistro_exp";
            this.btn_eliminaRegistro_exp.Size = new System.Drawing.Size(268, 46);
            this.btn_eliminaRegistro_exp.TabIndex = 24;
            this.btn_eliminaRegistro_exp.Text = "Eliminar registro";
            this.btn_eliminaRegistro_exp.Click += new System.EventHandler(this.btn_eliminaRegistro_exp_Click);
            // 
            // btnGuardarCambiosExp
            // 
            this.btnGuardarCambiosExp.BorderRadius = 15;
            this.btnGuardarCambiosExp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambiosExp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambiosExp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarCambiosExp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarCambiosExp.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardarCambiosExp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambiosExp.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambiosExp.Location = new System.Drawing.Point(159, 373);
            this.btnGuardarCambiosExp.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCambiosExp.Name = "btnGuardarCambiosExp";
            this.btnGuardarCambiosExp.Size = new System.Drawing.Size(268, 46);
            this.btnGuardarCambiosExp.TabIndex = 23;
            this.btnGuardarCambiosExp.Text = "Guardar cambios";
            this.btnGuardarCambiosExp.Click += new System.EventHandler(this.btnGuardarCambiosExp_Click);
            // 
            // dgvExperienciaLaboral
            // 
            this.dgvExperienciaLaboral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExperienciaLaboral.Location = new System.Drawing.Point(93, 85);
            this.dgvExperienciaLaboral.Margin = new System.Windows.Forms.Padding(4);
            this.dgvExperienciaLaboral.Name = "dgvExperienciaLaboral";
            this.dgvExperienciaLaboral.RowHeadersWidth = 51;
            this.dgvExperienciaLaboral.Size = new System.Drawing.Size(939, 260);
            this.dgvExperienciaLaboral.TabIndex = 25;
            this.dgvExperienciaLaboral.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExperienciaLaboral_CellDoubleClick);
            // 
            // frmEditExpe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 490);
            this.Controls.Add(this.dgvExperienciaLaboral);
            this.Controls.Add(this.btn_eliminaRegistro_exp);
            this.Controls.Add(this.btnGuardarCambiosExp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bordes_Boton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditExpe";
            this.Text = "frmEditExpe";
            this.Load += new System.EventHandler(this.frmEditExpe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperienciaLaboral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private Controls.Bordes_Boton bordes_Boton2;
        private Guna.UI2.WinForms.Guna2Button btn_eliminaRegistro_exp;
        private Guna.UI2.WinForms.Guna2Button btnGuardarCambiosExp;
        private System.Windows.Forms.DataGridView dgvExperienciaLaboral;
    }
}