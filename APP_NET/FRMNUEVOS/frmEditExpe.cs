using CapaDatos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace APP_NET.FRMNUEVOS
{
    public partial class frmEditExpe : Form
    {
        csUsuariosBD miClaseBD = new csUsuariosBD();
        csConexionSQL datos = new csConexionSQL();
        string ID;
        string IDpro;
        public frmEditExpe(string id)
        {
            InitializeComponent();
            ID = id;
            IDpro = miClaseBD.OBtenerIdpro(ID);
        }

        private void frmEditExpe_Load(object sender, EventArgs e)
        {
            dgvExperienciaLaboral.DataSource = datos.MostrarRegistros($"Select IdExperiencia, Empresa, Cargo, FechaInicio, FechaFin, Descripcion, Ubicacion, Archivo from ExpLaboral where ID_PerfilProfesional={IDpro}");
            dgvExperienciaLaboral.ReadOnly = false;
            dgvExperienciaLaboral.AllowUserToAddRows = false;
            dgvExperienciaLaboral.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarDatos();
            dgvExperienciaLaboral.Columns["Archivo"].Visible = false;
          
            EstiloDataGriv.AplicarEstilo(dgvExperienciaLaboral);
        }

        private void bordes_Boton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarDatos()
        {
            dgvExperienciaLaboral.DataSource = datos.MostrarRegistros($"Select IdExperiencia, Empresa, Cargo, FechaInicio, FechaFin,Descripcion, Ubicacion, Archivo from ExpLaboral e inner join Perfil_Profesional p on e.ID_PerfilProfesional=p.ID_PerfilProfesional where e.ID_PerfilProfesional={IDpro}");
        }

        private void btnGuardarCambiosExp_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvExperienciaLaboral.Rows)
                {
                    if (row.IsNewRow) continue;


                    int id = Convert.ToInt32(row.Cells["IdExperiencia"].Value);
                    string empresa = row.Cells["Empresa"].Value.ToString();
                    string cargo = row.Cells["Cargo"].Value.ToString();
                    DateTime fechaInicio = Convert.ToDateTime(row.Cells["FechaInicio"].Value);
                    DateTime fechaFin = Convert.ToDateTime(row.Cells["FechaFin"].Value);
                    string descripcion = row.Cells["Descripcion"].Value.ToString();
                    string ubicacion = row.Cells["Ubicacion"].Value.ToString();


                    object valorCelda = row.Cells["Archivo"].Value;
                    byte[] archivoBytes = null;


                    if (valorCelda is byte[])
                    {
                        archivoBytes = (byte[])valorCelda;
                    }
                    else if (valorCelda is string rutaArchivo && File.Exists(rutaArchivo))
                    {
                        archivoBytes = File.ReadAllBytes(rutaArchivo);
                    }
                    else
                    {
                        archivoBytes = new byte[0];
                    }


                    datos.EjecutarConsulta(
                    "UPDATE ExpLaboral SET Empresa=@em, Cargo=@ca, FechaInicio=@fi, FechaFin=@ff, Descripcion=@de, Ubicacion=@ub, Archivo=@ar WHERE IdExperiencia=@id",
                    new SqlParameter[]
                    {
                        new SqlParameter("@em", empresa),
                        new SqlParameter("@ca", cargo),
                        new SqlParameter("@fi", fechaInicio),
                        new SqlParameter("@ff", fechaFin),
                        new SqlParameter("@de", descripcion),
                        new SqlParameter("@ub", ubicacion),
                        new SqlParameter("@ar", archivoBytes),
                        new SqlParameter("@id", id)
                    }
                    );
                }


                MessageBox.Show("Cambios guardados correctamente");
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btn_eliminaRegistro_exp_Click(object sender, EventArgs e)
        {
            if (dgvExperienciaLaboral.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro.");
                return;
            }


            int id = Convert.ToInt32(dgvExperienciaLaboral.SelectedRows[0].Cells["IdExperiencia"].Value);


            DialogResult resp = MessageBox.Show(
            "¿Seguro que deseas eliminar este registro?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );


            if (resp == DialogResult.Yes)
            {
                datos.EjecutarConsulta(
                "DELETE FROM ExpLaboral WHERE IdExperiencia = @id",
                new SqlParameter[]
                {
                    new SqlParameter("@id", id)
                }
                );


                MessageBox.Show("Registro eliminado correctamente.");
                CargarDatos();
            }
        }

        private void dgvExperienciaLaboral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvExperienciaLaboral.Columns[e.ColumnIndex].Name == "Archivo")
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "PDF|*.pdf|Imagenes|*.jpg;*.jpeg;*.png|Todos|*.*";


                if (op.ShowDialog() == DialogResult.OK)
                {
                    dgvExperienciaLaboral.Rows[e.RowIndex].Cells["Archivo"].Value = op.FileName;
                }
            }
        }
    }
}
