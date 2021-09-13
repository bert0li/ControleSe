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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var usuario = ServicoLogarUsuario.LogarUsuario();

            if (usuario.Id != 0)
                Application.Run(new MenuForm(usuario));
            else
                Application.Exit();
        }
    }
}
