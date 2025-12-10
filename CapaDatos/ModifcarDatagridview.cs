using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    internal class ModifcarDatagridview : csConexionSQL
    {
        public void Mostrar(DataGridView Tabla, DataTable registros)
        {
            Tabla.Rows.Clear();
            int f = 0;
            foreach (DataRow row in registros.Rows)
            {
                Tabla.Rows.Add(row.ItemArray);
                Tabla.Rows[f].Resizable = DataGridViewTriState.False;
                Tabla.Rows[f++].Height = 50;
            }

            int x = 18;
            for (int i = 0; i < Tabla.ColumnCount - 1; i++)
            {
                // Ajustar el ancho de las columnas
                Tabla.Columns[i].Width = ((Tabla.Width - 50 - x) / (Tabla.ColumnCount - 1)) - 1;
                Tabla.Columns[i].Resizable = DataGridViewTriState.False;
            }

            // Aumentar el espacio entre columnas (margen adicional)
            foreach (DataGridViewColumn column in Tabla.Columns)
            {
                column.Width += 10; // Incrementar el ancho de cada columna
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                // Ajustar el Padding para aumentar el espacio entre las columnas
                column.DefaultCellStyle.Padding = new Padding(5);  // Aumenta el padding entre las celdas
            }

            // Opcional: Ajustar el Padding de los encabezados de las columnas
            Tabla.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 5, 10, 5); // Ajusta el padding de los encabezados

            // Ajustar el tamaño de las columnas de acuerdo al contenido
            Tabla.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


    }
}
