using CAPA_NEGOCIO;
using System;
using System.Windows.Forms;


namespace APP_NET
{
    public partial class FrmRecuperacionCuenta : Form
    {
        private static long codigo = 0; private static string correo = "";
        csMensajesDCorreosYMensajitos mensajes = new csMensajesDCorreosYMensajitos();



        public FrmRecuperacionCuenta()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            csLogin verificar = new csLogin();
            string NombreProcidius = "VerificarCorreoExistente";
            bool Verificador = verificar.VerificarCorreo(txtCorreo.Text.Trim(), NombreProcidius);

            if (Verificador == true && txtCorreo.Text.Contains("@"))
            {
                codigo = new Random().Next(100000, 999999);
                mensajes.EnvioDeCorreoRecuperacionDCuenta(txtCorreo.Text, codigo);
                btnEnviar.Visible = false;
                btnVerificar.Visible = true;
                txtCodigo.Enabled = true;
                txtCorreo.Enabled = false;
                correo = txtCorreo.Text;
            }
            else
                MessageBox.Show("❌ El correo electrónico ingresado no se encuentra en el sistema. Por favor, verifica la dirección o regístrate si aún no lo has hecho.", "Correo No Registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text != "")
            {
                if (long.Parse(txtCodigo.Text) == codigo)
                {
                    FrmActualizarContraseña frm = new FrmActualizarContraseña(txtCorreo.Text);
                    this.Hide();
                    frm.ShowDialog();

                }
                else { MessageBox.Show("ERROR, CODIGO INCORRECTO, VERIFIQUE."); }
            }
            else { MessageBox.Show("SE DEBE INGRESAR UN CODIGO."); }
        }


    }

}
