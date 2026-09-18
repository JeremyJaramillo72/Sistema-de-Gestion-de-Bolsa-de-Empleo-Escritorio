using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
namespace CAPA_NEGOCIO
{
    internal class csCorreoElectronico
    {
        string servidor, usuario, clave, emisor, emisor_nombre, receptor, con_copia, asunto, cuerpo, adjunto;
        int puerto;
        bool ssl;

        public string Emisor
        {
            get { return emisor; }
            set { emisor = value; }
        }
        public string Emisor_Nombre
        {
            get { return emisor_nombre; }
            set { emisor_nombre = value; }
        }
        public string Receptor
        {
            get { return receptor; }
            set { receptor = value; }
        }
        public string Con_Copia
        {
            get { return con_copia; }
            set { con_copia = value; }
        }
        public string Asunto
        {
            get { return asunto; }
            set { asunto = value; }
        }
        public string Cuerpo
        {
            get { return cuerpo; }
            set { cuerpo = value; }
        }
        public string Adjunto
        {
            get { return adjunto; }
            set { adjunto = value; }
        }
        public string Servidor
        {
            get { return servidor; }
            set { servidor = value; }
        }
        public int Puerto
        {
            get { return puerto; }
            set { puerto = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public bool Ssl
        {
            get { return ssl; }
            set { ssl = value; }
        }

        public csCorreoElectronico()
        {
            emisor = "networkinonline@gmail.com";
            emisor_nombre = "TRABJO ONLINE";
            servidor = "smtp.gmail.com";
            puerto = 587;
            ssl = true;
            usuario = "networkinonline@gmail.com";
            clave = "mpfb ivmh paum vrfx";


        }

        public bool Enviar()
        {
            using (MailMessage mensaje = new MailMessage())
            {
                try
                {
                    // Configurar los datos del mensaje
                    mensaje.From = new MailAddress(emisor, emisor_nombre);
                    mensaje.To.Add(new MailAddress(receptor));
                    if (!string.IsNullOrEmpty(con_copia))
                    {
                        mensaje.CC.Add(new MailAddress(con_copia));
                    }
                    mensaje.Subject = asunto;
                    mensaje.Body = cuerpo;
                    if (!string.IsNullOrEmpty(adjunto))
                    {
                        Attachment attachment = new Attachment(adjunto);
                        mensaje.Attachments.Add(attachment);
                    }

                    // Configurar el cliente SMTP
                    using (SmtpClient clienteSMTP = new SmtpClient(servidor, puerto))
                    {
                        clienteSMTP.EnableSsl = ssl;
                        clienteSMTP.Credentials = new NetworkCredential(usuario, clave);

                        // Enviar el correo
                        clienteSMTP.Send(mensaje);
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error de envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
