using CAPA_NEGOCIO;
using CapaDatos;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class Cambio_Contra : Form
    {
        string Usuario;
        string Email;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Cambio_Contra(string usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public string Email1 { get => Email; set => Email = value; }
        private void bordes_Boton1_Click(object sender, EventArgs e)
        {
            csConexionSQL cl = new csConexionSQL();
            string contrasenaActual = txtactual.Text.Trim();
            string nuevaContrasena = txtnuevo.Text.Trim();
            string confirmarContrasena = txtnuevoRe.Text.Trim();

            if (string.IsNullOrEmpty(contrasenaActual) ||
                string.IsNullOrEmpty(nuevaContrasena) ||
                string.IsNullOrEmpty(confirmarContrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("La nueva contraseña y la confirmación no coinciden.");
                return;
            }

            if (contrasenaActual == nuevaContrasena)
            {
                MessageBox.Show("La nueva contraseña no puede ser igual a la contraseña actual.");
                return;
            }

            csEncriptarMD5 Encriptar = new csEncriptarMD5();
            string ConActual = Encriptar.Encriptar(contrasenaActual, Email);
            string Clave_Encriptada = Encriptar.Encriptar(nuevaContrasena, Email);

            // Agregar este MessageBox para ver la consulta SQL
            string consultaSQL = $"update Usuarios set Contraseña='{Clave_Encriptada}' where ID_Usuario= {Usuario} and Contraseña='{ConActual}'";
            //MessageBox.Show(consultaSQL);  // Muestra la consulta antes de ejecutarla
            //MessageBox.Show(Email1);
            if (cl.Insert(consultaSQL))
            {
                MessageBox.Show("Contraseña actualizada correctamente");
                txtactual.Clear();
                txtnuevo.Clear();
                txtnuevoRe.Clear();
            }
            else
            {
                MessageBox.Show("No se encontró el usuario o la contraseña actual no es correcta.");
            }
        }

        private void bordes_Boton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cambio_Contra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Solo si se hace clic con el botón izquierdo
            {
                ReleaseCapture(); // Liberar la captura del mouse 
                SendMessage(this.Handle, 0x112, 0xf012, 0); // Enviar mensaje para mover el formulario
            }
        }

        private void Cambio_Contra_Load(object sender, EventArgs e)
        {
            this.MouseDown += Cambio_Contra_MouseDown;
        }
    }
}
