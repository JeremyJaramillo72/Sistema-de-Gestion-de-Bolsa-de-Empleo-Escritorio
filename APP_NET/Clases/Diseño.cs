using CapaDatos;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace APP_NET.Clases
{
    public class Diseño
    {
        public void AplicarBordeRedondo(PictureBox pictureBox)
        {
            if (pictureBox.Image == null) return;

            int tamaño = Math.Min(pictureBox.Width, pictureBox.Height);
            Bitmap imagenCircular = new Bitmap(tamaño, tamaño);

            using (Graphics g = Graphics.FromImage(imagenCircular))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // Crear un círculo perfecto con margen corregido
                int margen = 2; // Ajusta el margen para evitar imperfecciones en el borde
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(margen, margen, tamaño - margen * 2, tamaño - margen * 2);
                    g.SetClip(path);
                    g.DrawImage(pictureBox.Image, margen, margen, tamaño - margen * 2, tamaño - margen * 2);
                }

                // Dibujar borde blanco fino
                int grosorBorde = 2;
                using (Pen bordeBlanco = new Pen(Color.White, grosorBorde))
                {
                    g.DrawEllipse(bordeBlanco, margen, margen, tamaño - margen * 2, tamaño - margen * 2);
                }
            }

            pictureBox.Image = imagenCircular;
        }
        public void RedondearPaneles(Panel panel1, PaintEventArgs e)
        {


            int borderRadius = 20;
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = panel1.ClientRectangle;
            int diameter = borderRadius * 2;

            path.StartFigure();
            path.AddArc(rect.Left, rect.Top, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Top, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            panel1.Region = new Region(path);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(new SolidBrush(panel1.BackColor), path);
        }
        public void GuardarImagen(PictureBox Imagen, string consulta)
        {
            MemoryStream espacio = new MemoryStream(); //Dar espacio de memoria
            Imagen.Image.Save(espacio, ImageFormat.Png); // Guardar la imagen del Pb en el espacio de memoria en formato JPEG
            byte[] Convertir = espacio.ToArray(); // Convertir la imagen guardada en memoria a un arreglo de bytes
            csConexionSQL conexion = new csConexionSQL();
            conexion.AbrirConexion();
            SqlCommand Comando = new SqlCommand(consulta, conexion.Conexion);
            Comando.Parameters.AddWithValue("imagen1", Convertir); // Agregar el parámetro @Imagen con el arreglo de bytes convertido de la imagen
            Comando.ExecuteNonQuery(); //Ejecutar el comando
            conexion.CerrarConexion();
        }

        public void AjustarImagenAlTamaño(PictureBox pictureBox)
        {
            // Redimensionar la imagen al tamaño del PictureBox
            if (pictureBox.BackgroundImage != null)
            {
                Bitmap imagenRedimensionada = new Bitmap(pictureBox.BackgroundImage, pictureBox.Width, pictureBox.Height);
                pictureBox.BackgroundImage = imagenRedimensionada;
            }
        }
    }
}
