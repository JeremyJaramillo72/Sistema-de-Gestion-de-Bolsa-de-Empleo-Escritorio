using CapaDatos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace APP_NET.FRMNUEVOS
{
    public partial class frmEditAcademica : Form
    {
        csConexionSQL datos = new csConexionSQL();
        csUsuariosBD miClaseBD = new csUsuariosBD();
        string ID;
        string ID_Perfil;
        public frmEditAcademica(string iD)
        {
            InitializeComponent();
            ID = iD;
            ID_Perfil = miClaseBD.OBtenerIdpro(ID);
        }

        private void bordes_Boton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditAcademica_Load(object sender, EventArgs e)
        {

            dgvInfoAcademica.DataSource = datos.MostrarRegistros($"SELECT IdDocumentacion, TituloAcademico, Institucion, AnioGraduacion, NivelEstudios, ArchivoTitulo FROM DocAcademica d inner join\r" +
                $"\nPerfil_Profesional p on d.ID_PerfilProfesional=p.ID_PerfilProfesional where p.ID_PerfilProfesional={ID_Perfil}");
            dgvInfoAcademica.ReadOnly = false;
            dgvInfoAcademica.AllowUserToAddRows = false;
            dgvInfoAcademica.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarDatos();
            dgvInfoAcademica.Columns["ArchivoTitulo"].Visible = false;
            EstiloDataGriv.AplicarEstilo(dgvInfoAcademica);
        }

        private void dgvInfoAcademica_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvInfoAcademica.Columns[e.ColumnIndex].Name == "ArchivoTitulo")
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "PDF|*.pdf|Imagenes|*.jpg;*.jpeg;*.png|Todos|*.*";

                if (op.ShowDialog() == DialogResult.OK)
                {
                    dgvInfoAcademica.Rows[e.RowIndex].Cells["ArchivoTitulo"].Value = op.FileName;
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvInfoAcademica.Rows)
                {
                    // Validar que no sea una fila vacía o nueva sin datos
                    if (row.IsNewRow) continue;

                    int id = Convert.ToInt32(row.Cells["IdDocumentacion"].Value);
                    string titulo = row.Cells["TituloAcademico"].Value.ToString();
                    string inst = row.Cells["Institucion"].Value.ToString();
                    int anio = Convert.ToInt32(row.Cells["AnioGraduacion"].Value);
                    string nivel = row.Cells["NivelEstudios"].Value.ToString();

                    // --- INICIO DE LA CORRECCIÓN ---
                    // Obtenemos el valor sin convertirlo a string todavía
                    object valorCelda = row.Cells["ArchivoTitulo"].Value;
                    byte[] archivoBytes = null;

                    if (valorCelda is byte[])
                    {
                        // CASO 1: Ya viene como bytes desde la Base de Datos. Usamos eso directamente.
                        archivoBytes = (byte[])valorCelda;
                    }
                    else if (valorCelda is string textoBase64 && !string.IsNullOrEmpty(textoBase64))
                    {
                        // CASO 2: Es texto (Base64). Intentamos convertirlo.
                        try
                        {
                            archivoBytes = Convert.FromBase64String(textoBase64);
                        }
                        catch
                        {
                            // Si el texto no es válido, enviamos un array vacío para no romper el programa
                            archivoBytes = new byte[0];
                        }
                    }
                    else
                    {
                        // CASO 3: Es nulo o vacío
                        archivoBytes = new byte[0];
                    }
                    // --- FIN DE LA CORRECCIÓN ---

                    datos.EjecutarConsulta(
                        "UPDATE DocAcademica SET " +
                        "TituloAcademico=@t, Institucion=@i, AnioGraduacion=@a, NivelEstudios=@n, ArchivoTitulo=@f " +
                        "WHERE IdDocumentacion=@id",
                        new SqlParameter[]
                        {
                    new SqlParameter("@t", titulo),
                    new SqlParameter("@i", inst),
                    new SqlParameter("@a", anio),
                    new SqlParameter("@n", nivel),
                    new SqlParameter("@f", archivoBytes), // Ahora enviamos siempre Bytes seguros
                    new SqlParameter("@id", id)
                        }
                    );
                }

                MessageBox.Show("Cambios guardados correctamente");
                this.Close(); // Cierra el formulario si todo salió bien
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btn_eliminaRegistro_Click(object sender, EventArgs e)
        {
            if (dgvInfoAcademica.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro.");
                return;
            }

            int id = Convert.ToInt32(dgvInfoAcademica.SelectedRows[0].Cells["IdDocumentacion"].Value);

            DialogResult resp = MessageBox.Show(
                "¿Seguro que deseas eliminar este registro?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resp == DialogResult.Yes)
            {
                datos.EjecutarConsulta(
                    "DELETE FROM DocAcademica WHERE IdDocumentacion = @id",
                    new SqlParameter[]
                    {
                new SqlParameter("@id", id)
                    }
                );

                MessageBox.Show("Registro eliminado correctamente.");

                // Refrescar DataGridView
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            dgvInfoAcademica.DataSource = datos.MostrarRegistros($"SELECT IdDocumentacion, TituloAcademico, Institucion, AnioGraduacion, NivelEstudios, ArchivoTitulo FROM DocAcademica d inner join\r" +
               $"\nPerfil_Profesional p on d.ID_PerfilProfesional=p.ID_PerfilProfesional where p.ID_PerfilProfesional={ID_Perfil}");
        }

    }
}
