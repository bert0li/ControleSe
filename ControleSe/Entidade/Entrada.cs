using ControleSe.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Entidade
{
    public class Entrada : IEntidadeBase
    {
        public int Id { get; set; }
        public decimal ValorEntrada { get; set; }
        public DateTime DataEntrada { get; set; } = DateTime.Now;
        public Usuario Usuario { get; set; }
        public string Observacao { get; set; }
        public int UsuarioId { get; set; }

        [NotMapped]
        public bool EhIncluir { get; set; }
    }
}
