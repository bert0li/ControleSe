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
    public partial class EntradasForm : Form
    {
        private ServicoEntrada _servico = null;
        private Usuario _usuario = null;
        private Entrada _entrada = null;

        public EntradasForm(Usuario usuarioLogado, ServicoEntrada servicoEntrada)
        {
            InitializeComponent();
            _usuario = usuarioLogado;
            _servico = servicoEntrada;
            BindingEntradas();
        }

        private void BindingEntradas()
        {
            try
            {
                _servico = _servico ?? new ServicoEntrada();
                grid.AutoGenerateColumns = false;
                grid.DataSource = _servico.ObterEntradas(_usuario);
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void IncluirEntrada()
        {
            _entrada = new Entrada();
            _entrada.UsuarioId = _usuario.Id;

            using (var form = new EntradaDetalheForm(_servico, _entrada))
            {
                form.ShowDialog();
            }

            BindingEntradas();
        }

        private void ExcluirEntrada()
        {
            // TODO: Implementar
        }

        private void LinhasSelecionada(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
                _entrada = grid.Rows[e.RowIndex].DataBoundItem as Entrada;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e) => LinhasSelecionada(e);

        private void btnAdd_Click(object sender, EventArgs e) => IncluirEntrada();
    }
}
