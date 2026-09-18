using APP_NET.Formularios;
using CAPA_NEGOCIO;
using CapaDatos;
using System;
using System.Windows.Forms;
using CAPA_NEGOCIO;

namespace APP_NET
{
    public partial class FrmConexion : Form
    {
        csConexionSQL datos = new csConexionSQL();
        private string usuarioRemitente;
        private string usuarioReceptor;
        string ID;

        CsAmigos amigos = new CsAmigos();

        public FrmConexion(string id)
        {
            ID = id;
            InitializeComponent();
        }


        private void FrmConexion_Load(object sender, EventArgs e)
        {
            dgvconexion.DataSource = amigos.ObtenerUsuariosConTodosSusTitulos(int.Parse(ID)); /*(@"SELECT distinct U.ID_Usuario, U.Nombre_Usuario as Nombre, Apellido_Usuario as Apellido, C.Nombre_Ciudad as Ubicación, t.Nombre_Titulo as Titulo_Profesional FROM Usuarios U 
                inner join Perfil_Profesional p on U.ID_Usuario=p.ID_Usuario 
                inner join Ciudad C on C.ID_Ciudad=p.ID_Ciudad
                inner join Perfil_Area pa on pa.ID_Perfil=p.ID_Perfil inner join Tipo_Area ta on ta.ID_Area = pa.ID_Area 
                inner join Tipo_Titulo t on t.ID_Titulo=ta.ID_Titulo");*/
        }

        private void dgvconexion_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvconexion.Rows[e.RowIndex];
                usuarioReceptor = row.Cells["ID_Usuario"].Value.ToString();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                int IDUS = int.Parse(ID);
                int IDNF = int.Parse(usuarioReceptor);
                string mensaje = amigos.EnviarSolicitud(IDUS, IDNF);
                MessageBox.Show(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btn_Solicitudes_Click(object sender, EventArgs e)
        {
            Frm_Solicitud abrir = new Frm_Solicitud(ID);
            //abrir.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario en la pantalla
            abrir.ShowDialog();
        }

        private void bordes_Boton2_Click(object sender, EventArgs e)
        {
            FrmAmigos amigos = new FrmAmigos(ID);
            //amigos.StartPosition = FormStartPosition.CenterScreen;
            amigos.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            dgvconexion.DataSource = amigos.ObtenerUsuariosConTodosSusTitulos(int.Parse(ID), guna2TextBox1.Text);
        }
    }
}
