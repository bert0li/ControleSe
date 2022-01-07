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
    public partial class DeletarSplash : Form
    {
        private Timer _timer = null;
        private int _contador = 0;

        public DeletarSplash()
        {
            InitializeComponent();
            IniciarSplash();
        }

        private void IniciarSplash()
        {
            _timer = new Timer() { Interval = 1000 };
            _timer.Start();
            _timer.Tick += (o, e) =>
            {
                if (_contador == 4)
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
