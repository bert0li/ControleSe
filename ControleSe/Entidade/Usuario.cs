using ControleSe.Interface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleSe.Entidade
{
    public class Usuario : IEntidadeBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UsuarioAcesso { get; set; }
        public string SenhaAcesso { get; set; }
        public Cofre Cofre { get; set; }
        public List<Divida> Dividas { get; set; }
        public List<Entrada> Entradas { get; set; }
        public bool Ativo { get; set; } = true;

        [NotMapped]
        public bool EhIncluir { get; set; }
    }
}
