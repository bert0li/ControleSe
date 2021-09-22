using ControleSe.Enumerador;
using System;

namespace ControleSe.Entidade
{
    public class Divida
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoDivida TipoDivida { get; set; }
        public DateTime DataCompra { get; set; } 
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
