using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace envio_de_correos
{
    class Program
    {
        static void Main(string[] args)
        {

            string adjuntojardin = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/JARDIN.pdf";
            string adjuntotransicion = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/TRANSICION.pdf";
            string adjunto1a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/1A.pdf";
            string adjunto1b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/1B.pdf";
            string adjunto2a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/2A.pdf";
            string adjunto2b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/2B.pdf";
            string adjunto3a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/3A.pdf";
            string adjunto3b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/3B.pdf";
            string adjunto4a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/4A.pdf";
            string adjunto4b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/4B.pdf";
            string adjunto4c = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/4C.pdf";
            string adjunto5a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/5A.pdf";
            string adjunto5b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/5B.pdf";
            string adjunto5c = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/5C.pdf";
            string adjunto6a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/6A.pdf";
            string adjunto6b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/6B.pdf";
            string adjunto7a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/7A.pdf";
            string adjunto7b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/7B.pdf";
            string adjunto8a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/8A.pdf";
            string adjunto8b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/8B.pdf";
            string adjunto8c = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/8C.pdf";
            string adjunto8d = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/8D.pdf";
            string adjunto9a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/9A.pdf";
            string adjunto9b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/9B.pdf";
            string adjunto9c = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/9C.pdf";
            string adjunto10a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/10A.pdf";
            string adjunto10b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/10B.pdf";
            string adjunto10c = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/10C.pdf";
            string adjunto10d = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/10D.pdf";
            string adjunto11a = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/11A.pdf";
            string adjunto11b = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/11B.pdf";
            string adjunto11c = "C:/Users/FULLSTACK DEV/Documents/BACKUP/Colsafe/2021/Clases Virtuales/RECORDATORIOS/11C.pdf";

            List<Curso> lista = new List<Curso>()
            {

                new Curso() { correo = "jardingrado@colsafe.edu.co", contraseña = "csf-jardin", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-jardin@colsafe.edu.co", asunto ="RECORDATORIO DIARIO JRº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjuntojardin },
                new Curso() { correo = "transiciongrado@colsafe.edu.co", contraseña = "csf-transicion", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-transicion@colsafe.edu.co", asunto ="RECORDATORIO DIARIO TRº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjuntotransicion },
                new Curso() { correo = "primero-a@colsafe.edu.co", contraseña = "csf-primero-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-primero-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 1Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto1a },
                new Curso() { correo = "primero-b@colsafe.edu.co", contraseña = "csf-primero-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-primero-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 1Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto1b },
                new Curso() { correo = "segundo-a@colsafe.edu.co", contraseña = "csf-segundo-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-segundo-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 2Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto2a },
                new Curso() { correo = "segundo-b@colsafe.edu.co", contraseña = "csf-segundo-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-segundo-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 2Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto2b },
                new Curso() { correo = "tercero-a@colsafe.edu.co", contraseña = "csf-tercero-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-tercero-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 3Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto3a },
                new Curso() { correo = "tercero-b@colsafe.edu.co", contraseña = "csf-tercero-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-tercero-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 3Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto3b },
                new Curso() { correo = "cuarto-a@colsafe.edu.co", contraseña = "csf-cuarto-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-cuarto-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 4Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto4a },
                new Curso() { correo = "cuarto-b@colsafe.edu.co", contraseña = "csf-cuarto-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-cuarto-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 4Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto4b },
                new Curso() { correo = "cuarto-c@colsafe.edu.co", contraseña = "csf-cuarto-c", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-cuarto-c@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 4Cº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto4c },
                new Curso() { correo = "quinto-a@colsafe.edu.co", contraseña = "csf-quinto-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-quinto-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 5Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto5a },
                new Curso() { correo = "quinto-b@colsafe.edu.co", contraseña = "csf-quinto-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-quinto-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 5Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto5b },
                new Curso() { correo = "quinto-c@colsafe.edu.co", contraseña = "csf-quinto-c", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-quinto-c@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 5Cº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto5c },
                new Curso() { correo = "sexto-a@colsafe.edu.co", contraseña = "csf-sexto-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-sexto-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 6Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto6a },
                new Curso() { correo = "sexto-b@colsafe.edu.co", contraseña = "csf-sexto-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-sexto-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 6Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto6b },
                new Curso() { correo = "septimo-a@colsafe.edu.co", contraseña = "csf-septimo-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-septimo-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 7Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto7a },
                new Curso() { correo = "septimo-b@colsafe.edu.co", contraseña = "csf-septimo-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-septimo-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 7Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto7b },
                new Curso() { correo = "octavo-a@colsafe.edu.co", contraseña = "csf-octavo-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-octavo-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 8Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto8a },
                new Curso() { correo = "octavo-b@colsafe.edu.co", contraseña = "csf-octavo-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-octavo-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 8Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto8b },
                new Curso() { correo = "octavo-c@colsafe.edu.co", contraseña = "csf-octavo-c", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-octavo-c@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 8Cº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto8c },
                new Curso() { correo = "octavo-d@colsafe.edu.co", contraseña = "csf-octavo-d", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-octavo-d@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 8Dº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto8d },
                new Curso() { correo = "noveno-a@colsafe.edu.co", contraseña = "csf-noveno-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-noveno-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 9Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto9a },
                new Curso() { correo = "noveno-b@colsafe.edu.co", contraseña = "csf-noveno-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-noveno-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 9Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto9b },
                new Curso() { correo = "noveno-c@colsafe.edu.co", contraseña = "csf-noveno-c", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-noveno-c@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 9Cº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto9c },
                new Curso() { correo = "decimo-a@colsafe.edu.co", contraseña = "csf-decimo-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-decimo-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 10Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto10a },
                new Curso() { correo = "decimo-b@colsafe.edu.co", contraseña = "csf-decimo-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-decimo-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 10Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto10b },
                new Curso() { correo = "decimo-c@colsafe.edu.co", contraseña = "csf-decimo-c", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-decimo-c@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 10Cº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto10c },
                new Curso() { correo = "decimo-d@colsafe.edu.co", contraseña = "csf-decimo-d", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-decimo-d@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 10Dº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto10d },
                new Curso() { correo = "undecimo-a@colsafe.edu.co", contraseña = "csf-undecimo-a", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-undecimo-a@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 11Aº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto11a },
                new Curso() { correo = "undecimo-b@colsafe.edu.co", contraseña = "csf-undecimo-b", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-undecimo-b@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 11Bº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto11b },
                new Curso() { correo = "undecimo-c@colsafe.edu.co", contraseña = "csf-undecimo-c", nombre = "RECORDATORIO CLASES VIRTUALES", destinatario = "correos-undecimo-c@colsafe.edu.co", asunto ="RECORDATORIO DIARIO 11Cº - LINKS DE ACCESO A CLASES VIRTUALES" ,adjunto = adjunto11c },


            };

            foreach (Curso curso  in lista)
            {
                Enviar(curso.correo, curso.contraseña, curso.nombre, curso.destinatario, curso.asunto, curso.adjunto);
                Console.WriteLine($"{curso.correo}");
            }


                Console.ReadKey();
        }


        static void Enviar(string remitente, string clave, string nombre, string destinatario, string asunto, string adjunto)
        {
            try
            {

                string host = "smtp.gmail.com";
                int puerto = 587;

                SmtpClient cliente = new SmtpClient(host, puerto);
                MailMessage correo = new MailMessage();

                correo.From = new MailAddress(remitente, nombre);
                correo.Body = "LINK DE ACCESO A CLASES VIRTUALES";
                correo.Subject = asunto;
                correo.To.Add(destinatario);
                System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(adjunto);
                attachment.Name = "RECORDATORIO DIARIO.PDF";
                correo.Attachments.Add(attachment);

                cliente.Credentials = new NetworkCredential(remitente, clave);
                cliente.EnableSsl = true;
                cliente.Send(correo);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

        }



        public class Curso
        {
            public string correo { get; set; }
            public string contraseña { get; set; }
            public string nombre { get; set; }
            public string destinatario { get; set; }
            public string asunto { get; set; }
            public string adjunto { get; set; }
        }

    }
}
