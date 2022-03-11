using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Entidade
{
    public class Email
    {
        public int Id { get; set; }
        public string Smtp { get; set; }
        public int Porta { get; set; }
        public bool Ssl { get; set; }
        public string EnderecoEmail { get; set; }
        public string SenhaEmail { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        //public ICollection<EmailsEnviados> EmailsEnviados { get; set; }
    }
}
