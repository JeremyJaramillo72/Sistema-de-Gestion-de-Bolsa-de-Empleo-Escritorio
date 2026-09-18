using CAPA_NEGOCIO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace APP_NET
{

    public partial class FrmEmpleo : Form
    {
        string ID;
        Publicaciones publicar = new Publicaciones();
        public FrmEmpleo(string iD)
        {
            InitializeComponent();
            ID = iD;
            CrearBotonPostularme();
        }

        private void FrmEmpleo_Load(object sender, EventArgs e)
        {
            publicar.ListaPublicacione(dgvPublicaciones);
            publicar.AgregarComboBox(cmbCategoria, cmbModalidad, cmbJornada, cmbCiudad);

        }
        void CrearBotonPostularme()
        {
            DataGridViewButtonColumn btnPostularme = new DataGridViewButtonColumn();
            btnPostularme.Name = "btnPostularme";
            btnPostularme.HeaderText = "Postulación";
            btnPostularme.Text = "Posttularme";
            btnPostularme.UseColumnTextForButtonValue = true;
            btnPostularme.Width = 80;
            btnPostularme.FlatStyle = FlatStyle.Popup;
            btnPostularme.DefaultCellStyle.BackColor = Color.LightGray;
            dgvPublicaciones.Columns.Add(btnPostularme);
        }


        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscador.Text.Length >= 3)
            {
                publicar.BuscarPublicacion(dgvPublicaciones, txtBuscador.Text);

            }
            else
            {
                dgvPublicaciones.Rows.Clear();
                publicar.ListaPublicacione(dgvPublicaciones);
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string categoria = (cmbCategoria.SelectedItem as DataRowView)?["CategoriaPublicacion"].ToString();
            string modalidad = (cmbModalidad.SelectedItem as DataRowView)?["Modalidad"].ToString();
            string jornada = (cmbJornada.SelectedItem as DataRowView)?["Jornada"].ToString();
            string ciudad = (cmbCiudad.SelectedItem as DataRowView)?["Nombre_Ciudad"].ToString();
            publicar.BuscarPublicacionComboBox(dgvPublicaciones, categoria, modalidad, jornada, ciudad);
        }

        private void dgvPublicaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void cmbCiudad_DropDown(object sender, EventArgs e)
        {
            cmbCiudad.DropDownHeight = cmbCiudad.ItemHeight * 5;
        }

        private void guna2PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            cmbCategoria.Text = null;
            cmbCiudad.Text = null;
            cmbJornada.Text = null;
            cmbModalidad.Text = null;
            txtBuscador.Text = null;
            dgvPublicaciones.Rows.Clear();
            publicar.ListaPublicacione(dgvPublicaciones);

        }

        private void dgvPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPublicaciones.Columns[e.ColumnIndex].Name == "btnPostularme" && e.RowIndex >= 0)
            {
                FrmMostrarContenidoPublicacion frm = new FrmMostrarContenidoPublicacion(ID);
                this.AddOwnedForm(frm);
                frm.IdPublicacion = dgvPublicaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm.lbtitulo.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.lbAutor.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.btnCategoria.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.btnModalidad.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.BtnJornada.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.txtdescripcion.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[8].Value.ToString();
                frm.lbCiudad.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.lbProvincia.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[9].Value.ToString();
                frm.BtnSalarioMinimo.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[10].Value.ToString();
                frm.lbFecha.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[11].Value.ToString();
                frm.btnExperiencia.Text = dgvPublicaciones.Rows[e.RowIndex].Cells[12].Value.ToString();
                frm.ShowDialog();
            }
        }
    }
}
