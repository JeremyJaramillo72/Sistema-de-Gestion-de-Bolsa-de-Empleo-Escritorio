using CAPA_NEGOCIO;
using CapaDatos;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace APP_NET.Formularios
{
    public partial class FrmAmigos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private string ID_AMISTAD;

        CsMensajeria conec = new CsMensajeria();
        CsAmigosBD conec2 = new CsAmigosBD();

        csConexionSQL dat = new csConexionSQL();
        string ID;
        public FrmAmigos(string iD)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ID = iD;
        }

        private void FrmAmigos_Load(object sender, EventArgs e)
        {
            this.MouseDown += FrmAmigos_MouseDown;

            dgvamigos.DataSource = conec.ObtenerAmistades(int.Parse(ID));

            /*dgvamigos.DataSource = dat.MostrarRegistros($@"SELECT a.ID_Amistad as ID , u.Nombre_Usuario as Nombre , u.Apellido_Usuario as Apellido , a.FechaAmistad as Fecha_Amistad
                FROM Amigos a
                JOIN Usuarios u ON (a.ID_Usuario1 = u.ID_Usuario OR a.ID_Usuario2 = u.ID_Usuario)
                WHERE (a.ID_Usuario1 = {ID} OR a.ID_Usuario2 = {ID})
                AND u.ID_Usuario <> {ID};");*/
        }

        private void FrmAmigos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Solo si se hace clic con el botón izquierdo
            {
                ReleaseCapture(); // Liberar la captura del mouse 
                SendMessage(this.Handle, 0x112, 0xf012, 0); // Enviar mensaje para mover el formulario
            }
        }

        private void bordes_Boton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bordes_Boton1_Click(object sender, EventArgs e)
        {
            if (msgBox.Show() == DialogResult.Yes)
            {
                //dat.Insert($"delete from Amigos where ID_Amistad = {ID_AMISTAD}");

                conec2.RechazarSolicitud(int.Parse(ID_AMISTAD));
                msgCOnf.Show("Amigo eliminado.");

                this.FrmAmigos_Load(sender, e);

                //FrmAmigos amigos = new FrmAmigos(ID);
                //amigos.Refresh();
            }
            else
            {
                msgCOnf.Show("Acción Cancelada");
            }

        }

        private void dgvamigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvamigos.Rows[e.RowIndex];
                ID_AMISTAD = row.Cells["ID"].Value.ToString();
            }
        }
    }
}
