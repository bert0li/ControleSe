using ControleSe.Entidade;
using ControleSe.Servico;
using ControleSe.Utilitario;
using ControleSe.Utilitario.Splash;
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
    public partial class EntradaDetalheFormNova : Form
    {
        private ServicoEntrada _servico = null;
        private Entrada _entrada = null;
        private Usuario _usuario = null;

        public EntradaDetalheFormNova(ServicoEntrada servicoEntrada, Entrada entrada, Usuario usuarioLogado)
        {
            InitializeComponent();
            _servico = servicoEntrada;
            _entrada = entrada;
            _usuario = usuarioLogado;
            IncluirLabelInformacao();
            AtribuirBinding();
        }

        private void IncluirLabelInformacao() => lblInformacao.Text = "Atenção!!\nApós a inclusão da entrada não é possível alterar, somente exluir.";

        private void AtribuirBinding()
        {
            try
            {
                _servico = _servico ?? new ServicoEntrada();

                txtValorEntrada.DataBindings.Add("Text", _entrada, "ValorEntrada");
                txtObservacao.DataBindings.Add("Text", _entrada, "Observacao");
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void AcaoAcionada(KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                btnSalvar.PerformClick();
                return;
            }

            if (e.KeyData == Keys.Escape)
            {
                btnSair.PerformClick();
                return;
            }
        }

        private void ExibirSplash()
        {
            using (SalvarSplash formSplah = new())
            {
                formSplah.ShowDialog();
            }
        }

        private void Salvar()
        {
            try
            {
                if (_servico.Validar(_entrada))
                {
                    if (_servico.Salvar(_entrada, _usuario))
                    {
                        ExibirSplash();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void txtValorEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;
        }

        private void txtValorEntrada_KeyDown(object sender, KeyEventArgs e) => AcaoAcionada(e);

        private void btnSalvar_Click(object sender, EventArgs e) => Salvar();

        private void btnSair_Click(object sender, EventArgs e) => Close();

        private void btnFechar_Click(object sender, EventArgs e) => Close();
    }
}