namespace APP_NET
{
    partial class FrmActualizarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarContraseña));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.txtConfirmarCLave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(110, 252);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(157, 44);
            this.btnEnviar.TabIndex = 27;
            this.btnEnviar.Text = "ACTUALIZAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Confirmar Contraseña";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(106, 57);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(165, 22);
            this.lbCodigo.TabIndex = 23;
            this.lbCodigo.Text = "Nueva Contraseña";
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.BackColor = System.Drawing.Color.White;
            this.txtNuevaClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNuevaClave.Location = new System.Drawing.Point(62, 98);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.Size = new System.Drawing.Size(253, 35);
            this.txtNuevaClave.TabIndex = 52;
            // 
            // txtConfirmarCLave
            // 
            this.txtConfirmarCLave.BackColor = System.Drawing.Color.White;
            this.txtConfirmarCLave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtConfirmarCLave.Location = new System.Drawing.Point(62, 188);
            this.txtConfirmarCLave.Name = "txtConfirmarCLave";
            this.txtConfirmarCLave.Size = new System.Drawing.Size(253, 35);
            this.txtConfirmarCLave.TabIndex = 53;
            // 
            // FrmActualizarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 335);
            this.Controls.Add(this.txtConfirmarCLave);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCodigo);
            this.Name = "FrmActualizarContraseña";
            this.Text = "FrmActualizarContraseña";
            this.Load += new System.EventHandler(this.FrmActualizarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.TextBox txtConfirmarCLave;
    }
}