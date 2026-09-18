namespace APP_NET
{
    partial class FrmEmpleo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleo));
            this.dgvPublicaciones = new Guna.UI2.WinForms.Guna2DataGridView();
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
            this.lbModalidad = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cmbModalidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtBuscador = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbJornada = new System.Windows.Forms.Label();
            this.cmbJornada = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCiudad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBuscar = new APP_NET.Controls.Bordes_Boton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPublicaciones
            // 
            this.dgvPublicaciones.AllowUserToAddRows = false;
            this.dgvPublicaciones.AllowUserToDeleteRows = false;
            this.dgvPublicaciones.AllowUserToResizeColumns = false;
            this.dgvPublicaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPublicaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPublicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPublicaciones.ColumnHeadersHeight = 29;
            this.dgvPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPublicaciones.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPublicaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPublicaciones.Location = new System.Drawing.Point(31, 347);
            this.dgvPublicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPublicaciones.Name = "dgvPublicaciones";
            this.dgvPublicaciones.ReadOnly = true;
            this.dgvPublicaciones.RowHeadersVisible = false;
            this.dgvPublicaciones.RowHeadersWidth = 51;
            this.dgvPublicaciones.RowTemplate.Height = 24;
            this.dgvPublicaciones.Size = new System.Drawing.Size(929, 368);
            this.dgvPublicaciones.TabIndex = 17;
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
            this.dgvPublicaciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPublicaciones.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvPublicaciones.ThemeStyle.ReadOnly = true;
            this.dgvPublicaciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPublicaciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPublicaciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPublicaciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPublicaciones.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPublicaciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPublicaciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPublicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublicaciones_CellContentClick);
            this.dgvPublicaciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublicaciones_CellContentDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
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
            this.Estado.Visible = false;
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
            // lbModalidad
            // 
            this.lbModalidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModalidad.Location = new System.Drawing.Point(241, 181);
            this.lbModalidad.Name = "lbModalidad";
            this.lbModalidad.Size = new System.Drawing.Size(131, 36);
            this.lbModalidad.TabIndex = 24;
            this.lbModalidad.Text = "Modalidad";
            // 
            // lbCategoria
            // 
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(32, 182);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(131, 36);
            this.lbCategoria.TabIndex = 23;
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
            this.cmbModalidad.Location = new System.Drawing.Point(247, 220);
            this.cmbModalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(185, 36);
            this.cmbModalidad.TabIndex = 22;
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
            this.cmbCategoria.Location = new System.Drawing.Point(25, 222);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(185, 36);
            this.cmbCategoria.TabIndex = 21;
            // 
            // lbFiltro
            // 
            this.lbFiltro.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(31, 143);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(131, 36);
            this.lbFiltro.TabIndex = 20;
            this.lbFiltro.Text = "Filtros";
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
            this.txtBuscador.Location = new System.Drawing.Point(37, 100);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.PlaceholderText = "Buscar publicacion por titulo";
            this.txtBuscador.SelectedText = "";
            this.txtBuscador.Size = new System.Drawing.Size(888, 39);
            this.txtBuscador.TabIndex = 18;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // lbJornada
            // 
            this.lbJornada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJornada.Location = new System.Drawing.Point(457, 182);
            this.lbJornada.Name = "lbJornada";
            this.lbJornada.Size = new System.Drawing.Size(131, 36);
            this.lbJornada.TabIndex = 26;
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
            this.cmbJornada.Location = new System.Drawing.Point(461, 220);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Size = new System.Drawing.Size(248, 36);
            this.cmbJornada.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(732, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 45;
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
            this.cmbCiudad.Location = new System.Drawing.Point(736, 219);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(216, 36);
            this.cmbCiudad.TabIndex = 44;
            this.cmbCiudad.DropDown += new System.EventHandler(this.cmbCiudad_DropDown);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(584, 287);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(63, 39);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 47;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.guna2PictureBox1_MouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnBuscar.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.BorderRadius = 32;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(396, 287);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(181, 39);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 36);
            this.label1.TabIndex = 48;
            this.label1.Text = "Ofertas Laborales";
            // 
            // FrmEmpleo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1013, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbJornada);
            this.Controls.Add(this.cmbJornada);
            this.Controls.Add(this.lbModalidad);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.dgvPublicaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEmpleo";
            this.Text = "FrmEmpleo";
            this.Load += new System.EventHandler(this.FrmEmpleo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvPublicaciones;
        private System.Windows.Forms.Label lbModalidad;
        private System.Windows.Forms.Label lbCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cmbModalidad;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategoria;
        private System.Windows.Forms.Label lbFiltro;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscador;
        private System.Windows.Forms.Label lbJornada;
        private Guna.UI2.WinForms.Guna2ComboBox cmbJornada;
        private Controls.Bordes_Boton btnBuscar;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCiudad;
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
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
    }
}