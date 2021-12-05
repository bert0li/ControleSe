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
    public partial class DividaDetalheForm : Form
    {
        private ServicoDivida _servicoDivida;
        private Divida _divida;
        private bool PrimeiroBinding = false;

        public DividaDetalheForm(ServicoDivida servicoDivida, Divida divida)
        {
            InitializeComponent();
            _servicoDivida = servicoDivida;
            _divida = divida;
            AtribuirBinding(_divida);
        }

        private void InicializarDatas()
        {
            dtpDataVencimento.Value = DateTime.Now;

            if (_divida.EhIncluir)
                _divida.DataVencimento = dtpDataVencimento.Value;
        }


        /// <summary>
        /// Link com a documentação do código para 
        /// colocar descrição dos enums no ComboBox
        /// https://imasters.com.br/dotnet/populando-um-combobox-com-enumeradores
        /// </summary>
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
            cbxTipoDivida.DataSource = ListarEnum(typeof(TipoDivida));
            cbxTipoDivida.DisplayMember = "Value";
            cbxTipoDivida.ValueMember = "Key";
        }

        private void AtribuirBinding(Divida divida)
        {
            try
            {
                PrimeiroBinding = true;
                _servicoDivida = _servicoDivida ?? new ServicoDivida();
                _divida = divida ?? new Divida();

                InicializarDatas();
                CarregarCompoBox();

                txtCodigo.DataBindings.Add("Text", _divida, "Id");
                txtNome.DataBindings.Add("Text", _divida, "Nome");
                txtDescricao.DataBindings.Add("Text", _divida, "Descricao");
                txtValor.DataBindings.Add("Text", _divida, "Valor");
                dtpDataVencimento.DataBindings.Add("Value", _divida, "DataVencimento");
                cbxTipoDivida.DataBindings.Add("SelectedIndex", _divida, "TipoDivida");
                PrimeiroBinding = false;
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
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
                Msg.Erro($"[Erro]:{ex.Message} - [StackTrace]:{ex.StackTrace}");
            }
        }

        private void cbxTipoDivida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrimeiroBinding) return;

            _divida.TipoDivida = (TipoDivida)cbxTipoDivida.SelectedIndex;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (_divida.Pago != true)
            {
                if (Msg.Pergunta("Deseja realmente pagar?") == DialogResult.Yes)
                {
                    _divida.Pago = true;
                    _divida.DataPagamento = DateTime.Now;

                    if (_servicoDivida.Salvar(_divida))
                    {
                        Msg.Informacao("Divida paga.");
                        Close();
                    }
                }
            }
            else
            {
                Msg.Informacao("Divida já paga.");
            }
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