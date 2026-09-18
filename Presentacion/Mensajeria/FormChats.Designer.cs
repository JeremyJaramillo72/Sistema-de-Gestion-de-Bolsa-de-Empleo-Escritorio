namespace APP_NET
{
    partial class FormChats
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NombreContacto = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelInfoChats = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelap = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timerAbrir_ = new System.Windows.Forms.Timer(this.components);
            this.timerCerrar_ = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.circularPictureBox1 = new APP_NET.RJCircularPictureBox();
            this.ImageContac = new APP_NET.RJCircularPictureBox();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelInfoChats.SuspendLayout();
            this.panelap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageContac)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.circularPictureBox1);
            this.panel3.Controls.Add(this.NombreContacto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 80);
            this.panel3.TabIndex = 2;
            // 
            // NombreContacto
            // 
            this.NombreContacto.AutoSize = true;
            this.NombreContacto.BackColor = System.Drawing.Color.Transparent;
            this.NombreContacto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreContacto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NombreContacto.Location = new System.Drawing.Point(125, 31);
            this.NombreContacto.Name = "NombreContacto";
            this.NombreContacto.Size = new System.Drawing.Size(73, 25);
            this.NombreContacto.TabIndex = 4;
            this.NombreContacto.Text = "KENNY";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 508);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(947, 71);
            this.panel5.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderRadius = 15;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(16, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "";
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(823, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panelInfoChats
            // 
            this.panelInfoChats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelInfoChats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfoChats.Controls.Add(this.ImageContac);
            this.panelInfoChats.Controls.Add(this.label2);
            this.panelInfoChats.Controls.Add(this.panelap);
            this.panelInfoChats.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInfoChats.Location = new System.Drawing.Point(947, 0);
            this.panelInfoChats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfoChats.Name = "panelInfoChats";
            this.panelInfoChats.Size = new System.Drawing.Size(0, 579);
            this.panelInfoChats.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(49, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Info del contacto";
            // 
            // panelap
            // 
            this.panelap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(62)))));
            this.panelap.Controls.Add(this.label3);
            this.panelap.Controls.Add(this.button1);
            this.panelap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelap.Location = new System.Drawing.Point(0, 0);
            this.panelap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelap.Name = "panelap";
            this.panelap.Size = new System.Drawing.Size(0, 89);
            this.panelap.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(80, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Info del contacto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerAbrir_
            // 
            this.timerAbrir_.Interval = 5;
            this.timerAbrir_.Tick += new System.EventHandler(this.timerAbrir__Tick);
            // 
            // timerCerrar_
            // 
            this.timerCerrar_.Interval = 5;
            this.timerCerrar_.Tick += new System.EventHandler(this.timerCerrar__Tick);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(947, 428);
            this.panel4.TabIndex = 6;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.White;
            this.circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox1.BorderSize = 2;
            this.circularPictureBox1.GradientAngle = 50F;
            this.circularPictureBox1.Location = new System.Drawing.Point(16, 0);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(75, 75);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            this.circularPictureBox1.Click += new System.EventHandler(this.circularPictureBox1_Click);
            // 
            // ImageContac
            // 
            this.ImageContac.BackColor = System.Drawing.Color.White;
            this.ImageContac.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ImageContac.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ImageContac.BorderColor2 = System.Drawing.Color.HotPink;
            this.ImageContac.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ImageContac.BorderSize = 2;
            this.ImageContac.GradientAngle = 50F;
            this.ImageContac.Location = new System.Drawing.Point(72, 122);
            this.ImageContac.Name = "ImageContac";
            this.ImageContac.Size = new System.Drawing.Size(135, 135);
            this.ImageContac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageContac.TabIndex = 0;
            this.ImageContac.TabStop = false;
            // 
            // FormChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(947, 579);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelInfoChats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChats";
            this.Load += new System.EventHandler(this.FormChats_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panelInfoChats.ResumeLayout(false);
            this.panelInfoChats.PerformLayout();
            this.panelap.ResumeLayout(false);
            this.panelap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageContac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label NombreContacto;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private System.Windows.Forms.Panel panelInfoChats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerAbrir_;
        private System.Windows.Forms.Timer timerCerrar_;
        private System.Windows.Forms.FlowLayoutPanel panel4;
        public RJCircularPictureBox circularPictureBox1;
        private RJCircularPictureBox ImageContac;
    }
}