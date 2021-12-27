using ControleSe.Entidade;
using ControleSe.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSe.Operacoes
{
    public partial class EntradasForm : Form
    {
        private ServicoEntrada _servico = null;
        private Usuario _usuario = null;
        private Entrada _entrada = null;

        public EntradasForm(Usuario usuarioLogado, ServicoEntrada servicoEntrada)
        {
            InitializeComponent();
            _usuario = usuarioLogado;
            _servico = servicoEntrada;
        }
    }
}
