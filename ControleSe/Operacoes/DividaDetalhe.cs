using ControleSe.Entidade;
using ControleSe.Enumerador;
using ControleSe.Servico;
using ControleSe.Utilitario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        // https://imasters.com.br/dotnet/populando-um-combobox-com-enumeradores
        private string ObterDescricao(Enum valor)
        {
            FieldInfo fieldInfo = valor.GetType().GetField(valor.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description ?? "Nulo" : valor.ToString();
        }

        public IList ListarEnum(Type tipo)
        {
            ArrayList lista = new ArrayList();

            if (tipo != null)
            {
                Array enumValores = Enum.GetValues(tipo);

                foreach (Enum valor in enumValores)
                {
                    lista.Add(new KeyValuePair<Enum, string>(valor, ObterDescricao(valor)));
                }
            }

            return lista;
        }

        private void CarregarCompoBox()
        {
            var tiposDivida = Enum.GetValues(typeof(TipoDivida));
            cbxTipoDivida.DataSource = tiposDivida;

            //cbxTipoDivida.DataSource = ListarEnum(typeof(TipoDivida));
            //cbxTipoDivida.DisplayMember = "Value";
            //cbxTipoDivida.ValueMember = "Key";
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
            // erro aqui
            var tipoDivida = (TipoDivida)cbxTipoDivida.SelectedIndex;
            _divida.TipoDivida = tipoDivida;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
            => Salvar();

        private void btnSair_Click(object sender, EventArgs e)
            => Close();

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;
        }
    }
}
