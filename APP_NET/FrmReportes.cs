using CAPA_NEGOCIO;
using CAPA_NEGOCIO.New_Clases;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace APP_NET
{

    public partial class FrmReportes : Form
    {
        csReportes reporte = new csReportes();
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            cmbReporte.Items.Clear();
            cmbReporte.Items.AddRange(new string[] {
    "Usuarios del Sistema",
    "Publicaciones de Empleo",
    "Postulaciones a Empleos",
    "Empresas Registradas",
    "Profesionales Registrados",
    "Documentos Académicos",
    "Experiencia Laboral"
});

        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Dataset = ""; 
           
           if (cmbReporte.SelectedIndex == 0)
            {
                 Dataset = "dsUsuario";
                CargarInforme("APP_NET.rptUsuario2.rdlc", "Usuarios del Sistema", Dataset);

            }
            else if (cmbReporte.SelectedIndex == 1)
            {
                 Dataset = "dsPublicaciones";
                CargarInforme("APP_NET.rptPublicaciones2.rdlc", "Publicaciones de Empleo", Dataset);

            }
            else if (cmbReporte.SelectedIndex == 2)
            {
                 Dataset = "dsPostulaciones2";
                CargarInforme("APP_NET.rptPostulaciones2.rdlc", "Postulaciones a Empleos", Dataset);
            }
            else if (cmbReporte.SelectedIndex == 3  )
            {
                 Dataset = "dsEmpresa2";
                CargarInforme("APP_NET.rptEmpresas2.rdlc", "Empresas Registradas", Dataset);
            }
            else if (cmbReporte.SelectedIndex == 4)
            {
                 Dataset = "dsProfesionales2";
                CargarInforme("APP_NET.rptProfesionales2.rdlc", "Profesionales Registrados", Dataset);
            }
            else if (cmbReporte.SelectedIndex == 5)
            {
                 Dataset = "dsDocAcademico";
                CargarInforme("APP_NET.rptDocAcademico2.rdlc", "Documentos Académicos", Dataset);
                
            }
            else if (cmbReporte.SelectedIndex == 6)
            {
                 Dataset = "dsExpLaboral";
                CargarInforme("APP_NET.rptExpLaboral2.rdlc", "Experiencia Laboral", Dataset);
            }
           /* else if (cmbReporte.SelectedIndex == 7)
            {
                 Dataset = "dsSoftwareLicencias";
                CargarInforme("APP_NET.RptCiudadesConUsuarios.rdlc", "Ciudades con Usuarios", Dataset);
            }*/
            RpViewer.RefreshReport();
        }
        private void CargarInforme(string nombreInforme, string TipoStorProcedure, string dataset)
        {

            CsAdmin Admin = new CsAdmin();
            RpViewer.LocalReport.DataSources.Clear();
             (DataTable dtReportes, string Mensaje, int Exito) = Admin.ObtenerReporte(TipoStorProcedure);
             if (dtReportes == null)
             {
                 dtReportes = new DataTable(); 
             }
             try
             {
                 RpViewer.LocalReport.ReportEmbeddedResource = nombreInforme;
                 ReportDataSource fuenteDatos = new ReportDataSource(dataset, dtReportes);
                 RpViewer.LocalReport.DataSources.Add(fuenteDatos);

                 RpViewer.RefreshReport();
                 if (Exito == -1 || Exito == 0)
                 {
                     MessageBox.Show("Atención: " + Mensaje);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al renderizar el reporte: " + ex.Message);
             }

            
        }
    }
}
