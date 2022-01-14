using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSe.Utilitario.Splash
{
    public partial class LoginSplash : Form
    {
        public LoginSplash()
        {
            InitializeComponent();
            IniciarSplash();
        }

        private void IniciarSplash()
        {
            Timer timer = new Timer() { Interval = 1000 };
            int contador = 0;

            timer.Start();
            timer.Tick += (o, e) =>
            {
                if (contador == 1)
                    lblInfo.Text = "Aguarde, carregando informações.";

                if (contador == 2)
                    lblInfo.Text = "Aguarde, carregando informações..";

                if (contador == 3)
                    lblInfo.Text = "Aguarde, carregando informações...";

                if (contador == 4)
                {
                    timer.Stop();
                    timer.Dispose();
                    Close();
                }

                contador++;
            };
        }
    }
}