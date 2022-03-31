using ControleSe.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSe
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var usuario = ServicoLogarUsuario.LogarUsuario();

            if (usuario.Id != 0)
                Application.Run(new MenuPrincipalForm(usuario));
            else
                Application.Exit();
        }
    }
}
