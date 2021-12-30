﻿using ControleSe.Entidade;
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
    public partial class LoginForm : Form
    {
        private ServicoUsuario _servicoUsuario;
        public Usuario Usuario;

        public LoginForm(ServicoUsuario servicoUsuario, Usuario usuarioLogado)
        {
            InitializeComponent();
            _servicoUsuario = servicoUsuario;
            Usuario = usuarioLogado;
            AtribuirBinding(Usuario);
        }

        private void AtribuirBinding(Usuario usuario)
        {
            _servicoUsuario = _servicoUsuario ?? new ServicoUsuario();
            Usuario = usuario ?? new Usuario();

            txtUsuario.DataBindings.Add("Text", Usuario, "UsuarioAcesso");
            txtSenha.DataBindings.Add("Text", Usuario, "SenhaAcesso");

        }

        private void Entrar()
        {
            try
            {
                if (_servicoUsuario.ValidarLogin(Usuario))
                {
                    var usuario = _servicoUsuario.Logar(Usuario);

                    if (usuario != null)
                    {
                        Usuario = usuario;
                        //ExibirSplas();
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

        private void ExibirSplas()
        {
            using(var form = new LoginSplash())
            {
                form.ShowDialog();
            }
        }

        private void AcaoAcionada(KeyEventArgs e)
        {
            if (txtUsuario.Focused)
            {
                if (e.KeyData == Keys.Enter)
                {
                    txtSenha.Focus();
                    return;
                }
            }

            if (txtSenha.Focused)
            {
                if (e.KeyData == Keys.Enter)
                {
                    btnEntrar.PerformClick();
                    return;
                }
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
            => AcaoAcionada(e);

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
            => AcaoAcionada(e);

        private void btnEntrar_Click(object sender, EventArgs e)
            => Entrar();

        private void btnCancelar_Click(object sender, EventArgs e)
            => Close();
    }
}