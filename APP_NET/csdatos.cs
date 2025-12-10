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

        public void llenarlista(FlowLayoutPanel panel, string sentencia, string Columna, string valor)
        {
            // Obtener los registros de la base de datos
            var registros = conexion.MostrarRegistros(sentencia);

            // Limpiar cualquier CheckBox existente en el panel
            panel.Controls.Clear();

            // Recorrer los registros y crear un CheckBox para cada uno
            foreach (DataRow row in registros.Rows)
            {
                CheckBox chk = new CheckBox();
                chk.Text = row[Columna].ToString();  // Establecer el texto del CheckBox
                chk.Tag = row[valor];  // Asignar un valor a la propiedad Tag para uso futuro (por ejemplo, el ID o valor del registro)

                // Añadir el CheckBox al panel
                panel.Controls.Add(chk);
                chk.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
