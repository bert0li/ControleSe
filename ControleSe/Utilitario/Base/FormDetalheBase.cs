using ControleSe.Utilitario.UtilMensagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSe.Utilitario.Base
{
    public abstract class FormDetalheBase : Form
    {
        public IList<Mensagem> Erros;
    }
}
