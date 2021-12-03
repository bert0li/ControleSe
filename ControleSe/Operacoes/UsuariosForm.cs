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
    public partial class UsuariosForm : Form
    {
        private ServicoUsuario _servico = null;
        private Usuario _usuario = null;

        public UsuariosForm(ServicoUsuario servico)
        {
            InitializeComponent();  
            _servico = servico;
            BindingUsuarios();
        }

        private void BindingUsuarios()
        {
            try
            {
                _servico = _servico ?? new ServicoUsuario();
                grid.AutoGenerateColumns = false;
                grid.DataSource = _servico.ObterUsuarios();
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
                _usuario = new Usuario();
                _usuario.EhIncluir = true;
            }

            //using (var form = new UsuarioDetalheForm(_servico, _usuario))
            //{
            //    form.ShowDialog();
            //}

            BindingUsuarios();
        }

        private void ExluirUsuario()
        {
            try
            {
                if (_usuario != null)
                {
                    if (_servico.Excluir(_usuario))
                    {
                        BindingUsuarios();
                        Msg.Informacao("Usuário excluído com sucesso.");
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
                _usuario = grid.Rows[e.RowIndex].DataBoundItem as Usuario;
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarLinha(e);
            AlterarIncluirUsuario();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
            => SelecionarLinha(e);

        private void btnAdd_Click(object sender, EventArgs e)
            => AlterarIncluirUsuario(true);

        private void btnAlterar_Click(object sender, EventArgs e)
            => AlterarIncluirUsuario();

        private void btnDeletar_Click(object sender, EventArgs e)
            => ExluirUsuario();
    }
}
