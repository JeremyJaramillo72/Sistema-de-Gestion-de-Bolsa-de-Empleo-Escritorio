using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class FrmBase : Form
    {
        // 1. LIBRERÍAS PARA BORDE REDONDO
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // 2. LIBRERÍAS PARA MOVER VENTANA
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public FrmBase()
        {
            InitializeComponent();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Aseguramos que no tenga borde

            // Aplicamos el redondeo
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Recalculamos la forma redonda basándonos en el NUEVO ancho y alto
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
    }
}
