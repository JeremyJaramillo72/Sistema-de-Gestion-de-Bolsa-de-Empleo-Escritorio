using CapaDatos;
using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class csUsers : csLogin
    {
        private csUsuariosBD usuarios = new csUsuariosBD();
        int id;
        string nombre;
        string apellido;
        string correoEletronico;
        string telefono;
        string contra;
        string genero_usuario;
        int id_Estado;
        int id_ciudad;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string CorreoEletronico { get => correoEletronico; set => correoEletronico = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Contra { get => contra; set => contra = value; }
        public string Genero_usuario { get => genero_usuario; set => genero_usuario = value; }
        public int Id_Estado { get => id_Estado; set => id_Estado = value; }
        public int Id_Ciudad { get => id_ciudad; set => id_ciudad = value; }

        csConexionSQL conexion = new csConexionSQL();
        csEncriptarMD5 Encriptar = new csEncriptarMD5();
        csLogin login = new csLogin();
        public csUsers() { }

        public (bool, string) AgregarUsuario(int id, string nombre, string apellido, string mall, string telefono, string password, string TIPO_USERS)
        {
            return usuarios.AgregarUsuario(id, nombre, apellido, mall, telefono, password, TIPO_USERS);
        }
        public string InicioDeSession(string correo, string contra)
        {

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return " ";
            }
            string contraEncriptada = Encriptar.Encriptar(contra, correo);
            string rol = "";

            rol = login.VerificarLogin(correo, contraEncriptada);

            if (rol != null)
            {
                return rol;
            }
            else
            {
                MessageBox.Show("Datos Ingresados Incorrectos, intente de nuevo.");
                return null;

            }
        }
        public (bool, string) AgregarEmpresa(string NombreEmpresa, string RUC, string Telefono, string CorreoElectronico, string Contra)
        {
            return usuarios.AgregarEmpresa(NombreEmpresa, RUC, Telefono, CorreoElectronico, Contra);
        }






    }
}
