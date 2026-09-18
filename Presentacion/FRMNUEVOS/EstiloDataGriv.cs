using System.Drawing;
using System.Windows.Forms;

namespace APP_NET.FRMNUEVOS
{
    public class EstiloDataGriv
    {
        public static void AplicarEstilo(DataGridView dgv)
        {
            // Ajuste automático
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv.AllowUserToAddRows = false;

            // --- ENCABEZADO ---
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersHeight = 35;

            // --- SIN COLORES EN LAS FILAS ---
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dgv.DefaultCellStyle.SelectionBackColor = Color.BlueViolet; // Verde solo al seleccionar
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // Bordes
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
