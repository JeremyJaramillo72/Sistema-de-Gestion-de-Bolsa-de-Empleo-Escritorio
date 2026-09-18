using APP_NET.Clases;
using APP_NET.FRMNUEVOS;
using APP_NET.Mensajeria;
using APP_NET.Parte_Adminitardor;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_NET.Formularios
{
    public partial class FrmMenu : Form
    {
        string id;
        string Email;
        ToolTip toolTip = new ToolTip();
        public string Email1 { get => Email; set => Email = value; }
        public FrmMenu()
        {

        }
        public FrmMenu(string x)
        {
            InitializeComponent();
            id = x;
            Imagen mi = new Imagen();
            mi.MostrarLogoNombre(x, ImgPerfil);

            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.pnCentral.Controls.Count > 0)
                this.pnCentral.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnCentral.Controls.Add(fh);
            this.pnCentral.Tag = fh;
            fh.Show();
        }
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }
        private void CerrarSesion()
        {
            List<Form> formulariosAbiertos = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                formulariosAbiertos.Add(form);
            }
            foreach (Form form in formulariosAbiertos)
            {
                if (form.GetType().Name != "frmLOGEAGOR")
                {
                    form.Close();
                }
            }
            frmLOGEAGOR abrir = new frmLOGEAGOR();
            abrir.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambio_Contra abrir = new Cambio_Contra(id);
            abrir.Email1 = Email;
            abrir.StartPosition = FormStartPosition.CenterScreen;
            abrir.ShowDialog();
        }

        private void bordes_Boton4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEmpleo(id));
        }

        private void bordes_Boton5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReportes());
        }

        private void bordes_Boton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmConexion(id));
        }

        private void bordes_Boton1_Click(object sender, EventArgs e)
        {
            Perfil_Pro frmPerfil = new Perfil_Pro(id)
            {
                Owner = this
            };
            AbrirFormEnPanel(frmPerfil);
        }

        private void bordes_Boton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmMensajeria(int.Parse(id)));
        }

        private void btnMisPublicaciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmMisPublicaciones(id));
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btn_FA_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Frm_FormacionAcademica(id));
        }

        private void btn_EL_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmExperienciaLoboral(id));
        }

        private void btnPerfilEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmAgregarPerfilEmpresa(id));
        }

        private void btn_Validar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmValidarOfertas());
        }
    }
}