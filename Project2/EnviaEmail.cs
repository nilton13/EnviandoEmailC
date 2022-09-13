using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class EnviaEmail
    {
        // ENVIANDO EMAILS COM C#
        static void Main(string[] args)
        {
            try
            {
                string Remetente = "abcautomatico@cometasupermercados.com.br";
                string Destinatario = "alvaro.almeida@cometasupermercados.com.br";
                string Assunto = "Testando envio de emails com C#";
                string Enviamensagem = "Alguma coisa de teste.";

                MailMessage mensagemEmail = new MailMessage(Remetente,Destinatario,Assunto,Enviamensagem);


                SmtpClient client = new SmtpClient("mail.cometasupermercados.com.br", 587);
                client.EnableSsl = true;
                NetworkCredential cred = new NetworkCredential("abcautomatico@cometasupermercados.com.br","Cometa@123");
                client.Credentials = cred;

                client.UseDefaultCredentials = true;

                client.Send(mensagemEmail);

                Console.Write("Mensagem enviada para " + Destinatario + " as " + DateTime.Now.ToString() + ".");
            }
            catch(Exception e)
            {

            }
        }


    }
}
