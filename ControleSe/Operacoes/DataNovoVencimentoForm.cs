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

        public DataNovoVencimentoForm()
        {
            InitializeComponent();
            SetarDataAtual();
        }

        private void SetarDataAtual()
        {
            dtpDataNovoVencimento.Value = DateTime.Now;
        }

        private void SetarNovoVencimento()
        {
            if (dtpDataNovoVencimento.Value != DateTime.MinValue)
            {
                NovoVencimento = dtpDataNovoVencimento.Value;
                Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e) => SetarNovoVencimento();

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void btnFechar_Click(object sender, EventArgs e) => Close();        
    }
}
