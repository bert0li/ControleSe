
namespace ControleSe.Operacoes
{
    partial class EntradasForm
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
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.tlpPesquisa = new System.Windows.Forms.TableLayoutPanel();
            this.lblDataDe = new System.Windows.Forms.Label();
            this.dtpDataDe = new System.Windows.Forms.DateTimePicker();
            this.lblDataAte = new System.Windows.Forms.Label();
            this.dtpDataAte = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpBotoes.SuspendLayout();
            this.tlpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.ColumnCount = 2;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.65789F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.34211F));
            this.tlpBotoes.Controls.Add(this.btnAdd, 0, 0);
            this.tlpBotoes.Controls.Add(this.btnDeletar, 1, 0);
            this.tlpBotoes.Location = new System.Drawing.Point(12, 12);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.Size = new System.Drawing.Size(136, 65);
            this.tlpBotoes.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Image = global::ControleSe.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 59);
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
            this.btnDeletar.Location = new System.Drawing.Point(71, 3);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(62, 59);
            this.btnDeletar.TabIndex = 0;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // tlpPesquisa
            // 
            this.tlpPesquisa.ColumnCount = 4;
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.31469F));
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.68532F));
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tlpPesquisa.Controls.Add(this.lblDataDe, 0, 0);
            this.tlpPesquisa.Controls.Add(this.dtpDataDe, 1, 0);
            this.tlpPesquisa.Controls.Add(this.lblDataAte, 2, 0);
            this.tlpPesquisa.Controls.Add(this.dtpDataAte, 3, 0);
            this.tlpPesquisa.Location = new System.Drawing.Point(12, 94);
            this.tlpPesquisa.Name = "tlpPesquisa";
            this.tlpPesquisa.RowCount = 1;
            this.tlpPesquisa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPesquisa.Size = new System.Drawing.Size(522, 33);
            this.tlpPesquisa.TabIndex = 6;
            // 
            // lblDataDe
            // 
            this.lblDataDe.AutoSize = true;
            this.lblDataDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataDe.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataDe.Location = new System.Drawing.Point(3, 0);
            this.lblDataDe.Name = "lblDataDe";
            this.lblDataDe.Size = new System.Drawing.Size(84, 33);
            this.lblDataDe.TabIndex = 0;
            this.lblDataDe.Text = "Data de:";
            this.lblDataDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDataDe
            // 
            this.dtpDataDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDataDe.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDe.Location = new System.Drawing.Point(93, 3);
            this.dtpDataDe.Name = "dtpDataDe";
            this.dtpDataDe.Size = new System.Drawing.Size(159, 26);
            this.dtpDataDe.TabIndex = 2;
            // 
            // lblDataAte
            // 
            this.lblDataAte.AutoSize = true;
            this.lblDataAte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataAte.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataAte.Location = new System.Drawing.Point(258, 0);
            this.lblDataAte.Name = "lblDataAte";
            this.lblDataAte.Size = new System.Drawing.Size(84, 33);
            this.lblDataAte.TabIndex = 0;
            this.lblDataAte.Text = "Data ate:";
            this.lblDataAte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDataAte
            // 
            this.dtpDataAte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDataAte.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAte.Location = new System.Drawing.Point(348, 3);
            this.dtpDataAte.Name = "dtpDataAte";
            this.dtpDataAte.Size = new System.Drawing.Size(171, 26);
            this.dtpDataAte.TabIndex = 2;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisa.Location = new System.Drawing.Point(854, 97);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(208, 27);
            this.btnPesquisa.TabIndex = 3;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
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
            this.colId,
            this.colValorEntrada,
            this.colDataEntrada});
            this.grid.Location = new System.Drawing.Point(12, 146);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 25;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1050, 354);
            this.grid.TabIndex = 7;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colId.HeaderText = "Código";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colValorEntrada
            // 
            this.colValorEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValorEntrada.DataPropertyName = "ValorEntrada";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colValorEntrada.DefaultCellStyle = dataGridViewCellStyle3;
            this.colValorEntrada.HeaderText = "Valor da entrada";
            this.colValorEntrada.Name = "colValorEntrada";
            this.colValorEntrada.ReadOnly = true;
            // 
            // colDataEntrada
            // 
            this.colDataEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDataEntrada.DataPropertyName = "DataEntrada";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colDataEntrada.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDataEntrada.HeaderText = "Data da entrada";
            this.colDataEntrada.Name = "colDataEntrada";
            this.colDataEntrada.ReadOnly = true;
            // 
            // EntradasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 512);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.tlpPesquisa);
            this.Controls.Add(this.tlpBotoes);
            this.Name = "EntradasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpBotoes.ResumeLayout(false);
            this.tlpPesquisa.ResumeLayout(false);
            this.tlpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TableLayoutPanel tlpPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label lblDataDe;
        private System.Windows.Forms.DateTimePicker dtpDataDe;
        private System.Windows.Forms.Label lblDataAte;
        private System.Windows.Forms.DateTimePicker dtpDataAte;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrada;
    }
}