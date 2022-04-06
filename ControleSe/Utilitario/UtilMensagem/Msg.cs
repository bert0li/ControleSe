using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSe.Utilitario.UtilMensagem
{
    static class Msg
    {
        public static void Informacao(string msg)
        {
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Atencao(string msg)
        {
            MessageBox.Show(msg, "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Erro(string msg)
        {
            MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Pergunta(string msg)
        {
            return MessageBox.Show(msg, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}