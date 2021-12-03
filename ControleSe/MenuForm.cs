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
            using (var form = new UsuariosForm(new ServicoUsuario()))
            {
                form.ShowDialog();
            }
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            Msg.Informacao("Este recurso esta em desenvolvimento.");
        }
    }
}
