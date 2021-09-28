using ControleSe.Utilitario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Servico
{
    public static class ServicoLogErro
    {
        private static DateTime _dataAtual;
        private static string _pastaLog;
        private static string _arquivo;
        private static string _logMsg;

        public static void Gravar(string msg, string stackTrace)
        {
            try
            {
                _dataAtual = DateTime.Now;
                _pastaLog = @"C:\LogErroSentinela";
                _arquivo = @"C:\LogErroSentinela\logErro.txt";
                _logMsg = $"{_dataAtual} ERRO: {msg} \nStackTrace: {stackTrace}";

                VerificarPasta(_pastaLog);
                VerificarArquivo(_arquivo);

                using (StreamWriter writer = File.AppendText(_arquivo))
                {
                    writer.WriteLine(_logMsg);
                    writer.WriteLine("<-----//-----//-----//-----//-----//----- //----->");
                }
            }
            catch (IOException ex)
            {
                Msg.Erro(ex.Message);
            }
        }

        public static void VerificarArquivo(string pasta)
        {
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);
        }

        public static void VerificarPasta(string arquivo)
        {
            if (!File.Exists(arquivo))
                File.Create(arquivo);
        }
    }
}
