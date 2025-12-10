using APP_NET.FRMNUEVOS;
using CAPA_NEGOCIO;
using CAPA_NEGOCIO.New_Clases;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_NET.Parte_Adminitardor
{
    public partial class frmValidarOfertas : Form
    {
        ManejoAdmin admin = new ManejoAdmin();
        Publicaciones publicar = new Publicaciones();
        csConexionSQL datos = new csConexionSQL();

        string IdPublicacion;
        public frmValidarOfertas()
        {
            InitializeComponent();
        }

        private void frmValidarOfertas_Load(object sender, EventArgs e)
        {
            EstiloDataGriv.AplicarEstilo(dgvPublicaciones);
            CargarPublicaciones(); 
            publicar.AgregarComboBox(cmbCategoria, cmbModalidad, cmbJornada, cmbCiudad);
            cmbCiudad.MaxDropDownItems = 5;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgvPublicaciones.DataSource = admin.FiltrarPublicaciones(
            cmbCategoria.Text,
            cmbModalidad.Text,
            cmbJornada.Text,
            cmbCiudad.Text
        );
        }

        private void btn_aprobar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdPublicacion))
            {
                MessageBox.Show("Seleccione una publicación.");
                return;
            }
            MessageBox.Show("IDPu" + IdPublicacion);
            string consulta = $"UPDATE HistorialEstadoPublicacion SET ID_EstadoP = 1 WHERE ID_Publicacion = {IdPublicacion}";
            datos.Consultar(consulta);
            CargarPublicaciones();
            MessageBox.Show("Publicación aprobada.");
        }

        private void dgvPublicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdPublicacion = dgvPublicaciones.Rows[e.RowIndex].Cells["ID_Publicacion"].Value.ToString();
            }
        }

        private void btn_rechazar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdPublicacion))
            {
                MessageBox.Show("Seleccione una publicación.");
                return;
            }

            string consulta = $"UPDATE HistorialEstadoPublicacion SET ID_EstadoP = 4 WHERE ID_Publicacion = {IdPublicacion}";
            datos.Consultar(consulta);
            CargarPublicaciones();
            MessageBox.Show("Publicación Rechazada.");
        }



        private void CargarPublicaciones()
        {
            dgvPublicaciones.DataSource = null; // Limpia
            dgvPublicaciones.Rows.Clear(); // Limpia filas
            dgvPublicaciones.DataSource = admin.FiltrarPublicaciones(null, null, null, null);
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            dgvPublicaciones.DataSource = admin.Filtrarportitulo(txtBuscador.Text);
        }
    }
}
