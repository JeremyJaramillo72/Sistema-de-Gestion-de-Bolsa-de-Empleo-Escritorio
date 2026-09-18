namespace APP_NET
{
    partial class FrmCurriculum
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
            this.lblArchivoCargado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPostular = new APP_NET.Controls.Bordes_Boton();
            this.btnRegresar = new APP_NET.Controls.Bordes_Boton();
            this.btn_curriculum = new APP_NET.Controls.Bordes_Boton();
            this.lCuri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArchivoCargado
            // 
            this.lblArchivoCargado.BackColor = System.Drawing.Color.Transparent;
            this.lblArchivoCargado.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoCargado.Location = new System.Drawing.Point(375, 326);
            this.lblArchivoCargado.Margin = new System.Windows.Forms.Padding(4);
            this.lblArchivoCargado.Name = "lblArchivoCargado";
            this.lblArchivoCargado.Size = new System.Drawing.Size(195, 22);
            this.lblArchivoCargado.TabIndex = 0;
            this.lblArchivoCargado.Text = "Ningún archivo seleccionado";
            // 
            // btnPostular
            // 
            this.btnPostular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnPostular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnPostular.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnPostular.BorderRadius = 32;
            this.btnPostular.BorderSize = 0;
            this.btnPostular.FlatAppearance.BorderSize = 0;
            this.btnPostular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostular.ForeColor = System.Drawing.Color.White;
            this.btnPostular.Location = new System.Drawing.Point(693, 310);
            this.btnPostular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPostular.Name = "btnPostular";
            this.btnPostular.Size = new System.Drawing.Size(229, 39);
            this.btnPostular.TabIndex = 43;
            this.btnPostular.Text = "Enviar Postulacion";
            this.btnPostular.TextColor = System.Drawing.Color.White;
            this.btnPostular.UseVisualStyleBackColor = false;
            this.btnPostular.Click += new System.EventHandler(this.btnPostular_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnRegresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnRegresar.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnRegresar.BorderRadius = 32;
            this.btnRegresar.BorderSize = 0;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(15, 310);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 39);
            this.btnRegresar.TabIndex = 41;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextColor = System.Drawing.Color.White;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btn_curriculum
            // 
            this.btn_curriculum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btn_curriculum.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btn_curriculum.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btn_curriculum.BorderRadius = 32;
            this.btn_curriculum.BorderSize = 0;
            this.btn_curriculum.FlatAppearance.BorderSize = 0;
            this.btn_curriculum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_curriculum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_curriculum.ForeColor = System.Drawing.Color.White;
            this.btn_curriculum.Location = new System.Drawing.Point(287, 136);
            this.btn_curriculum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_curriculum.Name = "btn_curriculum";
            this.btn_curriculum.Size = new System.Drawing.Size(363, 112);
            this.btn_curriculum.TabIndex = 44;
            this.btn_curriculum.Text = "Subir curriculum";
            this.btn_curriculum.TextColor = System.Drawing.Color.White;
            this.btn_curriculum.UseVisualStyleBackColor = false;
            this.btn_curriculum.Click += new System.EventHandler(this.btn_curriculum_Click);
            // 
            // lCuri
            // 
            this.lCuri.AutoSize = true;
            this.lCuri.Location = new System.Drawing.Point(433, 259);
            this.lCuri.Name = "lCuri";
            this.lCuri.Size = new System.Drawing.Size(51, 16);
            this.lCuri.TabIndex = 45;
            this.lCuri.Text = "label1_";
            // 
            // FrmCurriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 384);
            this.Controls.Add(this.lCuri);
            this.Controls.Add(this.btn_curriculum);
            this.Controls.Add(this.btnPostular);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblArchivoCargado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCurriculum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCurriculum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblArchivoCargado;
        private Controls.Bordes_Boton btnRegresar;
        private Controls.Bordes_Boton btnPostular;
        private Controls.Bordes_Boton btn_curriculum;
        private System.Windows.Forms.Label lCuri;
    }
}