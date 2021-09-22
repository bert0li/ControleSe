using ControleSe.Entidade;
using ControleSe.Enumerador;
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
            AtribuirBinding(_divida);
        }

        private void InicializarDatas()
        {
            dtpDataCompra.Value = DateTime.Now;
            dtpDataVencimento.Value = DateTime.Now;
            _divida.DataCompra = dtpDataCompra.Value;
            _divida.DataVencimento = dtpDataVencimento.Value;
        }

        private void CarregarCompoBox()
        {
            var tiposDivida = Enum.GetValues(typeof(TipoDivida));
            cbxTipoDivida.DataSource = tiposDivida;
        }

        private void AtribuirBinding(Divida divida)
        {
            InicializarDatas();
            CarregarCompoBox();

            _servicoDivida = _servicoDivida ?? new ServicoDivida();
            _divida = divida ?? new Divida();

            txtNome.DataBindings.Add("Text", _divida, "Nome");
            txtDescricao.DataBindings.Add("Text", _divida, "Descricao");
            dtpDataCompra.DataBindings.Add("Value", _divida, "DataCompra");
            dtpDataVencimento.DataBindings.Add("Value", _divida, "DataVencimento");
            
        }

        private void cbxTipoDivida_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoDivida = (TipoDivida)cbxTipoDivida.SelectedIndex;
            _divida.TipoDivida = tipoDivida;
        }
    }
}
