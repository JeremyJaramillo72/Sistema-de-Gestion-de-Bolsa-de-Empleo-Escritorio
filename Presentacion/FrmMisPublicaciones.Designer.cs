namespace APP_NET
{
    partial class FrmMisPublicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMisPublicaciones));
            this.txtBuscador = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvMisPublicaciones = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jornada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Años = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCiudad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbJornada = new System.Windows.Forms.Label();
            this.cmbJornada = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbModalidad = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cmbModalidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAgregarP = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisPublicaciones)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.txtBuscador.Location = new System.Drawing.Point(21, 97);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.PlaceholderText = "Buscar publicacion por titulo";
            this.txtBuscador.SelectedText = "";
            this.txtBuscador.Size = new System.Drawing.Size(780, 39);
            this.txtBuscador.TabIndex = 31;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // dgvMisPublicaciones
            // 
            this.dgvMisPublicaciones.AllowUserToAddRows = false;
            this.dgvMisPublicaciones.AllowUserToDeleteRows = false;
            this.dgvMisPublicaciones.AllowUserToResizeColumns = false;
            this.dgvMisPublicaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMisPublicaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMisPublicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMisPublicaciones.ColumnHeadersHeight = 29;
            this.dgvMisPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Titulo,
            this.Autor,
            this.Categoria,
            this.Modalidad,
            this.Jornada,
            this.Ciudad,
            this.Estado,
            this.Descripcion,
            this.Provincia,
            this.SalarioMin,
            this.SalarioMax,
            this.Fecha,
            this.Años});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMisPublicaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMisPublicaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMisPublicaciones.Location = new System.Drawing.Point(40, 341);
            this.dgvMisPublicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisPublicaciones.Name = "dgvMisPublicaciones";
            this.dgvMisPublicaciones.ReadOnly = true;
            this.dgvMisPublicaciones.RowHeadersVisible = false;
            this.dgvMisPublicaciones.RowHeadersWidth = 51;
            this.dgvMisPublicaciones.RowTemplate.Height = 24;
            this.dgvMisPublicaciones.Size = new System.Drawing.Size(1039, 439);
            this.dgvMisPublicaciones.TabIndex = 30;
            this.dgvMisPublicaciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMisPublicaciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMisPublicaciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMisPublicaciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMisPublicaciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMisPublicaciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMisPublicaciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMisPublicaciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMisPublicaciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMisPublicaciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMisPublicaciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMisPublicaciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMisPublicaciones.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvMisPublicaciones.ThemeStyle.ReadOnly = true;
            this.dgvMisPublicaciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMisPublicaciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMisPublicaciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMisPublicaciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMisPublicaciones.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMisPublicaciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMisPublicaciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMisPublicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMisPublicaciones_CellContentClick);
            this.dgvMisPublicaciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMisPublicaciones_CellContentDoubleClick);
            this.dgvMisPublicaciones.SelectionChanged += new System.EventHandler(this.dgvMisPublicaciones_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Modalidad
            // 
            this.Modalidad.HeaderText = "Modalidad";
            this.Modalidad.MinimumWidth = 6;
            this.Modalidad.Name = "Modalidad";
            this.Modalidad.ReadOnly = true;
            // 
            // Jornada
            // 
            this.Jornada.HeaderText = "Jornada";
            this.Jornada.MinimumWidth = 6;
            this.Jornada.Name = "Jornada";
            this.Jornada.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.MinimumWidth = 6;
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            this.Provincia.Visible = false;
            // 
            // SalarioMin
            // 
            this.SalarioMin.HeaderText = "SalarioMin";
            this.SalarioMin.MinimumWidth = 6;
            this.SalarioMin.Name = "SalarioMin";
            this.SalarioMin.ReadOnly = true;
            this.SalarioMin.Visible = false;
            // 
            // SalarioMax
            // 
            this.SalarioMax.HeaderText = "SalarioMax";
            this.SalarioMax.MinimumWidth = 6;
            this.SalarioMax.Name = "SalarioMax";
            this.SalarioMax.ReadOnly = true;
            this.SalarioMax.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Visible = false;
            // 
            // Años
            // 
            this.Años.HeaderText = "Años";
            this.Años.MinimumWidth = 6;
            this.Años.Name = "Años";
            this.Años.ReadOnly = true;
            this.Años.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 71);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis Publicaciones";
            // 
            // lbFiltro
            // 
            this.lbFiltro.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(27, 140);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(131, 36);
            this.lbFiltro.TabIndex = 32;
            this.lbFiltro.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(859, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 54;
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
            this.cmbCiudad.Location = new System.Drawing.Point(863, 216);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(216, 36);
            this.cmbCiudad.TabIndex = 53;
            this.cmbCiudad.DropDown += new System.EventHandler(this.cmbCiudad_DropDown_1);
            // 
            // lbJornada
            // 
            this.lbJornada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJornada.Location = new System.Drawing.Point(572, 178);
            this.lbJornada.Name = "lbJornada";
            this.lbJornada.Size = new System.Drawing.Size(131, 36);
            this.lbJornada.TabIndex = 52;
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
            this.cmbJornada.Location = new System.Drawing.Point(553, 217);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(2);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Size = new System.Drawing.Size(248, 36);
            this.cmbJornada.TabIndex = 51;
            // 
            // lbModalidad
            // 
            this.lbModalidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModalidad.Location = new System.Drawing.Point(294, 178);
            this.lbModalidad.Name = "lbModalidad";
            this.lbModalidad.Size = new System.Drawing.Size(131, 36);
            this.lbModalidad.TabIndex = 50;
            this.lbModalidad.Text = "Modalidad";
            // 
            // lbCategoria
            // 
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(17, 189);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(141, 25);
            this.lbCategoria.TabIndex = 49;
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
            this.cmbModalidad.Location = new System.Drawing.Point(298, 217);
            this.cmbModalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(208, 36);
            this.cmbModalidad.TabIndex = 48;
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
            this.cmbCategoria.Location = new System.Drawing.Point(21, 217);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(209, 36);
            this.cmbCategoria.TabIndex = 47;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.BorderRadius = 20;
            this.btnAgregarP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarP.ForeColor = System.Drawing.Color.White;
            this.btnAgregarP.Location = new System.Drawing.Point(826, 91);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(239, 45);
            this.btnAgregarP.TabIndex = 57;
            this.btnAgregarP.Text = "Agregar Publicaciones";
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(285, 280);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(239, 45);
            this.guna2Button1.TabIndex = 58;
            this.guna2Button1.Text = "Buscar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(591, 286);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(63, 39);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 56;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            this.guna2PictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.guna2PictureBox1_MouseClick);
            // 
            // FrmMisPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1418, 676);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnAgregarP);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.lbJornada);
            this.Controls.Add(this.cmbJornada);
            this.Controls.Add(this.lbModalidad);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.dgvMisPublicaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMisPublicaciones";
            this.Text = "FrmMisPublicaciones";
            this.Load += new System.EventHandler(this.FrmMisPublicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisPublicaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.Bordes_Boton btnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscador;
        private Controls.Bordes_Boton btnAgregarPublicacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCiudad;
        private System.Windows.Forms.Label lbJornada;
        private Guna.UI2.WinForms.Guna2ComboBox cmbJornada;
        private System.Windows.Forms.Label lbModalidad;
        private System.Windows.Forms.Label lbCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cmbModalidad;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategoria;
        public Guna.UI2.WinForms.Guna2DataGridView dgvMisPublicaciones;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jornada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Años;
        private Guna.UI2.WinForms.Guna2Button btnAgregarP;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}