namespace APP_NET.FRMNUEVOS
{
    partial class FrmRevisiónDeDocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRevisiónDeDocs));
            this.dgvPerfilesRevisión = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new APP_NET.Controls.Bordes_Boton();
            this.btnRevisarDocDe = new APP_NET.Controls.Bordes_Boton();
            this.txtBuscadorR = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cmbEstadoGeneral = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCiudad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfilesRevisión)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerfilesRevisión
            // 
            this.dgvPerfilesRevisión.AllowUserToAddRows = false;
            this.dgvPerfilesRevisión.AllowUserToDeleteRows = false;
            this.dgvPerfilesRevisión.AllowUserToResizeColumns = false;
            this.dgvPerfilesRevisión.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPerfilesRevisión.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerfilesRevisión.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPerfilesRevisión.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerfilesRevisión.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPerfilesRevisión.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvPerfilesRevisión.Location = new System.Drawing.Point(40, 345);
            this.dgvPerfilesRevisión.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPerfilesRevisión.Name = "dgvPerfilesRevisión";
            this.dgvPerfilesRevisión.ReadOnly = true;
            this.dgvPerfilesRevisión.RowHeadersVisible = false;
            this.dgvPerfilesRevisión.RowHeadersWidth = 51;
            this.dgvPerfilesRevisión.RowTemplate.Height = 24;
            this.dgvPerfilesRevisión.Size = new System.Drawing.Size(915, 484);
            this.dgvPerfilesRevisión.TabIndex = 31;
            this.dgvPerfilesRevisión.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvPerfilesRevisión.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvPerfilesRevisión.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPerfilesRevisión.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPerfilesRevisión.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPerfilesRevisión.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPerfilesRevisión.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPerfilesRevisión.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvPerfilesRevisión.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvPerfilesRevisión.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPerfilesRevisión.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPerfilesRevisión.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPerfilesRevisión.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPerfilesRevisión.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvPerfilesRevisión.ThemeStyle.ReadOnly = true;
            this.dgvPerfilesRevisión.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvPerfilesRevisión.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPerfilesRevisión.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPerfilesRevisión.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPerfilesRevisión.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPerfilesRevisión.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvPerfilesRevisión.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPerfilesRevisión.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerfilesRevisión_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 71);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revisión de Docs";
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
            this.btnBuscar.Location = new System.Drawing.Point(40, 289);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(181, 39);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRevisarDocDe
            // 
            this.btnRevisarDocDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnRevisarDocDe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnRevisarDocDe.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnRevisarDocDe.BorderRadius = 32;
            this.btnRevisarDocDe.BorderSize = 0;
            this.btnRevisarDocDe.FlatAppearance.BorderSize = 0;
            this.btnRevisarDocDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisarDocDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisarDocDe.ForeColor = System.Drawing.Color.White;
            this.btnRevisarDocDe.Location = new System.Drawing.Point(705, 270);
            this.btnRevisarDocDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRevisarDocDe.Name = "btnRevisarDocDe";
            this.btnRevisarDocDe.Size = new System.Drawing.Size(249, 70);
            this.btnRevisarDocDe.TabIndex = 58;
            this.btnRevisarDocDe.Text = "Revisar Docs del profesional";
            this.btnRevisarDocDe.TextColor = System.Drawing.Color.White;
            this.btnRevisarDocDe.UseVisualStyleBackColor = false;
            this.btnRevisarDocDe.Click += new System.EventHandler(this.btnRevisarDocDe_Click);
            // 
            // txtBuscadorR
            // 
            this.txtBuscadorR.BorderRadius = 15;
            this.txtBuscadorR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscadorR.DefaultText = "";
            this.txtBuscadorR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscadorR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscadorR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscadorR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscadorR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscadorR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscadorR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtBuscadorR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscadorR.Location = new System.Drawing.Point(40, 94);
            this.txtBuscadorR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscadorR.Name = "txtBuscadorR";
            this.txtBuscadorR.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(181)))));
            this.txtBuscadorR.PlaceholderText = "Buscar profesional...";
            this.txtBuscadorR.SelectedText = "";
            this.txtBuscadorR.Size = new System.Drawing.Size(671, 39);
            this.txtBuscadorR.TabIndex = 59;
            this.txtBuscadorR.TextChanged += new System.EventHandler(this.txtBuscadorR_TextChanged_1);
            // 
            // lbCategoria
            // 
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(36, 203);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(131, 23);
            this.lbCategoria.TabIndex = 62;
            this.lbCategoria.Text = "Estado General";
            // 
            // cmbEstadoGeneral
            // 
            this.cmbEstadoGeneral.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstadoGeneral.BorderRadius = 15;
            this.cmbEstadoGeneral.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstadoGeneral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoGeneral.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstadoGeneral.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstadoGeneral.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstadoGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEstadoGeneral.ItemHeight = 30;
            this.cmbEstadoGeneral.Location = new System.Drawing.Point(28, 229);
            this.cmbEstadoGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstadoGeneral.Name = "cmbEstadoGeneral";
            this.cmbEstadoGeneral.Size = new System.Drawing.Size(219, 36);
            this.cmbEstadoGeneral.TabIndex = 61;
            this.cmbEstadoGeneral.DropDown += new System.EventHandler(this.cmbEstadoGeneral_DropDown);
            this.cmbEstadoGeneral.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoGeneral_SelectedIndexChanged);
            // 
            // lbFiltro
            // 
            this.lbFiltro.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(33, 150);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(131, 36);
            this.lbFiltro.TabIndex = 60;
            this.lbFiltro.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
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
            this.cmbCiudad.Location = new System.Drawing.Point(336, 229);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(236, 36);
            this.cmbCiudad.TabIndex = 64;
            this.cmbCiudad.DropDown += new System.EventHandler(this.cmbCiudad_DropDown);
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(240, 289);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(63, 39);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 57;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // FrmRevisiónDeDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1060, 676);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cmbEstadoGeneral);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.txtBuscadorR);
            this.Controls.Add(this.btnRevisarDocDe);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPerfilesRevisión);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRevisiónDeDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmRevisiónDeDocs";
            this.Load += new System.EventHandler(this.FrmRevisiónDeDocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfilesRevisión)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView dgvPerfilesRevisión;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Controls.Bordes_Boton btnBuscar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Controls.Bordes_Boton btnRevisarDocDe;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscadorR;
        private System.Windows.Forms.Label lbCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstadoGeneral;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCiudad;
    }
}