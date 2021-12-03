using ControleSe.Enumerador;
using ControleSe.Interface;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleSe.Entidade
{
    public class Divida : IEntidadeBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoDivida TipoDivida { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; } = null;
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public bool Pago { get; set; }

        [NotMapped]
        public bool EhIncluir { get; set; }
    }
}
