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

        public IEnumerable<Divida> ObterDividas(Usuario usuario)
        {
            IEnumerable<Divida> dividas = null;

            try
            {
                using (var contexto = new Contexto())
                {
                    dividas = contexto.Divida
                        .Include(i => i.Usuario)
                        .Where(w => w.UsuarioId == usuario.Id)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dividas;
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
                            contexto.SaveChanges();
                            EhValido = true;
                        }
                        else
                        {
                            contexto.Divida.Update(divida);
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
    }
}
