using System.Collections.Generic;

namespace ControleSe.Entidade
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UsuarioAcesso { get; set; }
        public string SenhaAcesso { get; set; }
        public List<Divida> Dividas { get; set; }
    }
}
