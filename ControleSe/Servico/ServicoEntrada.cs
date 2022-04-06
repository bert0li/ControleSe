using ControleSe.Entidade;
using ControleSe.Servico.Base;
using ControleSe.Repositorio.Contexto;
using ControleSe.Utilitario.UtilMensagem;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Servico
{
    public class ServicoEntrada : ServicoBase
    {
        public IList<Mensagem> Validar(Entrada entrada, IList<Mensagem> erros)
        {
            if (entrada != null)
            {
                if (entrada.ValorEntrada <= 0)
                {
                    erros.Add(new Mensagem("Informe o Valor da entrada."));
                    //Msg.Atencao("Informe o Valor da entrada.");
                    //EhValido = false;
                }
                //else
                //{
                //    EhValido = true;
                //}
            }

            return erros;
        }

        public IEnumerable<Entrada> ObterEntradas(Usuario usuario)
        {
            try
            {
                IEnumerable<Entrada> entradas = null;

                using (Contexto contexto = new())
                {
                    entradas = contexto.Entrada
                                       .Include(i => i.Usuario)
                                       .Where(w => w.UsuarioId == usuario.Id)
                                       .ToList();
                }

                return entradas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Entrada> PesquisarEntradas(Usuario usuario, DateTime dataDe, DateTime dataAte)
        {
            try
            {
                DateTime dataAteCorreta = dataAte.AddDays(1).AddSeconds(-1);

                IEnumerable<Entrada> entradas = null;

                using (Contexto contexto = new())
                {
                    entradas = contexto.Entrada
                                       .Include(i => i.Usuario)
                                       .Where(w =>
                                              w.UsuarioId == usuario.Id &&
                                              w.DataEntrada >= dataDe &&
                                              w.DataEntrada <= dataAteCorreta)
                                              .ToList();
                }

                return entradas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Salvar(Entrada entrada, Usuario usuarioLogado)
        {
            try
            {
                EhValido = false;

                using (Contexto contexto = new())
                {
                    if (entrada != null)
                    {
                        contexto.Entrada.Add(entrada);
                        contexto.SaveChanges();
                        AdicionarValorNoCofre(entrada.ValorEntrada, usuarioLogado);
                        EhValido = true;
                    }
                }

                return EhValido;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Excluir(Entrada entrada, Usuario usuarioLogado)
        {
            try
            {
                EhValido = false;

                if (RetirarValorNoCofre(entrada.ValorEntrada, usuarioLogado))
                {
                    using (Contexto contexto = new())
                    {
                        contexto.Entrada.Remove(entrada);
                        contexto.SaveChanges();
                        EhValido = true;
                    }
                }

                return EhValido;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AdicionarValorNoCofre(decimal valor, Usuario usuarioLogado)
        {
            try
            {
                using (Contexto contexto = new())
                {
                    Cofre cofre = contexto.Cofre
                                          .Where(w => w.UsuarioId == usuarioLogado.Id)
                                          .FirstOrDefault();

                    if (cofre != null)
                    {
                        cofre.AdicionarValor(valor);
                        contexto.Cofre.Update(cofre);
                    }
                    else
                    {
                        cofre = new Cofre
                        {
                            UsuarioId = usuarioLogado.Id
                        };

                        cofre.AdicionarValor(valor);
                        contexto.Cofre.Add(cofre);
                    }

                    contexto.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool RetirarValorNoCofre(decimal valor, Usuario usuarioLogado)
        {
            try
            {
                EhValido = false;

                using (Contexto contexto = new())
                {
                    Cofre cofre = contexto.Cofre
                                          .Where(w => w.UsuarioId == usuarioLogado.Id)
                                          .FirstOrDefault();

                    if (cofre != null)
                    {
                        if (cofre.TotalCobre >= valor)
                        {
                            cofre.RetirarValor(valor);
                            contexto.Cofre.Update(cofre);
                            contexto.SaveChanges();
                            EhValido = true;
                        }
                        else
                        {
                            Msg.Informacao($"Valor insuficiente no cofre para remover a entrada desejada.\nValor no cofre: {cofre.TotalCobre}\nValor divida: {valor}");
                        }
                    }
                    else
                    {
                        Msg.Informacao("O cofre esta vazio. Não é possível remover a entrada desejada.");
                    }
                }

                return EhValido;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
