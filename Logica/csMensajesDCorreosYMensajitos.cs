using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class csMensajesDCorreosYMensajitos
    {
        public void CorreoNoValidoORegistrado()
        {
            MessageBox.Show("⚠️ El correo electrónico ingresado no es válido o ya está registrado en nuestro sistema. Asegúrate de escribir una dirección de correo válida (por ejemplo, usuario@ejemplo.com) o intenta recuperar tu contraseña si ya tienes una cuenta registrada. ¡Gracias por tu comprensión! 📧", "Correo Inválido o Registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void MensajeCamposIncompletos()
        {
            MessageBox.Show("⚠️ ¡Atención! Por favor, completa todos los campos requeridos. La información es importante para continuar con el proceso. 📋", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void NoNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("⚠️ Solo se permiten letras y espacios. Por favor, no ingreses números o caracteres especiales.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void NoLetras()
        {
        }

        public void NoEspacio(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ' ' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("⚠️ El ingreso de espacios no está permitido. Por favor, usa caracteres válidos.", "Entrada No Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EnvioDeCorreoRecuperacionDCuenta(string Correo, long codigo)
        {
            csCorreoElectronico mensaje = new csCorreoElectronico();
            mensaje.Receptor = Correo;
            mensaje.Asunto = "Recuperación de Contraseña";
            mensaje.Cuerpo = "Estimado usuario,\n\nEl código de verificación es: " + codigo + ".\nPor favor, no comparta este código con nadie. Si no solicitó esta recuperación, revise su cuenta de inmediato.";

            if (mensaje.Enviar())
                MessageBox.Show("✅ El código de verificación ha sido enviado correctamente. Por favor, revisa tu bandeja de entrada. Si no lo encuentras, verifica la carpeta de SPAM.", "Envío Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("⚠️ Hubo un problema al enviar el correo. Verifica que la dirección de correo electrónico sea válida e intenta nuevamente.", "Error de Envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void EnvioDeCorreoUsuarioAgregar(string nombre, string correo)
        {
            MessageBox.Show("✅ El usuario ha sido agregado exitosamente a la Biblioteca. ¡Continúa gestionando tu equipo y brindando acceso al conocimiento! 📚", "Usuario Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            csCorreoElectronico mensaje = new csCorreoElectronico();
            mensaje.Receptor = correo.Trim();
            mensaje.Asunto = "¡Bienvenido a la Biblioteca Digital!";
            mensaje.Cuerpo = "Estimado Usuario,\n\n¡Nos complace darte la bienvenida a nuestra Biblioteca Digital! Tu cuenta ha sido creada exitosamente.\n\n🆔 Tu nombre de usuario es: " + nombre + "\n\nTe invitamos a explorar nuestra colección de libros y recursos. Si tienes alguna pregunta, no dudes en contactarnos.\n\n¡Feliz lectura!\n\nSaludos cordiales,\nEquipo de la Biblioteca 📚";

            if (mensaje.Enviar())
                MessageBox.Show("🎉 ¡Usuario agregado con éxito! Se ha enviado un correo con tu nombre de usuario para que puedas acceder a nuestra biblioteca digital. Revisa tu bandeja de entrada y, si no lo encuentras, asegúrate de revisar también la carpeta de SPAM. ¡Bienvenido a tu nueva aventura literaria! 📚", "Usuario Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("⚠️ Hubo un problema al enviar el correo. Verifica que la dirección de correo electrónico sea válida e intenta nuevamente.", "Error de Envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void EnvioCorreoUsuarioEditar(string nombre, string apellido, string correo, string rol)
        {
            MessageBox.Show("✅ Los datos del usuario han sido modificados exitosamente. ¡Gracias por mantener la información actualizada! 📚", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            csCorreoElectronico mensaje = new csCorreoElectronico();
            mensaje.Receptor = correo;
            mensaje.Asunto = "Actualización de Datos en la Biblioteca Digital";
            mensaje.Cuerpo = "Estimado usuario,\n\n" +
                             "Queremos informarte que los datos de tu cuenta en nuestra Biblioteca Digital han sido actualizados correctamente. Aquí están los detalles de tu información modificada:\n\n" +
                             "📝 Nombre: " + nombre + "\n" +
                             "📝 Apellido: " + apellido + "\n" +
                             "📧 Correo Electrónico: " + correo + "\n" +
                             "🔖 Rol: " + rol + "\n\n" +
                             "Si no solicitaste esta actualización o tienes alguna duda, por favor contáctanos de inmediato.\n\n" +
                             "Gracias por ser parte de nuestra comunidad lectora. ¡Sigue disfrutando de nuestra colección de libros y recursos!\n\n" +
                             "Saludos cordiales,\n" +
                             "Equipo de la Biblioteca 📚";
            if (mensaje.Enviar())
            {
                MessageBox.Show("✅ Los datos del usuario han sido modificados exitosamente y se ha enviado un correo con la información actualizada. Revisa tu bandeja de entrada y, si no lo encuentras, verifica también la carpeta de SPAM. ¡Gracias por mantener tu información al día! 📚",
                                "Modificación y Envío Exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("⚠️ Los datos del usuario se han actualizado correctamente, pero hubo un problema al enviar el correo. Verifica que la dirección de correo electrónico sea válida e intenta nuevamente.",
                                "Actualización Completa, Error de Envío",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        public void EnvioDeCorreoLectoresAgregar(string nombre, string apellido, string correo)
        {
            MessageBox.Show("✅ ¡Lector agregado con éxito! El nuevo lector ha sido registrado en el sistema. Continúa ampliando nuestra comunidad lectora y facilitando el acceso al conocimiento. 📚", "Lector Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            csCorreoElectronico mensaje = new csCorreoElectronico();
            mensaje.Receptor = correo;
            mensaje.Asunto = "¡Bienvenido a la Biblioteca Digital!";
            mensaje.Cuerpo = "Estimado lector,\n\n" +
                             "¡Nos complace darte la bienvenida a nuestra Biblioteca Digital! Tu cuenta ha sido creada exitosamente con los siguientes datos:\n\n" +
                             "🆔 Nombre: " + nombre + "\n" +
                             "🆔 Apellido: " + apellido + "\n" +
                             "📧 Correo Electrónico: " + correo + "\n\n" +
                             "Te invitamos a explorar nuestra colección de libros y recursos. Si tienes alguna pregunta, no dudes en contactarnos.\n\n" +
                             "¡Feliz lectura y bienvenida a tu nueva aventura literaria!\n\n" +
                             "Saludos cordiales,\n" +
                             "Equipo de la Biblioteca 📚";
            if (mensaje.Enviar())
            {
                MessageBox.Show("🎉 ¡Lector agregado con éxito! Se ha enviado un correo de bienvenida con los datos proporcionados. Revisa tu bandeja de entrada y, si no lo encuentras, asegúrate de revisar también la carpeta de SPAM. ¡Nos alegra tenerte con nosotros! 📚", "Lector Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

                MessageBox.Show("⚠️ Hubo un problema al enviar el correo. Verifica que la dirección de correo electrónico sea válida e intenta nuevamente.", "Error de Envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void EnvioCorreoLectorEditar(string nombre, string apellido, string correo)
        {
            MessageBox.Show("✅ Los datos del lector han sido actualizados exitosamente. ¡Gracias por mantener la información al día! 📖", "Actualización Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            csCorreoElectronico mensaje = new csCorreoElectronico();
            mensaje.Receptor = correo;
            mensaje.Asunto = "¡Actualización de tus datos en la Biblioteca Digital!";
            mensaje.Cuerpo = "Estimado lector,\n\nTus datos han sido actualizados correctamente en nuestra Biblioteca Digital. A continuación, te recordamos la información registrada:\n\n" +
                             "🆔 Nombre: " + nombre + "\n" +
                             "🆔 Apellido: " + apellido + "\n" +
                             "📧 Correo Electrónico: " + correo + "\n\n" +
                             "Si necesitas realizar algún cambio adicional o tienes alguna pregunta, no dudes en contactarnos.\n\n" +
                             "¡Gracias por ser parte de nuestra comunidad de lectores!\n\n" +
                             "Saludos cordiales,\n" +
                             "Equipo de la Biblioteca 📚";

            if (mensaje.Enviar())

                MessageBox.Show("✅ ¡Datos del lector actualizados con éxito! Se ha enviado un correo con la información actualizada. Revisa tu bandeja de entrada y, si no lo encuentras, verifica en la carpeta de SPAM.", "Actualización Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("⚠️ Hubo un problema al enviar el correo. Verifica que la dirección de correo electrónico sea válida e intenta nuevamente.", "Error de Envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void EnvioCorreoCandidatoAceptado(string nombreCandidato, string correoCandidato, string tituloOferta)
        {
            MessageBox.Show("✅ El candidato ha sido notificado. ¡Prepárate para la entrevista!", "Notificación Enviada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            csCorreoElectronico mensaje = new csCorreoElectronico();
            mensaje.Receptor = correoCandidato;
            mensaje.Asunto = "¡Buenas noticias! Tu perfil ha sido seleccionado";

            mensaje.Cuerpo = "Estimado/a " + nombreCandidato + ",\n\n" +
                             "Nos complace informarte que tu perfil ha destacado en el proceso de selección para el puesto de:\n\n" +
                             "🚀 " + tituloOferta + "\n\n" +
                             "La empresa ha revisado tu postulación y está interesada en avanzar contigo a la siguiente etapa (Entrevista).\n" +
                             "Pronto se pondrán en contacto contigo por correo o teléfono para coordinar los detalles.\n\n" +
                             "¡Felicidades y mucho éxito!\n\n" +
                             "Saludos cordiales,\n" +
                             "El equipo de NetWorking 💼";

            if (mensaje.Enviar())
            {
                MessageBox.Show("📧 Se ha enviado un correo al candidato informándole que ha sido seleccionado para la siguiente etapa.", "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("⚠️ Hubo un problema al enviar el correo de notificación. Por favor, verifica la conexión a internet.", "Error de Envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void EnvioCorreoCandidatoRechazado(string nombreCandidato, string correoCandidato, string tituloOferta)
        {
            

            csCorreoElectronico mensaje = new csCorreoElectronico();
            mensaje.Receptor = correoCandidato;
            mensaje.Asunto = "Actualización sobre tu postulación - " + tituloOferta;

            mensaje.Cuerpo = "Hola " + nombreCandidato + ",\n\n" +
                             "Queremos agradecerte por tu interés en la vacante de: " + tituloOferta + ".\n\n" +
                             "Hemos recibido muchas postulaciones de gran calidad y, tras una revisión detallada, la empresa ha decidido avanzar con otros candidatos que se ajustan más específicamente al perfil buscado en este momento.\n\n" +
                             "Sin embargo, te animamos a seguir postulando a otras ofertas en nuestra plataforma. Tu talento es valioso.\n\n" +
                             "Te deseamos lo mejor en tu búsqueda laboral.\n\n" +
                             "Atentamente,\n" +
                             "El equipo de NetWorking 💼";

            if (mensaje.Enviar())
            {
                MessageBox.Show("📧 Se ha enviado un correo de cortesía al candidato informándole sobre el estado de su postulación.", "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("⚠️ No se pudo enviar el correo de notificación.", "Error de Envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
