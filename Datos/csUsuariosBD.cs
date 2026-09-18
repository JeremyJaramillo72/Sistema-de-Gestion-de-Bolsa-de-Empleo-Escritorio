using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CapaDatos
{
    public class csUsuariosBD : csConexionSQL
    {
        public (bool, string) AgregarUsuario(int Id, string Nombre, string Apellido, string CorreoElectronico, string Telefono, string Contra, string Genero_usuario)
        {
            try
            {
                Conexion.Open();
                SqlCommand cmdUsuario = new SqlCommand("InsertarProfessional/Administrador", Conexion);
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.Parameters.AddWithValue("@Rol", 1);
                cmdUsuario.Parameters.AddWithValue("@Nombre", Nombre);
                cmdUsuario.Parameters.AddWithValue("@Apellido", Apellido);
                cmdUsuario.Parameters.AddWithValue("@Correo", CorreoElectronico);
                cmdUsuario.Parameters.AddWithValue("@Contraseña", Contra);
                cmdUsuario.Parameters.AddWithValue("@Telefono", Telefono);
                cmdUsuario.Parameters.AddWithValue("@Genero", Genero_usuario);
                cmdUsuario.Parameters.AddWithValue("@IDImagen", Id);
                SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                SqlParameter mensajeRetornoParam = new SqlParameter("@MensajeRetorno", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };
                cmdUsuario.Parameters.Add(resultadoParam);
                cmdUsuario.Parameters.Add(mensajeRetornoParam);
                cmdUsuario.ExecuteNonQuery();
                Conexion.Close();
                return (Convert.ToBoolean(resultadoParam.Value), mensajeRetornoParam.Value.ToString());
            }
            catch (Exception ex)
            {
                return (false, $"Error al guardar el usuario: {ex.Message}");

            }

        }

        public string OBtenerIdpro(string IDUser)
        {
            int idUsuario = 0;

            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("select ID_PerfilProfesional From Perfil_Profesional where ID_Usuario= @IDUser", con);
            cmd.Parameters.AddWithValue("@IDUser", Convert.ToInt32(IDUser));

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null) idUsuario = Convert.ToInt32(result);
            }
            finally
            {
                con.Close();
            }
            
            return idUsuario.ToString();
        }

        public string ObtenerIdRol(string IDUser)
        {
            int idRol = 0;

            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SELECT ID_Rol FROM Usuarios WHERE ID_Usuario = @IDUser", con);
            cmd.Parameters.AddWithValue("@IDUser", Convert.ToInt32(IDUser));

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    idRol = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Puedes loggear el error o manejarlo según necesites
                Console.WriteLine($"Error al obtener ID_Rol: {ex.Message}");
                return "0"; // Retorna 0 en caso de error
            }
            finally
            {
                con.Close();
            }

            return idRol.ToString();
        }

        // procedimiento para guardar los titulos academicos. Autor : kenny
        public (bool, string) GuardarTitulosAcademicos(
            string idPerfilProfesional,
            string tituloAcademico,
            string institucion,
            int anioGraduacion,
            string nivelEstudios,
            byte[] archivoTitulo)
        {
            try
            {
                Conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarTitulos", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdPerfilProfesional", idPerfilProfesional);
                cmd.Parameters.AddWithValue("@TituloAcademico", tituloAcademico);
                cmd.Parameters.AddWithValue("@Institucion", institucion);
                cmd.Parameters.AddWithValue("@AnioGraduacion", anioGraduacion);
                cmd.Parameters.AddWithValue("@NivelEstudios", nivelEstudios);
                cmd.Parameters.Add("@ArchivoTitulo", SqlDbType.VarBinary).Value = archivoTitulo;

                SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };

                SqlParameter mensajeParam = new SqlParameter("@MensajeRetorno", SqlDbType.VarChar, 200)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(resultadoParam);
                cmd.Parameters.Add(mensajeParam);

                cmd.ExecuteNonQuery();
                Conexion.Close();

                return (Convert.ToBoolean(resultadoParam.Value), mensajeParam.Value.ToString());
            }
            catch (Exception ex)
            {
                return (false, "Error al guardar título académico: " + ex.Message);
            }
        }

        public (bool, string) GuardarExperienciaLaboral(
            string idPerfilProfesional,
            string empresa,
            string cargo,
            DateTime fechaInicio,
            DateTime fechaFin,
            string descripcion,
            string ubicacion,
            string urlEmpresa,
            byte[] archivo)
        {
            try
            {
                Conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarExpLaboral", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdPerfilProfesional", idPerfilProfesional);
                cmd.Parameters.AddWithValue("@Empresa", empresa);
                cmd.Parameters.AddWithValue("@Cargo", cargo);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@Ubicacion", ubicacion);
                cmd.Parameters.AddWithValue("@UrlEmpresa", urlEmpresa);
                cmd.Parameters.Add("@Archivo", SqlDbType.VarBinary).Value = archivo;

                SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };

                SqlParameter mensajeParam = new SqlParameter("@MensajeRetorno", SqlDbType.VarChar, 200)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(resultadoParam);
                cmd.Parameters.Add(mensajeParam);

                cmd.ExecuteNonQuery();
                Conexion.Close();

                return (Convert.ToBoolean(resultadoParam.Value), mensajeParam.Value.ToString());
            }
            catch (Exception ex)
            {
                return (false, "Error al guardar experiencia laboral: " + ex.Message);
            }
        }


        public (bool, string) AgregarEmpresa(string NombreEmpresa, string RUC, string Telefono, string CorreoElectronico, string Contra)
        {
            try
            {
                Conexion.Open();
                SqlCommand cmdEmpresa = new SqlCommand("InsertarEmpresa", Conexion);
                cmdEmpresa.CommandType = CommandType.StoredProcedure;
                cmdEmpresa.Parameters.AddWithValue("@NombreEmpresa", NombreEmpresa);
                cmdEmpresa.Parameters.AddWithValue("@RUC", RUC);
                cmdEmpresa.Parameters.AddWithValue("@TELEFONO", Telefono);
                cmdEmpresa.Parameters.AddWithValue("@CORREO", CorreoElectronico);
                cmdEmpresa.Parameters.AddWithValue("@CONTRA", Contra);

                SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                SqlParameter mensajeRetornoParam = new SqlParameter("@MensajeRetorno", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };

                cmdEmpresa.Parameters.Add(resultadoParam);
                cmdEmpresa.Parameters.Add(mensajeRetornoParam);

                cmdEmpresa.ExecuteNonQuery();
                Conexion.Close();

                return (Convert.ToBoolean(resultadoParam.Value), mensajeRetornoParam.Value.ToString());
            }
            catch (Exception ex)
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                return (false, $"Error al guardar la empresa: {ex.Message}");
            }
        }


        public (bool, string) GuardarPerfilIdioma(string ID,
                                         int idIdioma,
                                         byte[] certificado,
                                         string codigoCertificado)
        {
            try
            {
                Conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarPerfilIdioma", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Usuario", ID);
                cmd.Parameters.AddWithValue("@ID_Idioma", idIdioma);
                cmd.Parameters.Add("@Certificado", SqlDbType.VarBinary).Value = certificado;
                cmd.Parameters.AddWithValue("@Codigo_Certificado", codigoCertificado);

                SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };

                SqlParameter mensajeParam = new SqlParameter("@MensajeRetorno", SqlDbType.VarChar, 200)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(resultadoParam);
                cmd.Parameters.Add(mensajeParam);

                cmd.ExecuteNonQuery();
                Conexion.Close();

                return (Convert.ToBoolean(resultadoParam.Value), mensajeParam.Value.ToString());
            }
            catch (Exception ex)
            {
                return (false, "Error al guardar idioma: " + ex.Message);
            }
        }

        public (bool, string) GuardarPostulacion(string idUsuario,
                                         string idPublicacion,
                                         byte[] cvArchivo)
        {
            try
            {
                Conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarPostulacionXML", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@IdPublicacion", idPublicacion);
                cmd.Parameters.Add("@CV_Archivo", SqlDbType.VarBinary).Value = cvArchivo;

                SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };

                SqlParameter mensajeParam = new SqlParameter("@MensajeRetorno", SqlDbType.VarChar, 200)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(resultadoParam);
                cmd.Parameters.Add(mensajeParam);

                cmd.ExecuteNonQuery();
                Conexion.Close();

                return (Convert.ToBoolean(resultadoParam.Value), mensajeParam.Value.ToString());
            }
            catch (Exception ex)
            {
                return (false, "Error al guardar la postulación: " + ex.Message);
            }
        }


    }
}
