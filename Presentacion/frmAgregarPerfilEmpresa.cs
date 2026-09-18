using APP_NET.Clases;
using CAPA_NEGOCIO;
using CapaDatos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class frmAgregarPerfilEmpresa : Form
    {
        string ID_Empresa = "";
        csConexionSQL dato = new csConexionSQL();
        csEmpresa empresa = new csEmpresa();
        public frmAgregarPerfilEmpresa()
        {
            InitializeComponent();
        }
        public frmAgregarPerfilEmpresa(string id)
        {
            InitializeComponent();
            ID_Empresa = id;
            Imagen mi = new Imagen();
            mi.MostrarLogoNombre(id, pctimagen);

        }

        private void btn_registrarEmpresa_Click(object sender, EventArgs e)
        {
            if (cbCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona una ciudad.", "Falta Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resppuesta = empresa.GuardarCambiosPerfil(int.Parse(ID_Empresa), cbtipoSector.SelectedValue.ToString(), txtSitioWeb.Text, Convert.ToInt32(cbCiudad.SelectedValue), txtDireccion.Text, txtDescripcionEmpresa.Text);
            if (resppuesta.Item1)
            {
                MessageBox.Show(resppuesta.Item2, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resppuesta.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void frmAgregarPerfilEmpresa_Load(object sender, EventArgs e)
        {
            empresa.AgregarComboBoxEstado(cbCiudad);
            int verificar = empresa.VerificarPerfilEmpresa(ID_Empresa);
            empresa.AgregarComboBoxSectorIndustrial(cbtipoSector);

            if (verificar != 0)
            {
                csEmpresa empresa1 = empresa.rellenarDatosEmpresa(ID_Empresa);

                lbNombreEmpresa.Text = empresa1.Nombre_Empresa;
                lbRuc.Text = empresa1.RUC;
                txtSitioWeb.Text = empresa1.Sitio_Web;
                cbtipoSector.Text = empresa1.Sector_Empresa;
                txtDescripcionEmpresa.Text = empresa1.DescripcionEmpresa;
                txtDireccion.Text = empresa1.Direccion;
                cbCiudad.Text = empresa1.NombreCiudad;




            }
        }

        private void pctimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image imagenCargada = Image.FromFile(ofd.FileName);
                pctimagen.Image = imagenCargada;
                pctimagen.SizeMode = PictureBoxSizeMode.Zoom;
                var respuesta = empresa.CambiarFotoPerfil(int.Parse(ID_Empresa), imagenCargada);

                if (respuesta.Item1)
                {
                    MessageBox.Show("Foto de perfil actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar la foto: " + respuesta.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
