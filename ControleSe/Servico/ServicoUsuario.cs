using ControleSe.Entidade;
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
    public class ServicoUsuario
    {
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