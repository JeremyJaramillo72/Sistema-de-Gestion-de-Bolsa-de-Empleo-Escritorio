using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class FormChats : Form
    {
        public int IDUsuario;
        DataMensajes objetoMsj = new DataMensajes();
        public static string usuario = "";
        public static string mensaje = "";
        public FormChats(string x)
        {
            InitializeComponent();
            IDUsuario = (Convert.ToInt32(x));
        }
        private void MensajeUsr(string mensaje)
        {
            Panel msjUsr = new Panel();
            msjUsr.Height = 59;
            msjUsr.Width = panel4.Width - 20;  // Ajustamos el ancho al panel
            panel4.Controls.Add(msjUsr);
            msjUsr.Dock = DockStyle.Bottom;

            TextBox txt = new TextBox();
            txt.BackColor = Color.HotPink;
            txt.Multiline = true;
            txt.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            txt.ForeColor = Color.White;
            txt.Text = mensaje;
            txt.Size = new Size(400, 45);

            msjUsr.Controls.Add(txt);
            txt.Location = new Point(69, 7);

            // Aquí se mueve el RJCircularPictureBox a la derecha
            circularPictureBox1.Location = new Point(msjUsr.Width - circularPictureBox1.Width - 10, 2); // 10 es el margen derecho
        }

        private void MensajeMio(string mensaje)
        {

            Panel msjUsr = new Panel();
            msjUsr.Height = 59;
            msjUsr.Width = panel4.Width - 20;  // Ajustamos el ancho al panel
            panel4.Controls.Add(msjUsr);
            msjUsr.Dock = DockStyle.Bottom;

            TextBox txt = new TextBox();
            txt.BackColor = Color.MediumSlateBlue;
            txt.Multiline = true;
            txt.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            txt.ForeColor = Color.White;
            txt.Text = mensaje;
            txt.Size = new Size(400, 45);
            txt.Anchor = AnchorStyles.Right;

            msjUsr.Controls.Add(txt);
            txt.Location = new Point(472, 7);

            // Aquí se mueve el RJCircularPictureBox a la derecha
            circularPictureBox1.Location = new Point(msjUsr.Width - circularPictureBox1.Width - 10, 2); // 10 es el margen derecho
        }

        private void timerAbrir__Tick(object sender, EventArgs e)
        {
            if (panelInfoChats.Width < 271)
            {
                panelInfoChats.Width = panelInfoChats.Width + 20;
            }
            else
            {
                timerAbrir_.Stop();
            }
        }

        private void timerCerrar__Tick(object sender, EventArgs e)
        {
            if (panelInfoChats.Width > 0)
            {
                panelInfoChats.Width = panelInfoChats.Width - 20;
            }
            else
            {
                timerCerrar_.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerCerrar_.Start();
        }



        private void FormChats_Load(object sender, EventArgs e)
        {
            // Ajusta el tamaño del formulario para que no sea demasiado grande
            this.Size = new Size(800, 500); // Ajusta el tamaño según prefieras

            // Asegura que el formulario no se expanda automáticamente dentro del panel
            this.Dock = DockStyle.None;

            // Centra el formulario en el panel contenedor si es necesario
            if (this.Parent != null)
            {
                this.Left = (this.Parent.Width - this.Width) / 2;
                this.Top = (this.Parent.Height - this.Height) / 2;
            }

            // Cargar mensajes
            var List = new List<DataMensajes>();
            List = objetoMsj.MsgConUsr(usuario, IDUsuario);
            foreach (DataMensajes item in List)
            {
                if (item.Emisor == IDUsuario)
                {
                    MensajeMio(item.Mensaje);
                }
                else
                {
                    MensajeUsr(item.Mensaje);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
                objetoMsj.Mensaje = textBox1.Text;
                objetoMsj.NuevoMensaje(usuario, IDUsuario);
                LimpiarPanel();
                CargarMensajes();
            }
        }

        private void LimpiarPanel()
        {
            while (panel4.Controls.Count > 0)
            {
                foreach (Panel item in panel4.Controls)
                {
                    panel4.Controls.Remove(item);
                }
            }
        }
        private void CargarMensajes()
        {
            var List = new List<DataMensajes>();
            List = objetoMsj.MsgConUsr(usuario, IDUsuario);
            foreach (DataMensajes item in List)
            {
                if (item.Emisor == IDUsuario)
                {
                    MensajeMio(item.Mensaje);
                }
                else
                {
                    MensajeUsr(item.Mensaje);
                }
            }
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            ImageContac.Image = circularPictureBox1.Image;
            label2.Text = NombreContacto.Text;
            timerAbrir_.Start();
        }
    }
}
