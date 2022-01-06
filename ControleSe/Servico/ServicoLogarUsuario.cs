﻿using ControleSe.Entidade;
using ControleSe.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Servico
{
    public static class ServicoLogarUsuario
    {
        public static Usuario Usuario;

        public static Usuario LogarUsuario()
        {
            using (var form = new LoginFormNova(new ServicoUsuario(), new Usuario()))
            {
                form.ShowDialog();

                if (form.Usuario != null)
                    Usuario = form.Usuario;
            }

            return Usuario;
        }
    }
}
