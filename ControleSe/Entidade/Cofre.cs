using ControleSe.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Entidade
{
    public class Cofre : IEntidadeBase
    {
        public int Id { get; set; }
        public decimal TotalCobre { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }

        [NotMapped]
        public bool EhIncluir { get; set; }

        public void AdicionarValor(decimal valor)
        {
            TotalCobre += valor;
        }

        public void RetirarValor(decimal valor)
        {
            TotalCobre -= valor;
        }
    }
}
