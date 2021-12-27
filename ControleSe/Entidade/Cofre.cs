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
        
        [NotMapped]
        public bool EhIncluir { get; set; }
    }
}
