using ControleSe.Entidade;
using ControleSe.Enumerador;
using ControleSe.Servico;
using ControleSe.Utilitario.UtilMensagem;
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
using ControleSe.Utilitario;
using ControleSe.Utilitario.Base;

namespace ControleSe.Operacoes
{
    public partial class DividaDetalheFormNova : FormDetalheBase
    {
        private ServicoDivida _servicoDivida = null;
        private ServicoEmail _servicoEmail = null;
        private ServicoArquivo _servicoArquivo = null;
        private Divida _divida = null;
        private Usuario _usuarioLogado = null;
        private bool PrimeiroBinding = false;
        private Task _retornoEnvioEmail = null;
        private DateTime _dataNovoVencimento;
        //private IList<Mensagem> _erros = null;

        public DividaDetalheFormNova(ServicoDivida servicoDivida, Divida divida, Usuario usuarioLogado)
        {
            InitializeComponent();
            _servicoDivida = servicoDivida;
            _divida = divida;
            _usuarioLogado = usuarioLogado;
            AtribuirBinding();
            VerificarSePodePagar();
        }

        private void InicializarDatas()
        {
            dtpDataVencimento.Value = DateTime.Now;

            if (_divida.EhIncluir)
                _divida.DataVencimento = dtpDataVencimento.Value;
        }

        private void VerificarSePodePagar() => btnPagar.Enabled = _divida.Id == 0 ? false : true;

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
                _servicoDivida = _servicoDivida ?? new ServicoDivida();
                _servicoEmail = new ServicoEmail();
                _servicoArquivo = new ServicoArquivo();
                //_erros = new List<Mensagem>();
                Erros = new List<Mensagem>();

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
                Erros = _servicoDivida.Validar(_divida, Erros);

                if (Erros.Count > 0)
                {
                    MensagemUtil.ExibirMensagem("Divida", Erros);
                }
                else
                {
                    if (_servicoDivida.Salvar(_divida))
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

        private void ExibirSplash(string texto = null)
        {
            using (SalvarSplash formSplah = new())
            {
                if (!string.IsNullOrWhiteSpace(texto))
                    formSplah.lblInfo.Text = texto;

                formSplah.ShowDialog();
            }
        }

        private void VerificarRetornoEnvioEmail()
        {
            try
            {
                Timer timer = new Timer() { Interval = 1000 };
                timer.Start();
                timer.Tick += (o, e) =>
                {
                    if (_retornoEnvioEmail.IsCompletedSuccessfully)
                    {
                        using (SplashEnvioEmail form = new())
                        {
                            timer.Stop();
                            timer.Dispose();
                            form.ShowDialog();
                        }
                    }
                };
            }
            catch { }
        }

        private void Pagar()
        {
            try
            {
                if (_divida.Pago != true)
                {
                    if (Msg.Pergunta("Deseja realmente pagar?") == DialogResult.Yes)
                    {
                        Tuple<Divida, bool> dividaTuple = _servicoDivida.Pagar(_divida, _usuarioLogado);

                        if (dividaTuple == null) return;

                        if (dividaTuple.Item2)
                        {
                            if (Msg.Pergunta("Divida paga.\nDeseja enviar a comprovação do pagamento no seu e-mail?") == DialogResult.Yes)
                            {
                                _retornoEnvioEmail = EnviarEmailAsync();
                                VerificarRetornoEnvioEmail();
                            }

                            if (_divida.TipoDivida == TipoDivida.Fixa)
                            {
                                if (Msg.Pergunta("Esse é uma divida FIXA. Deseja reabri-lá?") == DialogResult.Yes)
                                {
                                    using (DataNovoVencimentoForm form = new())
                                    {
                                        form.ShowDialog();
                                        _dataNovoVencimento = form.NovoVencimento;
                                        form.Close();
                                    }

                                    if (_servicoDivida.ReabrirDivida(_usuarioLogado, _divida, _dataNovoVencimento))
                                    {
                                        ExibirSplash("Divida reaberta com sucesso.");
                                        Close();
                                    }
                                }
                                else
                                    Close();
                            }
                            else
                                Close();

                            _servicoArquivo.GravarArquivoDividaPaga(dividaTuple.Item1);
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

        private async Task EnviarEmailAsync()
        {
            try
            {
                await _servicoEmail.EnviarEmailAsync(_usuarioLogado.Email, _divida);
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