using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSe.Utilitario.UtilMensagem
{
    public partial class MsgForm : Form
    {
        public MsgForm()
        {
            InitializeComponent();
        }

        public void AtribuirBinding(string titulo, IList<Mensagem> erros)
        {
            grid.AutoGenerateColumns = false;
            lblMsgTitulo.Text = titulo;
            grid.DataSource = erros;
            grid.ClearSelection();
        }

        private void btnOk_Click(object sender, EventArgs e) => Close();
    }
}