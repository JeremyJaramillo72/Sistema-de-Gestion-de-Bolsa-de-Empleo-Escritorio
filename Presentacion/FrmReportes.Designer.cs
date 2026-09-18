namespace APP_NET
{
    partial class FrmReportes
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
            this.RpViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbReporte = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // RpViewer
            // 
            this.RpViewer.Location = new System.Drawing.Point(3, 56);
            this.RpViewer.Name = "RpViewer";
            this.RpViewer.ServerReport.BearerToken = null;
            this.RpViewer.Size = new System.Drawing.Size(830, 494);
            this.RpViewer.TabIndex = 0;
            // 
            // cmbReporte
            // 
            this.cmbReporte.BackColor = System.Drawing.Color.Transparent;
            this.cmbReporte.BorderRadius = 15;
            this.cmbReporte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporte.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbReporte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbReporte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbReporte.ItemHeight = 30;
            this.cmbReporte.Items.AddRange(new object[] {
            "ReporteNumeroEmpleosPublicados"});
            this.cmbReporte.Location = new System.Drawing.Point(272, 15);
            this.cmbReporte.Margin = new System.Windows.Forms.Padding(2);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(293, 36);
            this.cmbReporte.TabIndex = 48;
            this.cmbReporte.SelectedIndexChanged += new System.EventHandler(this.cmbReporte_SelectedIndexChanged);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(835, 580);
            this.Controls.Add(this.cmbReporte);
            this.Controls.Add(this.RpViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpViewer;
        private Guna.UI2.WinForms.Guna2ComboBox cmbReporte;
    }
}