
namespace ControleSe.Operacoes
{
    partial class DividaDetalheFormNova
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
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.lblDetalheDivida = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tlpPagar = new System.Windows.Forms.TableLayoutPanel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.tlpInfoDivida = new System.Windows.Forms.TableLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cbxTipoDivida = new System.Windows.Forms.ComboBox();
            this.lblTipoDivida = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tlpCodigo = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            this.tlpPagar.SuspendLayout();
            this.tlpInfoDivida.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            this.tlpCodigo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimizar.Location = new System.Drawing.Point(1548, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(51, 52);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DarkGray;
            this.panelCabecalho.Controls.Add(this.lblDetalheDivida);
            this.panelCabecalho.Controls.Add(this.btnMinimizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(636, 52);
            this.panelCabecalho.TabIndex = 2;
            // 
            // lblDetalheDivida
            // 
            this.lblDetalheDivida.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetalheDivida.Location = new System.Drawing.Point(0, 0);
            this.lblDetalheDivida.Name = "lblDetalheDivida";
            this.lblDetalheDivida.Size = new System.Drawing.Size(167, 52);
            this.lblDetalheDivida.TabIndex = 3;
            this.lblDetalheDivida.Text = "Detalhe da divida";
            this.lblDetalheDivida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(585, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(51, 52);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tlpPagar
            // 
            this.tlpPagar.ColumnCount = 1;
            this.tlpPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPagar.Controls.Add(this.btnPagar, 0, 0);
            this.tlpPagar.Location = new System.Drawing.Point(545, 95);
            this.tlpPagar.Name = "tlpPagar";
            this.tlpPagar.RowCount = 1;
            this.tlpPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPagar.Size = new System.Drawing.Size(80, 37);
            this.tlpPagar.TabIndex = 2;
            // 
            // btnPagar
            // 
            this.btnPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPagar.Location = new System.Drawing.Point(3, 3);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(74, 31);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // tlpInfoDivida
            // 
            this.tlpInfoDivida.ColumnCount = 2;
            this.tlpInfoDivida.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.45827F));
            this.tlpInfoDivida.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.54173F));
            this.tlpInfoDivida.Controls.Add(this.lblNome, 0, 0);
            this.tlpInfoDivida.Controls.Add(this.txtNome, 1, 0);
            this.tlpInfoDivida.Controls.Add(this.lblDescricao, 0, 1);
            this.tlpInfoDivida.Controls.Add(this.lblValor, 0, 2);
            this.tlpInfoDivida.Controls.Add(this.cbxTipoDivida, 10, 3);
            this.tlpInfoDivida.Controls.Add(this.lblTipoDivida, 0, 3);
            this.tlpInfoDivida.Controls.Add(this.txtDescricao, 1, 1);
            this.tlpInfoDivida.Controls.Add(this.txtValor, 1, 2);
            this.tlpInfoDivida.Controls.Add(this.lblDataVencimento, 0, 4);
            this.tlpInfoDivida.Controls.Add(this.dtpDataVencimento, 1, 4);
            this.tlpInfoDivida.Location = new System.Drawing.Point(3, 138);
            this.tlpInfoDivida.Name = "tlpInfoDivida";
            this.tlpInfoDivida.RowCount = 5;
            this.tlpInfoDivida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfoDivida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfoDivida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpInfoDivida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpInfoDivida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpInfoDivida.Size = new System.Drawing.Size(622, 181);
            this.tlpInfoDivida.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(121, 36);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome divida:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(130, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(489, 27);
            this.txtNome.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(3, 36);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(121, 36);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(3, 72);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(121, 36);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor divida:";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxTipoDivida
            // 
            this.cbxTipoDivida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxTipoDivida.DropDownHeight = 100;
            this.cbxTipoDivida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDivida.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxTipoDivida.FormattingEnabled = true;
            this.cbxTipoDivida.IntegralHeight = false;
            this.cbxTipoDivida.Location = new System.Drawing.Point(130, 111);
            this.cbxTipoDivida.Name = "cbxTipoDivida";
            this.cbxTipoDivida.Size = new System.Drawing.Size(168, 27);
            this.cbxTipoDivida.TabIndex = 2;
            this.cbxTipoDivida.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDivida_SelectedIndexChanged);
            // 
            // lblTipoDivida
            // 
            this.lblTipoDivida.AutoSize = true;
            this.lblTipoDivida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipoDivida.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDivida.Location = new System.Drawing.Point(3, 108);
            this.lblTipoDivida.Name = "lblTipoDivida";
            this.lblTipoDivida.Size = new System.Drawing.Size(121, 36);
            this.lblTipoDivida.TabIndex = 0;
            this.lblTipoDivida.Text = "Tipo divida:";
            this.lblTipoDivida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.Location = new System.Drawing.Point(130, 39);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(489, 27);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(130, 75);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(489, 27);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataVencimento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataVencimento.Location = new System.Drawing.Point(3, 144);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(121, 37);
            this.lblDataVencimento.TabIndex = 0;
            this.lblDataVencimento.Text = "Data venc.:";
            this.lblDataVencimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(130, 147);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(168, 27);
            this.dtpDataVencimento.TabIndex = 3;
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.ColumnCount = 2;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.Controls.Add(this.btnSalvar, 0, 0);
            this.tlpBotoes.Controls.Add(this.btnSair, 1, 0);
            this.tlpBotoes.Location = new System.Drawing.Point(378, 335);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.Size = new System.Drawing.Size(247, 35);
            this.tlpBotoes.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(3, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 29);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar [F5]";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(126, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 29);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair [Esc]";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // tlpCodigo
            // 
            this.tlpCodigo.ColumnCount = 2;
            this.tlpCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.44586F));
            this.tlpCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.55414F));
            this.tlpCodigo.Controls.Add(this.lblCodigo, 0, 0);
            this.tlpCodigo.Controls.Add(this.txtCodigo, 1, 0);
            this.tlpCodigo.Location = new System.Drawing.Point(0, 95);
            this.tlpCodigo.Name = "tlpCodigo";
            this.tlpCodigo.RowCount = 1;
            this.tlpCodigo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCodigo.Size = new System.Drawing.Size(314, 37);
            this.tlpCodigo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.Location = new System.Drawing.Point(3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(121, 37);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(130, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(181, 30);
            this.txtCodigo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.tlpInfoDivida);
            this.panel1.Controls.Add(this.tlpPagar);
            this.panel1.Controls.Add(this.tlpCodigo);
            this.panel1.Controls.Add(this.panelCabecalho);
            this.panel1.Controls.Add(this.tlpBotoes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 381);
            this.panel1.TabIndex = 6;
            // 
            // DividaDetalheFormNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(660, 405);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DividaDetalheFormNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelCabecalho.ResumeLayout(false);
            this.tlpPagar.ResumeLayout(false);
            this.tlpInfoDivida.ResumeLayout(false);
            this.tlpInfoDivida.PerformLayout();
            this.tlpBotoes.ResumeLayout(false);
            this.tlpCodigo.ResumeLayout(false);
            this.tlpCodigo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.TableLayoutPanel tlpPagar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TableLayoutPanel tlpInfoDivida;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cbxTipoDivida;
        private System.Windows.Forms.Label lblTipoDivida;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TableLayoutPanel tlpCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDetalheDivida;
        private System.Windows.Forms.Panel panel1;
    }
}