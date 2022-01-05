using ControleSe.Entidade;
using ControleSe.Operacoes;
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

namespace ControleSe
{
    public partial class MenuPrincipalForm : Form
    {
        private Usuario _usuario = null;
        private Timer _timer = null;

        public MenuPrincipalForm(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            SetarUsuarioLogado();
            SetarDataHoraAtual();
        }

        private void SetarUsuarioLogado()
        {
            lblRodapeUsuarioLogado.Text = $"Usuário: {_usuario.UsuarioAcesso}";
        }

        private void SetarDataHoraAtual()
        {
            _timer = new Timer() { Interval = 1000 };
            _timer.Start();
            _timer.Tick += (o, e) =>
            {
                lblRodapeDataHora.Text = DateTime.Now.ToString();
            };
        }

        private void btnDividas_Click(object sender, EventArgs e)
        {
            using (var form = new DividasFormNova(_usuario, new ServicoDivida()))
            {
                form.ShowDialog();
            }
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            using (var form = new EntradasFormNova(_usuario, new ServicoEntrada()))
            {
                form.ShowDialog();
            }
        }

        private void btnCofre_Click(object sender, EventArgs e)
        {
            bool EhValido = false;

            using (var form = new ConfirmarSenhaUsuarioForm(_usuario, new ServicoUsuario()))
            {
                form.ShowDialog();
                EhValido = form.EhValido;
            }

            if (EhValido)
            {
                using (var form = new CofreForm(_usuario, new ServicoCofre()))
                {
                    form.ShowDialog();
                }
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Msg.Informacao("Recurso em desenvolvimento");
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            using (var form = new UsuariosFormNova(_usuario, new ServicoUsuario()))
            {
                form.ShowDialog();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnFechar_Click(object sender, EventArgs e) => Close();
    }
}