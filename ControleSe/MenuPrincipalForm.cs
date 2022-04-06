using ControleSe.Entidade;
using ControleSe.Operacoes;
using ControleSe.Servico;
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

namespace ControleSe
{
    public partial class MenuPrincipalForm : Form
    {
        private Usuario _usuarioLogado = null;
        private Timer _timer = null;
        private ServicoPermissao _servicoPermissao = null;

        public MenuPrincipalForm(Usuario usuario)
        {
            InitializeComponent();
            InicializarSevicoPermissao();
            _usuarioLogado = usuario;
            AplicarPermissaoBotoes(_usuarioLogado);
            SetarUsuarioLogado();
            SetarDataHoraAtual();
        }

        private void SetarUsuarioLogado() => lblRodapeUsuarioLogado.Text = $"Usuário: {_usuarioLogado.UsuarioAcesso}";

        private void InicializarSevicoPermissao() => _servicoPermissao = _servicoPermissao ?? new ServicoPermissao();

        private void SetarDataHoraAtual()
        {
            _timer = new Timer() { Interval = 1000 };
            _timer.Start();
            _timer.Tick += (o, e) =>
            {
                lblRodapeDataHora.Text = DateTime.Now.ToString();
            };
        }

        private void AplicarPermissaoBotoes(Usuario usuarioLogado)
        {
            try
            {
                bool ehAdm = _servicoPermissao.VerificarSeUsusarioEhAdm(usuarioLogado);

                if (!ehAdm)
                {
                    btnUsuarios.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void btnDividas_Click(object sender, EventArgs e)
        {
            using (var form = new DividasFormNova(_usuarioLogado, new ServicoDivida()))
            {
                form.ShowDialog();
            }
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            using (var form = new EntradasFormNova(_usuarioLogado, new ServicoEntrada()))
            {
                form.ShowDialog();
            }
        }

        private void btnCofre_Click(object sender, EventArgs e)
        {
            bool EhValido = false;

            using (var form = new ConfirmarSenhaUsuarioForm(_usuarioLogado, new ServicoUsuario()))
            {
                form.ShowDialog();
                EhValido = form.EhValido;
            }

            if (EhValido)
            {
                using (var form = new CofreForm(_usuarioLogado, new ServicoCofre()))
                {
                    form.ShowDialog();
                }
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Msg.Informacao("Recurso em desenvolvimento");
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            using (var form = new EmailDetalheFormNova(new ServicoEmail(), _usuarioLogado))
            {
                form.ShowDialog();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            using (var form = new UsuariosFormNova(_usuarioLogado, new ServicoUsuario()))
            {
                form.ShowDialog();
            }
        }

        private void lblLogoff_Click(object sender, EventArgs e) => Application.Restart();

        private void btnMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnFechar_Click(object sender, EventArgs e) => Close();
    }
}