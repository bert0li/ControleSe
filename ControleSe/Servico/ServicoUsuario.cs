using ControleSe.Entidade;
using ControleSe.Servico.Base;
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
                    usuarioLogado.SenhaAcesso = CriptografarSenha(usuarioLogado.SenhaAcesso);

                    _usuario = contexto.Usuario
                                       .Include(i => i.Dividas)
                                       .Include(i => i.Cofre)
                                       .Include(i => i.Email)
                                       .Where(w =>
                                              w.UsuarioAcesso == usuarioLogado.UsuarioAcesso &&
                                              w.SenhaAcesso == usuarioLogado.SenhaAcesso)
                                              .FirstOrDefault();

                    if (_usuario == null)
                        Msg.Atencao("Usuario ou Senha invalido. Tente novamente.");
                    else
                    {
                        _usuario.SenhaAcesso = DescriptografarSenha(_usuario.SenhaAcesso);

                        if (_usuario.Email is not null)
                            _usuario.Email.SenhaEmail = DescriptografarSenha(_usuario.Email.SenhaEmail);
                    }
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

                    foreach (var usuario in usuarios)
                    {
                        usuario.SenhaAcesso = DescriptografarSenha(usuario.SenhaAcesso);

                        if (usuario.Email is not null)
                            usuario.Email.SenhaEmail = DescriptografarSenha(usuario.Email.SenhaEmail);
                    }
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
                            {
                                usuarioLogado.SenhaAcesso = CriptografarSenha(usuarioLogado.SenhaAcesso);
                                contexto.Usuario.Add(usuarioLogado);
                            }
                            else
                            {
                                usuarioLogado.SenhaAcesso = CriptografarSenha(usuarioLogado.SenhaAcesso);
                                contexto.Usuario.Update(usuarioLogado);
                            }

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

        public bool Excluir(Usuario usuarioLogado, Usuario usuarioSelecionado)
        {
            EhValido = true;

            try
            {
                if (usuarioLogado.Id != usuarioSelecionado.Id)
                {
                    using (var contexto = new Contexto())
                    {
                        Usuario usuarioRetorno = contexto.Usuario
                                                         .Include(i => i.Dividas)
                                                         .Where(w => w.Id == usuarioSelecionado.Id)
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

        public bool VerificarSenhaSegurança(Usuario usuarioLogado, string senha)
        {
            try
            {
                EhValido = false;

                usuarioLogado.SenhaAcesso = CriptografarSenha(usuarioLogado.SenhaAcesso);

                using (var contexto = new Contexto())
                {
                    bool any = contexto.Usuario.Any(a =>
                                                    a.Id == usuarioLogado.Id &&
                                                    a.SenhaAcesso == senha.Trim());

                    if (any)
                        EhValido = true;
                }

                return EhValido;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Usuario> PesquisarUsuario(string usuarioPesquisa, bool ativo)
        {
            try
            {
                IEnumerable<Usuario> usuarios = null;

                using (var contexto = new Contexto())
                {
                    usuarios = contexto.Usuario.Where(w =>
                                                      w.UsuarioAcesso.StartsWith(usuarioPesquisa) &&
                                                      w.Ativo == ativo)
                                                      .ToList();
                }

                foreach (var usuario in usuarios)
                {
                    usuario.SenhaAcesso = CriptografarSenha(usuario.SenhaAcesso);

                    if (usuario.Email is not null)
                    {
                        usuario.Email.SenhaEmail = DescriptografarSenha(usuario.Email.SenhaEmail);
                    }
                }

                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string CriptografarSenha(string senha)
        {
            return ServicoCriptografia.Criptografar(senha);
        }

        private string DescriptografarSenha(string senha)
        {
            return ServicoCriptografia.Descriptografar(senha);
        }
    }
}