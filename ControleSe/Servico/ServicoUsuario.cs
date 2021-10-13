using ControleSe.Entidade;
using ControleSe.Entidade.Base;
using ControleSe.Repositorio.Contexto;
using ControleSe.Utilitario;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSe.Servico
{
    public class ServicoUsuario: ServicoBase
    {
        public bool ValidarLogin(Usuario usuario)
        {
            if (usuario == null) return false;

            EhValido = false;

            if (string.IsNullOrWhiteSpace(usuario.UsuarioAcesso))
            {
                Msg.Atencao("Informe o usuário.");
                EhValido = false;
            }

            if (string.IsNullOrWhiteSpace(usuario.SenhaAcesso))
            {
                Msg.Atencao("Informe a senha.");
                EhValido = false;
            }

            return EhValido;
        }

        public Usuario Logar(Usuario usuario)
        {
            Usuario _usuario = null;

            try
            {
                using (var contexto = new Contexto())
                {
                    _usuario = contexto.Usuario
                        .Include(i => i.Dividas)
                        .Where(w => w.UsuarioAcesso == usuario.UsuarioAcesso && w.SenhaAcesso == usuario.SenhaAcesso)
                        .FirstOrDefault();

                    if (_usuario == null)
                        Msg.Atencao("Usuario ou Senha invalido. Tente novamente.");
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                throw;
            }

            return _usuario;
        }
    }
}