using System.Data;
using System.Windows.Forms;


namespace CapaDatos
{
    public class csdatos
    {
        csConexionSQL conexion = new csConexionSQL();

        public void llenarcmb(ComboBox cmb, string sentencia, string Columna, string valor)
        {
            cmb.DataSource = conexion.MostrarRegistros(sentencia);
            cmb.ValueMember = valor;
            cmb.DisplayMember = Columna;
            cmb.SelectedIndex = -1;
        }
        public void llenarcmbProcedure(ComboBox cmb, string nombreProcedimiento, string Columna, string valor)
        {
            DataTable dt = conexion.MostrarRegistrosProcedure(nombreProcedimiento);
            cmb.DataSource = dt;
            cmb.ValueMember = valor;
            cmb.DisplayMember = Columna;
            cmb.SelectedIndex = -1;

        }




    }
}
