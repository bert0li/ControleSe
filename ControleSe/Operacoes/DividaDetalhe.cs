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
    public partial class DividaDetalhe : Form
    {
        private ServicoDivida _servicoDivida;
        private Divida _divida;

        public DividaDetalhe(ServicoDivida servicoDivida, Divida divida)
        {
            InitializeComponent();
            _servicoDivida = servicoDivida;
            _divida = divida;
        }
    }
}
