using ControleSe.Entidade;
using ControleSe.Operacoes;
using ControleSe.Servico;
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
        private Usuario _usuario;

        public MenuPrincipalForm(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDividas_Click(object sender, EventArgs e)
        {
            using (var form = new DividasFormNova(_usuario, new ServicoDivida()))
            {
                form.ShowDialog();
            }
        }
    }
}
