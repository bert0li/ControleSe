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
    public partial class UsuarioDetalheFormNova : Form
    {
        private ServicoUsuario _servico = null;
        private Usuario _usuarioLogado = null;
        private IList<Mensagem> _erros = null;
        public bool EhNovoUsuario = false;

        public UsuarioDetalheFormNova(ServicoUsuario servico, Usuario usuarioLogado, bool ehNovoUsuario = false)
        {
            InitializeComponent();
            _servico = servico;
            _usuarioLogado = usuarioLogado;
            EhNovoUsuario = ehNovoUsuario;
            AtribuirBinding(_usuarioLogado);
        }

        private void AtribuirBinding(Usuario usuarioLogado)
        {
            try
            {
                BloquearLiberarSenha(false);
                _usuarioLogado = usuarioLogado ?? new Usuario();
                _erros = new List<Mensagem>();

                txtCodigo.DataBindings.Add("Text", _usuarioLogado, "Id");
                txtNome.DataBindings.Add("Text", _usuarioLogado, "Nome");
                txtUsuario.DataBindings.Add("Text", _usuarioLogado, "UsuarioAcesso");
                txtSenha.DataBindings.Add("Text", _usuarioLogado, "SenhaAcesso");
                cbxAtivo.DataBindings.Add("Checked", _usuarioLogado, "Ativo");
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

        private void BloquearLiberarSenha(bool liberar)
        {
            txtConfirmarSenha.Text = string.Empty;
            txtConfirmarSenha.Enabled = liberar;
        }

        private void Salvar()
        {
            try
            {
                _erros = _servico.Validar(_usuarioLogado, _erros);

                if (_erros.Count > 0)
                {
                    MensagemUtil.ExibirMensagem("Usuário", _erros);
                }
                else
                {
                    if (_servico.Salvar(_usuarioLogado))
                    {
                        ExibirSplash();

                        if (EhNovoUsuario)
                            Msg.Informacao("Novo usuário cadastrado com sucesso!\nFaça o login com o seu novo usuário (=");

                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message} - [StackTrace]:{ex.StackTrace}");
            }
        }

        private void ExibirSplash()
        {
            using (SalvarSplash formSplah = new())
            {
                formSplah.ShowDialog();
            }
        }

        private bool VerificarIgualdadeSenha()
        {
            bool senhasIguais = false;

            if (txtSenha.Text != txtConfirmarSenha.Text)
                Msg.Atencao("Senhas são diferentes. Digite novamente.");
            else
                senhasIguais = true;

            return senhasIguais;
        }

        private void txtSenha_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                BloquearLiberarSenha(true);
                txtConfirmarSenha.Focus();
            }
        }

        private void txtConfirmarSenha_Validated(object sender, EventArgs e)
        {
            if (!VerificarIgualdadeSenha())
            {
                txtSenha.Focus();
                BloquearLiberarSenha(false);
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e) => AcaoAcionada(e);

        private void btnSalvar_Click(object sender, EventArgs e) => Salvar();

        private void btnSair_Click(object sender, EventArgs e) => Close();

        private void btnFechar_Click(object sender, EventArgs e) => Close();
    }
}