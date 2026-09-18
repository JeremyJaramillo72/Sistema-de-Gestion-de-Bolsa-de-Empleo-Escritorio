using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace APP_NET
{
    public partial class Frm_Solicitud : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        csConexionSQL soli = new csConexionSQL();

        string ID; 
        public Frm_Solicitud(string iD)
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ID = iD;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Solicitud_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Solo si se hace clic con el botón izquierdo
            {
                ReleaseCapture(); // Liberar la captura del mouse
                SendMessage(this.Handle, 0x112, 0xf012, 0); // Enviar mensaje para mover el formulario
            }
        }

        private void Frm_Solicitud_Load(object sender, EventArgs e)
        {
            this.MouseDown += Frm_Solicitud_MouseDown;
            dgvSolicitud.DataSource = soli.MostrarRegistros($"select u.Nombre_Usuario as Nombre, u.Apellido_Usuario as Apellido from Usuarios u inner join Conexion c on u.ID_Usuario=c.ID_Usuario_Solicitante where c.ID_Usuario_Receptor={ID}");

        }
    }
}
