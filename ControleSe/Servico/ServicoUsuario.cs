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
    public class ServicoUsuario : ServicoBase
    {
        public bool ValidarLogin(Usuario usuario)
        {
            if (usuario == null) return false;

            EhValido = true;

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
                        .Where(w =>
                               w.UsuarioAcesso == usuario.UsuarioAcesso &&
                               w.SenhaAcesso == usuario.SenhaAcesso)
                        .FirstOrDefault();

                    if (_usuario == null)
                        Msg.Atencao("Usuario ou Senha invalido. Tente novamente.");
                }
            }
            catch (Exception)
            {
                throw;
            }

            return _usuario;
        }

        public IEnumerable<Usuario> ObterUsuarios()
        {
            IEnumerable<Usuario> usuarios = null;

            try
            {
                using (var contexto = new Contexto())
                {
                    usuarios = contexto.Usuario.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return usuarios;
        }

        public bool Salvar(Usuario usuario)
        {
            EhValido = false;

            try
            {
                if (usuario != null)
                {
                    using (var contexto = new Contexto())
                    {
                        if (usuario != null)
                        {
                            if (usuario.Id == 0)
                                contexto.Usuario.Add(usuario);
                            else
                                contexto.Usuario.Update(usuario);

                            contexto.SaveChanges();
                            EhValido = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return EhValido;
        }

        public bool Excluir(Usuario usuario)
        {
            EhValido = false;

            try
            {
                using (var contexto = new Contexto())
                {
                    var usuarioRetorno = contexto.Usuario
                                      .Include(i => i.Dividas)
                                      .Where(w => w.Id == usuario.Id)
                                      .FirstOrDefault();

                    if (usuarioRetorno != null)
                    {
                        if (usuarioRetorno.Dividas.Any())
                            Msg.Informacao("Não é possível excluir um usuário que possui dividas");
                        else
                        {
                            contexto.Usuario.Remove(usuarioRetorno);
                            contexto.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return EhValido;
        }
    }
}