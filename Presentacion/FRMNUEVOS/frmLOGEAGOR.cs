using APP_NET.Formularios;
using CAPA_NEGOCIO;
using System;
using System.Windows.Forms;

namespace APP_NET.FRMNUEVOS
{
    public partial class frmLOGEAGOR : Form
    {
        csUsers usuario = new csUsers();
        public frmLOGEAGOR()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string rol = usuario.InicioDeSession(txtUsuario.Text, txtpassword.Text);
            MessageBox.Show(rol);
            usuario.ObtenerIDUsuario(txtUsuario.Text);
            if (rol == "Profesional")
            {

                FrmMenu entrar = new FrmMenu(usuario.IdUsuario);
                entrar.Email1 = txtUsuario.Text;
                entrar.btnMisPublicaciones.Visible = false;
                entrar.BtnReportes.Visible = false;
                entrar.btnPerfilEmpresa.Visible = false;
                entrar.btn_Validar.Visible = false;
                entrar.btnConexion.Visible = false;
                entrar.BtnMensajes.Visible = false;
                entrar.Show();
                this.Hide();
            }
            else if (rol == "Administrador")
            {
                FrmMenu entrar = new FrmMenu(usuario.IdUsuario);
                entrar.Email1 = txtUsuario.Text;
                entrar.btnMisPublicaciones.Visible = false;
                entrar.btnConexion.Visible = false;
                entrar.BtnMensajes.Visible = false;
                entrar.btnMisPublicaciones.Visible = false;
                entrar.BtnEmpleo.Visible = false;
                entrar.btnPerfil.Visible = false;
                entrar.btn_EL.Visible = false;
                entrar.btn_FA.Visible = false;

                entrar.btnPerfilEmpresa.Visible = false;
                entrar.Show();
                this.Hide();
            }
            else if (rol == "Empresa")
            {
                FrmMenu entrar = new FrmMenu(usuario.IdUsuario);
                entrar.Email1 = txtUsuario.Text;
                entrar.BtnReportes.Visible = false;
                entrar.BtnEmpleo.Visible = false;
                entrar.btnConexion.Visible = false;
                entrar.BtnMensajes.Visible = false;
                entrar.btnPerfil.Visible = false;
                entrar.btn_EL.Visible = false;
                entrar.btn_FA.Visible = false;
                entrar.btn_Validar.Visible = false;

                entrar.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Datos Ingresados Incorrectos, intente de nuevo.");
            }
        }

        private void lbCandidato_Click(object sender, EventArgs e)
        {
            frmRegistraPostulante frmP = new frmRegistraPostulante();
            frmP.StartPosition = FormStartPosition.CenterScreen;
            frmP.Show();
            this.Hide();
        }

        private void lbEmpresa_Click(object sender, EventArgs e)
        {
            frmRegistroEmpresa frmRegistroEmpresa = new frmRegistroEmpresa();
            frmRegistroEmpresa.StartPosition = FormStartPosition.CenterScreen;
            frmRegistroEmpresa.Show();
            this.Hide();
        }

        private void btn_ocultar_Click(object sender, EventArgs e)
        {
            btn_ocultar.Visible = false;  
            btnMuestra.Visible = true;   
            txtpassword.PasswordChar = '*';
        }

        private void btnMuestra_Click(object sender, EventArgs e)
        {
            btnMuestra.Visible = false;   
            btn_ocultar.Visible = true;   
            txtpassword.PasswordChar = '\0';
        }

        private void frmLOGEAGOR_Load(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
            btn_ocultar.Visible = false; 
            btnMuestra.Visible = true;   
        }
    }
}
