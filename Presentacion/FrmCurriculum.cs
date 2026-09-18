using CAPA_NEGOCIO;
using CapaDatos;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class FrmCurriculum : Form
    {

      csUsuariosBD subir = new csUsuariosBD();
        string IdUsuario;
        string IdPublicacion;
        byte[] archivoBytes = null;

        public FrmCurriculum(string idUsuario, string idPublicacion)
        {
            InitializeComponent();
            IdUsuario = idUsuario;
            IdPublicacion = idPublicacion;
        }

        private void btnPostular_Click_1(object sender, EventArgs e)
        {
            if (archivoBytes == null)
            {
                MessageBox.Show("Debe seleccionar un archivo.");
                return;
            }
            var resultado = subir.GuardarPostulacion(
                IdUsuario,
                IdPublicacion,
                archivoBytes
            );
            if (resultado.Item1)
            {
                MessageBox.Show("Curriculum registrado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: " + resultado.Item2);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_curriculum_Click(object sender, EventArgs e)
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
                    lCuri.Text = "1 elemento seleccionado";
                }
            }
        }
    }
}
