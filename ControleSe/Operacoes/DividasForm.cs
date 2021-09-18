using ControleSe.Entidade;
using ControleSe.Servico;
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
    public partial class DividasForm : Form
    {
        private ServicoDivida _servicoDivida;
        private Usuario _usuario;
        private Divida _divida;

        public DividasForm(Usuario usuario, ServicoDivida servicoDivida, Divida divida)
        {
            InitializeComponent();
            _servicoDivida = servicoDivida;
            _usuario = usuario;
            _divida = divida;
            BindingDividas();
        }

        private void BindingDividas()
        {
            _servicoDivida = _servicoDivida ?? new ServicoDivida();
            _divida.Usuario = _usuario;
            grid.DataSource = _servicoDivida.ObterDividas(_usuario);
            grid.AutoGenerateColumns = false;
        }

        private void LinhaSeleciona(/*DataGridViewCellEventArgs e*/)
        {
            grid.RowEnter += (s, e) =>
            {
                if (e.RowIndex > 0)
                    _divida = grid.Rows[e.RowIndex].DataBoundItem as Divida;
            };

            //if (e.RowIndex < 0)
            //    return;
            //else
            //    _divida = grid.Rows[e.RowIndex].DataBoundItem as Divida;
        }

        private void AlterarIncluir(bool incluir = false)
        {
            if (!incluir)
            {
                LinhaSeleciona();
            }

            using (var form = new DividaDetalhe(_servicoDivida, _divida))
            {
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        => AlterarIncluir(true);

        private void btnAlterar_Click(object sender, EventArgs e)
        => AlterarIncluir();

        private void grid_RowEnter(object sender, DataGridViewCellEventArgs e) => LinhaSeleciona();
    }
}
