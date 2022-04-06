using ControleSe.Entidade;
using ControleSe.Enumerador;
using ControleSe.Repositorio.Contexto;
using ControleSe.Servico.Base;
using ControleSe.Utilitario.UtilMensagem;
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
        public IList<Mensagem> Validar(Divida divida, IList<Mensagem> erros)
        {
            if (divida != null)
            {
                erros.Clear();

                if (string.IsNullOrWhiteSpace(divida.Nome))
                {
                    //Msg.Atencao("Informe o Nome da divida");
                    erros.Add(new Mensagem("Informe o Nome da divida"));
                    //EhValido = false;
                }
                if (string.IsNullOrWhiteSpace(divida.Descricao))
                {
                    //Msg.Atencao("Informe o Descricao da divida");
                    erros.Add(new Mensagem("Informe o Descrição da divida"));
                    //EhValido = false;
                }
                if (divida.Valor == 0)
                {
                    //Msg.Atencao("Informe o Valor da divida");
                    erros.Add(new Mensagem("Informe o Valor da divida"));
                    //EhValido = false;
                }
                if (divida.DataVencimento == DateTime.MinValue)
                {
                    //Msg.Atencao("Informe uma Data válida da divida");
                    erros.Add(new Mensagem("Informe uma Data válida da divida"));
                    //EhValido = false;
                }
                //else
                //{
                //    EhValido = true;
                //}
            }

            return erros;
        }

        public IEnumerable<Divida> ObterDividas(Usuario usuarioLogado)
        {
            try
            {
                IEnumerable<Divida> dividas = null;

                using (Contexto contexto = new())
                {
                    dividas = contexto.Divida.Include(i => i.Usuario)
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

        public Tuple<Divida, bool> Pagar(Divida divida, Usuario usuarioLogado)
        {
            try
            {
                EhValido = false;
                Tuple<Divida, bool> dividaTuple = null;

                if (divida != null)
                {
                    if (RetirarValorNoCofre(divida.Valor, usuarioLogado))
                    {
                        using (Contexto contexto = new())
                        {
                            Divida dividaParaPagar = contexto.Divida.Where(w =>
                                                                           w.Id == divida.Id &&
                                                                           w.UsuarioId == usuarioLogado.Id)
                                                                           .FirstOrDefault();

                            if (dividaParaPagar != null)
                            {
                                dividaParaPagar.Pago = true;
                                dividaParaPagar.DataPagamento = DateTime.Now;
                                contexto.Divida.Update(dividaParaPagar);
                                contexto.SaveChanges();
                                EhValido = true;
                                dividaTuple = new Tuple<Divida, bool>(dividaParaPagar, EhValido);
                            }
                        }
                    }
                }

                return dividaTuple;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ReabrirDivida(Usuario usuarioLogado, Divida divida, DateTime dataNovoVencimento)
        {
            try
            {
                EhValido = false;

                if (divida != null)
                {
                    using (Contexto contexto = new())
                    {
                        Divida dividaPesquisa = contexto.Divida.Where(w =>
                                                                      w.Id == divida.Id &&
                                                                      w.UsuarioId == usuarioLogado.Id)
                                                                      .FirstOrDefault();

                        if (dividaPesquisa != null)
                        {
                            dividaPesquisa.Pago = false;
                            dividaPesquisa.DataVencimento = dataNovoVencimento;
                            contexto.Divida.Update(dividaPesquisa);
                            contexto.SaveChanges();
                            EhValido = true;
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

        public bool Salvar(Divida divida)
        {
            EhValido = false;

            try
            {
                if (divida != null)
                {
                    using (Contexto contexto = new())
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
                using (Contexto contexto = new())
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

                using (Contexto contexto = new())
                {
                    Cofre cofre = contexto.Cofre.Where(w => w.UsuarioId == usuarioLogado.Id)
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

        public IEnumerable<Divida> PesquisarDividas(Usuario usuarioLogado, DateTime dataDe,
                                                    DateTime dataAte, string tipoDivida,
                                                    string dataPor, bool dividasPagas)
        {
            try
            {
                IEnumerable<Divida> dividasPesquisa = null;
                TipoDivida tipoDividaConsulta = TipoDivida.Fixa;
                DateTime dataDePesquisa = dataDe.Date;
                DateTime dataAtePesquisa = dataAte.Date;

                using (Contexto contexto = new())
                {

                    dividasPesquisa = contexto.Divida.Where(w => w.UsuarioId == usuarioLogado.Id).ToList();

                    if (tipoDivida != "Selecione...")
                    {
                        if (tipoDivida == "Fixa")
                            tipoDividaConsulta = TipoDivida.Fixa;

                        if (tipoDivida == "Não-Fixa")
                            tipoDividaConsulta = TipoDivida.NaoFixa;

                        dividasPesquisa = PesquisarPorTipoDivida(dividasPesquisa, tipoDividaConsulta);
                    }

                    if (dataPor != "Selecione...")
                    {
                        dividasPesquisa = PesquisarDataPor(dividasPesquisa, dataPor, dataDePesquisa, dataAtePesquisa);
                    }

                    if (dividasPagas)
                        dividasPesquisa = PesquisarDiidasPagas(dividasPesquisa, dividasPagas);
                }

                return dividasPesquisa;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private IEnumerable<Divida> PesquisarPorTipoDivida(IEnumerable<Divida> dividasPesquisa, TipoDivida tipoDivida)
        {
            try
            {
                dividasPesquisa = dividasPesquisa.Where(w => w.TipoDivida == tipoDivida).ToList();

                return dividasPesquisa;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private IEnumerable<Divida> PesquisarDataPor(IEnumerable<Divida> dividasPesquisa, string dataPor,
                                                     DateTime dataDe, DateTime dataAte)
        {
            try
            {
                if (dataPor.Contains("Pagamento"))
                {
                    dividasPesquisa = dividasPesquisa.Where(w =>
                                                            w.DataPagamento >= dataDe &&
                                                            w.DataPagamento <= dataAte)
                                                            .ToList();
                }

                if (dataPor.Contains("Vencimento"))
                {
                    dividasPesquisa = dividasPesquisa.Where(w =>
                                                            w.DataVencimento >= dataDe &&
                                                            w.DataVencimento <= dataAte)
                                                            .ToList();
                }

                return dividasPesquisa;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private IEnumerable<Divida> PesquisarDiidasPagas(IEnumerable<Divida> dividasPesquisa, bool dividaPaga)
        {
            try
            {
                dividasPesquisa = dividasPesquisa.Where(w => w.Pago == dividaPaga).ToList();

                return dividasPesquisa;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}