using CAPA_NEGOCIO.New_Clases;
using System;
using System.Data;
using System.Windows.Forms;
namespace APP_NET.FRMNUEVOS
{
    public partial class FrmRevisiónDeDocs : Form
    {
        private CsValidaciónPProfesional _negocioPerfiles;
        private DataTable _datosPerfiles;
        public FrmRevisiónDeDocs()
        {
            InitializeComponent();
            _negocioPerfiles = new CsValidaciónPProfesional();
            _datosPerfiles = new DataTable();
        }

        private void btnRevisarDocDe_Click(object sender, EventArgs e)
        {
            if (dgvPerfilesRevisión.CurrentRow != null && _datosPerfiles.Rows.Count > 0)
            {
                int idPerfilProfesional = Convert.ToInt32(
                    dgvPerfilesRevisión.CurrentRow.Cells["ID_PerfilProfesional"].Value);

                string nombreProfesional = dgvPerfilesRevisión.CurrentRow.Cells["Profesional"].Value.ToString();

                FrmValidarDocDelProfesional frmRevisarDocsProf =
                    new FrmValidarDocDelProfesional(idPerfilProfesional, nombreProfesional);

                this.AddOwnedForm(frmRevisarDocsProf);
                frmRevisarDocsProf.ShowDialog();

                // Recargar datos después de cerrar el formulario de revisión
                CargarPerfiles();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un profesional para revisar sus documentos.",
                    "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            // dentro de btnRevisarDocDe_Click, justo antes de crear el formulario
            int idPerfilProfesional22;
            var cellVal = dgvPerfilesRevisión.CurrentRow?.Cells["ID_PerfilProfesional"]?.Value;
            if (cellVal == null || !int.TryParse(cellVal.ToString(), out idPerfilProfesional22))
            {
                MessageBox.Show("ID_PerfilProfesional inválido en la fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Debug.WriteLine($"[DEBUG] FrmRevisiónDeDocs -> idPerfilProfesional seleccionado: {idPerfilProfesional22}");
            string nombreProfesional22 = dgvPerfilesRevisión.CurrentRow.Cells["Profesional"].Value?.ToString() ?? "(sin nombre)";

        }

        private void txtBuscadorR_TextChanged_1(object sender, EventArgs e)
        {
            // Búsqueda en tiempo real con delay para mejor performance
            Timer searchTimer = new Timer();
            searchTimer.Interval = 500; // 500ms delay
            searchTimer.Tick += (s, args) =>
            {
                searchTimer.Stop();
                CargarPerfiles();
                searchTimer.Dispose();
            };
            searchTimer.Start();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }
        private void LimpiarFiltros()
        {
            txtBuscadorR.Text = "";
            if (cmbEstadoGeneral.Items.Count > 0)
                cmbEstadoGeneral.SelectedIndex = 0;
            if (cmbCiudad.Items.Count > 0)
                cmbCiudad.SelectedIndex = 0;
            CargarPerfiles();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPerfiles();
        }

        private void cmbCiudad_DropDown(object sender, EventArgs e)
        {

        }

        private void cmbEstadoGeneral_DropDown(object sender, EventArgs e)
        {

        }


        private void FrmRevisiónDeDocs_Load(object sender, EventArgs e)
        {
            CargarFiltros();
            CargarPerfiles();
        }
        private void CargarFiltros()
        {
            try
            {
                //cargar estados desde vista
                var estados = _negocioPerfiles.ObtenerEstadosAprobacion();
                cmbEstadoGeneral.DataSource = estados;
                cmbEstadoGeneral.DisplayMember = "Tipo_Estado";
                cmbEstadoGeneral.ValueMember = "ID_Estado";

                //cargar ciudades desde vista
                var ciudades = _negocioPerfiles.ObtenerCiudades();
                cmbCiudad.DataSource = ciudades;
                cmbCiudad.DisplayMember = "Nombre_Ciudad";
                cmbCiudad.ValueMember = "ID_Ciudad";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar filtros: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPerfiles()
        {
            try
            {
                string filtro = txtBuscadorR.Text.Trim();
                string estado = cmbEstadoGeneral.SelectedValue?.ToString();
                string ciudad = cmbCiudad.SelectedValue?.ToString();

                _datosPerfiles = _negocioPerfiles.ObtenerPerfilesParaRevision(filtro, estado, ciudad);

                // Configurando 
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar perfiles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarDataGridView()
        {
            dgvPerfilesRevisión.DataSource = _datosPerfiles;


        }

        private void cmbEstadoGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPerfiles();
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPerfiles();
        }

        private void dgvPerfilesRevisión_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Doble click para revisar los docs 
            if (e.RowIndex >= 0)
            {
                btnRevisarDocDe_Click(sender, e);
            }
        }
    }
}
