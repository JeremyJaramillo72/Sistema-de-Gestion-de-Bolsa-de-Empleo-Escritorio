using CapaDatos;
using System;
using System.Data;

namespace CAPA_NEGOCIO.New_Clases
{
    public class CsValidaciónPProfesional
    {
        private CsDatosPerfilProfesional _datosPerfil;

        public CsValidaciónPProfesional()
        {
            _datosPerfil = new CsDatosPerfilProfesional();
        }

        public DataTable ObtenerPerfilesParaRevision(string filtro, string estado, string ciudad)
        {
            try
            {
                // Validar y formatear parámetros
                filtro = string.IsNullOrEmpty(filtro) ? "" : filtro.Trim();
                estado = string.IsNullOrEmpty(estado) ? "" : estado.Trim();
                ciudad = string.IsNullOrEmpty(ciudad) ? "" : ciudad.Trim();

                return _datosPerfil.ObtenerPerfilesParaRevision(filtro, estado, ciudad);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al obtener perfiles: {ex.Message}");
            }
        }

        public DataTable ObtenerEstadosAprobacion()
        {
            try
            {
                return _datosPerfil.ObtenerEstadosAprobacion();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al obtener estados: {ex.Message}");
            }
        }

        public DataTable ObtenerCiudades()
        {
            try
            {
                return _datosPerfil.ObtenerCiudades();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al obtener ciudades: {ex.Message}");
            }
        }

        public DataTable ObtenerDocumentosPendientes(int idPerfilProfesional)
        {
            try
            {
                // Validar que el ID sea válido
                if (idPerfilProfesional <= 0)
                    throw new ArgumentException("ID de perfil profesional no válido");

                return _datosPerfil.ObtenerDocumentosPendientes(idPerfilProfesional);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al obtener documentos: {ex.Message}");
            }
        }

        public bool AprobarDocumento(int idDocumento, string tipoDocumento)
        {
            try
            {
                return _datosPerfil.ActualizarEstadoDocumento(idDocumento, "Aprobado", tipoDocumento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al aprobar documento: {ex.Message}");
            }
        }

        public bool RechazarDocumento(int idDocumento, string tipoDocumento)
        {
            try
            {
                return _datosPerfil.ActualizarEstadoDocumento(idDocumento, "Rechazado", tipoDocumento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en negocio al rechazar documento: {ex.Message}");
            }
        }
    }
}