using APP_NET.Clases;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class MensaJS : Form
    {
        public static int IDUsuario;

        private Form ChatActual;
        DataMensajes Mensajes = new DataMensajes(IDUsuario);
        Imagen iso = new Imagen();
        public MensaJS(string x)
        {
            InitializeComponent();
            IDUsuario = (Convert.ToInt32(x));
            iso.MostrarLogoNombre(x, rjCircularPictureBox1);
        }



        public void CrearChatsParaUsuarios(int idUsuario)
        {
            // Obtener la lista de mensajes de otros usuarios
            List<DataMensajes> usuarios = Mensajes.UsrMje(idUsuario);

            // Recorrer la lista y crear un chat para cada usuario
            foreach (var usuario in usuarios)
            {
                // Crear chat para cada usuario (deberías pasar los parámetros adecuados a CrearChat)
                CrearChat(usuario.Usuario, usuario.Mensaje, usuario.Perfil, usuario.Emisor);
            }
        }

        private void abrirChat(FormChats chat, Image imagen, string titulo)
        {

            if (ChatActual != null)
            {
                ChatActual.Close();
            }

            chat.circularPictureBox1.Image = imagen;
            chat.NombreContacto.Text = titulo;
            ChatActual = chat;

            chat.TopLevel = false;
            chat.Dock = DockStyle.None; // Asegura que no se expanda automáticamente
            chat.Size = new Size(800, 500); // Ajusta el tamaño del chat
            chat.StartPosition = FormStartPosition.Manual;

            // Centrar el chat en el panelHijos
            chat.Left = (panelHijos.Width - chat.Width) / 2;
            chat.Top = (panelHijos.Height - chat.Height) / 2;

            panelHijos.Controls.Add(chat);
            panelHijos.Tag = chat;
            chat.BringToFront();
            chat.Show();
        }
        private void CrearChat(string usuario, string msg, byte[] img, int emisor)
        {
            //Crear Panel
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Height = 75;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panelChats.Controls.Add(panel);
            panel.BringToFront();

            // Verificar si el arreglo de imagen no es nulo ni vacío
            if (img != null && img.Length > 0)
            {
                // Crear Imagen dentro de panel
                MemoryStream ms = new MemoryStream(img);
                RJCircularPictureBox cpb = new RJCircularPictureBox();
                cpb.Width = 68;
                try
                {
                    cpb.Image = Image.FromStream(ms);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("La imagen no es válida.");
                    return;
                }

                panel.Controls.Add(cpb);
                cpb.Location = new Point(6, 2);
            }
            else
            {
                MessageBox.Show("No se ha proporcionado una imagen válida.");
            }

            //Crear Label
            Label titulo = new Label();
            titulo.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            titulo.Size = new Size(160, 17);
            titulo.Text = usuario;
            titulo.ForeColor = Color.White;
            panel.Controls.Add(titulo);
            titulo.Location = new Point(91, 18);

            //Crear Mensaje
            Label mensaje = new Label();
            mensaje.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            mensaje.ForeColor = Color.Gray;
            mensaje.Size = new Size(160, 17);
            if (emisor == IDUsuario)
            {
                mensaje.Text = "Tu: " + msg;
            }
            else
            {
                mensaje.Text = usuario + ": " + msg;
            }
            panel.Controls.Add(mensaje);
            mensaje.Location = new Point(91, 39);

            // Eventos 
            panel.Click += panel_Click;
            panel.MouseEnter += panel_MouseEnter;
            panel.MouseLeave += panel_MouseLeave;
        }
        private void panel_Click(object sender, EventArgs e)
        {
            //RJCircularPictureBox cpb = new RJCircularPictureBox();
            Image imagen = null;
            string titulo = "";
            foreach (var control in ((Panel)sender).Controls)
            {
                if (control is RJCircularPictureBox)
                {
                    imagen = ((RJCircularPictureBox)control).Image;
                }
                else if (control is Label)
                {
                    if (((Label)control).ForeColor == Color.White)
                    {
                        titulo = ((Label)control).Text;
                    }
                }
            }
            FormChats.usuario = titulo;
            abrirChat(new FormChats(IDUsuario.ToString()), imagen, titulo);
        }
        private void timerAbrir_Tick(object sender, EventArgs e)
        {
            if (panelInfoPer.Width < 320)
            {
                panelInfoPer.Width = panelInfoPer.Width + 20;
            }
            else
            {
                timerAbrir.Stop();
            }
        }

        private void timerCerrar_Tick(object sender, EventArgs e)
        {
            if (panelInfoPer.Width > 0)
            {
                panelInfoPer.Width = panelInfoPer.Width - 20;
            }
            else
            {
                timerCerrar.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerCerrar.Start();
        }

        void panel_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(26, 25, 62);
        }

        void panel_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(16, 15, 52);
        }

        private void MensaJS_Load(object sender, EventArgs e)
        {
            ActualizarChats();
            CrearChatsParaUsuarios(IDUsuario);
        }

        private void ActualizarChats()
        {
            var List = new List<DataMensajes>();
            List = Mensajes.UsrMje(IDUsuario);
            foreach (DataMensajes item in List)
            {
                CrearChat(item.Usuario, item.Mensaje, item.Perfil, item.Emisor);
            }
        }

        private void LimpiarChats()
        {
            while (panelChats.Controls.Count > 3)
            {
                foreach (Panel item in panelChats.Controls)
                {
                    if (item.Name != "panel2" && item.Name != "panelInfoPer" && item.Name != "PanelBuscar")
                    {
                        panelChats.Controls.Remove(item);
                    }
                }
            }
        }
        private void Actualizar_Tick(object sender, EventArgs e)
        {
            LimpiarChats();
            ActualizarChats();
        }

        private void rjCircularPictureBox1_Click_1(object sender, EventArgs e)
        {
            ImageUserPanel.Image = rjCircularPictureBox1.Image;
            labelNombre.Text = label4.Text;
            timerAbrir.Start();
        }
    }
}
