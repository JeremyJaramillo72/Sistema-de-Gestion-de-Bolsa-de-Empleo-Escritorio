using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CsMensajeriaBD
    {

        csConexionSQL conec = new csConexionSQL();


        public void ProbarConexion()
        {
            using (SqlConnection con = new SqlConnection(conec.cadenaConexion))
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Conexión exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    con.Close();
                }
            }
        }

        public DataTable ObtenerAmistades(int idUsuario)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = new SqlConnection(conec.cadenaConexion))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("sp_ObtenerAmistadesPorUsuario", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetro del SP
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    // Adaptador para llenar tabla
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
                con.Close();
            }


            return tabla;

        }

        public DataTable ObtenerMensajes(int idAmistad)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conec.cadenaConexion))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerMensajesPorAmistad", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Parámetro del SP
                    cmd.Parameters.AddWithValue("@IdAmistad", idAmistad);
                    // Adaptador para llenar tabla
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
                con.Close();
            }
            return tabla;
        }

        public void EnviarMensaje(int idAmistad, int idEmisor, string contenido)
        {
            using (SqlConnection con = new SqlConnection(conec.cadenaConexion))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("sp_EnviarMensaje", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Parámetros del SP
                    cmd.Parameters.AddWithValue("@IdAmistad", idAmistad);
                    cmd.Parameters.AddWithValue("@IdUsuarioEnvia", idEmisor);
                    cmd.Parameters.AddWithValue("@Mensaje", contenido);
                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        public void ELiminarMensaje(int idMensajeSeleccionado)
        {
            using (SqlConnection cn = new SqlConnection(conec.cadenaConexion))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_EliminarMensaje", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdMensaje", idMensajeSeleccionado);

                cmd.ExecuteNonQuery();
                cn.Close();
            }

        }

    }
}
