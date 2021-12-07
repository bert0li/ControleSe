using ControleSe.Entidade;
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
    public partial class DividasForm : Form
    {
        private ServicoDivida _servico = null;
        private Usuario _usuario = null;
        private Divida _divida = null;

        public DividasForm(Usuario usuarioLogado, ServicoDivida servicoDivida)
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
                _divida = new Divida();
                _divida.UsuarioId = _usuario.Id;
                _divida.EhIncluir = true;
            }

            using (var form = new DividaDetalheForm(_servico, _divida))
            {
                form.ShowDialog();
            }

            BindingDividas();
            SomarTotalDivida();
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
                var dataVencimento = (DateTime)grid.Rows[e.RowIndex].Cells["colDataVencimento"]?.Value;
                var pago = (bool)grid.Rows[e.RowIndex].Cells["colPago"]?.Value;

                if (dataVencimento <= DateTime.Now && pago != true)
                {
                    var cells = grid.Columns.Count;

                    for (int i = 0; i < cells; i++)
                    {
                        grid.Rows[e.RowIndex].Cells[i].Style.ForeColor = Color.Red;
                        grid.Rows[e.RowIndex].Cells[i].Style.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
                    }
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void SomarTotalDivida()
        {
            var somaTotalDivida = 0M;

            for (var i = 0; i < grid.RowCount; i++)
            {
                var valorDivida = (decimal)grid.Rows[i].Cells["colValor"]?.Value;
                if (valorDivida > 0)
                {
                    somaTotalDivida += valorDivida;
                }
            }

            lblValorTotalDivida.Text = somaTotalDivida.ToString("C");
        }
        
        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            => VerificarVencimento(e);

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            LinhaSeleciona(e);
            AlterarIncluirDivida();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
            => LinhaSeleciona(e);

        private void btnAdd_Click(object sender, EventArgs e)
            => AlterarIncluirDivida(true);

        private void btnAlterar_Click(object sender, EventArgs e)
            => AlterarIncluirDivida();

        private void btnDeletar_Click(object sender, EventArgs e)
            => ExcluirDivida();
    }
}