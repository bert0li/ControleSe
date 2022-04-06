using ControleSe.Entidade;
using ControleSe.Servico;
using ControleSe.Utilitario.Mensagem;
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
    public partial class DividasFormNova : Form
    {
        private ServicoDivida _servico = null;
        private Usuario _usuario = null;
        private Divida _divida = null;

        public DividasFormNova(Usuario usuarioLogado, ServicoDivida servicoDivida)
        {
            InitializeComponent();
            _servico = servicoDivida;
            _usuario = usuarioLogado;
            BindingDividas();
            SomarTotalDivida();
        }

        private void BindingDividas()
        {
            try
            {
                _servico = _servico ?? new ServicoDivida();
                grid.AutoGenerateColumns = false;
                grid.DataSource = _servico.ObterDividas(_usuario);
                cbxTipoDivida.SelectedIndex = 0;
                cbxDataPor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void LinhaSeleciona(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
                _divida = grid.Rows[e.RowIndex].DataBoundItem as Divida;
        }

        private void AlterarIncluirDivida(bool incluir = false)
        {
            if (incluir)
            {
                _divida = new();
                _divida.UsuarioId = _usuario.Id;
                _divida.EhIncluir = true;
            }

            if (_divida != null)
            {
                using (DividaDetalheFormNova form = new(_servico, _divida, _usuario))
                {
                    form.ShowDialog();
                }

                BindingDividas();
                SomarTotalDivida();
            }
            else
            {
                Msg.Informacao("Selecione um divida.");
            }

            _divida = null;
        }

        private void ExcluirDivida()
        {
            try
            {
                if (_divida != null)
                {
                    if (_servico.Excluir(_divida))
                    {
                        BindingDividas();
                        Msg.Informacao("Divida excluída com sucesso.");
                    }
                }
                else
                {
                    Msg.Informacao("Selecione uma divida.");
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void VerificarVencimento(DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int cells = grid.Columns.Count;
                DateTime dataVencimento = (DateTime)grid.Rows[e.RowIndex].Cells["colDataVencimento"]?.Value;
                bool pago = (bool)grid.Rows[e.RowIndex].Cells["colPago"]?.Value;

                if (DateTime.Now.Day + 1 == dataVencimento.Day &&
                    DateTime.Now.Month == dataVencimento.Month &&
                    DateTime.Now.Year == dataVencimento.Year &&
                    pago != true)
                {
                    for (int i = 0; i < cells; i++)
                    {
                        grid.Rows[e.RowIndex].Cells[i].Style.ForeColor = Color.FromArgb(255, 115, 57);
                        grid.Rows[e.RowIndex].Cells[i].Style.Font = new Font(new FontFamily("Tahoma"), 12, FontStyle.Bold);
                    }
                }                
                else if (DateTime.Now.Day + 2 == dataVencimento.Day &&
                         DateTime.Now.Month == dataVencimento.Month &&
                         DateTime.Now.Year == dataVencimento.Year &&
                         pago != true)
                {
                    for (int i = 0; i < cells; i++)
                    {
                        grid.Rows[e.RowIndex].Cells[i].Style.ForeColor = Color.FromArgb(255, 115, 57);
                        grid.Rows[e.RowIndex].Cells[i].Style.Font = new Font(new FontFamily("Tahoma"), 12, FontStyle.Bold);
                    }
                }
                else if (DateTime.Now.Day + 3 == dataVencimento.Day &&
                         DateTime.Now.Month == dataVencimento.Month &&
                         DateTime.Now.Year == dataVencimento.Year &&
                         pago != true)
                {
                    for (int i = 0; i < cells; i++)
                    {
                        grid.Rows[e.RowIndex].Cells[i].Style.ForeColor = Color.FromArgb(255, 115, 57);
                        grid.Rows[e.RowIndex].Cells[i].Style.Font = new Font(new FontFamily("Tahoma"), 12, FontStyle.Bold);
                    }
                }
                else if (dataVencimento.Date <= DateTime.Now.Date && pago != true)
                {
                    for (int i = 0; i < cells; i++)
                    {
                        grid.Rows[e.RowIndex].Cells[i].Style.ForeColor = Color.Red;
                        grid.Rows[e.RowIndex].Cells[i].Style.Font = new Font(new FontFamily("Tahoma"), 12, FontStyle.Bold);
                    }
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void SomarTotalDivida()
        {
            decimal somaTotalDivida = 0M;

            for (int i = 0; i < grid.RowCount; i++)
            {
                decimal valorDivida = (decimal)grid.Rows[i].Cells["colValor"]?.Value;
                bool pagoDivida = (bool)grid.Rows[i].Cells["colPago"]?.Value;

                if (valorDivida > 0 && pagoDivida != true)
                    somaTotalDivida += valorDivida;
            }

            lblValorTotalDivida.Text = somaTotalDivida.ToString("C");
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSeleciona(e);
            AlterarIncluirDivida();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                grid.DataSource = _servico.PesquisarDividas(_usuario, dtpDe.Value, dtpAte.Value, cbxTipoDivida.Text, cbxDataPor.Text, cbxSomenteDividasPagas.Checked);
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnFechar_Click(object sender, EventArgs e) => Close();

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) => VerificarVencimento(e);

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e) => LinhaSeleciona(e);

        private void btnIncluir_Click(object sender, EventArgs e) => AlterarIncluirDivida(true);

        private void btnAlterar_Click(object sender, EventArgs e) => AlterarIncluirDivida();

        private void btnExcluir_Click(object sender, EventArgs e) => ExcluirDivida();
    }
}
