namespace APP_NET.FRMNUEVOS
{
    partial class FrmValidarDocDelProfesional
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidarDocDelProfesional));
            this.dgvValidarDocumento = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cmbTipoDeDocumento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new APP_NET.Controls.Bordes_Boton();
            this.lblNombreProfesional = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblEstadoPerfil = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDocsAprobados = new System.Windows.Forms.Label();
            this.lblDocPendientes = new System.Windows.Forms.Label();
            this.lblDocTotales = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRechazados = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRechazarDoc = new APP_NET.Controls.Bordes_Boton();
            this.btnAprobarDoc = new APP_NET.Controls.Bordes_Boton();
            this.btnVerDoc = new APP_NET.Controls.Bordes_Boton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidarDocumento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvValidarDocumento
            // 
            this.dgvValidarDocumento.AllowUserToAddRows = false;
            this.dgvValidarDocumento.AllowUserToDeleteRows = false;
            this.dgvValidarDocumento.AllowUserToResizeColumns = false;
            this.dgvValidarDocumento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvValidarDocumento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvValidarDocumento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvValidarDocumento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvValidarDocumento.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvValidarDocumento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvValidarDocumento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvValidarDocumento.Location = new System.Drawing.Point(409, 206);
            this.dgvValidarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvValidarDocumento.Name = "dgvValidarDocumento";
            this.dgvValidarDocumento.ReadOnly = true;
            this.dgvValidarDocumento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvValidarDocumento.RowHeadersVisible = false;
            this.dgvValidarDocumento.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvValidarDocumento.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvValidarDocumento.RowTemplate.Height = 24;
            this.dgvValidarDocumento.Size = new System.Drawing.Size(597, 388);
            this.dgvValidarDocumento.TabIndex = 32;
            this.dgvValidarDocumento.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvValidarDocumento.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvValidarDocumento.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvValidarDocumento.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvValidarDocumento.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvValidarDocumento.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvValidarDocumento.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvValidarDocumento.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvValidarDocumento.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvValidarDocumento.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvValidarDocumento.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvValidarDocumento.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvValidarDocumento.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvValidarDocumento.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvValidarDocumento.ThemeStyle.ReadOnly = true;
            this.dgvValidarDocumento.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvValidarDocumento.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvValidarDocumento.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvValidarDocumento.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvValidarDocumento.ThemeStyle.RowsStyle.Height = 24;
            this.dgvValidarDocumento.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvValidarDocumento.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lbCategoria
            // 
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(493, 110);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(173, 23);
            this.lbCategoria.TabIndex = 65;
            this.lbCategoria.Text = "Tipo de Documento";
            this.lbCategoria.Visible = false;
            // 
            // cmbTipoDeDocumento
            // 
            this.cmbTipoDeDocumento.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoDeDocumento.BorderRadius = 15;
            this.cmbTipoDeDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoDeDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeDocumento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDeDocumento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDeDocumento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoDeDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoDeDocumento.ItemHeight = 30;
            this.cmbTipoDeDocumento.Location = new System.Drawing.Point(484, 148);
            this.cmbTipoDeDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoDeDocumento.Name = "cmbTipoDeDocumento";
            this.cmbTipoDeDocumento.Size = new System.Drawing.Size(219, 36);
            this.cmbTipoDeDocumento.TabIndex = 64;
            this.cmbTipoDeDocumento.Visible = false;
            this.cmbTipoDeDocumento.DropDown += new System.EventHandler(this.cmbTipoDeDocumento_DropDown);
            this.cmbTipoDeDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeDocumento_SelectedIndexChanged);
            // 
            // lbFiltro
            // 
            this.lbFiltro.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(491, 74);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(131, 36);
            this.lbFiltro.TabIndex = 63;
            this.lbFiltro.Text = "Filtros";
            this.lbFiltro.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.lblNombreProfesional);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 71);
            this.panel1.TabIndex = 67;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnVolver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnVolver.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnVolver.BorderRadius = 32;
            this.btnVolver.BorderSize = 0;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(16, 18);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(199, 39);
            this.btnVolver.TabIndex = 67;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombreProfesional
            // 
            this.lblNombreProfesional.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesional.ForeColor = System.Drawing.Color.White;
            this.lblNombreProfesional.Location = new System.Drawing.Point(264, 11);
            this.lblNombreProfesional.Name = "lblNombreProfesional";
            this.lblNombreProfesional.Size = new System.Drawing.Size(475, 50);
            this.lblNombreProfesional.TabIndex = 0;
            this.lblNombreProfesional.Text = "...";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "Ciudad:";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApellido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreApellido.Location = new System.Drawing.Point(9, 74);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(367, 38);
            this.lblNombreApellido.TabIndex = 70;
            this.lblNombreApellido.Text = "Name";
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCorreo
            // 
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCorreo.Location = new System.Drawing.Point(12, 133);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(364, 23);
            this.lblCorreo.TabIndex = 71;
            this.lblCorreo.Text = "Email";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "Experiencia:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(25, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 23);
            this.label4.TabIndex = 73;
            this.label4.Text = "Fecha de Registro:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(25, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 74;
            this.label5.Text = "Estado del Perfil: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(187, 203);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(173, 23);
            this.lblTelefono.TabIndex = 76;
            this.lblTelefono.Text = "...";
            // 
            // lblCiudad
            // 
            this.lblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lblCiudad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.Color.Black;
            this.lblCiudad.Location = new System.Drawing.Point(187, 256);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(173, 23);
            this.lblCiudad.TabIndex = 77;
            this.lblCiudad.Text = "...";
            // 
            // lblExp
            // 
            this.lblExp.BackColor = System.Drawing.Color.Transparent;
            this.lblExp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExp.ForeColor = System.Drawing.Color.Black;
            this.lblExp.Location = new System.Drawing.Point(187, 292);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(173, 23);
            this.lblExp.TabIndex = 78;
            this.lblExp.Text = "...";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.Black;
            this.lblFechaRegistro.Location = new System.Drawing.Point(187, 329);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(173, 23);
            this.lblFechaRegistro.TabIndex = 79;
            this.lblFechaRegistro.Text = "...";
            // 
            // lblEstadoPerfil
            // 
            this.lblEstadoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPerfil.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoPerfil.Location = new System.Drawing.Point(187, 374);
            this.lblEstadoPerfil.Name = "lblEstadoPerfil";
            this.lblEstadoPerfil.Size = new System.Drawing.Size(173, 23);
            this.lblEstadoPerfil.TabIndex = 80;
            this.lblEstadoPerfil.Text = "...";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.Enabled = false;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(45, 473);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(347, 226);
            this.guna2TextBox1.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(61, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 38);
            this.label6.TabIndex = 82;
            this.label6.Text = "Resumen de Documentos";
            // 
            // lblDocsAprobados
            // 
            this.lblDocsAprobados.BackColor = System.Drawing.Color.White;
            this.lblDocsAprobados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocsAprobados.ForeColor = System.Drawing.Color.Green;
            this.lblDocsAprobados.Location = new System.Drawing.Point(291, 617);
            this.lblDocsAprobados.Name = "lblDocsAprobados";
            this.lblDocsAprobados.Size = new System.Drawing.Size(73, 23);
            this.lblDocsAprobados.TabIndex = 88;
            this.lblDocsAprobados.Text = "0";
            // 
            // lblDocPendientes
            // 
            this.lblDocPendientes.BackColor = System.Drawing.Color.White;
            this.lblDocPendientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDocPendientes.Location = new System.Drawing.Point(291, 570);
            this.lblDocPendientes.Name = "lblDocPendientes";
            this.lblDocPendientes.Size = new System.Drawing.Size(73, 23);
            this.lblDocPendientes.TabIndex = 87;
            this.lblDocPendientes.Text = "0";
            // 
            // lblDocTotales
            // 
            this.lblDocTotales.BackColor = System.Drawing.Color.White;
            this.lblDocTotales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocTotales.ForeColor = System.Drawing.Color.Blue;
            this.lblDocTotales.Location = new System.Drawing.Point(291, 526);
            this.lblDocTotales.Name = "lblDocTotales";
            this.lblDocTotales.Size = new System.Drawing.Size(101, 23);
            this.lblDocTotales.TabIndex = 86;
            this.lblDocTotales.Text = "0";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Snow;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(63, 617);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 23);
            this.label10.TabIndex = 85;
            this.label10.Text = "Aprobados:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Snow;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(63, 570);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 23);
            this.label11.TabIndex = 84;
            this.label11.Text = "Pendientes:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Snow;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(63, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 23);
            this.label12.TabIndex = 83;
            this.label12.Text = "Total Documentos:";
            // 
            // lblRechazados
            // 
            this.lblRechazados.BackColor = System.Drawing.Color.White;
            this.lblRechazados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechazados.ForeColor = System.Drawing.Color.Black;
            this.lblRechazados.Location = new System.Drawing.Point(291, 656);
            this.lblRechazados.Name = "lblRechazados";
            this.lblRechazados.Size = new System.Drawing.Size(73, 23);
            this.lblRechazados.TabIndex = 90;
            this.lblRechazados.Text = "0";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(63, 656);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 23);
            this.label14.TabIndex = 89;
            this.label14.Text = "Rechazados:";
            // 
            // btnRechazarDoc
            // 
            this.btnRechazarDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnRechazarDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnRechazarDoc.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnRechazarDoc.BorderRadius = 32;
            this.btnRechazarDoc.BorderSize = 0;
            this.btnRechazarDoc.FlatAppearance.BorderSize = 0;
            this.btnRechazarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazarDoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarDoc.ForeColor = System.Drawing.Color.White;
            this.btnRechazarDoc.Location = new System.Drawing.Point(716, 617);
            this.btnRechazarDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechazarDoc.Name = "btnRechazarDoc";
            this.btnRechazarDoc.Size = new System.Drawing.Size(199, 39);
            this.btnRechazarDoc.TabIndex = 92;
            this.btnRechazarDoc.Text = "Rechazar Doc";
            this.btnRechazarDoc.TextColor = System.Drawing.Color.White;
            this.btnRechazarDoc.UseVisualStyleBackColor = false;
            this.btnRechazarDoc.Click += new System.EventHandler(this.btnRechazarDoc_Click);
            // 
            // btnAprobarDoc
            // 
            this.btnAprobarDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(168)))), ((int)(((byte)(40)))));
            this.btnAprobarDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(168)))), ((int)(((byte)(40)))));
            this.btnAprobarDoc.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnAprobarDoc.BorderRadius = 32;
            this.btnAprobarDoc.BorderSize = 0;
            this.btnAprobarDoc.FlatAppearance.BorderSize = 0;
            this.btnAprobarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobarDoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobarDoc.ForeColor = System.Drawing.Color.White;
            this.btnAprobarDoc.Location = new System.Drawing.Point(468, 617);
            this.btnAprobarDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAprobarDoc.Name = "btnAprobarDoc";
            this.btnAprobarDoc.Size = new System.Drawing.Size(199, 39);
            this.btnAprobarDoc.TabIndex = 91;
            this.btnAprobarDoc.Text = "Aprobar Doc";
            this.btnAprobarDoc.TextColor = System.Drawing.Color.White;
            this.btnAprobarDoc.UseVisualStyleBackColor = false;
            this.btnAprobarDoc.Click += new System.EventHandler(this.btnAprobarDoc_Click);
            // 
            // btnVerDoc
            // 
            this.btnVerDoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerDoc.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnVerDoc.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnVerDoc.BorderRadius = 32;
            this.btnVerDoc.BorderSize = 0;
            this.btnVerDoc.FlatAppearance.BorderSize = 0;
            this.btnVerDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDoc.ForeColor = System.Drawing.Color.White;
            this.btnVerDoc.Location = new System.Drawing.Point(779, 148);
            this.btnVerDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerDoc.Name = "btnVerDoc";
            this.btnVerDoc.Size = new System.Drawing.Size(199, 39);
            this.btnVerDoc.TabIndex = 66;
            this.btnVerDoc.Text = "Ver Documento";
            this.btnVerDoc.TextColor = System.Drawing.Color.White;
            this.btnVerDoc.UseVisualStyleBackColor = false;
            this.btnVerDoc.Click += new System.EventHandler(this.btnVerDoc_Click);
            // 
            // FrmValidarDocDelProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1196, 676);
            this.Controls.Add(this.btnRechazarDoc);
            this.Controls.Add(this.btnAprobarDoc);
            this.Controls.Add(this.lblRechazados);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblDocsAprobados);
            this.Controls.Add(this.lblDocPendientes);
            this.Controls.Add(this.lblDocTotales);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.lblEstadoPerfil);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerDoc);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cmbTipoDeDocumento);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.dgvValidarDocumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmValidarDocDelProfesional";
            this.Text = "FrmValidarDocDelProfesional";
            this.Load += new System.EventHandler(this.FrmValidarDocDelProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidarDocumento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView dgvValidarDocumento;
        private System.Windows.Forms.Label lbCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoDeDocumento;
        private System.Windows.Forms.Label lbFiltro;
        private Controls.Bordes_Boton btnVerDoc;
        private System.Windows.Forms.Panel panel1;
        private Controls.Bordes_Boton btnVolver;
        private System.Windows.Forms.Label lblNombreProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblEstadoPerfil;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDocsAprobados;
        private System.Windows.Forms.Label lblDocPendientes;
        private System.Windows.Forms.Label lblDocTotales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRechazados;
        private System.Windows.Forms.Label label14;
        private Controls.Bordes_Boton btnAprobarDoc;
        private Controls.Bordes_Boton btnRechazarDoc;
    }
}