namespace APP_NET.FRMNUEVOS
{
    partial class Frm_FormacionAcademica
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
            this.cmbNivel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtInstitucion = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_AdjuntoArchi = new Guna.UI2.WinForms.Guna2Button();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AggTítulo = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardaFA = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.txtAnio_ = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtAnio_);
            this.panel1.Controls.Add(this.cmbNivel);
            this.panel1.Controls.Add(this.txtInstitucion);
            this.panel1.Controls.Add(this.Btn_AdjuntoArchi);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(79, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 401);
            this.panel1.TabIndex = 0;
            // 
            // cmbNivel
            // 
            this.cmbNivel.BackColor = System.Drawing.Color.Transparent;
            this.cmbNivel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNivel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNivel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNivel.ForeColor = System.Drawing.Color.Black;
            this.cmbNivel.ItemHeight = 30;
            this.cmbNivel.Items.AddRange(new object[] {
            "Secundario",
            "Terciario",
            "Universitario",
            "Posgrado",
            "Maestría ",
            "Doctorado"});
            this.cmbNivel.Location = new System.Drawing.Point(520, 184);
            this.cmbNivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(268, 36);
            this.cmbNivel.TabIndex = 9;
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstitucion.DefaultText = "";
            this.txtInstitucion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstitucion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInstitucion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstitucion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstitucion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstitucion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInstitucion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstitucion.Location = new System.Drawing.Point(523, 78);
            this.txtInstitucion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.PlaceholderText = "";
            this.txtInstitucion.SelectedText = "";
            this.txtInstitucion.Size = new System.Drawing.Size(267, 44);
            this.txtInstitucion.TabIndex = 8;
            // 
            // Btn_AdjuntoArchi
            // 
            this.Btn_AdjuntoArchi.BorderRadius = 15;
            this.Btn_AdjuntoArchi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AdjuntoArchi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AdjuntoArchi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_AdjuntoArchi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_AdjuntoArchi.FillColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_AdjuntoArchi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AdjuntoArchi.ForeColor = System.Drawing.Color.White;
            this.Btn_AdjuntoArchi.Location = new System.Drawing.Point(36, 319);
            this.Btn_AdjuntoArchi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_AdjuntoArchi.Name = "Btn_AdjuntoArchi";
            this.Btn_AdjuntoArchi.Size = new System.Drawing.Size(263, 55);
            this.Btn_AdjuntoArchi.TabIndex = 17;
            this.Btn_AdjuntoArchi.Text = "Seleccionar Archivo";
            this.Btn_AdjuntoArchi.Click += new System.EventHandler(this.Btn_AdjuntoArchi_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.DefaultText = "";
            this.txtTitulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.Location = new System.Drawing.Point(36, 78);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.Size = new System.Drawing.Size(267, 44);
            this.txtTitulo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nivel de Estudios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Subir Título (PDF , JPG, PNG)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Institución";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Documentación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año de Graduación ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Título Obtenido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formación Académica";
            // 
            // btn_AggTítulo
            // 
            this.btn_AggTítulo.BorderRadius = 15;
            this.btn_AggTítulo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AggTítulo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AggTítulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AggTítulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AggTítulo.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AggTítulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AggTítulo.ForeColor = System.Drawing.Color.White;
            this.btn_AggTítulo.Location = new System.Drawing.Point(79, 509);
            this.btn_AggTítulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AggTítulo.Name = "btn_AggTítulo";
            this.btn_AggTítulo.Size = new System.Drawing.Size(335, 55);
            this.btn_AggTítulo.TabIndex = 16;
            this.btn_AggTítulo.Text = "+ Agregar Título Académico";
            this.btn_AggTítulo.Click += new System.EventHandler(this.btn_AggTítulo_Click);
            // 
            // btn_guardaFA
            // 
            this.btn_guardaFA.BorderRadius = 15;
            this.btn_guardaFA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardaFA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardaFA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guardaFA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guardaFA.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_guardaFA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardaFA.ForeColor = System.Drawing.Color.White;
            this.btn_guardaFA.Location = new System.Drawing.Point(79, 698);
            this.btn_guardaFA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardaFA.Name = "btn_guardaFA";
            this.btn_guardaFA.Size = new System.Drawing.Size(205, 55);
            this.btn_guardaFA.TabIndex = 18;
            this.btn_guardaFA.Text = "Guardar";
            this.btn_guardaFA.Click += new System.EventHandler(this.btn_guardaFA_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.SystemColors.HotTrack;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(731, 698);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(205, 55);
            this.guna2Button2.TabIndex = 19;
            this.guna2Button2.Text = "Editar";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Location = new System.Drawing.Point(162, 590);
            this.dgvTitulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.RowHeadersWidth = 51;
            this.dgvTitulos.Size = new System.Drawing.Size(705, 100);
            this.dgvTitulos.TabIndex = 20;
            // 
            // txtAnio_
            // 
            this.txtAnio_.BackColor = System.Drawing.Color.Transparent;
            this.txtAnio_.BorderRadius = 15;
            this.txtAnio_.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtAnio_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAnio_.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnio_.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnio_.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAnio_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtAnio_.ItemHeight = 30;
            this.txtAnio_.Items.AddRange(new object[] {
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.txtAnio_.Location = new System.Drawing.Point(36, 184);
            this.txtAnio_.Name = "txtAnio_";
            this.txtAnio_.Size = new System.Drawing.Size(267, 36);
            this.txtAnio_.TabIndex = 18;
            // 
            // Frm_FormacionAcademica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 762);
            this.Controls.Add(this.dgvTitulos);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btn_guardaFA);
            this.Controls.Add(this.btn_AggTítulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_FormacionAcademica";
            this.Text = "Frm_FormacionAcademica";
            this.Load += new System.EventHandler(this.Frm_FormacionAcademica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNivel;
        private Guna.UI2.WinForms.Guna2TextBox txtInstitucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btn_AggTítulo;
        private Guna.UI2.WinForms.Guna2Button Btn_AdjuntoArchi;
        private Guna.UI2.WinForms.Guna2Button btn_guardaFA;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.DataGridView dgvTitulos;
        private Guna.UI2.WinForms.Guna2ComboBox txtAnio_;
    }
}