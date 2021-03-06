using ControleSe.Entidade;
using ControleSe.Servico;
using ControleSe.Utilitario.UtilMensagem;
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
    public partial class UsuarioDetalheForm : Form
    {
        private ServicoUsuario _servico = null;
        private Usuario _usuario = null;

        public UsuarioDetalheForm(ServicoUsuario servico, Usuario usuarioLogado)
        {
            InitializeComponent();
            _servico = servico;
            _usuario = usuarioLogado;
            AtribuirBinding(_usuario);
        }

        private void AtribuirBinding(Usuario usuario)
        {
            try
            {
                BloquearLiberarSenha(false);
                _usuario = usuario ?? new Usuario();

                txtCodigo.DataBindings.Add("Text", _usuario, "Id");
                txtNome.DataBindings.Add("Text", _usuario, "Nome");
                txtUsuario.DataBindings.Add("Text", _usuario, "UsuarioAcesso");
                txtSenha.DataBindings.Add("Text", _usuario, "SenhaAcesso");
                cbxAtivo.DataBindings.Add("Checked", _usuario, "Ativo");
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
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
        
        private void BloquearLiberarSenha(bool liberar)
        {
            txtConfirmarSenha.Text = string.Empty;
            txtConfirmarSenha.Enabled = liberar;
        }

        private void Salvar()
        {
            //try
            //{
            //    if (_servico.Validar(_usuario))
            //    {
            //        if (_servico.Salvar(_usuario))
            //        {
            //            ExibirSplash();
            //            Close();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
            //    Msg.Erro($"[Erro]:{ex.Message} - [StackTrace]:{ex.StackTrace}");
            //}
        }

        private void ExibirSplash()
        {
            using (SalvarSplash formSplah = new())
            {
                formSplah.ShowDialog();
            }
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

        private void btnSalvar_Click(object sender, EventArgs e) => Salvar();

        private void btnSair_Click(object sender, EventArgs e) => Close();
    }
}