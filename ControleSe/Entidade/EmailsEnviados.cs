using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Entidade
{
    public class EmailsEnviados
    {
        public int Id { get; set; }
        public int EmailId { get; set; }
        public Email Email { get; set; }    
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string Cc { get; set; }
        public string EmailDestinatario { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataEnvio { get; set; }
    }
}
