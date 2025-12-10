using APP_NET.Clases;
using APP_NET.Formularios;
using APP_NET.FRMNUEVOS;
using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class Perfil_Pro : Form
    {
        string ID_rol;
        string ID;
        bool registroExistente = false; // nivel de clase
        csConexionSQL dato = new csConexionSQL();
        csdatos dt = new csdatos();
        csUsuariosBD usa = new csUsuariosBD();


        public Perfil_Pro(string x)
        {
            InitializeComponent();
            ID = x;
            ID_rol = usa.ObtenerIdRol(ID);
            Imagen mi = new Imagen();
            mi.MostrarLogoNombre(x, Ft_Perfil);

        }

        private void Perfil_Pro_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            dt.llenarcmb(cmbProvincia, "select * from Provincia", "Nombre_Provincia", "ID_Provincia");
            CargarIdiomas();
            //dt.llenarcmb(cmb_Idioma, "select * from Tipo_Idioma", "Nombre_Idioma", "ID_Idioma");
            CargarDatosPerfil();

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            btn_idioama.Visible = false;
        }

        private void CargarDatosUsuario()
        {
            try
            {
                dato.AbrirConexion();

                string query = "SELECT Nombre_Usuario, Apellido_Usuario, Email, Telefono " +
                               "FROM Usuarios WHERE ID_Usuario = @ID";

                SqlCommand cmd = new SqlCommand(query, dato.Conexion);
                cmd.Parameters.AddWithValue("@ID", ID);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txt_nom.Text = dr["Nombre_Usuario"].ToString();
                    txt_apellido_.Text = dr["Apellido_Usuario"].ToString();
                    txt_email.Text = dr["Email"].ToString();
                    txt_telefono_.Text = dr["Telefono"].ToString();
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message);
            }
            finally
            {
                dato.CerrarConexion();
            }
        }

        private void cmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idProvincia = cmbProvincia.SelectedValue.ToString();
            dtLlenarCiudades(idProvincia);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagen = new OpenFileDialog();
            Imagen.Filter = "archivos de imagen (*.png)|*.png;";
            if (Imagen.ShowDialog() == DialogResult.OK)
            {
                Ft_Perfil.BackgroundImage = null;
                Ft_Perfil.Image = null;

                Ft_Perfil.Image = System.Drawing.Image.FromFile(Imagen.FileName);
                new Imagen().GuardarImagen(Ft_Perfil, "INSERT INTO Imagen(Imagen) VALUES(@imagen)");

                string IdUltimo = "SELECT MAX(ID_Imagen) AS ID_MAX FROM Imagen";
                string idMaximo = dato.Extraer(IdUltimo, "ID_MAX");
                string cadena2 = "UPDATE Usuario_Imagen SET ID_Imagen = '" + idMaximo + "' WHERE ID_Usuario = '" + ID + "'";
                dato.Insert(cadena2);

                if (this.Owner is FrmMenu frmMenu)
                {
                    frmMenu.ImgPerfil.Image = null;
                    frmMenu.ImgPerfil.Image = Ft_Perfil.Image;
                    frmMenu.ImgPerfil.Refresh();
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string Descripcion = richTextBox1.Text.Trim();
            int ID_Ciudad = int.Parse(cmbCiudad.SelectedValue.ToString());
            string ID_Usuario = ID;   // asumimos que ya lo tienes
           
            // Validaciones
            if (string.IsNullOrWhiteSpace(Descripcion))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            if (cmbCiudad.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una ciudad.");
                return;
            }

            if (!registroExistente)
            {
                dato.Insert($"UPDATE Usuarios SET ID_Rol = '{ID_rol}', Descripcion_Personal = '{Descripcion}',  ID_Ciudad = {ID_Ciudad} WHERE ID_Usuario = {ID}");
                MessageBox.Show("Registro guardado correctamente.");
                registroExistente = true;
                btn_Guardar.Text = "Actualizar Datos";
            }
            else
            {
                dato.Insert($"UPDATE Usuarios SET ID_Rol = '{ID_rol}', Descripcion_Personal = '{Descripcion}',  ID_Ciudad = {ID_Ciudad} WHERE ID_Usuario = {ID}");
                MessageBox.Show("Datos actualizados correctamente.");
            }

        }

        private void CargarDatosPerfil()
        {
            string ID_Usuario = ID;

            DataTable dt = dato.Consultar(@"select u.Descripcion_Personal, u.ID_Ciudad, c.ID_Provincia from Usuarios u 
            inner join Ciudad c on u.ID_Ciudad=c.ID_Ciudad
            where u.ID_Usuario= '"+ ID_Usuario + "'");

            if (dt.Rows.Count > 0)
            {
                string descripcion = dt.Rows[0]["Descripcion_Personal"].ToString();
                string idCiudad = dt.Rows[0]["ID_Ciudad"].ToString();
                string idProvincia = dt.Rows[0]["ID_Provincia"].ToString();
                richTextBox1.Text = descripcion;
                cmbProvincia.SelectedValue = idProvincia;
                dtLlenarCiudades(idProvincia);
                cmbCiudad.SelectedValue = idCiudad;
                registroExistente = true;
                btn_Guardar.Text = "Actualizar Datos";
            }
            else
            {
                registroExistente = false;
                btn_Guardar.Text = "Guardar";
            }
        }

        private void dtLlenarCiudades(string idProvincia)
        {
            dt.llenarcmb(cmbCiudad,
                         $"SELECT * FROM Ciudad WHERE ID_Provincia = {idProvincia}",
                         "Nombre_Ciudad",
                         "ID_Ciudad");
        }

        private void btn_idioama_Click(object sender, EventArgs e)
        {
            int idIdiomaSeleccionado = Convert.ToInt32(cmb_Idioma.SelectedValue);
            frmIdioma frm = new frmIdioma(idIdiomaSeleccionado, ID);
            frm.StartPosition = FormStartPosition.CenterParent; 
            frm.ShowDialog(this);
        }

        private void CargarIdiomas()
        {
            DataTable dt = dato.Consultar("SELECT ID_Idioma, Nombre_Idioma FROM Tipo_Idioma");

            cmb_Idioma.DataSource = dt;
            cmb_Idioma.DisplayMember = "Nombre_Idioma"; // Lo que ve el usuario
            cmb_Idioma.ValueMember = "ID_Idioma";        // El ID real del idioma
        }

        private void cmb_Idioma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_Idioma.SelectedValue != null)
                btn_idioama.Visible = true;
        }

        private void cmbProvincia_DropDown(object sender, EventArgs e)
        {
            cmbProvincia.DropDownHeight = cmbProvincia.ItemHeight * 5;
        }

        private void cmbCiudad_DropDown(object sender, EventArgs e)
        {
            cmbCiudad.DropDownHeight = cmbCiudad.ItemHeight * 5;
        }
    }
}
