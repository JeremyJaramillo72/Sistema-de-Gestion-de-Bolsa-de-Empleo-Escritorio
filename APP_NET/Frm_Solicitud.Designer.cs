namespace APP_NET
{
    partial class Frm_Solicitud
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
            this.bordes_Boton2 = new APP_NET.Controls.Bordes_Boton();
            this.btnSalir = new APP_NET.Controls.Bordes_Boton();
            this.dgvSolicitud = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).BeginInit();
            this.SuspendLayout();
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
            this.bordes_Boton2.Location = new System.Drawing.Point(32, 338);
            this.bordes_Boton2.Name = "bordes_Boton2";
            this.bordes_Boton2.Size = new System.Drawing.Size(150, 40);
            this.bordes_Boton2.TabIndex = 13;
            this.bordes_Boton2.Text = "Aceptar Solicitud";
            this.bordes_Boton2.TextColor = System.Drawing.Color.Black;
            this.bordes_Boton2.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.BackgroundColor = System.Drawing.Color.White;
            this.btnSalir.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 40;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 40);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.TextColor = System.Drawing.Color.Black;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvSolicitud
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSolicitud.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSolicitud.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitud.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSolicitud.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSolicitud.Location = new System.Drawing.Point(32, 87);
            this.dgvSolicitud.Name = "dgvSolicitud";
            this.dgvSolicitud.RowHeadersVisible = false;
            this.dgvSolicitud.RowHeadersWidth = 51;
            this.dgvSolicitud.RowTemplate.Height = 24;
            this.dgvSolicitud.Size = new System.Drawing.Size(468, 245);
            this.dgvSolicitud.TabIndex = 15;
            this.dgvSolicitud.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSolicitud.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSolicitud.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSolicitud.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSolicitud.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSolicitud.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSolicitud.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSolicitud.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSolicitud.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSolicitud.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSolicitud.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSolicitud.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSolicitud.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvSolicitud.ThemeStyle.ReadOnly = false;
            this.dgvSolicitud.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSolicitud.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSolicitud.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSolicitud.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSolicitud.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSolicitud.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSolicitud.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Solicitudes de Amistad";
            // 
            // Frm_Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSolicitud);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bordes_Boton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Solicitud";
            this.Text = "Frm_Solicitud";
            this.Load += new System.EventHandler(this.Frm_Solicitud_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Solicitud_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.Bordes_Boton bordes_Boton2;
        private Controls.Bordes_Boton btnSalir;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSolicitud;
        private System.Windows.Forms.Label label1;
    }
}