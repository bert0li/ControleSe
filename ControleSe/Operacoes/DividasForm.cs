﻿using ControleSe.Entidade;
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
        private ServicoDivida _servicoDivida = null;
        private Usuario _usuario = null;
        private Divida _divida = null;
        private List<decimal> _somaTotalDivida;

        public DividasForm(Usuario usuario, ServicoDivida servicoDivida, Divida divida)
        {
            InitializeComponent();
            _servicoDivida = servicoDivida;
            _usuario = usuario;
            _divida = divida;
            _divida.UsuarioId = _usuario.Id;
            BindingDividas();
            SomarTotalDivida();
        }

        private void BindingDividas()
        {
            _somaTotalDivida = new List<decimal>();
            _servicoDivida = _servicoDivida ?? new ServicoDivida();
            grid.AutoGenerateColumns = false;
            grid.DataSource = _servicoDivida.ObterDividas(_usuario);
        }

        private void LinhaSeleciona(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
                _divida = grid.Rows[e.RowIndex].DataBoundItem as Divida;
        }

        private void AlterarIncluir(bool incluir = false)
        {
            if (incluir)
            {
                _divida.EhIncluir = true;
            }

            using (var form = new DividaDetalhe(_servicoDivida, _divida))
            {
                form.ShowDialog();
            }

            BindingDividas();
            SomarTotalDivida();
        }

        private void VerificarVencimento(DataGridViewCellFormattingEventArgs e)
        {
            var dataVencimento = (DateTime)grid.Rows[e.RowIndex].Cells["colDataVencimento"]?.Value;

            if (dataVencimento <= DateTime.Now)
            {
                var cells = grid.Columns.Count;

                for (int i = 0; i < cells; i++)
                {
                    grid.Rows[e.RowIndex].Cells[i].Style.ForeColor = Color.Red;
                }
            }
        }

        private void SomarTotalDivida()
        {
            var somaTotalDivida = 0M;

            for (var i = 0; i < grid.RowCount; i++)
            {
                var valorDivida = (decimal)grid.Rows[i].Cells["colValor"]?.Value;
                if (valorDivida > 0)
                {
                    somaTotalDivida += valorDivida;
                }
            }

            lblValorTotalDivida.Text = somaTotalDivida.ToString("C");
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            => VerificarVencimento(e);

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            => LinhaSeleciona(e);

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
            => LinhaSeleciona(e);

        private void btnAdd_Click(object sender, EventArgs e)
            => AlterarIncluir(true);

        private void btnAlterar_Click(object sender, EventArgs e)
            => AlterarIncluir();
    }
}