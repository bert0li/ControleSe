using ControleSe.Entidade;
using ControleSe.Enumerador;
using ControleSe.Servico;
using ControleSe.Utilitario;
using ControleSe.Utilitario.Splash;
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
    public partial class DividaDetalheFormNova : Form
    {
        private ServicoDivida _servico = null;
        private Divida _divida = null;
        private Usuario _usuario = null;
        private bool PrimeiroBinding = false;
        private DateTime _dataNovoVencimento;

        public DividaDetalheFormNova(ServicoDivida servicoDivida, Divida divida, Usuario usuarioLogado)
        {
            InitializeComponent();
            _servico = servicoDivida;
            _divida = divida;
            _usuario = usuarioLogado;
            AtribuirBinding();
            VerificarSePodePagar();
        }

        private void InicializarDatas()
        {
            dtpDataVencimento.Value = DateTime.Now;

            if (_divida.EhIncluir)
                _divida.DataVencimento = dtpDataVencimento.Value;
        }

        private void VerificarSePodePagar() 
        {
            btnPagar.Enabled = _divida.Id == 0 ? false : true;
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

        private void AtribuirBinding()
        {
            try
            {
                PrimeiroBinding = true;
                _servico = _servico ?? new ServicoDivida();

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

        private void AcaoAcionada(KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                btnSalvar.PerformClick();
                return;
            }

            if (e.KeyData == Keys.Escape)
            {
                btnSair.PerformClick();
                return;
            }
        }

        private void Salvar()
        {
            try
            {
                if (_servico.Validar(_divida))
                {
                    if (_servico.Salvar(_divida))
                    {
                        ExibirSplash();
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

        private void ExibirSplash()
        {
            using (var formSplah = new SalvarSplash())
            {
                formSplah.ShowDialog();
            }
        }

        private void Pagar()
        {
            try
            {
                if (_divida.Pago != true)
                {
                    if (Msg.Pergunta("Deseja realmente pagar?") == DialogResult.Yes)
                    {
                        if (_servico.Pagar(_divida, _usuario))
                        {
                            Msg.Informacao("Divida paga.");

                            if (_divida.TipoDivida == TipoDivida.Fixa)
                            {
                                if (Msg.Pergunta("Esse é uma divida FIXA. Deseja reabri-lá?") == DialogResult.Yes)
                                {
                                    using (var form = new DataNovoVencimentoForm())
                                    {
                                        form.ShowDialog();
                                        _dataNovoVencimento = form.NovoVencimento;
                                        form.Close();
                                    }

                                    if (_servico.ReabrirDivida(_usuario, _divida, _dataNovoVencimento))
                                    {
                                        Msg.Informacao("Divida reaberta com sucesso.");
                                        Close();
                                    }
                                }
                                else
                                    Close();
                            }
                            else
                                Close();
                        }
                    }
                }
                else
                {
                    Msg.Informacao("Divida já paga.");
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

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e) => AcaoAcionada(e);

        private void btnPagar_Click(object sender, EventArgs e) => Pagar();

        private void btnFechar_Click(object sender, EventArgs e) => Close();

        private void btnSalvar_Click(object sender, EventArgs e) => Salvar();
    }
}
