using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APP_NET
{
    public partial class FrmMisPublicaciones : Form
    {

        public string id; public string IdPublicacion;
        Publicaciones publicar = new Publicaciones();
        public FrmMisPublicaciones()
        {
            InitializeComponent();
        }
        public FrmMisPublicaciones(string x)
        {

            InitializeComponent();
            id = x;
            CargarTabla();
            ConfigurarGrid();
        }
        void CargarTabla()
        {
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Opciones";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 80;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.DefaultCellStyle.BackColor = Color.LightGray;
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "btnEliminar";
            btnEliminar.HeaderText = "Opciones";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Width = 80;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.DefaultCellStyle.BackColor = Color.LightGray;


            DataGridViewButtonColumn btnVerPostulantes = new DataGridViewButtonColumn();
            btnVerPostulantes.Name = "btnVerPostulantes";
            btnVerPostulantes.HeaderText = "Candidatos";
            btnVerPostulantes.Text = "Postulantes";
            btnVerPostulantes.UseColumnTextForButtonValue = true;
            btnVerPostulantes.Width = 100;
            btnVerPostulantes.FlatStyle = FlatStyle.Popup;
            btnVerPostulantes.DefaultCellStyle.BackColor = Color.LightGray;
            dgvMisPublicaciones.Columns.Add(btnVerPostulantes);
            dgvMisPublicaciones.Columns.Add(btnEditar);
            dgvMisPublicaciones.Columns.Add(btnEliminar);

        }
        private void ConfigurarGrid()
        {
            dgvMisPublicaciones.Columns["Titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMisPublicaciones.Columns["Titulo"].MinimumWidth = 150;

            dgvMisPublicaciones.Columns["Categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMisPublicaciones.Columns["Modalidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMisPublicaciones.Columns["Jornada"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMisPublicaciones.Columns["Ciudad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvMisPublicaciones.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgvMisPublicaciones.Columns["btnVerPostulantes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvMisPublicaciones.Columns["btnVerPostulantes"].Width = 100;
            dgvMisPublicaciones.Columns["btnEditar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvMisPublicaciones.Columns["btnEditar"].Width = 70;

            dgvMisPublicaciones.Columns["btnEliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvMisPublicaciones.Columns["btnEliminar"].Width = 70;

            dgvMisPublicaciones.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMisPublicaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscador.Text.Length >= 3)
            {
                publicar.MisPublicacionBuscar(dgvMisPublicaciones, txtBuscador.Text, id);
            }
            else
            {
                dgvMisPublicaciones.Rows.Clear();
                publicar.ListaMisPublicacione(dgvMisPublicaciones, id);
            }
        }

        private void FrmMisPublicaciones_Load(object sender, EventArgs e)
        {

            publicar.ListaMisPublicacione(dgvMisPublicaciones, id);
            publicar.AgregarComboBox(cmbCategoria, cmbModalidad, cmbJornada, cmbCiudad);
            cmbCiudad.MaxDropDownItems = 5;
        }

       

       

        private void cmbCiudad_DropDown(object sender, EventArgs e)
        {
            cmbCiudad.DropDownHeight = cmbCiudad.ItemHeight * 5;
        }

        private void cmbCiudad_DropDown_1(object sender, EventArgs e)
        {
            cmbCiudad.DropDownHeight = cmbCiudad.ItemHeight * 5;
        }

        private void dgvMisPublicaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void dgvMisPublicaciones_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvMisPublicaciones.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvMisPublicaciones.SelectedRows[0];
                IdPublicacion = filaSeleccionada.Cells["Codigo"].Value.ToString();
            }
        }

        private void guna2PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            cmbCategoria.SelectedIndex = -1;
            cmbCiudad.SelectedIndex = -1;
            cmbJornada.SelectedIndex = -1;
            cmbModalidad.SelectedIndex = -1;
            txtBuscador.Text = null;
            dgvMisPublicaciones.Rows.Clear();
            publicar.ListaMisPublicacione(dgvMisPublicaciones, id);
        }

        private void dgvMisPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMisPublicaciones.Columns[e.ColumnIndex].Name == "btnEditar" && e.RowIndex >= 0)
            {

                string IdPublicacion = dgvMisPublicaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
                FrmModificarPublicacion frm = new FrmModificarPublicacion(id, IdPublicacion);
                this.AddOwnedForm(frm);
                publicar.AgregarComboBox(frm.cmbCategoria, frm.cmbModalidad, frm.cmbJornada, frm.cmbCiudad);
                publicar.AgregarComboBoxEstado(frm.cmbEstadoPublicacion);
                frm.btnTitulo.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.cmbCategoria.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.cmbModalidad.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.cmbJornada.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.cmbCiudad.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.cmbEstadoPublicacion.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm.btnDescripcion.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[8].Value.ToString();
                frm.BtnSalarioP.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[10].Value.ToString();
                frm.btnExperiencia.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[12].Value.ToString();
                frm.ShowDialog();
            }
            if (dgvMisPublicaciones.Columns[e.ColumnIndex].Name == "btnEliminar" && e.RowIndex >= 0)
            {
                string IdPublicacion = dgvMisPublicaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta publicación?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    publicar.EliminarPublicacion(IdPublicacion);
                    dgvMisPublicaciones.Rows.Clear();
                    publicar.ListaMisPublicacione(dgvMisPublicaciones, id);
                }
            }
            if (dgvMisPublicaciones.Columns[e.ColumnIndex].Name == "btnVerPostulantes" && e.RowIndex >= 0)
            {
                string IdPublicacion = dgvMisPublicaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
                FrmVisualizarPostulante 
                frm = new FrmVisualizarPostulante(id, IdPublicacion);        
                this.AddOwnedForm(frm);
                frm.lbNombreEmpresa.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            FrmAgregarPublicacion frm = new FrmAgregarPublicacion(id);
            this.AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string categoria = (cmbCategoria.SelectedItem as DataRowView)?["CategoriaPublicacion"].ToString();
            string modalidad = (cmbModalidad.SelectedItem as DataRowView)?["Modalidad"].ToString();
            string jornada = (cmbJornada.SelectedItem as DataRowView)?["Jornada"].ToString();
            string ciudad = (cmbCiudad.SelectedItem as DataRowView)?["Nombre_Ciudad"].ToString();
            publicar.BuscarMisPublicacionComboBox(dgvMisPublicaciones, id, categoria, modalidad, jornada, ciudad);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
