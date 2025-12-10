using CAPA_NEGOCIO;
using System;
using System.Windows.Forms;

namespace APP_NET.FRMNUEVOS
{
    public partial class frmRegistroEmpresa : Form
    {
        csEncriptarMD5 Encriptar = new csEncriptarMD5();
        csUsers usuario = new csUsers();

        public frmRegistroEmpresa()
        {
            InitializeComponent();

        }

        private void btn_regCandi_Click(object sender, EventArgs e)
        {
            frmRegistraPostulante frmP = new frmRegistraPostulante();
            frmP.StartPosition = FormStartPosition.CenterScreen;
            frmP.Show();
            this.Hide();
        }

        private void Btn_Inicia_Click(object sender, EventArgs e)
        {
            frmLOGEAGOR frmlogin = new frmLOGEAGOR();
            frmlogin.StartPosition = FormStartPosition.CenterScreen;
            frmlogin.Show();
            this.Hide();
        }

        private void btn_registrarEmpresa_Click(object sender, EventArgs e)
        {
            string claveEncriptada = Encriptar.Encriptar(txtPassword.Text.Trim(), txtEmail.Text.Trim());

            (bool resultado, string mensaje) = usuario.AgregarEmpresa(txtNombreEmpresa.Text.Trim(), txtRUC.Text.Trim(), txtTelefono.Text.Trim(), txtEmail.Text.Trim(), claveEncriptada);
            MessageBox.Show(mensaje, resultado ? "Éxito" : "Error", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }


    }
}
