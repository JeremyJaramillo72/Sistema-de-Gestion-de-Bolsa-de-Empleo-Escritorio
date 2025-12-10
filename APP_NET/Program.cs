using APP_NET.FRMNUEVOS;
using APP_NET.Parte_Adminitardor;
using System;
using System.Windows.Forms;

namespace APP_NET
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Application.Run(new frmLOGEAGOR());
            
        }
    }
}
