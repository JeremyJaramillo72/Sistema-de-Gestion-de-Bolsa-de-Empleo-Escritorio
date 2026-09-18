namespace APP_NET.FRMNUEVOS
{
    partial class frmIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdioma));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bordes_Boton2 = new APP_NET.Controls.Bordes_Boton();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoCertificado = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_AdjuntoArchiI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardaEL = new Guna.UI2.WinForms.Guna2Button();
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
            this.label1.Location = new System.Drawing.Point(179, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sube el certificado del Idioma";
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
            this.bordes_Boton2.Location = new System.Drawing.Point(15, 14);
            this.bordes_Boton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bordes_Boton2.Name = "bordes_Boton2";
            this.bordes_Boton2.Size = new System.Drawing.Size(83, 46);
            this.bordes_Boton2.TabIndex = 18;
            this.bordes_Boton2.TextColor = System.Drawing.Color.White;
            this.bordes_Boton2.UseVisualStyleBackColor = false;
            this.bordes_Boton2.Click += new System.EventHandler(this.bordes_Boton2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(449, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Certificado idioma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Código Certificado";
            // 
            // txtCodigoCertificado
            // 
            this.txtCodigoCertificado.BorderRadius = 15;
            this.txtCodigoCertificado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoCertificado.DefaultText = "";
            this.txtCodigoCertificado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoCertificado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoCertificado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoCertificado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoCertificado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoCertificado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigoCertificado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoCertificado.Location = new System.Drawing.Point(64, 130);
            this.txtCodigoCertificado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoCertificado.Name = "txtCodigoCertificado";
            this.txtCodigoCertificado.PlaceholderText = "";
            this.txtCodigoCertificado.SelectedText = "";
            this.txtCodigoCertificado.Size = new System.Drawing.Size(267, 44);
            this.txtCodigoCertificado.TabIndex = 37;
            // 
            // Btn_AdjuntoArchiI
            // 
            this.Btn_AdjuntoArchiI.BorderRadius = 15;
            this.Btn_AdjuntoArchiI.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AdjuntoArchiI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AdjuntoArchiI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_AdjuntoArchiI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_AdjuntoArchiI.FillColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_AdjuntoArchiI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AdjuntoArchiI.ForeColor = System.Drawing.Color.White;
            this.Btn_AdjuntoArchiI.Location = new System.Drawing.Point(411, 127);
            this.Btn_AdjuntoArchiI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_AdjuntoArchiI.Name = "Btn_AdjuntoArchiI";
            this.Btn_AdjuntoArchiI.Size = new System.Drawing.Size(263, 55);
            this.Btn_AdjuntoArchiI.TabIndex = 38;
            this.Btn_AdjuntoArchiI.Text = "Seleccionar Archivo";
            this.Btn_AdjuntoArchiI.Click += new System.EventHandler(this.Btn_AdjuntoArchiI_Click);
            // 
            // btn_guardaEL
            // 
            this.btn_guardaEL.BorderRadius = 15;
            this.btn_guardaEL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardaEL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardaEL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guardaEL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guardaEL.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_guardaEL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardaEL.ForeColor = System.Drawing.Color.White;
            this.btn_guardaEL.Location = new System.Drawing.Point(64, 251);
            this.btn_guardaEL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardaEL.Name = "btn_guardaEL";
            this.btn_guardaEL.Size = new System.Drawing.Size(205, 55);
            this.btn_guardaEL.TabIndex = 39;
            this.btn_guardaEL.Text = "Guardar";
            this.btn_guardaEL.Click += new System.EventHandler(this.btn_guardaEL_Click);
            // 
            // frmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 321);
            this.Controls.Add(this.btn_guardaEL);
            this.Controls.Add(this.Btn_AdjuntoArchiI);
            this.Controls.Add(this.txtCodigoCertificado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bordes_Boton2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmIdioma";
            this.Text = "frmIdioma";
            this.Load += new System.EventHandler(this.frmIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private Controls.Bordes_Boton bordes_Boton2;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoCertificado;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Btn_AdjuntoArchiI;
        private Guna.UI2.WinForms.Guna2Button btn_guardaEL;
    }
}