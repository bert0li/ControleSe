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
    public class ServicoEntrada : ServicoBase
    {
        public bool Validar(Entrada entrada)
        {
            if (entrada != null)
            {
                if (entrada.ValorEntrada <= 0)
                {
                    Msg.Atencao("Informe o Valor da entrada.");
                    EhValido = false;
                }
                else
                {
                    EhValido = true;
                }
            }

            return EhValido;
        }

        public IEnumerable<Entrada> ObterEntradas(Usuario usuario)
        {
            try
            {
                IEnumerable<Entrada> entradas = null;

                using (var contexto = new Contexto())
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
                var dataAteCorreta = dataAte.AddDays(1).AddSeconds(-1);

                IEnumerable<Entrada> entradas = null;

                using (var contexto = new Contexto())
                {
                    entradas = contexto.Entrada
                                       .Include(i => i.Usuario)
                                       .Where(w => w.UsuarioId == usuario.Id &&
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

        public bool Salvar(Entrada entrada)
        {
            EhValido = false;

            try
            {
                using (var contexto = new Contexto())
                {
                    if (entrada != null)
                    {
                        contexto.Entrada.Add(entrada);
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
