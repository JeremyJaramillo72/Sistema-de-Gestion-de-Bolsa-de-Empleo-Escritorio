using CapaDatos;
using System.Data;
using System.Windows.Forms;

namespace CAPA_NEGOCIO.New_Clases
{
    public class CsAdmin
    {
        private csReportesBD datos;
        public CsAdmin()
        {
            datos = new csReportesBD();
        }
        public (DataTable, string, int) ObtenerReporte(string TipoStorProcedure)
        {
            string NombreProcedimiento = "";
            NombreProcedimiento = ObtenerNombreSP(TipoStorProcedure);
            return datos.EjecutarProcedimientoReportesSinFecha(NombreProcedimiento);
        }
        private string ObtenerNombreSP(string tipoReporte)
        {
            string nombreSP = "";

            switch (tipoReporte)
            {
                case "Usuarios del Sistema":
                    nombreSP = "SP_ReporteUsuarios";
                    break;
                case "Publicaciones de Empleo":
                    nombreSP = "SP_ReportePublicaciones";
                    break;
                case "Postulaciones a Empleos":
                    nombreSP = "SP_ReportePostulaciones";
                    break;
                case "Empresas Registradas":
                    nombreSP = "SP_ReporteEmpresas";
                    break;
                case "Profesionales Registrados":
                    nombreSP = "SP_ReporteProfesionales";
                    break;
                case "Documentos Académicos":
                    nombreSP = "SP_ReporteDocumentosAcademicos";
                    break;
                case "Experiencia Laboral":
                    nombreSP = "SP_ReporteExperienciaLaboral";
                    break;
                case "Mensajes entre Usuarios":
                    nombreSP = "SP_ReporteMensajeria";
                    break;
                default:
                    MessageBox.Show("Tipo de reporte no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;

            }
            return nombreSP;
        }
    }
}
