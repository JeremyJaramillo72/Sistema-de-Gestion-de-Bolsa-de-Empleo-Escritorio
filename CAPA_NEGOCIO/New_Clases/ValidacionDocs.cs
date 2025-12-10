using CapaDatos;
using System;
using System.Data;
using System.IO;
namespace CAPA_NEGOCIO.New_Clases
{
    public class ValidacionDocs
    {
        private CsDtValidacionDocs _datosValidacion;

        public ValidacionDocs()
        {
            _datosValidacion = new CsDtValidacionDocs();
        }

        public DataTable ObtenerDatosProfesional(int idPerfilProfesional)
        {
            try
            {
                return _datosValidacion.ObtenerDatosProfesional(idPerfilProfesional);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al obtener datos del profesional: {ex.Message}");
            }
        }

        public DataTable ObtenerTiposDocumento()
        {
            try
            {
                return _datosValidacion.ObtenerTiposDocumento();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al obtener tipos de documento: {ex.Message}");
            }
        }

        public DataTable ObtenerDocumentosPorProfesional(int idPerfilProfesional, string tipoDocumento)
        {
            try
            {
                return _datosValidacion.ObtenerDocumentosPorProfesional(idPerfilProfesional, tipoDocumento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al obtener documentos: {ex.Message}");
            }
        }

        public DataTable ObtenerResumenDocumentos(int idPerfilProfesional)
        {
            try
            {
                return _datosValidacion.ObtenerResumenDocumentos(idPerfilProfesional);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al obtener resumen: {ex.Message}");
            }
        }

        public string AbrirDocumentoEnNavegador(int idDocumento, string tipoDocumento, string tablaOrigen)
        {
            try
            {
                var (archivo, tipoMIME) = _datosValidacion.ObtenerArchivoDocumento(idDocumento, tipoDocumento, tablaOrigen);
                if (archivo != null)
                {
                    // Crear archivo temporal
                    string extension = ObtenerExtensionPorTipoMIME(tipoMIME);
                    string tempPath = Path.GetTempFileName();
                    string tempFilePath = Path.ChangeExtension(tempPath, extension);

                    File.WriteAllBytes(tempFilePath, archivo);

                    // Abrir en el navegador predeterminado
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = tempFilePath,
                        UseShellExecute = true
                    });

                    return tempFilePath;
                }
                else
                {
                    throw new Exception("El documento no está disponible o no se encontró.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al abrir el documento: {ex.Message}");
            }
        }

        private string ObtenerExtensionPorTipoMIME(string tipoMIME)
        {
            switch (tipoMIME.ToLower())
            {
                case "application/pdf":
                    return ".pdf";
                case "image/jpeg":
                    return ".jpg";
                case "image/png":
                    return ".png";
                case "application/msword":
                    return ".doc";
                case "application/vnd.openxmlformats-officedocument.wordprocessingml.document":
                    return ".docx";
                default:
                    return ".pdf"; // Por defecto asumimos PDF
            }
        }

        public bool ActualizarEstadoDocumento(int idDocumento, string tipoDocumento, string estado, string tablaOrigen)
        {
            try
            {
                return _datosValidacion.ActualizarEstadoDocumento(idDocumento, tipoDocumento, estado, tablaOrigen);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al actualizar estado: {ex.Message}");
            }
        }
    }
}