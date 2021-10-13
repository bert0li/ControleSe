using ControleSe.Entidade;
using ControleSe.Enumerador;
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

            if (_divida.EhIncluir)
            {
                _divida.DataCompra = dtpDataCompra.Value;
                _divida.DataVencimento = dtpDataVencimento.Value;
            }
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

            txtCodigo.DataBindings.Add("Text", _divida, "Id");
            txtNome.DataBindings.Add("Text", _divida, "Nome");
            txtDescricao.DataBindings.Add("Text", _divida, "Descricao");
            txtValor.DataBindings.Add("Text", _divida, "Valor");
            dtpDataCompra.DataBindings.Add("Value", _divida, "DataCompra");
            dtpDataVencimento.DataBindings.Add("Value", _divida, "DataVencimento");

        }

        private void Salvar()
        {
            try
            {
                if (_servicoDivida.Validar(_divida))
                {
                    if (_servicoDivida.Salvar(_divida))
                    {
                        Msg.Informacao("Divida salva.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro(ex.Message);
            }
        }

        private void cbxTipoDivida_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoDivida = (TipoDivida)cbxTipoDivida.SelectedIndex;
            _divida.TipoDivida = tipoDivida;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
            => Salvar();

        private void btnSair_Click(object sender, EventArgs e)
            => Close();
    }
}
