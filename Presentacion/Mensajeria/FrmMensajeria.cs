using APP_NET.Clases;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;

namespace APP_NET.Mensajeria
{
    public partial class FrmMensajeria : Form
    {

        int idUsuario;
        int Tag;
        CsMensajeria conexion = new CsMensajeria();
        int idotrousuario;

        public FrmMensajeria(int id)
        {
            InitializeComponent();

            idUsuario = id;
            CargarAmistades(idUsuario);
        }

        private void CargarAmistades(int idUsuario)
        {
            DataTable amistades = conexion.ObtenerAmistades(idUsuario);

            panelChats.Controls.Clear();

            foreach (DataRow fila in amistades.Rows)
            {
                int idAmistad = Convert.ToInt32(fila["IdAmistad"]);
                int id = Convert.ToInt32(fila["IdDelOtroUsuario"]);
                string nombre = fila["NombreDelOtroUsuario"].ToString();
                idotrousuario = id;

                Panel x = new Panel();
                x.Width = 212;
                x.Height = 58;
                x.Dock = DockStyle.Top;
                x.Tag = idAmistad;

                panelChats.Controls.Add(x);


                Label btn = new Label();
                btn.Text = nombre;
                btn.Dock = DockStyle.Left;
                btn.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                x.Controls.Add(btn);

                RJCircularPictureBox pic = new RJCircularPictureBox();
                pic.Width = 57;
                pic.Height = 57;
                pic.Dock = DockStyle.Left;
                pic.BorderColor = Color.RoyalBlue;
                pic.BorderSize = 2;
                pic.BorderColor2 = Color.HotPink;

                Imagen mi = new Imagen();
                mi.MostrarLogoNombre(id.ToString(), pic);

                x.Controls.Add(pic);

                x.MouseClick += button1_Click;

            }
        }

        private void button1_Click(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                Tag = Convert.ToInt32(panel.Tag);
                MessageBox.Show("ID de Amistad seleccionado: " + Tag);
            }
            NombreContacto.Text = panel.Controls.OfType<Label>().FirstOrDefault()?.Text;
            circularPictureBox1 = panel.Controls.OfType<RJCircularPictureBox>().FirstOrDefault();
            CargarMensaje();
        }

        private void CargarMensaje()
        {
            DataTable amistades = conexion.ObtenerMensajes(Tag);

            PanelMensajes.Controls.Clear();

            foreach (DataRow fila in amistades.Rows)
            {
                int id = Convert.ToInt32(fila["IdMensaje"]);
                int user = Convert.ToInt32(fila["IdUserEnvi"]);
                string contenido = fila["mensaje"].ToString();
                string fecha = fila["fecha"].ToString();

                Panel panel = new Panel();
                panel.Height = 60;
                panel.Dock = DockStyle.Bottom;



                Guna2TextBox txt = new Guna2TextBox();
                txt.Text = contenido;
                //txt.Multiline = true;
                txt.Width = 400;
                txt.Height = 40;
                txt.BorderRadius = 10;


                // txt.Enabled = false;
                txt.MouseDoubleClick += (s, e) =>
                {
                    // Aquí puedes agregar la lógica para eliminar el mensaje
                    double_click(s, e);

                };
                txt.ReadOnly = true;
                txt.Tag = id;

                Label lb = new Label();
                lb.Text = fecha;
                //Color = Color.Gray;


                if (user != idUsuario)
                { txt.Dock = DockStyle.Left; lb.Dock = DockStyle.Right; txt.BackColor = Color.FromArgb(58, 55, 138); }
                else
                { txt.Dock = DockStyle.Right; lb.Dock = DockStyle.Left; txt.BackColor = Color.FromArgb(30, 103, 119); }

                panel.Controls.Add(lb);
                panel.Controls.Add(txt);
                PanelMensajes.Controls.Add(panel);
            }
        }

        private void double_click(object sender, MouseEventArgs e)
        {
            Guna2TextBox txt = sender as Guna2TextBox;
            if (txt != null)
            {
                int idMensaje = Convert.ToInt32(txt.Tag);
                EliminarMensaje(idMensaje);
            }
        }

        private void EliminarMensaje(int id)
        {
            DialogResult result = MessageBox.Show(
                "¿Quieres eliminar el mensaje?",
                "eliminado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );
            if (result == DialogResult.Yes)
            {
                conexion.EliminarMensaje(id);
                CargarMensaje();
            }
        }

        private void rjCircularPictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
