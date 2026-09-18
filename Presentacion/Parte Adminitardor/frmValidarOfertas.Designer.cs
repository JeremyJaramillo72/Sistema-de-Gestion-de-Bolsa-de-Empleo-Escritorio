namespace APP_NET.Parte_Adminitardor
{
    partial class frmValidarOfertas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPublicaciones = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aprobar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_rechazar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCiudad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbJornada = new System.Windows.Forms.Label();
            this.cmbJornada = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbModalidad = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cmbModalidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtBuscador = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_buscar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPublicaciones
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPublicaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPublicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPublicaciones.ColumnHeadersHeight = 4;
            this.dgvPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPublicaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPublicaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPublicaciones.Location = new System.Drawing.Point(61, 296);
            this.dgvPublicaciones.Name = "dgvPublicaciones";
            this.dgvPublicaciones.RowHeadersVisible = false;
            this.dgvPublicaciones.RowHeadersWidth = 51;
            this.dgvPublicaciones.RowTemplate.Height = 24;
            this.dgvPublicaciones.Size = new System.Drawing.Size(991, 251);
            this.dgvPublicaciones.TabIndex = 0;
            this.dgvPublicaciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPublicaciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPublicaciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPublicaciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPublicaciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPublicaciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPublicaciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPublicaciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPublicaciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPublicaciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPublicaciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPublicaciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPublicaciones.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPublicaciones.ThemeStyle.ReadOnly = false;
            this.dgvPublicaciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPublicaciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPublicaciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPublicaciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPublicaciones.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPublicaciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPublicaciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPublicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublicaciones_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valida las Ofertas Laborales";
            // 
            // btn_aprobar
            // 
            this.btn_aprobar.BorderRadius = 15;
            this.btn_aprobar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_aprobar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_aprobar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_aprobar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_aprobar.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_aprobar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aprobar.ForeColor = System.Drawing.Color.White;
            this.btn_aprobar.Location = new System.Drawing.Point(61, 588);
            this.btn_aprobar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aprobar.Name = "btn_aprobar";
            this.btn_aprobar.Size = new System.Drawing.Size(237, 55);
            this.btn_aprobar.TabIndex = 16;
            this.btn_aprobar.Text = "Aprobar";
            this.btn_aprobar.Click += new System.EventHandler(this.btn_aprobar_Click);
            // 
            // btn_rechazar
            // 
            this.btn_rechazar.BorderRadius = 15;
            this.btn_rechazar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_rechazar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_rechazar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rechazar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_rechazar.FillColor = System.Drawing.Color.Red;
            this.btn_rechazar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechazar.ForeColor = System.Drawing.Color.White;
            this.btn_rechazar.Location = new System.Drawing.Point(815, 588);
            this.btn_rechazar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rechazar.Name = "btn_rechazar";
            this.btn_rechazar.Size = new System.Drawing.Size(237, 55);
            this.btn_rechazar.TabIndex = 17;
            this.btn_rechazar.Text = "Rechazar";
            this.btn_rechazar.Click += new System.EventHandler(this.btn_rechazar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(832, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 63;
            this.label2.Text = "Ciudad";
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
            this.cmbCiudad.Location = new System.Drawing.Point(836, 176);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(216, 36);
            this.cmbCiudad.TabIndex = 62;
            // 
            // lbJornada
            // 
            this.lbJornada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJornada.Location = new System.Drawing.Point(570, 138);
            this.lbJornada.Name = "lbJornada";
            this.lbJornada.Size = new System.Drawing.Size(131, 36);
            this.lbJornada.TabIndex = 61;
            this.lbJornada.Text = "Jornada";
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
            this.cmbJornada.Location = new System.Drawing.Point(574, 177);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(2);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Size = new System.Drawing.Size(213, 36);
            this.cmbJornada.TabIndex = 60;
            // 
            // lbModalidad
            // 
            this.lbModalidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModalidad.Location = new System.Drawing.Point(315, 138);
            this.lbModalidad.Name = "lbModalidad";
            this.lbModalidad.Size = new System.Drawing.Size(131, 36);
            this.lbModalidad.TabIndex = 59;
            this.lbModalidad.Text = "Modalidad";
            // 
            // lbCategoria
            // 
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(57, 138);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(141, 25);
            this.lbCategoria.TabIndex = 58;
            this.lbCategoria.Text = "Categoria";
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
            this.cmbModalidad.Location = new System.Drawing.Point(319, 176);
            this.cmbModalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(208, 36);
            this.cmbModalidad.TabIndex = 57;
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
            this.cmbCategoria.Location = new System.Drawing.Point(61, 177);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(209, 36);
            this.cmbCategoria.TabIndex = 56;
            // 
            // lbFiltro
            // 
            this.lbFiltro.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(55, 89);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(472, 36);
            this.lbFiltro.TabIndex = 55;
            this.lbFiltro.Text = "Aplica Filtros de Búsqueda";
            // 
            // txtBuscador
            // 
            this.txtBuscador.BorderRadius = 15;
            this.txtBuscador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscador.DefaultText = "";
            this.txtBuscador.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscador.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscador.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscador.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscador.Location = new System.Drawing.Point(61, 240);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.PlaceholderText = "Buscar publicacion por titulo";
            this.txtBuscador.SelectedText = "";
            this.txtBuscador.Size = new System.Drawing.Size(780, 39);
            this.txtBuscador.TabIndex = 64;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BorderRadius = 15;
            this.btn_buscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buscar.FillColor = System.Drawing.Color.Green;
            this.btn_buscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(879, 224);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(126, 55);
            this.btn_buscar.TabIndex = 65;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // frmValidarOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 729);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.lbJornada);
            this.Controls.Add(this.cmbJornada);
            this.Controls.Add(this.lbModalidad);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.btn_rechazar);
            this.Controls.Add(this.btn_aprobar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPublicaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmValidarOfertas";
            this.Text = "frmValidarOfertas";
            this.Load += new System.EventHandler(this.frmValidarOfertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPublicaciones;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_aprobar;
        private Guna.UI2.WinForms.Guna2Button btn_rechazar;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCiudad;
        private System.Windows.Forms.Label lbJornada;
        private Guna.UI2.WinForms.Guna2ComboBox cmbJornada;
        private System.Windows.Forms.Label lbModalidad;
        private System.Windows.Forms.Label lbCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cmbModalidad;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategoria;
        private System.Windows.Forms.Label lbFiltro;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscador;
        private Guna.UI2.WinForms.Guna2Button btn_buscar;
    }
}