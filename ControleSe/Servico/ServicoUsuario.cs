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
        public bool ValidarLogin(Usuario usuarioLogado)
        {
            if (usuarioLogado != null)
            {
                if (string.IsNullOrWhiteSpace(usuarioLogado.UsuarioAcesso))
                {
                    Msg.Atencao("Informe o usuário.");
                    EhValido = false;
                }
                else if (string.IsNullOrWhiteSpace(usuarioLogado.SenhaAcesso))
                {
                    Msg.Atencao("Informe a senha.");
                    EhValido = false;
                }
                else
                {
                    EhValido = true;
                }
            }

            return EhValido;
        }

        public bool Validar(Usuario usuarioLogado)
        {
            try
            {
                if (usuarioLogado != null)
                {
                    if (string.IsNullOrWhiteSpace(usuarioLogado.Nome))
                    {
                        Msg.Atencao("Informe o Nome do usuário");
                        EhValido = false;
                    }
                    else if (string.IsNullOrWhiteSpace(usuarioLogado.UsuarioAcesso))
                    {
                        Msg.Atencao("Informe o Usuário de acesso.");
                        EhValido = false;
                    }
                    else if (string.IsNullOrWhiteSpace(usuarioLogado.SenhaAcesso))
                    {
                        Msg.Atencao("Informe o Senha do usuário");
                        EhValido = false;
                    }
                    else
                    {
                        EhValido = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return EhValido;
        }

        public Usuario Logar(Usuario usuarioLogado)
        {
            Usuario _usuario = null;

            try
            {
                using (var contexto = new Contexto())
                {
                    _usuario = contexto.Usuario
                                       .Include(i => i.Dividas)
                                       .Include(i=>i.Cofre)
                                       .Where(w =>
                                              w.UsuarioAcesso == usuarioLogado.UsuarioAcesso &&
                                              w.SenhaAcesso == usuarioLogado.SenhaAcesso)
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

        public IEnumerable<Usuario> ObterUsuarios(bool ativoInativo)
        {
            IEnumerable<Usuario> usuarios = null;

            try
            {
                using (var contexto = new Contexto())
                {
                    usuarios = contexto.Usuario.Where(w => w.Ativo == ativoInativo)
                                               .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return usuarios;
        }

        public bool Salvar(Usuario usuarioLogado)
        {
            EhValido = false;

            try
            {
                if (usuarioLogado != null)
                {
                    using (var contexto = new Contexto())
                    {
                        if (usuarioLogado != null)
                        {
                            if (usuarioLogado.Id == 0)
                                contexto.Usuario.Add(usuarioLogado);
                            else
                                contexto.Usuario.Update(usuarioLogado);

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

        public bool Excluir(Usuario usuarioLogado)
        {
            EhValido = true;

            try
            {
                if (usuarioLogado.Id != usuarioLogado.Id)
                {
                    using (var contexto = new Contexto())
                    {
                        var usuarioRetorno = contexto.Usuario
                                                     .Include(i => i.Dividas)
                                                     .Where(w => w.Id == usuarioLogado.Id)
                                                     .FirstOrDefault();

                        if (usuarioRetorno != null)
                        {
                            if (usuarioRetorno.Dividas.Any())
                            {
                                Msg.Informacao("Não é possível excluir um usuário que possui dividas");
                                EhValido = false;
                            }
                            else
                            {
                                contexto.Usuario.Remove(usuarioRetorno);
                                contexto.SaveChanges();
                            }
                        }
                    }
                }
                else
                {
                    Msg.Informacao("Não é possível excluir o usuário logado no sistema.");
                    EhValido = false;
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