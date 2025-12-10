using CAPA_NEGOCIO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class FrmAgregarPublicacion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        Publicaciones publicar = new Publicaciones();
        public string id;
        public FrmAgregarPublicacion(string x)
        {

            InitializeComponent();
            id = x;
        }

        private void btnAgregarPublicacion_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(id);
                int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue); int idJornada = Convert.ToInt32(cmbJornada.SelectedValue);
                int idModalidad = Convert.ToInt32(cmbModalidad.SelectedValue); int idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
                int experiencia = int.TryParse(btnExperiencia.Text, out int result) ? result : int.MinValue;
                int salarioP = int.TryParse(BtnsalarioP.Text, out int result1) ? result1 : int.MinValue;


                (bool resultado, string mensaje) = publicar.AgregarPublicacion(ID, btnTitulo.Text, idCategoria, idModalidad, idJornada, idCiudad, btnDescripcion.Text, experiencia, salarioP);
                MessageBox.Show(mensaje, resultado ? "Éxito" : "Error", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (mensaje == "Publicación agregada exitosamente")
                {
                    FrmMisPublicaciones frm = Owner as FrmMisPublicaciones;
                    frm.dgvMisPublicaciones.Rows.Clear();
                    publicar.ListaMisPublicacione(frm.dgvMisPublicaciones, id);
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
        private void FrmAgregarEditarPublicacion_Load(object sender, EventArgs e)
        {
            publicar.AgregarComboBox(cmbCategoria, cmbModalidad, cmbJornada, cmbCiudad);
            this.MouseDown += FrmAgregarPublicacion_MouseDown;
        }
        private void cmbCiudad_DropDown(object sender, EventArgs e)
        {
            cmbCiudad.DropDownHeight = cmbCiudad.ItemHeight * 5;
        }

        private void FrmAgregarPublicacion_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Solo si se hace clic con el botón izquierdo
            {
                ReleaseCapture(); // Liberar la captura del mouse 
                SendMessage(this.Handle, 0x112, 0xf012, 0); // Enviar mensaje para mover el formulario
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
