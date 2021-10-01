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
            EhValido = true;

            if (divida != null)
            {
                if (string.IsNullOrWhiteSpace(divida.Nome))
                {
                    Msg.Atencao("Informe o Nome da divida");
                    EhValido = false;
                }

                if (string.IsNullOrWhiteSpace(divida.Descricao))
                {
                    Msg.Atencao("Informe o Descricao da divida");
                    EhValido = false;
                }

                if (divida.Valor == 0)
                {
                    Msg.Atencao("Informe o Valor da divida");
                    EhValido = false;
                }

                if (divida.DataVencimento == DateTime.MinValue)
                {
                    Msg.Atencao("Informe uma Data valida da divida");
                    EhValido = false;
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
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
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
                        contexto.Divida.Add(divida);
                        contexto.SaveChanges();
                        EhValido = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                EhValido = false;
            }

            return EhValido;
        }
    }
}
