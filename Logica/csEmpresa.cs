
using CapaDatos;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
namespace CAPA_NEGOCIO
{
    public class csEmpresa
    {
        csEmpresaBD empresaBD = new csEmpresaBD();
        string nombre_Empresa;
        string rUC;
        string sitio_Web;
        string sector_Empresa;
        string descripcionEmpresa;
        string direccion;
        string nombreCiudad;


        public string Nombre_Empresa { get => nombre_Empresa; set => nombre_Empresa = value; }
        public string RUC { get => rUC; set => rUC = value; }
        public string Sitio_Web { get => sitio_Web; set => sitio_Web = value; }
        public string Sector_Empresa { get => sector_Empresa; set => sector_Empresa = value; }
        public string DescripcionEmpresa { get => descripcionEmpresa; set => descripcionEmpresa = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }

        public csEmpresa()
        {

        }
        public void AgregarComboBoxEstado(ComboBox Estado)
        {
            empresaBD.AgregarComboBoxEstado(Estado);
        }
        public void AgregarComboBoxSectorIndustrial(ComboBox Estado)
        {
            empresaBD.AgregarComboBoxSectorIndustrial(Estado);
        }
        public int VerificarPerfilEmpresa(string ID_Empresa)
        {
            int verificar = empresaBD.VerificarPerfilEmpresa(ID_Empresa);
            return verificar;


        }
        public (bool, string) CambiarFotoPerfil(int idUsuario, Image imagen)
        {

            byte[] imagenEnBytes;

            using (MemoryStream ms = new MemoryStream())
            {

                imagen.Save(ms, ImageFormat.Png);
                imagenEnBytes = ms.ToArray();
            }


            return empresaBD.ActualizarFotoPerfil(idUsuario, imagenEnBytes);
        }
        public csEmpresa rellenarDatosEmpresa(string ID_Empresa)
        {
            csEmpresaBD datosCrudos = empresaBD.rellenarDatosEmpresa(ID_Empresa);

            if (datosCrudos != null)
            {
                csEmpresa modeloLimpio = new csEmpresa();
                modeloLimpio.Nombre_Empresa = datosCrudos.Nombre_Empresa;
                modeloLimpio.RUC = datosCrudos.RUC;
                modeloLimpio.Sitio_Web = datosCrudos.Sitio_Web;
                modeloLimpio.Sector_Empresa = datosCrudos.Sector_Empresa;
                modeloLimpio.DescripcionEmpresa = datosCrudos.DescripcionEmpresa;
                modeloLimpio.Direccion = datosCrudos.Direccion;
                modeloLimpio.NombreCiudad = datosCrudos.NombreCiudad;

                return modeloLimpio;
            }
            else
            {
                return null;
            }
        }
        public (bool, string) GuardarCambiosPerfil(int idUsuario, string sector, string web, int idCiudad, string direccion, string descripcion)
        {

            if (string.IsNullOrEmpty(descripcion) || descripcion.Length < 10)
            {
                return (false, "La descripción es muy corta. Cuéntanos más sobre tu empresa.");
            }

            return empresaBD.ActualizarPerfil(idUsuario, sector, web, idCiudad, direccion, descripcion);
        }
    }
}
