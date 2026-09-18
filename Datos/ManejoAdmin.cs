using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaDatos
{
    public class ManejoAdmin
    {
        csConexionSQL conexion = new csConexionSQL();
        // Método para filtrar publicaciones
        public DataTable FiltrarPublicaciones(string categoria, string modalidad, string jornada, string ciudad)
        {
            DataTable tabla = new DataTable();

            using (SqlCommand cmd = new SqlCommand("SP_FiltrarPublicacionesValidacion", conexion.Conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;


                // Parámetros (si vienen vacíos se envía NULL)
                cmd.Parameters.AddWithValue("@CategoriaPublicacion", string.IsNullOrWhiteSpace(categoria) ? (object)DBNull.Value : categoria);
                cmd.Parameters.AddWithValue("@Modalidad", string.IsNullOrWhiteSpace(modalidad) ? (object)DBNull.Value : modalidad);
                cmd.Parameters.AddWithValue("@Jornada", string.IsNullOrWhiteSpace(jornada) ? (object)DBNull.Value : jornada);
                cmd.Parameters.AddWithValue("@Nombre_Ciudad", string.IsNullOrWhiteSpace(ciudad) ? (object)DBNull.Value : ciudad);

                try
                {
                    conexion.AbrirConexion();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
            return tabla;
        }


        public DataTable Filtrarportitulo(string texto)
        {
            DataTable tabla = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SP_BuscarPublicacionesPendientes", conexion.Conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Buscar", string.IsNullOrWhiteSpace(texto) ? (object)DBNull.Value : texto);

                try
                {
                    conexion.AbrirConexion();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
            return tabla;
        }
    }
}
