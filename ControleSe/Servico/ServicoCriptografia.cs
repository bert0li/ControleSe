using ControleSe.Servico.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Servico
{
    public static class ServicoCriptografia
    {
        private static string _chavePublica = "12345678";
        private static string _chaveSecreta = "87654321";
        private static byte[] _chavePublicaByte = { };
        private static byte[] _chaveSecretaByte = { };
        private static MemoryStream _memoryStream = null;
        private static CryptoStream _cryptoStream = null;
        private static byte[] _textoByArray = { };

        public static string Criptografar(string texto)
        {
            try
            {
                string textoCriptografado = string.Empty;
                _chavePublicaByte = Encoding.UTF8.GetBytes(_chavePublica);
                _chaveSecretaByte = Encoding.UTF8.GetBytes(_chaveSecreta);
                _textoByArray = Encoding.UTF8.GetBytes(texto);

                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    _memoryStream = new MemoryStream();
                    _cryptoStream = new CryptoStream(_memoryStream, des.CreateEncryptor(_chavePublicaByte, _chaveSecretaByte), CryptoStreamMode.Write);
                    _cryptoStream.Write(_textoByArray, 0, _textoByArray.Length);
                    _cryptoStream.FlushFinalBlock();
                    textoCriptografado = Convert.ToBase64String(_memoryStream.ToArray());
                }

                return textoCriptografado;
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                return default(string);
            }
        }

        public static string Descriptografar(string texto)
        {
            try
            {
                string textoDescriptografado = string.Empty;
                _chavePublicaByte = Encoding.UTF8.GetBytes(_chavePublica);
                _chaveSecretaByte = Encoding.UTF8.GetBytes(_chaveSecreta);
                _textoByArray = new byte[texto.Replace(" ", "+").Length];
                _textoByArray = Convert.FromBase64String(texto.Replace(" ", "+"));

                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    _memoryStream = new MemoryStream();
                    _cryptoStream = new CryptoStream(_memoryStream, des.CreateDecryptor(_chavePublicaByte, _chaveSecretaByte), CryptoStreamMode.Write);
                    _cryptoStream.Write(_textoByArray, 0, _textoByArray.Length);
                    _cryptoStream.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    textoDescriptografado = encoding.GetString(_memoryStream.ToArray());
                }

                return textoDescriptografado;
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                return default(string);
            }
        }
    }
}
