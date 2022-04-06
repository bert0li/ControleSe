using ControleSe.Utilitario.UtilMensagem;
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
    public partial class DataNovoVencimentoForm : Form
    {
        public DateTime NovoVencimento;
        private IList<Mensagem> _erros = null;

        public DataNovoVencimentoForm()
        {
            InitializeComponent();
            SetarDataAtual();
            _erros = new List<Mensagem>();
        }

        private void SetarDataAtual() => dtpDataNovoVencimento.Value = DateTime.Now;

        private void SetarNovoVencimento()
        {
            if (dtpDataNovoVencimento.Value != DateTime.MinValue)
            {
                NovoVencimento = dtpDataNovoVencimento.Value;
                Close();
            }
            else
            {
                _erros.Clear();
                _erros.Add(new Mensagem("Informe uma data válida."));
                //MensagemUtil.ExibirMensagem("Novo vencimento", _erros);
                //Msg.Informacao("Informe uma data válida.");
                dtpDataNovoVencimento.Focus();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e) => SetarNovoVencimento();

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void btnFechar_Click(object sender, EventArgs e) => Close();        
    }
}
