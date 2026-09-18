using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class FrmVisualizarPostulante : Form
    {
        string IdUsuario;
        string IdPublicacion;
        Publicaciones publicar = new Publicaciones();
        public FrmVisualizarPostulante()
        {
            InitializeComponent();
       
        }
        public FrmVisualizarPostulante(string idusuario, string idPublicacion)
        {
            InitializeComponent();
            IdUsuario = idusuario;
            IdPublicacion = idPublicacion;
            CrearColumna();
          


        }
        public void  CrearColumna()
        {
            DataGridViewButtonColumn btnVerDocumentos = new DataGridViewButtonColumn();
            btnVerDocumentos.Name = "btnVerDocumentos";
            btnVerDocumentos.HeaderText = "Documentos";
            btnVerDocumentos.Text = "Ver Documentos";
            btnVerDocumentos.UseColumnTextForButtonValue = true;
            btnVerDocumentos.Width = 120;
            btnVerDocumentos.FlatStyle = FlatStyle.Popup;
            btnVerDocumentos.DefaultCellStyle.BackColor = Color.LightGray;
            dgvMisPostulantes.Columns.Add(btnVerDocumentos);
            if (!dgvMisPostulantes.Columns.Contains("btnAceptar"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnAceptar";
                btn.HeaderText = "Acción";
                btn.Text = "✅";
                btn.UseColumnTextForButtonValue = true;
                btn.Width = 40;
                dgvMisPostulantes.Columns.Add(btn);
            }

         
            if (!dgvMisPostulantes.Columns.Contains("btnRechazar"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnRechazar";
                btn.HeaderText = "";
                btn.Text = "❌";
                btn.UseColumnTextForButtonValue = true;
                btn.Width = 40;
                dgvMisPostulantes.Columns.Add(btn);
            }
        }
        
      

        private void FrmVisualizarPostulante_Load(object sender, EventArgs e)
        {
            publicar.ListaPostulantes(dgvMisPostulantes,IdPublicacion);
            lblTotal.Text = "" + dgvMisPostulantes.Rows.Count;
        }

        private void dgvMisPostulantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex < 0) return;
            string colName = dgvMisPostulantes.Columns[e.ColumnIndex].Name; 
            if (colName == "btnVerDocumentos")
            {

                string correo = dgvMisPostulantes.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                string candidato = dgvMisPostulantes.Rows[e.RowIndex].Cells["Candidatos"].Value.ToString();
                string idPostulante = dgvMisPostulantes.Rows[e.RowIndex].Cells["Codigo"].Value.ToString(); 
                string telefono = dgvMisPostulantes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                string ciudad = dgvMisPostulantes.Rows[e.RowIndex].Cells["Ciudad"].Value.ToString();
                string postulante01 = dgvMisPostulantes.Rows[e.RowIndex].Cells["ID_Postulacion"].Value.ToString();


                FrmVerficiarDocEmpresa verDocumentos = new FrmVerficiarDocEmpresa(idPostulante, IdPublicacion, candidato, correo, ciudad, telefono,postulante01);
                
                verDocumentos.ShowDialog();
            }
            else if (colName == "btnAceptar" || colName == "btnRechazar")
            {
                try
                {
  
                    int idPostulacion = Convert.ToInt32(dgvMisPostulantes.Rows[e.RowIndex].Cells["ID_Postulacion"].Value);

                    string nuevoEstado = (colName == "btnAceptar") ? "Aceptada" : "Rechazada";

    
                    bool exito = publicar.DecidirCandidato(idPostulacion, nuevoEstado);

                    if (exito)
                    {
                        csMensajesDCorreosYMensajitos envio = new csMensajesDCorreosYMensajitos();
                        dgvMisPostulantes.Rows[e.RowIndex].Cells["Estado"].Value = nuevoEstado;
                        string correo = dgvMisPostulantes.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                        string candidato = dgvMisPostulantes.Rows[e.RowIndex].Cells["Candidatos"].Value.ToString();
                        string titulo = lbNombreEmpresa.Text;
                        if (nuevoEstado == "Aceptada")
                        {
                            dgvMisPostulantes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                            envio.EnvioCorreoCandidatoAceptado(candidato, correo, titulo);
                        }

                        else
                        {
                            dgvMisPostulantes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                            envio.EnvioCorreoCandidatoRechazado(candidato, correo, titulo);
                        }
                            

                        MessageBox.Show("Candidato marcado como: " + nuevoEstado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el estado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
