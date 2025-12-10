using APP_NET.Clases;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_NET
{

    public partial class FrmVerficiarDocEmpresa : Form
    {
        Publicaciones validar = new Publicaciones();
        Imagen mi = new Imagen();
       
        string IdPublicacion = " "; string idUsuario; string Candidato; string Correo; string Ciudad; string Telefono; string IDPostulante;
        public FrmVerficiarDocEmpresa()
        {
            InitializeComponent();
        }
        public FrmVerficiarDocEmpresa(string IdUsuario, string idPublicacion, string candidato, string correo, string ciudad, string telefono,string IDpostulante)
        {
            InitializeComponent();
            ConfigurarGrid();
           Candidato = candidato;
            idUsuario = IdUsuario;
            IdPublicacion = idPublicacion;
            Correo = correo;
            Ciudad = ciudad;
            Telefono = telefono;
            IDPostulante = IDpostulante;


            mi.MostrarLogoNombre(IdUsuario, pctimagen);

        }
        private void ConfigurarGrid()
        {

            if (!dgvValidacionDocumentos.Columns.Contains("btnVer"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnVer";
                btn.HeaderText = "Vista Previa";
                btn.Text = "👁️ Ver PDF";
                btn.UseColumnTextForButtonValue = true;
                btn.Width = 80;
                dgvValidacionDocumentos.Columns.Add(btn);
            }
            if (!dgvValidacionDocumentos.Columns.Contains("btnAprobar"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnAprobar";
                btn.HeaderText = "Acción";
                btn.Text = "✅";
                btn.UseColumnTextForButtonValue = true;
                btn.Width = 40;
                dgvValidacionDocumentos.Columns.Add(btn);
            }


            if (!dgvValidacionDocumentos.Columns.Contains("btnRechazar"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnRechazar";
                btn.HeaderText = "";
                btn.Text = "❌";
                btn.UseColumnTextForButtonValue = true;
                btn.Width = 40;
                dgvValidacionDocumentos.Columns.Add(btn);
            }
        }
        private void FrmVerficiarDocEmpresa_Load(object sender, EventArgs e)
        {
            validar.ValidarDOc(dgvValidacionDocumentos, idUsuario);
     
            lbNombreU.Text = Candidato;
            lbTelefono.Text = Telefono;
            lbEmail.Text = Correo;
            lbCiudad.Text = Ciudad;
           

        }

        private void dgvValidacionDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvValidacionDocumentos.Columns[e.ColumnIndex].Name;

            // CASO 1: VER DOCUMENTO
            if (colName == "btnVer")
            {
                AbrirDocumento(e.RowIndex);
            }
            // CASO 2: APROBAR O RECHAZAR
            else if (colName == "btnAprobar" || colName == "btnRechazar")
            {
                GestionarEstadoDocumento(e.RowIndex, colName);
            }
        } 

        

        private void btnVerCurriculum_Click(object sender, EventArgs e)
        {



            try
            {            
                byte[] pdfBytes = validar.DescargarCV(idUsuario, IdPublicacion);
          
                if (pdfBytes != null && pdfBytes.Length > 0)
                {               
                    string rutaPDF = Path.GetTempFileName() + ".pdf";              
                    File.WriteAllBytes(rutaPDF, pdfBytes);              
                    Process.Start(new ProcessStartInfo(rutaPDF) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Este candidato no tiene un CV cargado o no se encontró.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir el PDF: " + ex.Message);
            }

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void AbrirDocumento(int rowIndex)
        {
            try
            {
                object valorCelda = dgvValidacionDocumentos.Rows[rowIndex].Cells["Archivo"].Value;

                if (valorCelda == null || valorCelda == DBNull.Value || string.IsNullOrWhiteSpace(valorCelda.ToString()))
                {
                    MessageBox.Show("No hay documento adjunto.");
                    return;
                }

                string rutaPDF = "";

        
                if (valorCelda.GetType() == typeof(byte[]))
                {
                    byte[] archivoBytes = (byte[])valorCelda;
                    if (archivoBytes.Length > 0)
                    {
                        rutaPDF = Path.GetTempFileName() + ".pdf";
                        File.WriteAllBytes(rutaPDF, archivoBytes);
                    }
                }
    
                else
                {
                    string texto = valorCelda.ToString();
                    if (File.Exists(texto))
                    {
                        rutaPDF = texto;
                    }
                    else
                    {
                        MessageBox.Show("El archivo no se encuentra en la ruta:\n" + texto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

  
                if (!string.IsNullOrEmpty(rutaPDF))
                {
                    Process.Start(new ProcessStartInfo(rutaPDF) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el documento: " + ex.Message);
            }
        }
        private void GestionarEstadoDocumento(int rowIndex, string accion)
        {
            try
            {
            
                int idRegistro = Convert.ToInt32(dgvValidacionDocumentos.Rows[rowIndex].Cells["ID_Registro"].Value);
                string categoria = dgvValidacionDocumentos.Rows[rowIndex].Cells["Categoria"].Value.ToString();

           
                string nuevoEstado;
                Color colorFondo;

                if (accion == "btnAprobar")
                {
                    nuevoEstado = "Aprobado";
                    colorFondo = Color.LightGreen;
                }
                else 
                {
                    nuevoEstado = "Rechazado";
                    colorFondo = Color.MistyRose;
                }

 
                bool exito = validar.ActualizarEstadoDocumento(idRegistro, categoria, nuevoEstado, IDPostulante);

                if (exito)
                {
                 
                    dgvValidacionDocumentos.Rows[rowIndex].Cells["Estado"].Value = nuevoEstado;
                    dgvValidacionDocumentos.Rows[rowIndex].DefaultCellStyle.BackColor = colorFondo;

                    MessageBox.Show($"Documento {nuevoEstado} correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al cambiar estado: " + ex.Message);
            }
        }
    }
}