namespace APP_NET
{
    partial class FrmAgregarPublicacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnsalarioP = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbExperiencia = new System.Windows.Forms.Label();
            this.btnExperiencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbModalidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbJornada = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCiudad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDescripcion = new System.Windows.Forms.TextBox();
            this.btnRegresar = new APP_NET.Controls.Bordes_Boton();
            this.btnAgregarPublicacion = new APP_NET.Controls.Bordes_Boton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 71);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar  Publicación";
            // 
            // BtnsalarioP
            // 
            this.BtnsalarioP.BorderRadius = 15;
            this.BtnsalarioP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BtnsalarioP.DefaultText = "";
            this.BtnsalarioP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BtnsalarioP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BtnsalarioP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BtnsalarioP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BtnsalarioP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BtnsalarioP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnsalarioP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BtnsalarioP.Location = new System.Drawing.Point(337, 330);
            this.BtnsalarioP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnsalarioP.Name = "BtnsalarioP";
            this.BtnsalarioP.PlaceholderText = "Promedio";
            this.BtnsalarioP.SelectedText = "";
            this.BtnsalarioP.Size = new System.Drawing.Size(233, 39);
            this.BtnsalarioP.TabIndex = 54;
            // 
            // lbSalario
            // 
            this.lbSalario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario.Location = new System.Drawing.Point(378, 303);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(155, 23);
            this.lbSalario.TabIndex = 53;
            this.lbSalario.Text = "Salario promedio";
            // 
            // lbExperiencia
            // 
            this.lbExperiencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExperiencia.Location = new System.Drawing.Point(23, 303);
            this.lbExperiencia.Name = "lbExperiencia";
            this.lbExperiencia.Size = new System.Drawing.Size(245, 23);
            this.lbExperiencia.TabIndex = 52;
            this.lbExperiencia.Text = "Experiencia Minima Requerida";
            // 
            // btnExperiencia
            // 
            this.btnExperiencia.BorderRadius = 15;
            this.btnExperiencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnExperiencia.DefaultText = "";
            this.btnExperiencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnExperiencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnExperiencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnExperiencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnExperiencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExperiencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExperiencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExperiencia.Location = new System.Drawing.Point(23, 330);
            this.btnExperiencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExperiencia.Name = "btnExperiencia";
            this.btnExperiencia.PlaceholderText = "Experiencia";
            this.btnExperiencia.SelectedText = "";
            this.btnExperiencia.Size = new System.Drawing.Size(223, 39);
            this.btnExperiencia.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Jornada Laboral";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Modalidad";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategoria.BorderRadius = 15;
            this.cmbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategoria.ItemHeight = 30;
            this.cmbCategoria.Location = new System.Drawing.Point(15, 236);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(231, 36);
            this.cmbCategoria.TabIndex = 57;
            // 
            // cmbModalidad
            // 
            this.cmbModalidad.BackColor = System.Drawing.Color.Transparent;
            this.cmbModalidad.BorderRadius = 15;
            this.cmbModalidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModalidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModalidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbModalidad.ItemHeight = 30;
            this.cmbModalidad.Location = new System.Drawing.Point(337, 236);
            this.cmbModalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(233, 36);
            this.cmbModalidad.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "Titulo de la Publicaciòn";
            // 
            // btnTitulo
            // 
            this.btnTitulo.BorderRadius = 15;
            this.btnTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnTitulo.DefaultText = "";
            this.btnTitulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnTitulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnTitulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnTitulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnTitulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTitulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTitulo.Location = new System.Drawing.Point(15, 144);
            this.btnTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTitulo.Name = "btnTitulo";
            this.btnTitulo.PlaceholderText = "Titulo";
            this.btnTitulo.SelectedText = "";
            this.btnTitulo.Size = new System.Drawing.Size(847, 39);
            this.btnTitulo.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(671, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 23);
            this.label7.TabIndex = 62;
            this.label7.Text = "Ciudad";
            // 
            // cmbJornada
            // 
            this.cmbJornada.BackColor = System.Drawing.Color.Transparent;
            this.cmbJornada.BorderRadius = 15;
            this.cmbJornada.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJornada.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbJornada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbJornada.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbJornada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbJornada.ItemHeight = 30;
            this.cmbJornada.Location = new System.Drawing.Point(659, 236);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Size = new System.Drawing.Size(239, 36);
            this.cmbJornada.TabIndex = 59;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.BackColor = System.Drawing.Color.Transparent;
            this.cmbCiudad.BorderRadius = 15;
            this.cmbCiudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCiudad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCiudad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCiudad.ItemHeight = 30;
            this.cmbCiudad.Location = new System.Drawing.Point(659, 329);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(255, 36);
            this.cmbCiudad.TabIndex = 63;
            this.cmbCiudad.DropDown += new System.EventHandler(this.cmbCiudad_DropDown);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 23);
            this.label8.TabIndex = 64;
            this.label8.Text = "Descripción de la Publicaciòn";
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Location = new System.Drawing.Point(27, 448);
            this.btnDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescripcion.Multiline = true;
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(887, 180);
            this.btnDescripcion.TabIndex = 65;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnRegresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnRegresar.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnRegresar.BorderRadius = 32;
            this.btnRegresar.BorderSize = 0;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(27, 650);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 39);
            this.btnRegresar.TabIndex = 67;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextColor = System.Drawing.Color.White;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregarPublicacion
            // 
            this.btnAgregarPublicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnAgregarPublicacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnAgregarPublicacion.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarPublicacion.BorderRadius = 32;
            this.btnAgregarPublicacion.BorderSize = 0;
            this.btnAgregarPublicacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarPublicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPublicacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPublicacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPublicacion.Location = new System.Drawing.Point(659, 650);
            this.btnAgregarPublicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPublicacion.Name = "btnAgregarPublicacion";
            this.btnAgregarPublicacion.Size = new System.Drawing.Size(249, 39);
            this.btnAgregarPublicacion.TabIndex = 66;
            this.btnAgregarPublicacion.Text = "Agregar Publicacion";
            this.btnAgregarPublicacion.TextColor = System.Drawing.Color.White;
            this.btnAgregarPublicacion.UseVisualStyleBackColor = false;
            this.btnAgregarPublicacion.Click += new System.EventHandler(this.btnAgregarPublicacion_Click);
            // 
            // FrmAgregarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(996, 743);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregarPublicacion);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTitulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbJornada);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.BtnsalarioP);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.lbExperiencia);
            this.Controls.Add(this.btnExperiencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgregarPublicacion";
            this.Text = "FrmAgregarEditarPublicacion";
            this.Load += new System.EventHandler(this.FrmAgregarEditarPublicacion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAgregarPublicacion_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox BtnsalarioP;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lbExperiencia;
        public Guna.UI2.WinForms.Guna2TextBox btnExperiencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cmbModalidad;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2TextBox btnTitulo;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbJornada;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCiudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox btnDescripcion;
        private Controls.Bordes_Boton btnAgregarPublicacion;
        private Controls.Bordes_Boton btnRegresar;
    }
}