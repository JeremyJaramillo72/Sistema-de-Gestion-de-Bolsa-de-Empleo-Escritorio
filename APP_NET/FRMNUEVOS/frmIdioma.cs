using CapaDatos;
using System;
using System.IO;
using System.Windows.Forms;


namespace APP_NET.FRMNUEVOS
{
    public partial class frmIdioma : Form
    {
        csUsuariosBD miClaseBD = new csUsuariosBD();
        private int _idIdioma;
        string ID;
        byte[] archivoBytes = null;
        public frmIdioma(int idIdioma, string id)
        {
            InitializeComponent();
            _idIdioma = idIdioma;
            ID = id;
        }

        private void bordes_Boton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_AdjuntoArchiI_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar archivo";
                ofd.Filter = "Archivos permitidos (*.pdf;*.png;*.jpg;*.jpeg)|*.pdf;*.png;*.jpg;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Convertir a bytes
                    archivoBytes = File.ReadAllBytes(ofd.FileName);

                    // Mostrar mensaje
                    label11.Text = "1 elemento seleccionado";
                }
            }
        }

        private void btn_guardaEL_Click(object sender, EventArgs e)
        {
            if (archivoBytes == null)
            {
                MessageBox.Show("Debe seleccionar un archivo.");
                return;
            }

            var resultado = miClaseBD.GuardarPerfilIdioma(
                ID,
                _idIdioma,
                archivoBytes,
                txtCodigoCertificado.Text.Trim()
            );

            if (resultado.Item1)
            {
                MessageBox.Show("Idioma registrado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: " + resultado.Item2);
            }
        }

        private void frmIdioma_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ID);
        }
    }
}
