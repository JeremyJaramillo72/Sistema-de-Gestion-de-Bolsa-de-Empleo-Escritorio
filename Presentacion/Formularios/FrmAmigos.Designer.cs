namespace APP_NET.Formularios
{
    partial class FrmAmigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAmigos));
            this.dgvamigos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bordes_Boton2 = new APP_NET.Controls.Bordes_Boton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.bordes_Boton1 = new APP_NET.Controls.Bordes_Boton();
            this.msgBox = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgCOnf = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvamigos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvamigos
            // 
            this.dgvamigos.AllowUserToAddRows = false;
            this.dgvamigos.AllowUserToDeleteRows = false;
            this.dgvamigos.AllowUserToResizeColumns = false;
            this.dgvamigos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvamigos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvamigos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvamigos.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvamigos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvamigos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvamigos.Location = new System.Drawing.Point(98, 136);
            this.dgvamigos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvamigos.Name = "dgvamigos";
            this.dgvamigos.ReadOnly = true;
            this.dgvamigos.RowHeadersVisible = false;
            this.dgvamigos.RowHeadersWidth = 51;
            this.dgvamigos.RowTemplate.Height = 24;
            this.dgvamigos.Size = new System.Drawing.Size(442, 200);
            this.dgvamigos.TabIndex = 18;
            this.dgvamigos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvamigos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvamigos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvamigos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvamigos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvamigos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvamigos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvamigos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvamigos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvamigos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvamigos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvamigos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvamigos.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvamigos.ThemeStyle.ReadOnly = true;
            this.dgvamigos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvamigos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvamigos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvamigos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvamigos.ThemeStyle.RowsStyle.Height = 24;
            this.dgvamigos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvamigos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvamigos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvamigos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Conéctate, conoce y chatea sin límites.";
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
            this.bordes_Boton2.Location = new System.Drawing.Point(9, 9);
            this.bordes_Boton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bordes_Boton2.Name = "bordes_Boton2";
            this.bordes_Boton2.Size = new System.Drawing.Size(62, 37);
            this.bordes_Boton2.TabIndex = 17;
            this.bordes_Boton2.TextColor = System.Drawing.Color.White;
            this.bordes_Boton2.UseVisualStyleBackColor = false;
            this.bordes_Boton2.Click += new System.EventHandler(this.bordes_Boton2_Click);
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
            this.guna2TextBox1.Location = new System.Drawing.Point(26, 84);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "Buscar amigos";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(244, 32);
            this.guna2TextBox1.TabIndex = 20;
            // 
            // bordes_Boton1
            // 
            this.bordes_Boton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bordes_Boton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bordes_Boton1.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.bordes_Boton1.BorderRadius = 32;
            this.bordes_Boton1.BorderSize = 0;
            this.bordes_Boton1.FlatAppearance.BorderSize = 0;
            this.bordes_Boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bordes_Boton1.ForeColor = System.Drawing.Color.White;
            this.bordes_Boton1.Location = new System.Drawing.Point(98, 353);
            this.bordes_Boton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bordes_Boton1.Name = "bordes_Boton1";
            this.bordes_Boton1.Size = new System.Drawing.Size(112, 32);
            this.bordes_Boton1.TabIndex = 21;
            this.bordes_Boton1.Text = "eliminar";
            this.bordes_Boton1.TextColor = System.Drawing.Color.White;
            this.bordes_Boton1.UseVisualStyleBackColor = false;
            this.bordes_Boton1.Click += new System.EventHandler(this.bordes_Boton1_Click);
            // 
            // msgBox
            // 
            this.msgBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.msgBox.Caption = "¿Estás seguro de que quieres eliminar a este amigo?";
            this.msgBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.msgBox.Parent = this;
            this.msgBox.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.msgBox.Text = "Confirmación";
            // 
            // msgCOnf
            // 
            this.msgCOnf.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgCOnf.Caption = "";
            this.msgCOnf.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.msgCOnf.Parent = this;
            this.msgCOnf.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.msgCOnf.Text = null;
            // 
            // FrmAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 395);
            this.Controls.Add(this.bordes_Boton1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvamigos);
            this.Controls.Add(this.bordes_Boton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAmigos";
            this.Text = "FrmAmigos";
            this.Load += new System.EventHandler(this.FrmAmigos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAmigos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvamigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Bordes_Boton bordes_Boton2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvamigos;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Controls.Bordes_Boton bordes_Boton1;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBox;
        private Guna.UI2.WinForms.Guna2MessageDialog msgCOnf;
    }
}