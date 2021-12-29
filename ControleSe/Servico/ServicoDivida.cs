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

namespace ControleSe.Servico
{
    public class ServicoDivida : ServicoBase
    {
        public bool Validar(Divida divida)
        {
            if (divida != null)
            {
                if (string.IsNullOrWhiteSpace(divida.Nome))
                {
                    Msg.Atencao("Informe o Nome da divida");
                    EhValido = false;
                }
                else if (string.IsNullOrWhiteSpace(divida.Descricao))
                {
                    Msg.Atencao("Informe o Descricao da divida");
                    EhValido = false;
                }
                else if (divida.Valor == 0)
                {
                    Msg.Atencao("Informe o Valor da divida");
                    EhValido = false;
                }
                else if (divida.DataVencimento == DateTime.MinValue)
                {
                    Msg.Atencao("Informe uma Data valida da divida");
                    EhValido = false;
                }
                else
                {
                    EhValido = true;
                }
            }

            return EhValido;
        }

        public IEnumerable<Divida> ObterDividas(Usuario usuarioLogado)
        {
            try
            {
                IEnumerable<Divida> dividas = null;

                using (var contexto = new Contexto())
                {
                    dividas = contexto.Divida
                                      .Include(i => i.Usuario)
                                      .Where(w => w.UsuarioId == usuarioLogado.Id)
                                      .ToList();
                }

                return dividas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Pagar(Divida divida, Usuario usuarioLogado)
        {
            try
            {
                EhValido = false;

                try
                {
                    if (divida != null)
                    {
                        if (RetirarValorNoCofre(divida.Valor, usuarioLogado))
                        {
                            using (var contexto = new Contexto())
                            {
                                var dividaParaPagar = contexto.Divida.Where(w => w.Id == divida.Id && 
                                                                                 w.UsuarioId == usuarioLogado.Id)
                                                                     .FirstOrDefault();

                                if (dividaParaPagar != null)
                                {
                                    dividaParaPagar.Pago = true;
                                    dividaParaPagar.DataPagamento = DateTime.Now;
                                    contexto.Divida.Update(dividaParaPagar);
                                    contexto.SaveChanges();
                                    EhValido = true;
                                }
                            }
                        }
                    }

                    return EhValido;
                }
                catch (Exception)
                {
                    throw;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Salvar(Divida divida)
        {
            EhValido = false;

            try
            {
                if (divida != null)
                {
                    using (var contexto = new Contexto())
                    {
                        if (divida.Id == 0)
                        {
                            contexto.Divida.Add(divida);
                            EhValido = true;
                        }
                        else
                        {
                            contexto.Divida.Update(divida);
                            EhValido = true;
                        }

                        contexto.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return EhValido;
        }

        public bool Excluir(Divida divida)
        {
            EhValido = false;

            try
            {
                using (var contexto = new Contexto())
                {
                    if (divida != null)
                    {
                        contexto.Divida.Remove(divida);
                        contexto.SaveChanges();
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

        private bool RetirarValorNoCofre(decimal valor, Usuario usuarioLogado)
        {
            try
            {
                EhValido = false;

                using (var contexto = new Contexto())
                {
                    var cofre = contexto.Cofre.Where(w => w.UsuarioId == usuarioLogado.Id)
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
                            Msg.Informacao($"Valor insuficiente no cofre para pagar divida.\nValor no cofre: {cofre.TotalCobre}\nValor divida: {valor}");
                        }
                    }
                    else
                    {
                        Msg.Informacao("O cofre esta vazio. Não é possivél pagar a divida.");
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
