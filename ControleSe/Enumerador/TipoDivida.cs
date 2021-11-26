using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Enumerador
{
    public enum TipoDivida
    {
        [Description("Fixa")]
        Fixa = 0,
        [Description("Não-Fixa")]
        NaoFixa = 1
    }
}
