using ControleSe.Entidade;
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

namespace ControleSe.Operacoes
{
    public partial class DividasForm : Form
    {
        private ServicoDivida _servicoDivida;
        private Usuario _usuario;

        public DividasForm(Usuario usuario, ServicoDivida servicoDivida)
        {
            InitializeComponent();
            _servicoDivida = servicoDivida;
            _usuario = usuario;
            CarregarDividas();
        }

        private void CarregarDividas()
        {
            _servicoDivida = _servicoDivida ?? new ServicoDivida();
            grid.DataSource = _servicoDivida.ObterDividas(_usuario);
        }
    }
}
