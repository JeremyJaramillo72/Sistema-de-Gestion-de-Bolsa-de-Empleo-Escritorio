using CapaDatos;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace APP_NET.Clases
{
    public class Imagen
    {
        private csConexionSQL conexion;

        public Imagen()
        {
            conexion = new csConexionSQL();
        }

        public void MostrarLogoNombre(string ID, PictureBox Ft_Perfil)
        {
            Diseño Redondear = new Diseño();
            csConexionSQL conexion = new csConexionSQL();
            string consulta1 = @"select U.ID_Usuario,I.Imagen 
                             from Usuarios as U 
                             inner join Usuario_Imagen as UI on U.ID_Usuario=UI.ID_Usuario 
                             inner join Imagen as I on UI.ID_Imagen=I.ID_Imagen 
                             where U.ID_Usuario= '" + ID + "'";

            SqlDataReader leer = conexion.SelectLeer(consulta1);

            if (leer.Read())
            {
                try
                {
                    MemoryStream ImgMemoria = new MemoryStream((byte[])leer["imagen"]);
                    Bitmap bitmap = new Bitmap(ImgMemoria);
                    Ft_Perfil.Image = bitmap;
                    Ft_Perfil.SizeMode = PictureBoxSizeMode.Zoom;

                    Redondear.AjustarImagenAlTamaño(Ft_Perfil);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cargar la imagen: " + ex.Message);
                }
            }

            Redondear.AplicarBordeRedondo(Ft_Perfil);
            conexion.CerrarConexion();
        }

        public void GuardarImagen(PictureBox Imagen, string consulta)
        {
            MemoryStream espacio = new MemoryStream();
            Imagen.Image.Save(espacio, ImageFormat.Png);
            byte[] Convertir = espacio.ToArray();
            csConexionSQL conexion = new csConexionSQL();
            conexion.AbrirConexion();
            SqlCommand Comando = new SqlCommand(consulta, conexion.Conexion);
            Comando.Parameters.AddWithValue("imagen", Convertir);
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


    }
}
