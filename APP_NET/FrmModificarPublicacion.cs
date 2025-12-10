using CAPA_NEGOCIO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class FrmModificarPublicacion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        string Id; public int IDPublicacion;
        Publicaciones publicar = new Publicaciones();
        public FrmModificarPublicacion(string id, string idP)
        {
            InitializeComponent();
            Id = id;
            IDPublicacion = Convert.ToInt32(idP);
        }

        private void FrmModificarPublicacion_Load(object sender, EventArgs e)
        {
            this.MouseDown += FrmModificarPublicacion_MouseDown;
        }

        private void cmbCiudad_DropDown(object sender, EventArgs e)
        {
            cmbCiudad.DropDownHeight = cmbCiudad.ItemHeight * 5;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(Id); int idEstadoPublicacion = Convert.ToInt32(cmbEstadoPublicacion.SelectedValue);
                int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue); int idJornada = Convert.ToInt32(cmbJornada.SelectedValue);
                int idModalidad = Convert.ToInt32(cmbModalidad.SelectedValue); int idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
                int experiencia = int.TryParse(btnExperiencia.Text, out int result) ? result : int.MinValue;
                int salarioP = int.TryParse(BtnSalarioP.Text, out int result1) ? result1 : int.MinValue;
                (bool resultado, string mensaje) = publicar.ModifcarPublicacion(IDPublicacion, btnTitulo.Text, idCategoria, idModalidad, idJornada, idCiudad, idEstadoPublicacion, btnDescripcion.Text, experiencia, salarioP);
                MessageBox.Show(mensaje, resultado ? "Éxito" : "Error", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (mensaje == "Publicación modificada exitosamente")
                {
                    FrmMisPublicaciones frm = Owner as FrmMisPublicaciones;
                    frm.dgvMisPublicaciones.Rows.Clear();
                    publicar.ListaMisPublicacione(frm.dgvMisPublicaciones, Id);
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmModificarPublicacion_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
