using ControleSe.Entidade;
using ControleSe.Repositorio.Contexto;
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
                        MessageBox.Show("Usuario ou Senha invalido. Tente novamente.");
                }
            }
            catch (Exception ex)
            {
                // TODO: Implementar Msg e Log
                throw;
            }

            return _usuario;
        }
    }
}
