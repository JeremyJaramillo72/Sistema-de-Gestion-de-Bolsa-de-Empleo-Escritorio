using CAPA_NEGOCIO;
using CapaDatos;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace APP_NET.Formularios
{
    public partial class Frm_Solicitud : Form
    {
        private string ID_Solicitud;
        csConexionSQL soli = new csConexionSQL();
        string ID;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        CsAmigos amigos = new CsAmigos();
        public Frm_Solicitud(string iD)
        {
            InitializeComponent();
            ID = iD;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_Solicitud_Load(object sender, EventArgs e)
        {
            this.MouseDown += Frm_Solicitud_MouseDown;
            dgvSolicitud.DataSource = amigos.ObtenerAmistadesPendientes(int.Parse(ID));
            //dgvSolicitud.DataSource = soli.MostrarRegistros($"select c.SolicitudID ,u.Nombre_Usuario as Nombre, u.Apellido_Usuario as Apellido, c.Estado as Estaso_Solicitud from Usuarios u inner join Solicitudes c on u.ID_Usuario=c.RemitenteID where c.DestinatarioID={ID}");
        }

        private void Frm_Solicitud_MouseDown(object sender, MouseEventArgs e)
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
            // soli.Insert($"UPDATE Solicitudes SET Estado = 'Aceptada' WHERE SolicitudID = {ID_Solicitud};");

            //soli.Insert($"INSERT INTO Amigos (ID_Usuario1, ID_Usuario2) SELECT RemitenteID, DestinatarioID FROM Solicitudes WHERE SolicitudID = {ID_Solicitud};");

            amigos.AceptarSolicitud(int.Parse(ID_Solicitud));

        }

        private void dgvSolicitud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSolicitud.Rows[e.RowIndex];
                ID_Solicitud = row.Cells["SolicitudID"].Value.ToString();
            }
        }


    }
}
