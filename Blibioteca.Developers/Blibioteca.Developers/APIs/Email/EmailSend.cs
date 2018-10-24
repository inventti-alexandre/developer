using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca.Developers.APIs.Email
{
    class EmailSend
    {
        public void EnviarEmail(EmailDTO dto)
        {
            var smtp = new SmtpClient("smtp.gmail.com");

            smtp.EnableSsl = true; // GMail requer SSL
            smtp.Port = 587;       // porta para SSL
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
            smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

            // seu usuário e senha para autenticação
            smtp.Credentials = new NetworkCredential(dto.RemetenteEmail, dto.RemetenteSenha);

            MailMessage mail = new MailMessage();

            //mail.Sender = new MailAddress(dto.ReceptorEmail, EmailDTO.remetente);
            mail.From = new MailAddress(dto.RemetenteEmail, dto.RemetenteNome);
            mail.To.Add(new MailAddress(dto.DestinatarioEmail, dto.DestinatarioNome));
            mail.Subject = dto.Assunto;
            mail.Body = dto.Mensagem;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            try
            {
                // envia o e-mail
                smtp.Send(mail);
            }
            catch (Exception erro)
            {
                throw new ArgumentException($"Ocorreu um erro: {erro.Message}");
            }
            finally
            {
                mail = null;
            }
        }

        public int CodEmailVerificar()
        {
            //Ative o modo de envio de email para terceiros na sua conta Gmail, antes de usá-la
            //para enviar emails de verificação.

            //Seu Email
            string email = "";
            //Sua Senha
            string senha = "";
            //Seu nome ou nome da Empresa
            string remetente = "";

            Random codigo = new Random();
            int cod = codigo.Next(111111, 999999);

            EmailDTO dto = new EmailDTO();
            dto.RemetenteNome = remetente;
            dto.RemetenteEmail = email;
            dto.RemetenteSenha = senha;

            EnviarEmail(dto, cod);
            return cod;
        }

        private void EnviarEmail(EmailDTO dto, int CodVerificacao)
        {
            var smtp = new SmtpClient("smtp.gmail.com");

            smtp.EnableSsl = true; // GMail requer SSL
            smtp.Port = 587;       // porta para SSL
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
            smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

            // seu usuário e senha para autenticação
            smtp.Credentials = new NetworkCredential(dto.RemetenteEmail, dto.RemetenteSenha);

            MailMessage mail = new MailMessage();

            //mail.Sender = new MailAddress(dto.ReceptorEmail, EmailDTO.remetente);
            mail.From = new MailAddress(dto.RemetenteEmail, dto.RemetenteNome);
            mail.To.Add(new MailAddress(dto.DestinatarioEmail, dto.DestinatarioNome));
            mail.Subject = $"Codigo de Verificação - {dto.RemetenteNome}";
            mail.Body = bodyEmailVerificacao(CodVerificacao, dto.DestinatarioNome);
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            try
            {
                // envia o e-mail
                smtp.Send(mail);
            }
            catch (Exception erro)
            {
                throw new ArgumentException($"Ocorreu um erro: {erro.Message}");
            }
            finally
            {
                mail = null;
            }
        }

        private string bodyEmailVerificacao(int cod, string nome)
        {
            string body = $@"
<CENTER>
    <h1>PB Technology ©<h1>
</CENTER>
<font>
    <br>
    <p>Olá {nome}, Você está cadastrando-se em nosso sistema, para finalizar seu cadastro informe o código abaixo.</p>
    <p>Seu código de verificação é: {cod}.</p>
    <p>Caso não tenha feito isso, desconsidere este email!</p>
    <br>
    <p>Cordialmente,</p>
    <p>CEO - Pedro Henrique Moreira Martins da Silva</p>
    <p>Program Boys Technology LTDA</p>
</font>";
            return body;
        }
    }
}
