using ControleSe.Entidade;
using ControleSe.Servico;
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
    public partial class LoginForm : Form
    {
        private ServicoUsuario _servicoUsuario;
        public Usuario Usuario;

        public LoginForm(ServicoUsuario servicoUsuario, Usuario usuario)
        {
            InitializeComponent();
            _servicoUsuario = servicoUsuario;
            Usuario = usuario;
            AtribuirBinding(Usuario);
        }

        private void AtribuirBinding(Usuario usuario)
        {
            _servicoUsuario = _servicoUsuario ?? new ServicoUsuario();
            Usuario = usuario ?? new Usuario();

            txtUsuario.DataBindings.Add("Text", Usuario, "UsuarioAcesso");
            txtSenha.DataBindings.Add("Text", Usuario, "SenhaAcesso");

        }

        private void Entrar()
        {
            // TODO : Implementar validação
            var usuario = _servicoUsuario.Logar(Usuario);

            if (usuario != null)
            {
                Usuario = usuario;
                Close();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        => Entrar();

        private void btnCancelar_Click(object sender, EventArgs e)
        => Close();
    }
}
