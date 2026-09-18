using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CAPA_NEGOCIO
{
    public class CsMensajeria
    {
        CsMensajeriaBD conexion = new CsMensajeriaBD();

        public CsMensajeria() { }

        public DataTable ObtenerAmistades(int idUsuario)
        {
            return conexion.ObtenerAmistades(idUsuario);
        }

        public DataTable ObtenerMensajes(int idUsuario)
        {
            return conexion.ObtenerMensajes(idUsuario);
        }

        public void EliminarMensaje(int idMensajeSeleccionado)
        {
            conexion.ELiminarMensaje(idMensajeSeleccionado);
        }

        public void EnviarMensaje(int idUsuarioRemitente, int idUsuarioReceptor, string contenidoMensaje)
        {
            conexion.EnviarMensaje(idUsuarioRemitente, idUsuarioReceptor, contenidoMensaje);
        }
    }
}
