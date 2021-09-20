using ControleSe.Entidade;
using ControleSe.Entidade.Base;
using ControleSe.Repositorio.Contexto;
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
                //Implementar Msg e Log
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
                        contexto.Divida.Add(divida);
                        contexto.SaveChanges();
                        EhValido = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //Implementar Msg e Log
                EhValido = false;
                throw;
            }

            return EhValido;
        }
    }
}
