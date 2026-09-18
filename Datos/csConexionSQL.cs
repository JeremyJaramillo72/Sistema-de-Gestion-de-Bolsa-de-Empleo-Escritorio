using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CapaDatos
{
    public class csConexionSQL
    {
        SqlCommand comando;
        protected List<SqlParameter> parametros;
        // Cadena de conexión que especifica el servidor, base de datos, y las credenciales de SQL Server.

        //public string cadenaConexion = @"Password=1234567;Persist Security Info=True;User ID=SPAIN;Initial Catalog=APLICACION_NETWORKING;Data Source=26.118.46.198";

        //public string cadenaConexion = @"Server=DESKTOP-BH5OFV8\SQLEXPRESS;Database=V17;User Id=ESPAÑIN;Password=123456;";
        //public string cadenaConexion = @"Password=123;Persist Security Info=True;User ID=Jeremy72;Initial Catalog=v15;Data Source=JEREMY\SQLEXPRESS;";
       // public string cadenaConexion = @"Server=HP\SQLEXPRESS;Database=v14;User Id=Heiner;Password=12345;";

        //public string cadenaConexion = @"Server=DESKTOP-I8UU101\SQLEXPRESS;Database=V12;User Id=KENNYDY;Password=123456;";
        public string cadenaConexion = @"Password=1234567;Persist Security Info=True;User ID=ESPAÑIN;Initial Catalog=V20;Data Source=DESKTOP-BH5OFV8\SQLEXPRESS;";
        //public string cadenaConexion = @"Server=HP\SQLEXPRESS;Database=v14;User Id=Heiner;Password=12345;";


        //public string cadenaConexion = $"Server={servidor}; DataBase={bd}; User id= {usuario}; Password={password} ";

        private SqlConnection conexion;  // Objeto SqlConnection para manejar la conexión con SQL Server.
        // Propiedad que permite acceder al objeto SqlConnection desde fuera de la clase.
        public SqlConnection Conexion { get { return conexion; } }

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }

        private string idUsuario;
        // Constructor de la clase que inicializa el objeto SqlConnection con la cadena de conexión.
        public csConexionSQL()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public int ObtenerIDUsuario(string correo)
        {
            int idUsuario = 0;

            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SELECT ID_Usuario FROM Usuarios WHERE Email =@correo", con);
            cmd.Parameters.AddWithValue("@correo", correo);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null) idUsuario = Convert.ToInt32(result);
                IdUsuario = idUsuario.ToString();
            }
            finally
            {
                con.Close();
            }

            return idUsuario;
        }
        // Método para ejecutar una consulta SELECT y devolver los resultados en un DataTable.
        public DataTable MostrarRegistros(string consulta)
        {
            SqlCommand comando = new SqlCommand(consulta, conexion); // Crea un comando SQL con la consulta proporcionada.
            SqlDataAdapter datos = new SqlDataAdapter(comando);       // Usa SqlDataAdapter para llenar el DataTable con los resultados de la consulta.
            DataTable tabla = new DataTable();                        // Crea un nuevo DataTable para almacenar los resultados.
            datos.Fill(tabla);                                        // Llena el DataTable con los datos obtenidos.
            return tabla;                                             // Retorna el DataTable lleno.
        }
        public DataTable MostrarRegistrosProcedure(string nombreProcedimiento)
        {
            SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
        public DataTable MostrarRegistrosProcedurePorParametro(string nombreProcedimiento, string nombreParametro)
        {

            SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@buscar", SqlDbType.NVarChar, 50)).Value = nombreParametro;
            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
        public DataTable MostrarRegistrosProcedureMisPublicaciones(string nombreProcedimiento, string nombreParametro)
        {
            int id = int.Parse(nombreParametro);
            SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 50)).Value = id;
            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
        public DataTable MostrarRegistrosProcedureMisPublicacionesPorTitulo(string nombreProcedimiento, string nombreParametro, string ID)
        {
            int id = int.Parse(ID);
            SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 50)).Value = id;
            comando.Parameters.Add(new SqlParameter("@buscar", SqlDbType.NVarChar, 50)).Value = nombreParametro;
            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public DataTable MostrarRegistrosComboBox(string nombreProcedimiento, string categoria, string modalidad, string jornadas, string ciudad)
        {
            SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@modalidad", modalidad);
            comando.Parameters.AddWithValue("@jornada", jornadas);
            comando.Parameters.AddWithValue("@ciudad", ciudad);

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
        public DataTable MostrarRegistrosMisComboBox(string nombreProcedimiento, string id, string categoria, string modalidad, string jornada, string ciudad)
        {

            int ID = Convert.ToInt32(id);
            SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 50)).Value = ID;
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@modalidad", modalidad);
            comando.Parameters.AddWithValue("@jornada", jornada);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public (bool, string) RegistrarPublicacion(int id, string titulo, int categoria, int modalidad, int jornada, int ciudad, string descripcion, int experiencia, int salarioP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("PAgregarPublicacion", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("ID_Usuario", id);
            comando.Parameters.AddWithValue("@ID_Categoria", categoria);
            comando.Parameters.AddWithValue("@ID_Modalidad", modalidad);
            comando.Parameters.AddWithValue("@ID_Jornada", jornada);
            comando.Parameters.AddWithValue("@ID_Ciudad", ciudad);
            comando.Parameters.AddWithValue("@Titulo", titulo);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Experiencia", experiencia);
            comando.Parameters.AddWithValue("@SalarioPromedio", salarioP);


            SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
            SqlParameter mensajeRetornoParam = new SqlParameter("@MensajeRetorno", SqlDbType.VarChar, 50) { Direction = ParameterDirection.Output };
            comando.Parameters.Add(resultadoParam);
            comando.Parameters.Add(mensajeRetornoParam);
            comando.ExecuteNonQuery();
            conexion.Close();
            return (Convert.ToBoolean(resultadoParam.Value), mensajeRetornoParam.Value.ToString());

        }

        public (bool, string) ModifcarPublicacion(int idPublicacion, string titulo, int categoria, int modalidad, int jornada, int ciudad, int estado, string descripcion, int experiencia, int salarioP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("PModificarPublicacion", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_Publicacion", idPublicacion);
            comando.Parameters.AddWithValue("@ID_Estado", estado);
            comando.Parameters.AddWithValue("@ID_Categoria", categoria);
            comando.Parameters.AddWithValue("@ID_Modalidad", modalidad);
            comando.Parameters.AddWithValue("@ID_Jornada", jornada);
            comando.Parameters.AddWithValue("@ID_Ciudad", ciudad);
            comando.Parameters.AddWithValue("@Titulo", titulo);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Experiencia", experiencia);
            comando.Parameters.AddWithValue("@SalarioPromedio", salarioP);


            SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
            SqlParameter mensajeRetornoParam = new SqlParameter("@MensajeRetorno", SqlDbType.VarChar, 100) { Direction = ParameterDirection.Output };
            comando.Parameters.Add(resultadoParam);
            comando.Parameters.Add(mensajeRetornoParam);

            comando.ExecuteNonQuery();
            conexion.Close();

            return (Convert.ToBoolean(resultadoParam.Value), mensajeRetornoParam.Value.ToString());
        }
        public (bool, string) GuardarCurriculumPublicacionProcedure(string rutaArchivo, int idUsuario, int idPublicacion)
        {
            try
            {

                byte[] contenido = File.ReadAllBytes(rutaArchivo);
                conexion.Open();
                SqlCommand comando = new SqlCommand("PGestionarHojaVida", conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@Contenido", contenido);
                comando.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                comando.Parameters.AddWithValue("@ID_Publicacion", idPublicacion);
                SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                SqlParameter mensajeRetornoParam = new SqlParameter("@ErrorMessage", SqlDbType.VarChar, 100) { Direction = ParameterDirection.Output };
                comando.Parameters.Add(resultadoParam);
                comando.Parameters.Add(mensajeRetornoParam);

                comando.ExecuteNonQuery();
                conexion.Close();

                return (Convert.ToBoolean(resultadoParam.Value), mensajeRetornoParam.Value.ToString());


            }

            catch (Exception ex)
            {
                return (false, $"Error al guardar la hoja de vida: {ex.Message}");
            }

        }
        public (bool, string) EliminarPublicacion(int IdPublicacion)
        {

            conexion.Open();
            SqlCommand comando = new SqlCommand("PEliminarPublicacion", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Publicacion ", IdPublicacion);
            SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
            SqlParameter mensajeRetornoParam = new SqlParameter("@ErrorMessage ", SqlDbType.VarChar, 100) { Direction = ParameterDirection.Output };
            comando.Parameters.Add(resultadoParam);
            comando.Parameters.Add(mensajeRetornoParam);
            comando.ExecuteNonQuery();
            conexion.Close();

            return (Convert.ToBoolean(resultadoParam.Value), mensajeRetornoParam.Value.ToString());

        }
        public bool VerificarInformacionUsuario(int ID)
        {

            string query = "SELECT COUNT(*) FROM Perfil_Profesional WHERE ID_Usuario = @ID_Usuario";
            int count = 0;
            try
            {
                conexion.Open();
                comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ID_Usuario", ID);
                count = (int)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la información del usuario: " + ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return count > 0;
        }

        public bool Insert(string consulta)
        {
            int result = 0;

            try
            {
                conexion.Open();                                          // Abre la conexión con SQL Server.
                comando = new SqlCommand(consulta, conexion);  // Crea un comando SQL con la consulta proporcionada.
                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result > 0;
        }
        public string EnviarSolicitud(int remitenteId, int destinatarioId)
        {
            string mensajeResultado = "";

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                comando = new SqlCommand("EnviarSolicitud", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@RemitenteID", remitenteId);
                comando.Parameters.AddWithValue("@DestinatarioID", destinatarioId);

                SqlParameter mensajeParameter = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 4000)
                {
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(mensajeParameter);
                comando.ExecuteNonQuery();
                mensajeResultado = mensajeParameter.Value.ToString();

            }
            catch (SqlException ex)
            {
                mensajeResultado = "Error de SQL: " + ex.Message;
            }
            catch (Exception ex)
            {
                mensajeResultado = "Error inesperado: " + ex.Message;
            }
            return mensajeResultado;
        }




        // Método para ejecutar una consulta SELECT y devolver los resultados como un SqlDataReader.
        public SqlDataReader SelectLeer(string consulta)
        {
            conexion.Open();                                          // Abre la conexión con SQL Server.
            SqlCommand comando = new SqlCommand(consulta, conexion);  // Crea un comando SQL con la consulta proporcionada.
            SqlDataReader leer = comando.ExecuteReader();             // Ejecuta la consulta y obtiene un SqlDataReader con los resultados.
            return leer;                                              // Retorna el SqlDataReader con los resultados.
        }
        // Método para cerrar la conexión con SQL Server.
        public void CerrarConexion()
        {
            conexion.Close();
        }

        public void AbrirConexion()
        {
            conexion.Open();
        }
        public string Extraer(string consulta, string columna)
        {
            string resultado = "";
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read()) { resultado = leer[columna].ToString(); }
            conexion.Close();
            return resultado;
        }


        public void ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open(); // Abrir la conexión si no está abierta
                }
                cmd.ExecuteNonQuery(); // Ejecutar la consulta sin devolver resultados
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close(); // Asegúrate de cerrar la conexión después de la operación
                }
            }
        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open(); // Abrir la conexión si no está abierta
                }
                return cmd.ExecuteScalar(); // Ejecutar y devolver el resultado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close(); // Asegúrate de cerrar la conexión después de la operación
                }
            }
        }

        //Metodo kenny
        public DataTable Consultar(string consulta)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }

            return tabla;
        }

        //Metodo kenny
        public void EjecutarConsulta(string query, SqlParameter[] parametros)
        {
            using (SqlCommand cmd = new SqlCommand(query, Conexion))
            {
                cmd.Parameters.AddRange(parametros);
                Conexion.Open();
                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
        }

        //Modificado del existente
        public DataTable MostrarRegistrosProcedurePorParametro22(string nombreProcedimiento, string nombreParametro)
        {

            SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@ID_PerfilProfesional", SqlDbType.NVarChar, 50)).Value = nombreParametro;
            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

    }
}
