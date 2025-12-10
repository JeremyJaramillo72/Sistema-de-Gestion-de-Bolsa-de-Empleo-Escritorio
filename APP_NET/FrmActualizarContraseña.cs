using CAPA_NEGOCIO;
using System;
using System.Windows.Forms;

namespace APP_NET
{

    public partial class FrmActualizarContraseña : Form
    {
        static public string correo = "";
        public FrmActualizarContraseña(string email)
        {
            InitializeComponent();
            correo = email;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNuevaClave.Text != string.Empty & txtConfirmarCLave.Text != string.Empty)
            {

                csLogin ingreso = new csLogin();
                csEncriptarMD5 encriptar = new csEncriptarMD5();
                if (txtNuevaClave.Text == txtConfirmarCLave.Text)
                {
                    string ClaveEncriptada = encriptar.Encriptar(txtConfirmarCLave.Text, correo);
                    ingreso.ActualizarContraseña(correo, ClaveEncriptada);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La Claves no son iguales");
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos solicitados");
            }
        }

        private void FrmActualizarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
