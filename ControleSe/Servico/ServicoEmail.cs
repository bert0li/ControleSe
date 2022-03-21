using ControleSe.Entidade;
using ControleSe.Repositorio.Contexto;
using ControleSe.Servico.Base;
using ControleSe.Utilitario;
using ControleSe.Utilitario.Splash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ControleSe.Servico
{
    public class ServicoEmail : ServicoBase
    {
        public bool Validar(Email email)
        {
            if (email is not null)
            {
                if (string.IsNullOrWhiteSpace(email.Smtp))
                {
                    Msg.Atencao("Informe o servidor Smtp.");
                    EhValido = false;
                }
                else if (email.Porta < 0)
                {
                    Msg.Atencao("Informe a Porta.");
                    EhValido = false;
                }
                else if (string.IsNullOrWhiteSpace(email.EnderecoEmail))
                {
                    Msg.Atencao("Informe o E-mail.");
                    EhValido = false;
                }
                else if (!ValidarEmail(email.EnderecoEmail))
                {
                    Msg.Atencao("Informe um e-mail valido.");
                    EhValido = false;
                }
                else if (string.IsNullOrWhiteSpace(email.SenhaEmail))
                {
                    Msg.Atencao("Informe a senha.");
                    EhValido = false;
                }
                else
                {
                    EhValido = true;
                }
            }

            return EhValido;
        }

        public bool Salvar(Email email, Usuario usuarioLogado)
        {
            try
            {
                EhValido = false;

                using (var contexto = new Contexto())
                {
                    if (email is not null)
                    {
                        if (email.Id is 0)
                        {
                            email.UsuarioId = usuarioLogado.Id;
                            contexto.Email.Add(email);
                        }
                        else
                        {
                            contexto.Email.Update(email);
                        }

                        contexto.SaveChanges();
                        EhValido = true;
                    }
                }

                return EhValido;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool ValidarEmail(string email)
        {
            EhValido = false;

            if (string.IsNullOrWhiteSpace(email))
                return EhValido;
            else
                EhValido = new Regex(@"^([\w\-]+\.)*[\w\- ]+@([\w\- ]+\.)+([\w\-]{2,3})$").IsMatch(email);

            return EhValido;
        }

        public async Task EnviarEmailAsync(Email email, Divida divida)
        {
            try
            {
                using (var smptClient = new SmtpClient())
                {
                    using (var mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress(email.EnderecoEmail);
                        mailMessage.Subject = "ControleSe - DIVIDA PAGA";
                        
                        mailMessage.Body = $"<b>Divida paga</b>: {divida.Nome}</br>" +
                                           $"<b>Valor</b>: {divida.Valor.ToString("C")}</br>" +
                                           $"<b>Data do pagamento</b>: {divida.DataPagamento}</br>" +
                                           $"<b>Data do vencimento</b>: {divida.DataVencimento.ToShortDateString()}";
                        
                        mailMessage.IsBodyHtml = true;
                        mailMessage.To.Add(email.EnderecoEmail);

                        smptClient.Host = email.Smtp;
                        smptClient.Port = email.Porta;
                        smptClient.EnableSsl = email.Ssl;
                        //smptClient.Timeout = 2;
                        smptClient.UseDefaultCredentials = false;
                        smptClient.Credentials = new NetworkCredential(email.EnderecoEmail, email.SenhaEmail);

                        await smptClient.SendMailAsync(mailMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro("Falha no envio de e-mail.\nVerifique as configurações de e-mail cadastrada.\nConsulte o log para ter mais detalhes.");
            }
        }
    }
}