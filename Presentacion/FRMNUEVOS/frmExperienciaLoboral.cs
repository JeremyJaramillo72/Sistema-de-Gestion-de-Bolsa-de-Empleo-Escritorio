using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace APP_NET.FRMNUEVOS
{
    public partial class frmExperienciaLoboral : Form
    {
        DataTable dtExpe = new DataTable();
        csUsuariosBD miClaseBD = new csUsuariosBD();
        csConexionSQL datos = new csConexionSQL();  

        string archivoSeleccionado = "";
        byte[] archivoBytes = null;
        string ID;
        string IDpro;

        public frmExperienciaLoboral(string id)
        {
            InitializeComponent();
            ID = id;
            IDpro = miClaseBD.OBtenerIdpro(ID);
        }
        private void Btn_AdjuntoArchiE_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Archivos permitidos (*.pdf;*.png;*.jpg;*.jpeg)|*.pdf;*.png;*.jpg;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    archivoBytes = File.ReadAllBytes(dlg.FileName);
                    archivoSeleccionado = dlg.FileName;
                    MessageBox.Show("Archivo cargado correctamente.");
                }
            }
        }

        private void btn_AggExpe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombreempresa.Text) ||
        string.IsNullOrWhiteSpace(txt_cargo.Text) ||
        string.IsNullOrWhiteSpace(text_RDES.Text) ||
        string.IsNullOrWhiteSpace(text_ubicaciónEmpresa.Text) ||
        string.IsNullOrWhiteSpace(text_URLEmpresa.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (archivoBytes == null)
            {
                MessageBox.Show("Debe seleccionar un archivo.");
                return;
            }

            // Convertir a Base64 string para el DataTable
            string archivoBase64 = Convert.ToBase64String(archivoBytes);

            dtExpe.Rows.Add(
                txt_Nombreempresa.Text,
                txt_cargo.Text,
                Dt_Inicio.Value,
                dt_Fin.Value,
                text_RDES.Text,
                text_ubicaciónEmpresa.Text,
                text_URLEmpresa.Text,
                archivoBase64  // Guardar como string Base64
            );

            // Limpiar campos
            txt_Nombreempresa.Clear();
            txt_cargo.Clear();
            text_RDES.Clear();
            text_ubicaciónEmpresa.Clear();
            text_URLEmpresa.Clear();
            archivoBytes = null;
            archivoSeleccionado = "";

            MessageBox.Show("Experiencia agregada.");
        }

        private void frmExperienciaLoboral_Load(object sender, EventArgs e)
        {
            dtExpe.Columns.Add("Empresa");
            dtExpe.Columns.Add("Cargo");
            dtExpe.Columns.Add("FechaInicio", typeof(DateTime));
            dtExpe.Columns.Add("FechaFin", typeof(DateTime));
            dtExpe.Columns.Add("Descripcion");
            dtExpe.Columns.Add("Ubicacion");
            dtExpe.Columns.Add("URLEmpresa");
            dtExpe.Columns.Add("Archivo"); // Mantener como string para Base64

            dgv_Experiencias_.DataSource = dtExpe;
            dgv_Experiencias_.Columns["Archivo"].Visible = false;
            dgv_Experiencias_.AllowUserToAddRows = false;

            dgv_Experiencias_.DataError += (s, ev) => { ev.ThrowException = false; };

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

            EstiloDataGriv.AplicarEstilo(dgv_Experiencias_);
        }

        private void btn_guardaEL_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay experiencias para guardar
                if (dtExpe.Rows.Count == 0)
                {
                    MessageBox.Show("No hay experiencias laborales para guardar.");
                    return;
                }

                bool algunError = false;
                string mensajesError = "";

                foreach (DataRow row in dtExpe.Rows)
                {
                    // Obtener valores del DataTable
                    string empresa = row["Empresa"]?.ToString() ?? "";
                    string cargo = row["Cargo"]?.ToString() ?? "";
                    DateTime fechaInicio = Convert.ToDateTime(row["FechaInicio"]);
                    DateTime fechaFin = Convert.ToDateTime(row["FechaFin"]);
                    string descripcion = row["Descripcion"]?.ToString() ?? "";
                    string ubicacion = row["Ubicacion"]?.ToString() ?? "";
                    string urlEmpresa = row["URLEmpresa"]?.ToString() ?? "";

                    // Manejar el archivo - convertir desde Base64 string a byte[]
                    byte[] archivo;
                    object archivoValue = row["Archivo"];

                    if (archivoValue == null || string.IsNullOrEmpty(archivoValue.ToString()))
                    {
                        archivo = new byte[0];
                    }
                    else
                    {
                        try
                        {
                            // Convertir desde Base64 a byte[]
                            archivo = Convert.FromBase64String(archivoValue.ToString());
                        }
                        catch
                        {
                            archivo = new byte[0];
                        }
                    }

                    // Usar tu método para guardar
                    var (exito, mensaje) = miClaseBD.GuardarExperienciaLaboral(
                        IDpro,
                        empresa,
                        cargo,
                        fechaInicio,
                        fechaFin,
                        descripcion,
                        ubicacion,
                        urlEmpresa,
                        archivo
                    );

                    // Verificar el resultado
                    if (!exito)
                    {
                        algunError = true;
                        mensajesError += $"- {mensaje}\n";
                    }
                }

                if (algunError)
                {
                    MessageBox.Show($"Algunas experiencias no se guardaron correctamente:\n{mensajesError}");
                }
                else
                {
                    MessageBox.Show("Todas las experiencias laborales se guardaron correctamente");

                    // Limpiar el DataTable después de guardar
                    dtExpe.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btn_EditLAb_Click(object sender, EventArgs e)
        {
            frmEditExpe abrir = new frmEditExpe(ID);
            abrir.ShowDialog();
        }

    }
}
