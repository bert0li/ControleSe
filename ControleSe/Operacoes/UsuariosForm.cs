using ControleSe.Entidade;
using ControleSe.Servico;
using ControleSe.Utilitario;
using ControleSe.Utilitario.Splash;
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
    public partial class UsuariosForm : Form
    {
        private ServicoUsuario _servico = null;
        private Usuario _usuarioLogado = null;
        private Usuario _usuarioSelecionado = null;

        public UsuariosForm(Usuario usuarioLogado, ServicoUsuario servico)
        {
            InitializeComponent();  
            _servico = servico;
            _usuarioLogado = usuarioLogado;
            AtivarCheckBox();
            BindingUsuarios(true);
        }

        private void AtivarCheckBox() => cbxAtivos.Checked = true;

        private void BindingUsuarios(bool ativoInativo)
        {
            try
            {
                _servico = _servico ?? new ServicoUsuario();
                grid.AutoGenerateColumns = false;
                grid.DataSource = _servico.ObterUsuarios(ativoInativo);
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void AlterarIncluirUsuario(bool incluir = false)
        {
            if (incluir)
            {
                _usuarioSelecionado = new Usuario();
                //_usuario.EhIncluir = true;
            }

            using (var form = new UsuarioDetalheForm(_servico, _usuarioSelecionado))
            {
                form.ShowDialog();
            }

            AtivarCheckBox();
            BindingUsuarios(true);
        }

        private void ExluirUsuario()
        {
            try
            {
                if (_usuarioSelecionado != null)
                {
                    if (Msg.Pergunta("Deseja realmente exluir o usuário?") == DialogResult.Yes)
                    {
                        if (_servico.Excluir(_usuarioLogado, _usuarioSelecionado))
                        {
                            ExibirSplash();
                            AtivarCheckBox();
                            BindingUsuarios(true);
                        }
                    }
                }
                else
                {
                    Msg.Informacao("Selecione um usuário.");
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void SelecionarLinha(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
                _usuarioSelecionado = grid.Rows[e.RowIndex].DataBoundItem as Usuario;
        }

        private void ExibirSplash()
        {
            using (var form = new DeletarSplash())
            {
                form.ShowDialog();
            }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarLinha(e);
            AlterarIncluirUsuario();
        }

        private void cbxAtivos_CheckedChanged(object sender, EventArgs e)
            => BindingUsuarios(cbxAtivos.Checked);

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
            => SelecionarLinha(e);

        private void btnAdd_Click(object sender, EventArgs e)
            => AlterarIncluirUsuario(true);

        private void btnAlterar_Click(object sender, EventArgs e)
            => AlterarIncluirUsuario();

        private void btnDeletar_Click(object sender, EventArgs e)
            => ExluirUsuario();

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            // TODO : Implementar
        }
    }
}
