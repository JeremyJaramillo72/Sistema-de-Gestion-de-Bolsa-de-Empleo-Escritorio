using System;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class csReportesBD
    {
        public csConexionSQL conectar = new csConexionSQL();
        public DataTable ResumenPublicacionPorEmpleoPublicado(string fechaIni, string fechaFin, string estado)
        {
            DataTable dtProfesionales = new DataTable();
            try
            {
                conectar.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand("PReporteNumeroEmpleosPublicados", conectar.Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio", Convert.ToDateTime(fechaIni).Date);
                    cmd.Parameters.AddWithValue("@FechaFin", Convert.ToDateTime(fechaFin).Date);
                    cmd.Parameters.AddWithValue("@Estado", estado);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtProfesionales);
                    }
                }
                conectar.CerrarConexion();
                return dtProfesionales;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public (DataTable, string Mensaje, int Exito) EjecutarProcedimientoReportesSinFecha(string nombreProcedimiento)
        {


            string Mensaje = "";
            int Exito = -1;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = conectar.Conexion)
                {
                    using (SqlCommand oCom = new SqlCommand(nombreProcedimiento, conn))
                    {
                        oCom.CommandType = CommandType.StoredProcedure;

                        SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 255)
                        { Direction = ParameterDirection.Output };
                        oCom.Parameters.Add(paramMensaje);

                        SqlParameter paramExito = new SqlParameter("@Exito", SqlDbType.Bit)
                        { Direction = ParameterDirection.Output };
                        oCom.Parameters.Add(paramExito);

                        using (SqlDataAdapter da = new SqlDataAdapter(oCom))
                        {
                            da.Fill(dt);
                        }
                        Mensaje = paramMensaje.Value != DBNull.Value ? paramMensaje.Value.ToString() : "";
                        Exito = paramExito.Value != DBNull.Value ? Convert.ToInt32(paramExito.Value) : -1;

                        return (dt, Mensaje, Exito);
                    }
                }
            }
            catch (Exception)
            {

                 return (dt, Mensaje, -1);
            }
        }
    }
}
