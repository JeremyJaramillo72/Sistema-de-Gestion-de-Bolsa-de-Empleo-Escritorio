using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
namespace CAPA_NEGOCIO
{
    public class CsAmigos
    {

        CsAmigosBD conec = new CsAmigosBD();
        public void AceptarSolicitud(int IdAmistad)
        {
            conec.AceptarSolicitud(IdAmistad);
            MessageBox.Show("Solicitud Aceptada");
        }
        public void RechazarSolicitud(int IdAmistad)
        {
            conec.RechazarSolicitud(IdAmistad);
            MessageBox.Show("Solicitud Rechazada");
        }
        public string EnviarSolicitud(int idUsuarioRemitente, int idUsuarioReceptor)
        {
            return conec.EnviarSolicitud(idUsuarioRemitente, idUsuarioReceptor);
        }

        public DataTable ObtenerAmistadesPendientes(int idUsuario)
        {
            return conec.ObtenerAmistadesPendientes(idUsuario);
        }

        public DataTable ObtenerUsuariosConTodosSusTitulos(int idUsuario, string xd = "")
        {
            return conec.ObtenerUsuariosConTodosSusTitulos(idUsuario, xd);
        }

    }
}
