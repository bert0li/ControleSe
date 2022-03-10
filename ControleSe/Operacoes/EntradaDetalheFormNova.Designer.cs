
namespace ControleSe.Operacoes
{
    partial class EntradaDetalheFormNova
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
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.lblDetalheEntrada = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblValorEntrada = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.panelDetalheEntrada = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDetalheEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DarkGray;
            this.panelCabecalho.Controls.Add(this.lblDetalheEntrada);
            this.panelCabecalho.Controls.Add(this.btnMinimizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(458, 52);
            this.panelCabecalho.TabIndex = 3;
            // 
            // lblDetalheEntrada
            // 
            this.lblDetalheEntrada.BackColor = System.Drawing.Color.DarkGray;
            this.lblDetalheEntrada.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDetalheEntrada.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetalheEntrada.Location = new System.Drawing.Point(0, 0);
            this.lblDetalheEntrada.Name = "lblDetalheEntrada";
            this.lblDetalheEntrada.Size = new System.Drawing.Size(187, 52);
            this.lblDetalheEntrada.TabIndex = 3;
            this.lblDetalheEntrada.Text = "Detalhe da entrada";
            this.lblDetalheEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnMinimizar.Location = new System.Drawing.Point(1806, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(51, 52);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
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
            this.btnFechar.Location = new System.Drawing.Point(407, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(51, 52);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.ColumnCount = 2;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.Controls.Add(this.btnSalvar, 0, 0);
            this.tlpBotoes.Controls.Add(this.btnSair, 1, 0);
            this.tlpBotoes.Location = new System.Drawing.Point(196, 241);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.Size = new System.Drawing.Size(247, 35);
            this.tlpBotoes.TabIndex = 5;
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
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblInformacao
            // 
            this.lblInformacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblInformacao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInformacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInformacao.Location = new System.Drawing.Point(15, 67);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(428, 75);
            this.lblInformacao.TabIndex = 7;
            this.lblInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.22749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.77251F));
            this.tableLayoutPanel1.Controls.Add(this.lblValorEntrada, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblObservacao, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtValorEntrada, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtObservacao, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 156);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 64);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblValorEntrada
            // 
            this.lblValorEntrada.AutoSize = true;
            this.lblValorEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorEntrada.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorEntrada.Location = new System.Drawing.Point(3, 0);
            this.lblValorEntrada.Name = "lblValorEntrada";
            this.lblValorEntrada.Size = new System.Drawing.Size(131, 32);
            this.lblValorEntrada.TabIndex = 0;
            this.lblValorEntrada.Text = "Valor entrada:";
            this.lblValorEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObservacao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObservacao.Location = new System.Drawing.Point(3, 32);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(131, 32);
            this.lblObservacao.TabIndex = 0;
            this.lblObservacao.Text = "Observação:";
            this.lblObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValorEntrada.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorEntrada.Location = new System.Drawing.Point(140, 3);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(285, 26);
            this.txtValorEntrada.TabIndex = 1;
            this.txtValorEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorEntrada_KeyDown);
            this.txtValorEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorEntrada_KeyPress);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacao.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObservacao.Location = new System.Drawing.Point(140, 35);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(285, 26);
            this.txtObservacao.TabIndex = 1;
            this.txtObservacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorEntrada_KeyDown);
            // 
            // panelDetalheEntrada
            // 
            this.panelDetalheEntrada.BackColor = System.Drawing.Color.Silver;
            this.panelDetalheEntrada.Controls.Add(this.lblInformacao);
            this.panelDetalheEntrada.Controls.Add(this.tlpBotoes);
            this.panelDetalheEntrada.Controls.Add(this.panelCabecalho);
            this.panelDetalheEntrada.Controls.Add(this.tableLayoutPanel1);
            this.panelDetalheEntrada.Location = new System.Drawing.Point(12, 12);
            this.panelDetalheEntrada.Name = "panelDetalheEntrada";
            this.panelDetalheEntrada.Size = new System.Drawing.Size(458, 291);
            this.panelDetalheEntrada.TabIndex = 8;
            // 
            // EntradaDetalheFormNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(482, 315);
            this.Controls.Add(this.panelDetalheEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntradaDetalheFormNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntradaDetalheFormNova";
            this.panelCabecalho.ResumeLayout(false);
            this.tlpBotoes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelDetalheEntrada.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label lblDetalheEntrada;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblValorEntrada;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtValorEntrada;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Panel panelDetalheEntrada;
    }
}