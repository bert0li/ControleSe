using ControleSe.Entidade;
using ControleSe.Servico;
using ControleSe.Utilitario.UtilMensagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSe.Operacoes
{
    public partial class CofreForm : Form
    {
        private Usuario _usuario = null;
        private ServicoCofre _servico = null;

        public CofreForm(Usuario usuario, ServicoCofre servicoCofre)
        {
            InitializeComponent();
            _usuario = usuario;
            _servico = servicoCofre;
            ObterValorTotalCofre();
            ObterUltimasEntradas();
        }

        private void ObterValorTotalCofre()
        {
            try
            {
                string valorTotalNoCofre = _servico.ObterValorTotalCofre(_usuario);
                lblValorTotalCofre.Text = valorTotalNoCofre;
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void ObterUltimasEntradas()
        {
            try
            {
                int contador = 0;
                IEnumerable<Tuple<decimal, DateTime>> ultimasEntradas = _servico.ObterUltimasEntradas(_usuario);

                foreach (Tuple<decimal, DateTime> entrada in ultimasEntradas)
                {
                    if (contador == 0)
                    {
                        lblUltimaEntrada01.Text = $"{entrada.Item1.ToString("C2")} - {Convert.ToDateTime(entrada.Item2).ToShortDateString()}";
                        contador++;
                        continue;
                    }

                    if (contador == 1)
                    {
                        lblUltimaEntrada02.Text = $"{entrada.Item1.ToString("C2")} - {Convert.ToDateTime(entrada.Item2).ToShortDateString()}";
                        contador++;
                        continue;
                    }

                    if (contador == 2)
                    {
                        lblUltimaEntrada03.Text = $"{entrada.Item1.ToString("C2")} - {Convert.ToDateTime(entrada.Item2).ToShortDateString()}";
                        contador++;
                        continue;
                    }

                    if (contador == 3)
                    {
                        lblUltimaEntrada04.Text = $"{entrada.Item1.ToString("C2")} - {Convert.ToDateTime(entrada.Item2).ToShortDateString()}";
                        contador++;
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                ServicoLogErro.Gravar(ex.Message, ex.StackTrace);
                Msg.Erro($"[Erro]:{ex.Message}\n[StackTrace]:{ex.StackTrace}");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e) => Close();
    }
}