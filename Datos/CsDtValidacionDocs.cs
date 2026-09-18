using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CsDtValidacionDocs
    {
        private csConexionSQL _conexion;

        public CsDtValidacionDocs()
        {
            _conexion = new csConexionSQL();
        }

        public DataTable ObtenerDatosProfesional(int idPerfilProfesional)
        {
            return _conexion.MostrarRegistrosProcedurePorParametro22(
                "SP_ObtenerDatosProfesional",
                idPerfilProfesional.ToString());
        }

        public DataTable ObtenerTiposDocumento()
        {
            return _conexion.MostrarRegistrosProcedure("SP_ObtenerTiposDocumento");
        }

        public DataTable ObtenerDocumentosPorProfesional(int idPerfilProfesional, string tipoDocumento)
        {
            // Creamos un comando personalizado para manejar múltiples parámetros
            using (var connection = new SqlConnection(_conexion.cadenaConexion))
            {
                using (var command = new SqlCommand("SP_ObtenerDocumentosPorProfesional", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_PerfilProfesional", idPerfilProfesional);

                    if (string.IsNullOrEmpty(tipoDocumento))
                        command.Parameters.AddWithValue("@TipoDocumento", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);

                    var dataTable = new DataTable();
                    var adapter = new SqlDataAdapter(command);

                    connection.Open();
                    adapter.Fill(dataTable);
                    // en ObtenerDocumentosPorProfesional, antes de connection.Open()
                    System.Diagnostics.Debug.WriteLine($"[DEBUG] SP_ObtenerDocumentosPorProfesional -> ID_PerfilProfesional={idPerfilProfesional}, TipoDocumento={(string.IsNullOrEmpty(tipoDocumento) ? "NULL" : tipoDocumento)}");
                    return dataTable;
                }
            }
        }

        public DataTable ObtenerResumenDocumentos(int idPerfilProfesional)
        {
            return _conexion.MostrarRegistrosProcedurePorParametro22(
                "SP_ObtenerResumenDocumentos",
                idPerfilProfesional.ToString());
        }

        public (byte[] Archivo, string TipoMIME) ObtenerArchivoDocumento(int idDocumento, string tipoDocumento, string tablaOrigen)
        {
            using (var connection = new SqlConnection(_conexion.cadenaConexion))
            {
                using (var command = new SqlCommand("SP_ObtenerArchivoDocumento", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Documento", idDocumento);
                    command.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                    command.Parameters.AddWithValue("@TablaOrigen", tablaOrigen);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                byte[] archivo = (byte[])reader["Archivo"];
                                string tipoMIME = reader["TipoMIME"].ToString();
                                return (archivo, tipoMIME);
                            }
                        }
                    }
                }
            }
            return (null, null);
        }

        public bool ActualizarEstadoDocumento(int idDocumento, string tipoDocumento, string estado, string tablaOrigen)
        {
            using (var connection = new SqlConnection(_conexion.cadenaConexion))
            {
                using (var command = new SqlCommand("SP_ActualizarEstadoDocumento", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Documento", idDocumento);
                    command.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@TablaOrigen", tablaOrigen);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) == 1;
                }
            }
        }
    }
}