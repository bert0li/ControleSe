using ControleSe.Entidade;
using ControleSe.Servico;
using ControleSe.Utilitario;
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
    public partial class ConfirmarSenhaUsuarioForm : Form
    {
        private ServicoUsuario _servico = null;
        private Usuario _usuario = null;
        public bool EhValido = false;

        public ConfirmarSenhaUsuarioForm(Usuario usuarioLogado, ServicoUsuario servicoUsuario)
        {
            InitializeComponent();
            _usuario = usuarioLogado;
            _servico = servicoUsuario;
        }

        private void VerificarSenhaSegurança()
        {
            try
            {
                if(!string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    EhValido = _servico.VerificarSenhaSegurança(_usuario, txtSenha.Text);

                    if (EhValido)
                    {
                        Close();
                    }
                    else
                    {
                        Msg.Informacao("Senha invalida.");
                        txtSenha.Focus();
                        txtSenha.SelectAll();
                    }
                }
                else
                {
                    Msg.Informacao("Informe a senha do seu usuário.");
                    txtSenha.Focus();
                }
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
    }
}
