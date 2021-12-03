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
    public partial class UsuarioDetalheForm : Form
    {
        private ServicoUsuario _servico = null;
        private Usuario _usuario = null;

        public UsuarioDetalheForm(ServicoUsuario servico, Usuario usuario)
        {
            InitializeComponent();
            _servico = servico;
            _usuario = usuario;
            AtribuirBinding(_usuario);
        }

        private void AtribuirBinding(Usuario usuario)
        {
            try
            {
                _usuario = usuario ?? new Usuario();

                txtCodigo.DataBindings.Add("Text", _usuario, "Id");
                txtNome.DataBindings.Add("Text", _usuario, "Nome");
                txtUsuario.DataBindings.Add("Text", _usuario, "UsuarioAcesso");
                txtSenha.DataBindings.Add("Text", _usuario, "SenhaAcesso");
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }
    }
}
