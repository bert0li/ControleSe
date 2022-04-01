using ControleSe.Entidade;
using ControleSe.Repositorio.Contexto;
using ControleSe.Servico.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Servico
{
    public class ServicoPermissao : ServicoBase
    {
        public bool VerificarSeUsusarioEhAdm(Usuario usuarioLogado)
        {
            try
            {
                bool ehAdm = false;

                using (Contexto contexto = new())
                {
                    ehAdm = contexto.Usuario.Any(w => w.Id == usuarioLogado.Id && w.EhAdm == true);
                }

                return ehAdm;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}