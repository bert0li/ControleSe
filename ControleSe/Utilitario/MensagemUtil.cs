using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSe.Utilitario
{
    public static class MensagemUtil
    {
        private static MsgForm _msgForm = null;

        public static DialogResult ExibirMensagem(string titulo, IList<Mensagem> mensagens)
        {
            if (_msgForm is null)
                _msgForm = new MsgForm();

            _msgForm.AtribuirDataSourceGrid(titulo, mensagens);

            return _msgForm.ShowDialog();
        }
    }
}
