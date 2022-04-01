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
    public partial class EmailDetalheFormNova : Form
    {
        private ServicoEmail _servico = null;
        private Usuario _usuarioLogado = null;

        public EmailDetalheFormNova(ServicoEmail servico, Usuario usuarioLogado)
        {
            InitializeComponent();
            _servico = servico;
            _usuarioLogado = usuarioLogado;
            AtribuirBinding(_usuarioLogado);
        }

        private void AtribuirBinding(Usuario usuairoLogado)
        {
            try
            {
                _usuarioLogado = usuairoLogado ?? new Usuario();
                _usuarioLogado.Email = usuairoLogado.Email ?? new Email();

                txtSmtp.DataBindings.Add("Text", _usuarioLogado.Email, "Smtp");
                txtPorta.DataBindings.Add("Text", _usuarioLogado.Email, "Porta");
                cbxSsl.DataBindings.Add("Checked", _usuarioLogado.Email, "Ssl");
                txtEmail.DataBindings.Add("Text", _usuarioLogado.Email, "EnderecoEmail");
                txtSenha.DataBindings.Add("Text", _usuarioLogado.Email, "SenhaEmail");
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[ERRO]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void ExibirSplash()
        {
            using (SalvarSplash formSplah = new())
            {
                formSplah.ShowDialog();
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

        private void Salvar()
        {
            try
            {
                if (_servico.Validar(_usuarioLogado.Email))
                {
                    if (_servico.Salvar(_usuarioLogado.Email, _usuarioLogado))
                    {
                        ExibirSplash();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[ERRO]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e) => Close();        

        private void btnSalvar_Click(object sender, EventArgs e) => Salvar();

        private void btnSair_Click(object sender, EventArgs e) => Close();

        private void txtSmtp_KeyDown(object sender, KeyEventArgs e) => AcaoAcionada(e);
    }
}
