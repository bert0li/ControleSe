using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Utilitario
{
    public class Mensagem
    {
        public string TextMensagem { get; set; }
        public Bitmap Icone { get; set; }

        public Mensagem( string textoMensagem)
        {
            TextMensagem = textoMensagem;
            Icone = Properties.Resources.alerta;
        }
    }
}
