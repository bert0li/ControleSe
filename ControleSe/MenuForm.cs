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
    public partial class MenuForm : Form
    {
        private Usuario _usuario;
        public MenuForm(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            SetarDataHoraAtual();
        }

        private void SetarDataHoraAtual()
        {
            Timer timer = new Timer() { Interval = 1000 };
            timer.Start();
            timer.Tick += (a, b) =>
            {
                lblHora.Text = DateTime.Now.ToShortTimeString();
                lblData.Text = DateTime.Now.ToShortDateString();
            };
        }

        private void dividasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new DividasForm(_usuario, new ServicoDivida()))
            {
                form.ShowDialog();
            }
        }

        private void btnDividas_Click(object sender, EventArgs e)
        {
            using (var form = new DividasForm(_usuario, new ServicoDivida()))
            {
                form.ShowDialog();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            using (var form = new UsuariosForm(_usuario, new ServicoUsuario()))
            {
                form.ShowDialog();
            }
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            using (var form = new EntradasForm(_usuario, new ServicoEntrada()))
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
            Msg.Informacao("Recurso em desenvolvimento.");
        }
    }
}
