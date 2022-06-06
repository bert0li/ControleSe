using ControleSe.Entidade;
using ControleSe.Servico;
using ControleSe.Utilitario;
using ControleSe.Utilitario.Base;
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
    public partial class ConfirmarSenhaUsuarioForm : FormDetalheBase
    {
        private ServicoUsuario _servico = null;
        private Usuario _usuario = null;
        public bool EhValido = false;
        //private IList<Mensagem> _erros = null;

        public ConfirmarSenhaUsuarioForm(Usuario usuarioLogado, ServicoUsuario servicoUsuario)
        {
            InitializeComponent();
            _usuario = usuarioLogado;
            _servico = servicoUsuario;
            //_erros = new List<Mensagem>();
            Erros = new List<Mensagem>();
        }

        private void VerificarSenhaSegurança()
        {
            try
            {
                if(!string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    Erros = _servico.VerificarSenhaSegurança(_usuario, txtSenha.Text, Erros);

                    if (Erros.Count > 0)
                    {
                        MensagemUtil.ExibirMensagem("Confirmação de senha", Erros);
                        //Msg.Informacao("Senha inválida.");
                        txtSenha.Focus();
                        txtSenha.SelectAll();
                    }
                    else
                    {
                        Close();
                        EhValido = true;
                    }
                }
                //else
                //{
                //    Erros.Clear();
                //    Erros.Add(new Mensagem("Informe a senha do seu usuário."));
                //    MensagemUtil.ExibirMensagem("Confirmação de senha", Erros);
                //    //Msg.Informacao("Informe a senha do seu usuário.");
                //    txtSenha.Focus();
                //}
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e) => VerificarSenhaSegurança();

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnConfirmar.PerformClick();
        }

        private void btnFechar_Click(object sender, EventArgs e) => Close();        
    }
}
