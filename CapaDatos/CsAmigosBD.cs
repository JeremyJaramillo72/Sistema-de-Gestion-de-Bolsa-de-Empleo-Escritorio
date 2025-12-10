using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CsAmigosBD
    {

        csConexionSQL conec = new csConexionSQL();

        public string EnviarSolicitud(int idUsuarioRemitente, int idUsuarioReceptor)
        {

            string tabla;
            using (SqlConnection con = new SqlConnection(conec.cadenaConexion))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerUsuariosConTodosSusTitulos", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Parámetro del SP
                    cmd.Parameters.AddWithValue("@IdUserSoli", idUsuarioRemitente);
                    cmd.Parameters.AddWithValue("@IdUserReci", idUsuarioReceptor);
                    // Adaptador para llenar tabla
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        tabla = da.ToString();
                    }
                }
                con.Close();

            }

            return tabla;
        }

        public string EliminarAmigo(int idAmistad)
        {
            // Lógica para eliminar una amistad en la base de datos
            // Esto es solo un ejemplo y debe ser reemplazado con la lógica real de acceso a la base de datos
            return "Amigo eliminado correctamente.";
        }

        public void AceptarSolicitud(int IdAmistad)
        {
            using (SqlConnection cn = new SqlConnection(conec.cadenaConexion))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_AceptarAmistad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdAmistad", IdAmistad);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public void RechazarSolicitud(int IdAmistad)
        {
            using (SqlConnection cn = new SqlConnection(conec.cadenaConexion))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_RechazarAmistad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdAmistad", IdAmistad);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public DataTable ObtenerUsuariosConTodosSusTitulos(int idUsuario, string xd = "")
        {

            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conec.cadenaConexion))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerUsuariosConTodosSusTitulos", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Parámetro del SP
                    cmd.Parameters.AddWithValue("@IdUsuarioExcluir", idUsuario);
                    cmd.Parameters.AddWithValue("@TextoBusqueda", xd);
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
        public DataTable ObtenerAmistadesPendientes(int idUsuario)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conec.cadenaConexion))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerAmistadesPendientes", con))
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

    }
}
