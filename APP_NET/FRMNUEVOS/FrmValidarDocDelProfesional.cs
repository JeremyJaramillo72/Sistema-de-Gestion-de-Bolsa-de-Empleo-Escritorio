using CAPA_NEGOCIO.New_Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace APP_NET.FRMNUEVOS
{
    public partial class FrmValidarDocDelProfesional : Form
    {
        private int _idPerfilProfesional;
        private string _nombreProfesional;
        private ValidacionDocs _negocioValidacion;
        private DataTable _datosDocumentos;
        public FrmValidarDocDelProfesional(int idPerfilProfesional, string nombreProfesional)
        {
            InitializeComponent();
            _idPerfilProfesional = idPerfilProfesional;
            _nombreProfesional = nombreProfesional;
            _negocioValidacion = new ValidacionDocs();
            _datosDocumentos = new DataTable();
        }

        private void btnVerDoc_Click(object sender, EventArgs e)
        {
            if (dgvValidarDocumento.CurrentRow != null && _datosDocumentos.Rows.Count > 0)
            {
                try
                {
                    int idDocumento = Convert.ToInt32(dgvValidarDocumento.CurrentRow.Cells["ID_Documento"].Value);
                    string tipoDocumento = dgvValidarDocumento.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                    string tablaOrigen = dgvValidarDocumento.CurrentRow.Cells["TablaOrigen"].Value.ToString();

                    string tempFilePath = _negocioValidacion.AbrirDocumentoEnNavegador(idDocumento, tipoDocumento, tablaOrigen);

                    MessageBox.Show($"Documento abierto correctamente en: {tempFilePath}", "Documento Abierto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el documento: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un documento para ver.", "Selección requerida",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAprobarDoc_Click(object sender, EventArgs e)
        {
            CambiarEstadoDocumento("Aprobado");
        }

        private void btnRechazarDoc_Click(object sender, EventArgs e)
        {
            // Confirmación más explícita al rechazar
            var dr = MessageBox.Show("¿Confirma que desea rechazar el documento seleccionado?", "Confirmar Rechazo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                CambiarEstadoDocumento("Rechazado");
            }
        }
        private void cmbTipoDeDocumento_DropDown(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoDeDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDocumentos();
        }

        private void FrmValidarDocDelProfesional_Load(object sender, EventArgs e)
        {
            CargarDatosProfesional();
            CargarTiposDocumento();
            CargarDocumentos();
            CargarResumenDocumentos();
        }
        private void CargarDatosProfesional()
        {
            try
            {
                lblNombreProfesional.Text = _nombreProfesional;
                lblNombreApellido.Text = _nombreProfesional;

                var datos = _negocioValidacion.ObtenerDatosProfesional(_idPerfilProfesional);
                if (datos.Rows.Count > 0)
                {
                    var row = datos.Rows[0];
                    lblCorreo.Text = row["Email"].ToString();
                    lblTelefono.Text = row["Telefono"].ToString();
                    lblCiudad.Text = row["Ciudad"].ToString();
                    lblExp.Text = row["Experiencia"].ToString() + " años";
                    lblFechaRegistro.Text = Convert.ToDateTime(row["FechaRegistro"]).ToShortDateString();
                    lblEstadoPerfil.Text = row["EstadoPerfil"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del profesional: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarTiposDocumento()
        {
            try
            {
                var tipos = _negocioValidacion.ObtenerTiposDocumento();
                cmbTipoDeDocumento.DataSource = tipos;
                cmbTipoDeDocumento.DisplayMember = "TipoDocumento";
                cmbTipoDeDocumento.ValueMember = "ID_Tipo";
                cmbTipoDeDocumento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de documento: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDocumentos()
        {
            try
            {
                // --- LECTURA SEGURA DEL TIPO DE DOCUMENTO ---
                string tipoDocumento = null;

                // Preferimos sacar el texto mostrado (TipoDocumento) desde SelectedItem (DataRowView)
                if (cmbTipoDeDocumento.SelectedItem != null)
                {
                    var drv = cmbTipoDeDocumento.SelectedItem as DataRowView;
                    if (drv != null && drv.Row.Table.Columns.Contains("TipoDocumento"))
                    {
                        tipoDocumento = drv["TipoDocumento"]?.ToString();
                    }
                    else
                    {
                        // Fallback: usar el texto del combo (puede contener el valor visible)
                        tipoDocumento = cmbTipoDeDocumento.Text;
                        if (string.IsNullOrWhiteSpace(tipoDocumento))
                            tipoDocumento = null;
                    }
                }

                // Llamada al negocio con tipoDocumento correcto o null
                _datosDocumentos = _negocioValidacion.ObtenerDocumentosPorProfesional(_idPerfilProfesional, tipoDocumento);
                dgvValidarDocumento.DataSource = _datosDocumentos;

                if (_datosDocumentos.Rows.Count > 0)
                {
                    if (dgvValidarDocumento.Columns.Contains("ID_Documento"))
                        dgvValidarDocumento.Columns["ID_Documento"].Visible = false;
                    if (dgvValidarDocumento.Columns.Contains("TablaOrigen"))
                        dgvValidarDocumento.Columns["TablaOrigen"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar documentos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarResumenDocumentos()
        {
            try
            {
                var resumen = _negocioValidacion.ObtenerResumenDocumentos(_idPerfilProfesional);
                if (resumen.Rows.Count > 0)
                {
                    var row = resumen.Rows[0];
                    lblDocTotales.Text = row["TotalDocumentos"].ToString();
                    lblDocPendientes.Text = row["Pendientes"].ToString();
                    lblDocsAprobados.Text = row["Aprobados"].ToString();
                    lblRechazados.Text = row["Rechazados"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar resumen: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CambiarEstadoDocumento(string estado)
        {
            if (dgvValidarDocumento.CurrentRow != null && _datosDocumentos.Rows.Count > 0)
            {
                int idDocumento = Convert.ToInt32(dgvValidarDocumento.CurrentRow.Cells["ID_Documento"].Value);
                string tipoDocumento = dgvValidarDocumento.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                string tablaOrigen = dgvValidarDocumento.CurrentRow.Cells["TablaOrigen"].Value.ToString();

                try
                {
                    bool resultado = _negocioValidacion.ActualizarEstadoDocumento(idDocumento, tipoDocumento, estado, tablaOrigen);
                    if (resultado)
                    {
                        MessageBox.Show($"Documento {estado.ToLower()} correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDocumentos();
                        CargarResumenDocumentos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el estado del documento.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el documento: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un documento para actualizar.", "Selección requerida",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}