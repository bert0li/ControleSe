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
    public partial class SalvarSplash : Form
    {
        private Timer _timer = null;
        private int _contador = 0;

        public SalvarSplash()
        {
            InitializeComponent();
            IniciarSplash();
        }

        private void IniciarSplash()
        {
            _timer = new Timer() { Interval = 1000 };
            _timer.Start();
            _timer.Tick += (a, b) =>
            {
                if (_contador == 2)
                {
                    _timer.Stop();
                    _timer.Dispose();
                    Close();
                }

                _contador++;
            };
        }
    }
}
