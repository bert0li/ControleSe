
namespace ControleSe.Operacoes
{
    partial class DividasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlpPesquisa = new System.Windows.Forms.TableLayoutPanel();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tlpTotalDivida = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalDivida = new System.Windows.Forms.Label();
            this.lblValorTotalDivida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tlpPesquisa.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            this.tlpTotalDivida.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome,
            this.colDescricao,
            this.colValor,
            this.colDataVencimento,
            this.colPago});
            this.grid.Location = new System.Drawing.Point(12, 137);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 25;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1204, 335);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colNome.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNome.HeaderText = "Nome divida";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colDescricao.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "Valor";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colValor.DefaultCellStyle = dataGridViewCellStyle5;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.DataPropertyName = "DataVencimento";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colDataVencimento.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDataVencimento.HeaderText = "Data vencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.ReadOnly = true;
            this.colDataVencimento.Width = 250;
            // 
            // colPago
            // 
            this.colPago.DataPropertyName = "Pago";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.NullValue = false;
            this.colPago.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPago.HeaderText = "Pago?";
            this.colPago.Name = "colPago";
            this.colPago.ReadOnly = true;
            this.colPago.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tlpPesquisa
            // 
            this.tlpPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPesquisa.ColumnCount = 7;
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.27941F));
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.72059F));
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tlpPesquisa.Controls.Add(this.lblPesquisa, 0, 0);
            this.tlpPesquisa.Controls.Add(this.lblDataInicio, 2, 0);
            this.tlpPesquisa.Controls.Add(this.btnPesquisa, 6, 0);
            this.tlpPesquisa.Controls.Add(this.lblDataFim, 4, 0);
            this.tlpPesquisa.Controls.Add(this.txtPesquisa, 1, 0);
            this.tlpPesquisa.Controls.Add(this.dateTimePicker1, 3, 0);
            this.tlpPesquisa.Controls.Add(this.dateTimePicker2, 5, 0);
            this.tlpPesquisa.Location = new System.Drawing.Point(12, 89);
            this.tlpPesquisa.Name = "tlpPesquisa";
            this.tlpPesquisa.RowCount = 1;
            this.tlpPesquisa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPesquisa.Size = new System.Drawing.Size(1204, 33);
            this.tlpPesquisa.TabIndex = 1;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPesquisa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesquisa.Location = new System.Drawing.Point(3, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(79, 33);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisa:";
            this.lblPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataInicio.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataInicio.Location = new System.Drawing.Point(495, 0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(102, 33);
            this.lblDataInicio.TabIndex = 0;
            this.lblDataInicio.Text = "Data inicio:";
            this.lblDataInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisa.Location = new System.Drawing.Point(965, 3);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(236, 27);
            this.btnPesquisa.TabIndex = 3;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataFim.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataFim.Location = new System.Drawing.Point(735, 0);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(87, 33);
            this.lblDataFim.TabIndex = 0;
            this.lblDataFim.Text = "Data fim:";
            this.lblDataFim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisa.Location = new System.Drawing.Point(88, 3);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(401, 26);
            this.txtPesquisa.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(603, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(828, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.ColumnCount = 3;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.65789F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.34211F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpBotoes.Controls.Add(this.btnAdd, 0, 0);
            this.tlpBotoes.Controls.Add(this.btnDeletar, 2, 0);
            this.tlpBotoes.Controls.Add(this.btnAlterar, 1, 0);
            this.tlpBotoes.Location = new System.Drawing.Point(12, 12);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.Size = new System.Drawing.Size(200, 65);
            this.tlpBotoes.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Image = global::ControleSe.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 59);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.Image = global::ControleSe.Properties.Resources.deletar;
            this.btnDeletar.Location = new System.Drawing.Point(120, 3);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(77, 59);
            this.btnDeletar.TabIndex = 0;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = global::ControleSe.Properties.Resources.alterar;
            this.btnAlterar.Location = new System.Drawing.Point(62, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(52, 59);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tlpTotalDivida
            // 
            this.tlpTotalDivida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTotalDivida.ColumnCount = 2;
            this.tlpTotalDivida.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.65702F));
            this.tlpTotalDivida.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.34298F));
            this.tlpTotalDivida.Controls.Add(this.lblTotalDivida, 0, 0);
            this.tlpTotalDivida.Controls.Add(this.lblValorTotalDivida, 1, 0);
            this.tlpTotalDivida.Location = new System.Drawing.Point(867, 478);
            this.tlpTotalDivida.Name = "tlpTotalDivida";
            this.tlpTotalDivida.RowCount = 1;
            this.tlpTotalDivida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotalDivida.Size = new System.Drawing.Size(349, 31);
            this.tlpTotalDivida.TabIndex = 5;
            // 
            // lblTotalDivida
            // 
            this.lblTotalDivida.AutoSize = true;
            this.lblTotalDivida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalDivida.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDivida.Location = new System.Drawing.Point(3, 0);
            this.lblTotalDivida.Name = "lblTotalDivida";
            this.lblTotalDivida.Size = new System.Drawing.Size(153, 31);
            this.lblTotalDivida.TabIndex = 0;
            this.lblTotalDivida.Text = "Total de divida:";
            this.lblTotalDivida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValorTotalDivida
            // 
            this.lblValorTotalDivida.AutoSize = true;
            this.lblValorTotalDivida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorTotalDivida.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotalDivida.Location = new System.Drawing.Point(162, 0);
            this.lblValorTotalDivida.Name = "lblValorTotalDivida";
            this.lblValorTotalDivida.Size = new System.Drawing.Size(184, 31);
            this.lblValorTotalDivida.TabIndex = 0;
            this.lblValorTotalDivida.Text = "Valor";
            this.lblValorTotalDivida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DividasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1228, 521);
            this.Controls.Add(this.tlpTotalDivida);
            this.Controls.Add(this.tlpBotoes);
            this.Controls.Add(this.tlpPesquisa);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DividasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dividas ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tlpPesquisa.ResumeLayout(false);
            this.tlpPesquisa.PerformLayout();
            this.tlpBotoes.ResumeLayout(false);
            this.tlpTotalDivida.ResumeLayout(false);
            this.tlpTotalDivida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TableLayoutPanel tlpTotalDivida;
        private System.Windows.Forms.Label lblTotalDivida;
        private System.Windows.Forms.Label lblValorTotalDivida;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataVencimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPago;
    }
}