using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSe.Utilitario
{
    static class Msg
    {
        public static void Informacao(string msg)
        {
            MessageBox.Show("Informação", msg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Atencao(string msg)
        {
            MessageBox.Show("Atenção", msg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Erro(string msg)
        {
            MessageBox.Show("Erro", msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Pergunta(string msg)
        {
            return MessageBox.Show("Pergunta", msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}