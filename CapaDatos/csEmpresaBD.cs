using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class csEmpresaBD : csConexionSQL
    {
        csdatos llenarCombox = new csdatos();

        string nombre_Empresa;
        string rUC;
        string sitio_Web;
        string sector_Empresa;
        string descripcionEmpresa;
        string direccion;
        int ciudad;
        string nombreCiudad;

        public string Nombre_Empresa { get => nombre_Empresa; set => nombre_Empresa = value; }
        public string RUC { get => rUC; set => rUC = value; }
        public string Sitio_Web { get => sitio_Web; set => sitio_Web = value; }
        public string Sector_Empresa { get => sector_Empresa; set => sector_Empresa = value; }
        public string DescripcionEmpresa { get => descripcionEmpresa; set => descripcionEmpresa = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Ciudad { get => ciudad; set => ciudad = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }

        public csEmpresaBD()
        {
        }
        public void AgregarComboBoxEstado(ComboBox Estado)
        {
            llenarCombox.llenarcmbProcedure(Estado, "PVisualizarCiudades", "Nombre_Ciudad", "ID_Ciudad");
        }


        public void AgregarComboBoxSectorIndustrial(ComboBox Estado)
        {
            llenarCombox.llenarcmbProcedure(Estado, "PObtenerSectores", "Nombre_Sector", "ID_Sector");
        }
        public int VerificarPerfilEmpresa(string ID_Empresa)
        {
            int verificar = 0;
            Conexion.Open();

            SqlCommand comando = new SqlCommand("VerificarExistenciaDeDatosEmpresa", Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_USUARIO", int.Parse(ID_Empresa));
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {

                if (leer["ID_Ciudad"] != DBNull.Value)
                {

                    verificar = Convert.ToInt32(leer["ID_Ciudad"]);
                }
                else
                {


                    verificar = 0;
                }
            }
            leer.Close();
            Conexion.Close();
            return verificar;

        }
        public csEmpresaBD rellenarDatosEmpresa(string ID_Empresa)
        {
            csEmpresaBD datos = new csEmpresaBD();
            Conexion.Open();
            SqlCommand comando = new SqlCommand("RellenarDatosEmpresa", Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_USUARIO", int.Parse(ID_Empresa));
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                datos.Nombre_Empresa = leer["Razon_Social"].ToString().Trim();
                datos.RUC = leer["RUC"].ToString().Trim();
                datos.Sitio_Web = leer["Sitio_Web"].ToString().Trim();
                datos.Sector_Empresa = leer["Sector_Industrial"].ToString().Trim();
                datos.DescripcionEmpresa = leer["Descripcion_Empresa"].ToString().Trim();
                datos.Direccion = leer["Direccion"].ToString().Trim();
                datos.NombreCiudad = leer["Nombre_Ciudad"].ToString().Trim();

                leer.Close();
                Conexion.Close();
                return datos;
            }
            else
            {
                leer.Close();
                Conexion.Close();
                return null;
            }
        }


        public (bool, string) ActualizarPerfil(int idUsuario, string sector, string web, int idCiudad, string direccion, string descripcion)
        {
            try
            {
                Conexion.Open();
                SqlCommand cmd = new SqlCommand("PActualizarPerfilEmpresa", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                cmd.Parameters.AddWithValue("@ID_Sector ", sector);
                cmd.Parameters.AddWithValue("@SitioWeb", web);
                cmd.Parameters.AddWithValue("@ID_Ciudad", idCiudad);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                SqlParameter paramRes = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                SqlParameter paramMsj = new SqlParameter("@Mensaje", SqlDbType.VarChar, 100) { Direction = ParameterDirection.Output };

                cmd.Parameters.Add(paramRes);
                cmd.Parameters.Add(paramMsj);

                cmd.ExecuteNonQuery();
                Conexion.Close();

                return (Convert.ToBoolean(paramRes.Value), paramMsj.Value.ToString());
            }
            catch (Exception ex)
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                return (false, "Error: " + ex.Message);
            }
        }


        public (bool, string) ActualizarFotoPerfil(int idUsuario, byte[] imagenBytes)
        {
            try
            {
                Conexion.Open();
                SqlCommand cmd = new SqlCommand("PActualizarFotoEmpresa", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                cmd.Parameters.AddWithValue("@Imagen", imagenBytes);

                SqlParameter paramRes = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                SqlParameter paramMsj = new SqlParameter("@Mensaje", SqlDbType.VarChar, 100) { Direction = ParameterDirection.Output };

                cmd.Parameters.Add(paramRes);
                cmd.Parameters.Add(paramMsj);

                cmd.ExecuteNonQuery();
                Conexion.Close();

                return (Convert.ToBoolean(paramRes.Value), paramMsj.Value.ToString());
            }
            catch (Exception ex)
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                return (false, ex.Message);
            }
        }
    }
}
