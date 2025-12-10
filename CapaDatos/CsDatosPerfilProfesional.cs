using System;
using System.Data;

namespace CapaDatos
{
    public class CsDatosPerfilProfesional
    {
        private csConexionSQL _conexion;

        public CsDatosPerfilProfesional()
        {
            _conexion = new csConexionSQL();
        }

        public DataTable ObtenerPerfilesParaRevision(string filtro, string estado, string ciudad)
        {
            try
            {
                return _conexion.MostrarRegistrosProcedure("SP_ObtenerPerfilesParaRevision");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en datos al obtener perfiles: {ex.Message}");
            }
        }
        public DataTable ObtenerEstadosAprobacion()
        {
            try
            {
                // Uss vista
                return _conexion.MostrarRegistros("SELECT * FROM VW_EstadosAprobacion");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en datos al obtener estados: {ex.Message}");
            }
        }
        public DataTable ObtenerCiudades()
        {
            try
            {
                // Uso vista
                return _conexion.MostrarRegistros("SELECT * FROM VW_CiudadesActivas");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en datos al obtener ciudades: {ex.Message}");
            }
        }

        public DataTable ObtenerDocumentosPendientes(int idPerfilProfesional)
        {
            try
            {
                // Usamos el método existente que acepta parámetros
                return _conexion.MostrarRegistrosProcedurePorParametro22(
                    "VW_ObtenerDocumentosPendientes",
                    idPerfilProfesional.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en datos al obtener documentos: {ex.Message}");
            }
        }

        public bool ActualizarEstadoDocumento(int idDocumento, string estado, string tipoDocumento)
        {
            try
            {
                string consulta = $@"
                    UPDATE {tipoDocumento} 
                    SET Estado_Validacion = '{estado}', Fecha_Validacion = GETDATE() 
                    WHERE IdDocumentacion = {idDocumento}";

                return _conexion.Insert(consulta);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en datos al actualizar documento: {ex.Message}");
            }
        }
    }
}