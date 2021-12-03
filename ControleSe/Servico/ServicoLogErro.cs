using ControleSe.Utilitario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Servico
{
    public class ServicoLogErro
    {
        public static DateTime DataAtual { get; set; }
        public static string Pasta { get; set; }
        public static string Arquivo { get; set; }
        public static string MsgLog { get; set; }

        public static void Gravar(string mensagem, string stackTrace)
        {
            try
            {
                DataAtual = DateTime.Now;
                Pasta = @"C:\LogErroControleSe";
                Arquivo = @"C:\LogErroControleSe\LogErro.txt";
                MsgLog = $"[{DataAtual}] [MENSAGEM ERRO]=> {mensagem} [StackTrace] => {stackTrace}";

                VerificarPasta(Pasta);
                VerificarArquivo(Arquivo);

                using (StreamWriter writer = File.AppendText(Arquivo))
                {
                    writer.WriteLine(MsgLog);
                    writer.WriteLine("-----//-----//-----//-----");
                }
            }
            catch (IOException ex)
            {
                Msg.Erro($"Erro ao gravar o arquivo de LOG:\n{ex.Message}\n{ex.StackTrace}");
            }
        }

        public static void VerificarArquivo(string arquivo)
        {
            if (!File.Exists(arquivo))
                File.Create(arquivo);
        }

        public static void VerificarPasta(string pasta)
        {
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);
        }
    }
}
