using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class DataMensajes : csConexionSQL
    {
        csConexionSQL app = new csConexionSQL();
        private string usuario;
        private int id_usuario;
        private byte[] perfil;
        private int id_usrEmisor;
        private int id_usrReceptor;
        private string mensaje;
        private DateTime fechaHora;


        // Método 
        public string Usuario { get { return usuario; } set { usuario = value; } }
        public int IdUsuario { get { return id_usuario; } set { id_usuario = value; } }
        public byte[] Perfil { get { return perfil; } set { perfil = value; } }
        public int Emisor { get { return id_usrEmisor; } set { id_usrEmisor = value; } }
        public int Receptor { get { return id_usrReceptor; } set { id_usrReceptor = value; } }
        public string Mensaje { get { return mensaje; } set { mensaje = value; } }
        public DateTime FechaHora { get { return fechaHora; } set { fechaHora = value; } }

        public DataMensajes(int id)
        {
            IdUsuario = id;

        }
        public DataMensajes()
        {

        }
        public List<DataMensajes> UsrMje(int id)
        {
            //csConexionSQL app = new csConexionSQL();
            string comando = "ObtenerUltimosMensajes";
            SqlCommand cmd = new SqlCommand(comando, app.Conexion); // Suponiendo que 'connection' ya está definida

            // Establecer el tipo de comando como procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure;

            // Establecer el parámetro para la consulta
            cmd.Parameters.AddWithValue("@loginUser", id);

            // Ejecutar la consulta y obtener los resultados
            SqlDataReader reader = null;
            List<DataMensajes> ListaUsrMje = new List<DataMensajes>();

            try
            {
                app.Conexion.Open(); // Asegúrate de que la conexión esté abierta

                reader = cmd.ExecuteReader(); // Ejecutar el procedimiento almacenado y obtener el DataReader

                // Llenar la lista con los resultados de la consulta
                while (reader.Read())
                {
                    ListaUsrMje.Add(new DataMensajes
                    {
                        Usuario = reader["TUsuario"].ToString(),
                        Perfil = (byte[])reader["Perfil"],
                        Mensaje = reader["TMensaje"].ToString(),
                        Emisor = Convert.ToInt32(reader["Emisor"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los mensajes: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close(); // Asegúrate de cerrar el lector de datos
                app.Conexion.Close(); // Cerrar la conexión
            }

            return ListaUsrMje;
        }




        public List<DataMensajes> MsgConUsr(string Usr, int id)
        {
            string comando = "ObtenerMensajesPorUsuario";
            SqlCommand cmd = new SqlCommand(comando, app.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@loginUsr", id));
            cmd.Parameters.Add(new SqlParameter("@usuario", Usr));
            var MensajesConUsr = new List<DataMensajes>();
            try
            {
                app.Conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MensajesConUsr.Add(new DataMensajes
                    {
                        Emisor = Convert.ToInt32(reader["ID_Remitente"]),
                        Mensaje = reader["mensaje"].ToString()
                    });
                }
                reader.Close();  // Cerrar el reader
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los mensajes: " + ex.Message);
            }
            finally
            {
                app.Conexion.Close();
            }
            return MensajesConUsr;
        }
        public void NuevoMensaje(string UsuarioR, int id)
        {
            // Establecer el nombre del procedimiento almacenado para verificar duplicados
            string verificarComando = "VerificarMensajeDuplicado";
            SqlCommand cmd = new SqlCommand(verificarComando, app.Conexion); // Suponiendo que 'app.Conexion' es tu conexión a la base de datos

            // Establecer el tipo de comando como StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Agregar los parámetros necesarios para la verificación
            cmd.Parameters.Add(new SqlParameter("@id_emisor", id));
            cmd.Parameters.Add(new SqlParameter("@usr_receptor", UsuarioR));
            cmd.Parameters.Add(new SqlParameter("@mensaje", mensaje));
            cmd.Parameters.Add(new SqlParameter("@fechaLimite", DateTime.Now.AddSeconds(-5))); // Verifica si fue enviado hace menos de 5 segundos

            // Ejecutar la consulta para verificar si el mensaje ya fue enviado
            var resultado = ExecuteScalar(cmd); // Ejecutar el procedimiento y obtener el resultado

            if (Convert.ToInt32(resultado) == 0) // Si no hay mensajes duplicados
            {
                // Establecer el nombre del procedimiento almacenado para insertar el mensaje
                string comando = "InsertarMensaje";
                cmd = new SqlCommand(comando, app.Conexion); // Crear un nuevo comando para la inserción

                // Establecer el tipo de comando como StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros necesarios para la inserción
                cmd.Parameters.Add(new SqlParameter("@id_emisor", id));
                cmd.Parameters.Add(new SqlParameter("@usr_receptor", UsuarioR));
                cmd.Parameters.Add(new SqlParameter("@mensaje", mensaje));
                cmd.Parameters.Add(new SqlParameter("@fechaHora", DateTime.Now));

                // Ejecutar el procedimiento para insertar el mensaje
                ExecuteNonQuery(cmd); // Ejecutar el procedimiento para insertar el mensaje
            }
            else
            {
                // Si el mensaje es duplicado, no realizar ninguna acción
                MessageBox.Show("Este mensaje ya fue enviado.");
            }
        }
    }
}
