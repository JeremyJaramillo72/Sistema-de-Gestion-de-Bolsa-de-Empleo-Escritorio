namespace APP_NET
{
    partial class FrmConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConexion));
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTitulo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCIudad_ = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvconexion = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEnviar = new APP_NET.Controls.Bordes_Boton();
            this.bordes_Boton1 = new APP_NET.Controls.Bordes_Boton();
            this.btn_Solicitudes = new APP_NET.Controls.Bordes_Boton();
            this.bordes_Boton2 = new APP_NET.Controls.Bordes_Boton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconexion)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(88, 211);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "Buscar profesionales por nombre";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(536, 32);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de profesionales";
            // 
            // cmbTitulo
            // 
            this.cmbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.cmbTitulo.BorderRadius = 15;
            this.cmbTitulo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitulo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTitulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTitulo.ItemHeight = 30;
            this.cmbTitulo.Location = new System.Drawing.Point(11, 86);
            this.cmbTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTitulo.Name = "cmbTitulo";
            this.cmbTitulo.Size = new System.Drawing.Size(147, 36);
            this.cmbTitulo.TabIndex = 3;
            this.cmbTitulo.Visible = false;
            // 
            // cmbCIudad_
            // 
            this.cmbCIudad_.BackColor = System.Drawing.Color.Transparent;
            this.cmbCIudad_.BorderRadius = 15;
            this.cmbCIudad_.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCIudad_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCIudad_.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCIudad_.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCIudad_.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCIudad_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCIudad_.ItemHeight = 30;
            this.cmbCIudad_.Location = new System.Drawing.Point(194, 86);
            this.cmbCIudad_.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCIudad_.Name = "cmbCIudad_";
            this.cmbCIudad_.Size = new System.Drawing.Size(147, 36);
            this.cmbCIudad_.TabIndex = 4;
            this.cmbCIudad_.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Especialidad";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ubicación";
            this.label3.Visible = false;
            // 
            // dgvconexion
            // 
            this.dgvconexion.AllowUserToResizeColumns = false;
            this.dgvconexion.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvconexion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvconexion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvconexion.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvconexion.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvconexion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvconexion.Location = new System.Drawing.Point(26, 277);
            this.dgvconexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvconexion.Name = "dgvconexion";
            this.dgvconexion.ReadOnly = true;
            this.dgvconexion.RowHeadersVisible = false;
            this.dgvconexion.RowHeadersWidth = 51;
            this.dgvconexion.RowTemplate.Height = 24;
            this.dgvconexion.Size = new System.Drawing.Size(658, 255);
            this.dgvconexion.TabIndex = 7;
            this.dgvconexion.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvconexion.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvconexion.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvconexion.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvconexion.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvconexion.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvconexion.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvconexion.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvconexion.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvconexion.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvconexion.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvconexion.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvconexion.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvconexion.ThemeStyle.ReadOnly = true;
            this.dgvconexion.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvconexion.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvconexion.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvconexion.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvconexion.ThemeStyle.RowsStyle.Height = 24;
            this.dgvconexion.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvconexion.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvconexion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvconexion_CellClick);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.BackgroundColor = System.Drawing.Color.White;
            this.btnEnviar.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnEnviar.BorderRadius = 40;
            this.btnEnviar.BorderSize = 0;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(73, 563);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(166, 41);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar Solicitud";
            this.btnEnviar.TextColor = System.Drawing.Color.Black;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // bordes_Boton1
            // 
            this.bordes_Boton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.bordes_Boton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.bordes_Boton1.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.bordes_Boton1.BorderRadius = 32;
            this.bordes_Boton1.BorderSize = 0;
            this.bordes_Boton1.FlatAppearance.BorderSize = 0;
            this.bordes_Boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bordes_Boton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bordes_Boton1.ForeColor = System.Drawing.Color.White;
            this.bordes_Boton1.Location = new System.Drawing.Point(359, 86);
            this.bordes_Boton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bordes_Boton1.Name = "bordes_Boton1";
            this.bordes_Boton1.Size = new System.Drawing.Size(94, 32);
            this.bordes_Boton1.TabIndex = 1;
            this.bordes_Boton1.Text = "Buscar";
            this.bordes_Boton1.TextColor = System.Drawing.Color.White;
            this.bordes_Boton1.UseVisualStyleBackColor = false;
            this.bordes_Boton1.Visible = false;
            // 
            // btn_Solicitudes
            // 
            this.btn_Solicitudes.BackColor = System.Drawing.Color.White;
            this.btn_Solicitudes.BackgroundColor = System.Drawing.Color.White;
            this.btn_Solicitudes.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btn_Solicitudes.BorderRadius = 40;
            this.btn_Solicitudes.BorderSize = 0;
            this.btn_Solicitudes.FlatAppearance.BorderSize = 0;
            this.btn_Solicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Solicitudes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Solicitudes.ForeColor = System.Drawing.Color.Black;
            this.btn_Solicitudes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Solicitudes.Image")));
            this.btn_Solicitudes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Solicitudes.Location = new System.Drawing.Point(265, 563);
            this.btn_Solicitudes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Solicitudes.Name = "btn_Solicitudes";
            this.btn_Solicitudes.Size = new System.Drawing.Size(169, 41);
            this.btn_Solicitudes.TabIndex = 9;
            this.btn_Solicitudes.Text = "Mis Solicitudes";
            this.btn_Solicitudes.TextColor = System.Drawing.Color.Black;
            this.btn_Solicitudes.UseVisualStyleBackColor = false;
            this.btn_Solicitudes.Click += new System.EventHandler(this.btn_Solicitudes_Click);
            // 
            // bordes_Boton2
            // 
            this.bordes_Boton2.BackColor = System.Drawing.Color.White;
            this.bordes_Boton2.BackgroundColor = System.Drawing.Color.White;
            this.bordes_Boton2.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.bordes_Boton2.BorderRadius = 40;
            this.bordes_Boton2.BorderSize = 0;
            this.bordes_Boton2.FlatAppearance.BorderSize = 0;
            this.bordes_Boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bordes_Boton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bordes_Boton2.ForeColor = System.Drawing.Color.Black;
            this.bordes_Boton2.Image = ((System.Drawing.Image)(resources.GetObject("bordes_Boton2.Image")));
            this.bordes_Boton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bordes_Boton2.Location = new System.Drawing.Point(454, 563);
            this.bordes_Boton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bordes_Boton2.Name = "bordes_Boton2";
            this.bordes_Boton2.Size = new System.Drawing.Size(170, 41);
            this.bordes_Boton2.TabIndex = 10;
            this.bordes_Boton2.Text = "Mis Amigos";
            this.bordes_Boton2.TextColor = System.Drawing.Color.Black;
            this.bordes_Boton2.UseVisualStyleBackColor = false;
            this.bordes_Boton2.Click += new System.EventHandler(this.bordes_Boton2_Click);
            // 
            // FrmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 636);
            this.Controls.Add(this.bordes_Boton2);
            this.Controls.Add(this.btn_Solicitudes);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.dgvconexion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCIudad_);
            this.Controls.Add(this.cmbTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bordes_Boton1);
            this.Controls.Add(this.guna2TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConexion";
            this.Text = "FrmConexion";
            this.Load += new System.EventHandler(this.FrmConexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconexion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Controls.Bordes_Boton bordes_Boton1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTitulo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCIudad_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvconexion;
        private Controls.Bordes_Boton btnEnviar;
        private Controls.Bordes_Boton btn_Solicitudes;
        private Controls.Bordes_Boton bordes_Boton2;
    }
}