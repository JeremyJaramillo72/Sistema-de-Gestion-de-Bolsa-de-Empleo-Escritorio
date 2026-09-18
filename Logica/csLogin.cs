using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class csLogin : csConexionSQL
    {
        public string VerificarLogin(string usuario, string contraseña)
        {
            string Rol = "";
            Conexion.Open();
            string consulta = "ObtenerUsuarioPorCredenciales";
            SqlCommand comando = new SqlCommand(consulta, Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                IdUsuario = leer["ID_Usuario"].ToString().Trim();
                leer.Close();
                Conexion.Close();
                Rol = VerificarIDRol(int.Parse(IdUsuario));


                return Rol;
            }
            else
            {
                leer.Close();
                Conexion.Close();
                return Rol = " ";
            }
        }
        public string VerificarRol(string idusuario)
        {
            Conexion.Open();

            SqlCommand comando = new SqlCommand("Rol_Usuario", Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreRol", idusuario);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                string rol = leer["Nombre_Rol"].ToString().Trim();
                leer.Close();
                Conexion.Close();
                return rol;
            }
            else
            {
                leer.Close();
                Conexion.Close();
                return null;
            }
        }
        public string VerificarIDRol(int idRolusuario)
        {
            Conexion.Open();
            string consulta = "Id_Rol";
            SqlCommand comando = new SqlCommand(consulta, Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", idRolusuario);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                string rol = leer["ID_Rol"].ToString().Trim();
                leer.Close();
                Conexion.Close();
                string rol02 = VerificarRol(rol);
                return rol02;
            }
            else
            {
                leer.Close();
                Conexion.Close();
                return null;
            }
        }

        public void ActualizarContraseña(string correo, string NuevaClave)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ActualizarContraseñaPorCorreo", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", NuevaClave);
                Conexion.Open();
                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña: " + ex.Message);
            }
        }


        public bool VerificarCorreo(string correo, string nombreProcedimiento)
        {
            bool existe = false;
            try
            {
                SqlCommand cmd = new SqlCommand(nombreProcedimiento, Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Correo", correo);
                SqlParameter outputParam = new SqlParameter("@Resultado", SqlDbType.Int);
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);

                Conexion.Open();
                cmd.ExecuteNonQuery();
                int resultado = (int)outputParam.Value;
                if (resultado > 0)
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return existe;
        }

    }
}
