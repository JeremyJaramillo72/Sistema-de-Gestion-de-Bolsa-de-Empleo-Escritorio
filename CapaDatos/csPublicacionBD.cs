using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class csPublicacionBD : csConexionSQL
    {
        ModifcarDatagridview Modificador = new ModifcarDatagridview();
        csdatos llenarCombox = new csdatos();
        private static DataTable registros = new DataTable();
        csConexionSQL conexion = new csConexionSQL();

        public csPublicacionBD()
        {

        }
        public bool ActualizarEstadoDocumento(int id, string categoria, string nuevoEstado,string postulante)
        {
            using (SqlConnection con = new SqlConnection(Conexion.ConnectionString))
            {
                try
                {
                    con.Open();
                    string spName = "";

                  
                    if (categoria == "Formación") spName = "PActualizarEstadoTitulo";
                    else if (categoria == "Idioma") spName = "PActualizarEstadoIdioma";
                    else if (categoria == "Experiencia") spName = "PActualizarEstadoExperiencia";
                    else if (categoria == "Curso") spName = "PActualizarEstadoCurso";

                    if (spName == "") return false; 

                    SqlCommand cmd = new SqlCommand(spName, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Registro", id);
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@ID_Postulacion", postulante);
                    cmd.Parameters.AddWithValue("@Observacion", "NO");

                    return true;
                    
                }
                catch { return false; }
            }
        }
        public bool ActualizarEstadoPostulacion(int idPostulacion, string estado)
        {
            using (SqlConnection con = new SqlConnection(Conexion.ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("PCambiarEstadoPostulacion", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Postulacion", idPostulacion);
                    cmd.Parameters.AddWithValue("@NuevoEstado", estado);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch { return false; }
            }
        }
        public byte[] ObtenerCurriculum(string idUsuario, string idPublicacion)
        {
            byte[] archivoBytes = null;

            using (SqlConnection oconexion = new SqlConnection(Conexion.ConnectionString))
            {
                try
                {
                    oconexion.Open();
                    SqlCommand cmd = new SqlCommand("PVisualizarcurriculum", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

            
                    cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@ID_Publicacion", idPublicacion);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        archivoBytes = (byte[])resultado;
                    }
                }
                catch (Exception ex)
                {
                    archivoBytes = null;
                }
            }
            return archivoBytes;
        }
        public DataGridView LlenarDvgPublicacion(DataGridView dvgPublicacion)
        {
            registros = conexion.MostrarRegistrosProcedure("PMostrar_Publicaciones");
            Modificador.Mostrar(dvgPublicacion, registros);
            return dvgPublicacion;
        }
        public DataGridView LlenarDvgMisPublicacion(DataGridView dvgPublicacion, string id)
        {
            registros = conexion.MostrarRegistrosProcedureMisPublicaciones("PMisPublicaciones", id);
            Modificador.Mostrar(dvgPublicacion, registros);
            return dvgPublicacion;
        }
        public DataGridView ListaPostulantes(DataGridView dvgPublicaciones, string id)
        {
            dvgPublicaciones.Rows.Clear();
            registros = conexion.MostrarRegistrosProcedurePorParametro("PMostrarPostulantes", id);
            Modificador.Mostrar(dvgPublicaciones, registros);
            return dvgPublicaciones;
        }
        public DataGridView ValidarDOc(DataGridView dvgPublicaciones, string id)
        {
            dvgPublicaciones.Rows.Clear();
            registros = conexion.MostrarRegistrosProcedurePorParametro("PObtenerDocumentosCompletos", id);
            Modificador.Mostrar(dvgPublicaciones, registros);
            return dvgPublicaciones;
        }
        public byte[] ObtenerBytesDeBD(int idRegistro, string categoria)
        {
            byte[] archivoBytes = null;

            // Usamos 'using' para que la conexión se cierre sola
            using (SqlConnection oconexion = new SqlConnection(Conexion.ConnectionString))
            {
                try
                {
                    oconexion.Open();
                    SqlCommand cmd = new SqlCommand("PObtenerArchivoBinario", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros
                    cmd.Parameters.AddWithValue("@ID_Registro", idRegistro);
                    cmd.Parameters.AddWithValue("@Categoria", categoria);

                    // ExecuteScalar: Es la función perfecta cuando solo quieres traer UN dato (el archivo)
                    object resultado = cmd.ExecuteScalar();

                    // Validamos que no sea nulo antes de convertir
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        archivoBytes = (byte[])resultado;
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error devolvemos null
                    archivoBytes = null;
                }
            }

            return archivoBytes;
        }
        public DataGridView BuscarPublicacion(DataGridView dvgPublicaciones, string buscar)
        {

            dvgPublicaciones.Rows.Clear();
            registros = conexion.MostrarRegistrosProcedurePorParametro("PBuscarPublicaciones", buscar);
            Modificador.Mostrar(dvgPublicaciones, registros);
            return dvgPublicaciones;
        }
        public DataGridView MisBuscarPublicacion(DataGridView dvgPublicaciones, string buscar, string id)
        {

            dvgPublicaciones.Rows.Clear();
            registros = conexion.MostrarRegistrosProcedureMisPublicacionesPorTitulo("PMisPublicacionesBuscar", buscar, id);
            Modificador.Mostrar(dvgPublicaciones, registros);
            return dvgPublicaciones;
        }
        public void AgregarComboBox(ComboBox categoria, ComboBox modalidad, ComboBox jornada, ComboBox ciudad)
        {
            llenarCombox.llenarcmbProcedure(categoria, "PMostrarCategorias", "CategoriaPublicacion", "ID_Categoria_Publicacion");
            llenarCombox.llenarcmbProcedure(modalidad, "PMostrarModalidad", "Modalidad", "ID_Modalidad");
            llenarCombox.llenarcmbProcedure(jornada, "PMostrarJornada", "Jornada", "ID_Jornada");
            llenarCombox.llenarcmbProcedure(ciudad, "PVisualizarCiudades", "Nombre_Ciudad", "ID_Ciudad");
        }
        public void AgregarComboBoxEstado(ComboBox Estado)
        {
            llenarCombox.llenarcmbProcedure(Estado, "PVisualizarEstadoPublicacion", "TipoEstado", "ID_EstadoP");
        }
        public void AgregarComboBoxCiudad (ComboBox ciudad)
        {
            llenarCombox.llenarcmbProcedure(ciudad, "PVisualizarCiudades", "Nombre_Ciudad", "ID_Ciudad");
        }
        public DataGridView BuscarMisPublicacionComboBox(DataGridView dvgPublicaciones, string id, string categoria, string modalidad, string jornada, string ciudad)
        {
            dvgPublicaciones.Rows.Clear();
            registros = conexion.MostrarRegistrosMisComboBox("PMisPublicaionesFiltro", id, categoria, modalidad, jornada, ciudad);
            Modificador.Mostrar(dvgPublicaciones, registros);
            return dvgPublicaciones;
        }
        public DataGridView BuscarPublicacionComboBox(DataGridView dvgPublicaciones, string categoria, string modalidad, string jornada, string ciudad)
        {
            dvgPublicaciones.Rows.Clear();
            registros = conexion.MostrarRegistrosComboBox("PBuscarPublicacionesPorFiltros", categoria, modalidad, jornada, ciudad);
            Modificador.Mostrar(dvgPublicaciones, registros);
            return dvgPublicaciones;
        }
        public (bool, string) AgregarPublicacion(int id, string titulo, int categoria, int modalidad, int jornada, int ciudad, string descripcion, int experiencia, int salarioP)
        {
            return conexion.RegistrarPublicacion(id, titulo, categoria, modalidad, jornada, ciudad, descripcion, experiencia, salarioP);
        }
        public (bool, string) ModifcarPublicacion(int idPublicacion, string titulo, int categoria, int modalidad, int jornada, int ciudad, int estado, string descripcion, int experiencia, int salarioP)
        {
            return conexion.ModifcarPublicacion(idPublicacion, titulo, categoria, modalidad, jornada, ciudad, estado, descripcion, experiencia, salarioP);
        }
        public (bool, string) GuardarCurriculumPublicacion(string rutaArchivo, int idUsuario, int idPublicacion)
        {
            return conexion.GuardarCurriculumPublicacionProcedure(rutaArchivo, idUsuario, idPublicacion);
        }
        public (bool, string) EliminarPublicacionProcedure(int IdPublicacion)
        {

            return conexion.EliminarPublicacion(IdPublicacion);
        }
    }
}