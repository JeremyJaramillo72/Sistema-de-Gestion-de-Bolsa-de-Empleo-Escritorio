namespace APP_NET
{
    partial class frmAgregarPerfilEmpresa
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
            this.lbNombreEmpresa = new System.Windows.Forms.Label();
            this.cbtipoSector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCiudad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbRuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSitioWeb = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripcionEmpresa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_registrarEmpresa = new Guna.UI2.WinForms.Guna2Button();
            this.pctimagen = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctimagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lbNombreEmpresa
            // 
            this.lbNombreEmpresa.AutoSize = true;
            this.lbNombreEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.lbNombreEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNombreEmpresa.Location = new System.Drawing.Point(194, 35);
            this.lbNombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreEmpresa.Name = "lbNombreEmpresa";
            this.lbNombreEmpresa.Size = new System.Drawing.Size(268, 28);
            this.lbNombreEmpresa.TabIndex = 33;
            this.lbNombreEmpresa.Text = "Nombre de la Empresa S.A.";
            // 
            // cbtipoSector
            // 
            this.cbtipoSector.BackColor = System.Drawing.Color.Transparent;
            this.cbtipoSector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbtipoSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipoSector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtipoSector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtipoSector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbtipoSector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbtipoSector.ItemHeight = 30;
            this.cbtipoSector.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbtipoSector.Location = new System.Drawing.Point(38, 279);
            this.cbtipoSector.Margin = new System.Windows.Forms.Padding(4);
            this.cbtipoSector.Name = "cbtipoSector";
            this.cbtipoSector.Size = new System.Drawing.Size(383, 36);
            this.cbtipoSector.TabIndex = 43;
            // 
            // cbCiudad
            // 
            this.cbCiudad.BackColor = System.Drawing.Color.Transparent;
            this.cbCiudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCiudad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCiudad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCiudad.ItemHeight = 30;
            this.cbCiudad.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbCiudad.Location = new System.Drawing.Point(38, 379);
            this.cbCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(383, 36);
            this.cbCiudad.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Location = new System.Drawing.Point(195, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "RUC:";
            // 
            // lbRuc
            // 
            this.lbRuc.AutoSize = true;
            this.lbRuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.lbRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuc.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbRuc.Location = new System.Drawing.Point(248, 82);
            this.lbRuc.Name = "lbRuc";
            this.lbRuc.Size = new System.Drawing.Size(131, 20);
            this.lbRuc.TabIndex = 59;
            this.lbRuc.Text = "0999546531001 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(385, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Configuración del Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(370, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 28);
            this.label5.TabIndex = 62;
            this.label5.Text = "Información General";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(36, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "SECTOR INDUSTRIAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(467, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "SITIO WEB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(467, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "DIRECCIÓN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(36, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "CIUDAD / SEDE PRINCIPAL";
            // 
            // txtSitioWeb
            // 
            this.txtSitioWeb.BorderRadius = 15;
            this.txtSitioWeb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSitioWeb.DefaultText = "";
            this.txtSitioWeb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSitioWeb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSitioWeb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSitioWeb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSitioWeb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSitioWeb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSitioWeb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSitioWeb.Location = new System.Drawing.Point(461, 271);
            this.txtSitioWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSitioWeb.MaxLength = 50;
            this.txtSitioWeb.Name = "txtSitioWeb";
            this.txtSitioWeb.PlaceholderText = "www.miempresa.com";
            this.txtSitioWeb.SelectedText = "";
            this.txtSitioWeb.Size = new System.Drawing.Size(492, 44);
            this.txtSitioWeb.TabIndex = 67;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderRadius = 15;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "";
            this.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.Location = new System.Drawing.Point(461, 374);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Av. Francisco de Orellana...";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.Size = new System.Drawing.Size(492, 44);
            this.txtDireccion.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 458);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 28);
            this.label10.TabIndex = 69;
            this.label10.Text = "Sobre Nosotros";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(19, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = "DESCRIPCIÓN DE LA EMPRESA";
            // 
            // txtDescripcionEmpresa
            // 
            this.txtDescripcionEmpresa.BorderRadius = 15;
            this.txtDescripcionEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionEmpresa.DefaultText = "";
            this.txtDescripcionEmpresa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcionEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcionEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcionEmpresa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcionEmpresa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcionEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcionEmpresa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcionEmpresa.Location = new System.Drawing.Point(23, 524);
            this.txtDescripcionEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcionEmpresa.MaxLength = 50;
            this.txtDescripcionEmpresa.Name = "txtDescripcionEmpresa";
            this.txtDescripcionEmpresa.PlaceholderText = "Av. Francisco de Orellana...";
            this.txtDescripcionEmpresa.SelectedText = "";
            this.txtDescripcionEmpresa.Size = new System.Drawing.Size(930, 73);
            this.txtDescripcionEmpresa.TabIndex = 71;
            // 
            // btn_registrarEmpresa
            // 
            this.btn_registrarEmpresa.BorderRadius = 15;
            this.btn_registrarEmpresa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_registrarEmpresa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_registrarEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_registrarEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_registrarEmpresa.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_registrarEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarEmpresa.ForeColor = System.Drawing.Color.White;
            this.btn_registrarEmpresa.Location = new System.Drawing.Point(692, 636);
            this.btn_registrarEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_registrarEmpresa.Name = "btn_registrarEmpresa";
            this.btn_registrarEmpresa.Size = new System.Drawing.Size(276, 55);
            this.btn_registrarEmpresa.TabIndex = 72;
            this.btn_registrarEmpresa.Text = "Guardar Cambios";
            this.btn_registrarEmpresa.Click += new System.EventHandler(this.btn_registrarEmpresa_Click);
            // 
            // pctimagen
            // 
            this.pctimagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.pctimagen.ImageRotate = 0F;
            this.pctimagen.Location = new System.Drawing.Point(38, 10);
            this.pctimagen.Name = "pctimagen";
            this.pctimagen.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctimagen.Size = new System.Drawing.Size(126, 123);
            this.pctimagen.TabIndex = 1;
            this.pctimagen.TabStop = false;
            this.pctimagen.Click += new System.EventHandler(this.pctimagen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 150);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgregarPerfilEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 722);
            this.Controls.Add(this.btn_registrarEmpresa);
            this.Controls.Add(this.txtDescripcionEmpresa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtSitioWeb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRuc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.cbtipoSector);
            this.Controls.Add(this.lbNombreEmpresa);
            this.Controls.Add(this.pctimagen);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarPerfilEmpresa";
            this.Text = "frmAgregarPerfilEmpresa";
            this.Load += new System.EventHandler(this.frmAgregarPerfilEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctimagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctimagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNombreEmpresa;
        private Guna.UI2.WinForms.Guna2ComboBox cbCiudad;
        private Guna.UI2.WinForms.Guna2ComboBox cbtipoSector;
        private System.Windows.Forms.Label lbRuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcionEmpresa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtDireccion;
        private Guna.UI2.WinForms.Guna2TextBox txtSitioWeb;
        private Guna.UI2.WinForms.Guna2Button btn_registrarEmpresa;
    }
}