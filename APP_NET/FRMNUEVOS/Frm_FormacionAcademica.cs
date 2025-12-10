using CapaDatos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace APP_NET.FRMNUEVOS
{
    public partial class Frm_FormacionAcademica : Form
    {
        DataTable dtTitulos = new DataTable();
        csUsuariosBD miClaseBD = new csUsuariosBD();
        string archivoSeleccionado = "";
        byte[] archivoBytes = null;
        string ID;
        string IDpro;
        public Frm_FormacionAcademica(string id)
        {
            InitializeComponent();
            ID = id;
            IDpro = miClaseBD.OBtenerIdpro(ID);
        }

        private void btn_AggTítulo_Click(object sender, EventArgs e)
        {
            // Validaciones rápidas
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtInstitucion.Text) ||
                string.IsNullOrWhiteSpace(txtAnio_.Text) ||
                string.IsNullOrWhiteSpace(cmbNivel.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            // Agregar al DataTable
            dtTitulos.Rows.Add(
             txtTitulo.Text,
             txtInstitucion.Text,
             txtAnio_.Text,
             cmbNivel.Text,
             Convert.ToBase64String(archivoBytes)
             );

            // Limpiar campos
            txtTitulo.Clear();
            txtInstitucion.Clear();
            txtAnio_.SelectedIndex = -1;
            cmbNivel.SelectedIndex = -1;
            archivoSeleccionado = "";

            MessageBox.Show("Título agregado.");
        }

        private void Btn_AdjuntoArchi_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar archivo";
                ofd.Filter = "Archivos permitidos (*.pdf;*.png;*.jpg;*.jpeg)|*.pdf;*.png;*.jpg;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    archivoBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void Frm_FormacionAcademica_Load(object sender, EventArgs e)
        {
            dtTitulos.Columns.Add("TituloAcademico");
            dtTitulos.Columns.Add("Institucion");
            dtTitulos.Columns.Add("AnioGraduacion");
            dtTitulos.Columns.Add("NivelEstudios");
            dtTitulos.Columns.Add("ArchivoTitulo", typeof(string)); // 👈 IMPORTANTE

            dgvTitulos.DataSource = dtTitulos;

            // Evitar que DataGridView intente mostrarlo como imagen
            dgvTitulos.Columns["ArchivoTitulo"].DefaultCellStyle.NullValue = "Archivo";
            dgvTitulos.Columns["ArchivoTitulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgvTitulos.DataError += (s, ev) => { ev.ThrowException = false; };

            dgvTitulos.Columns["ArchivoTitulo"].Visible = false;

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;

            EstiloDataGriv.AplicarEstilo(dgvTitulos);
        }

        private void btn_guardaFA_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvTitulos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un título.");
                    return;
                }


                DataGridViewRow row = dgvTitulos.SelectedRows[0];


                string titulo = row.Cells["TituloAcademico"].Value.ToString();
                string institucion = row.Cells["Institucion"].Value.ToString();
                int anio = Convert.ToInt32(row.Cells["AnioGraduacion"].Value);
                string nivel = row.Cells["NivelEstudios"].Value.ToString();


                // Conversión correcta del archivo
                byte[] archivoBytes = Convert.FromBase64String(row.Cells["ArchivoTitulo"].Value.ToString());


                if (archivoBytes == null || archivoBytes.Length == 0)
                {
                    MessageBox.Show("Debe seleccionar un archivo para el título.");
                    return;
                }


                var resultado = miClaseBD.GuardarTitulosAcademicos(
                IDpro,
                titulo,
                institucion,
                anio,
                nivel,
                archivoBytes
                );


                if (resultado.Item1)
                {
                    MessageBox.Show("Título registrado correctamente.");

                }
                else
                {
                    MessageBox.Show("Error: " + resultado.Item2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmEditAcademica abir = new frmEditAcademica(ID);
            abir.ShowDialog();
        }
    }
}
