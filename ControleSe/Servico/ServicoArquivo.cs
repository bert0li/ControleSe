﻿using ControleSe.Entidade;
using ControleSe.Servico.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Servico
{
    public class ServicoArquivo : ServicoBase
    {
        private string _localPadrao = @"C:\Users\Public\Documents\";
        private DateTime _dataDividaPaga;
        private string _diaDividaPaga = null;
        private string _mesDividaPaga = null;
        private string _anoDividaPaga = null;
        private string _nomePasta = null;
        private string _nomeSubPasta = null;
        private string _nomeArquivo = null;
        private string _nomeDivida = null;
        private StreamWriter _stringWriter = null;
        private Divida _divida = null;


        public void GravarArquivoDividaPaga(Divida divida)
        {
            _divida = divida;
            _dataDividaPaga = Convert.ToDateTime(_divida.DataPagamento).Date;
            _diaDividaPaga = _dataDividaPaga.Day.ToString();
            _mesDividaPaga = _dataDividaPaga.Month.ToString();
            _anoDividaPaga = _dataDividaPaga.Year.ToString();
            _nomeDivida = _divida.Nome;
            _nomePasta = "ControleSe";
            _nomeSubPasta = $"{_diaDividaPaga}-{_mesDividaPaga}-{_anoDividaPaga}";
            _nomeArquivo = $"{_nomeDivida}-{_diaDividaPaga}-{_mesDividaPaga}-{_anoDividaPaga}";
            VerificarSeExistePastaRoot(_nomePasta);
        }

        private void VerificarSeExisteSubPasta(string subPasta)
        {
            string localArquivo = $@"{subPasta}\{_nomeArquivo}.txt";

            if (Directory.Exists(subPasta))
            {
                VerificarArquivo(localArquivo);
            }
            else
            {
                Directory.CreateDirectory(subPasta);
                VerificarArquivo(localArquivo);
            }
        }

        private void VerificarSeExistePastaRoot(string pastaRoot)
        {
            string localPasta = string.Concat(_localPadrao, pastaRoot);

            if (Directory.Exists(localPasta))
            {
                string caminhoComSubPasta = $@"{localPasta}\{_nomeSubPasta}";
                VerificarSeExisteSubPasta(caminhoComSubPasta);
            }
            else
            {
                Directory.CreateDirectory(localPasta);
                VerificarSeExisteSubPasta(_nomeSubPasta);
            }
        }

        private void VerificarArquivo(string arquivoTexto)
        {
            if (!File.Exists(arquivoTexto))
                _stringWriter = File.CreateText(arquivoTexto); // cria e já abre o arquivo para inserir as info.

            EscreverArquivo(_stringWriter);
        }

        private void EscreverArquivo(StreamWriter streamWriter)
        {
            streamWriter.WriteLine("---------------------------------------------");
            streamWriter.WriteLine("- DIVIDA PAGA");
            streamWriter.WriteLine("---------------------------------------------");
            streamWriter.WriteLine($"- Nome da divida: {_divida.Nome}");
            streamWriter.WriteLine($"- Valor: R$ {_divida.Valor}");
            streamWriter.WriteLine($"- Data do pagamento: {Convert.ToDateTime(_divida.DataPagamento).ToShortDateString()}");
            streamWriter.WriteLine($"- Data do vencimento: {_divida.DataVencimento.ToShortDateString()}");
            streamWriter.WriteLine("---------------------------------------------");
            streamWriter.Close();
        }
    }
}