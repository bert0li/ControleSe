
namespace ControleSe.Operacoes
{
    partial class UsuarioDetalheFormNova
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
            this.panelDetalheUsuario = new System.Windows.Forms.Panel();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tlpInfoDivida = new System.Windows.Forms.TableLayoutPanel();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.tlpCodigo = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbxAtivo = new System.Windows.Forms.CheckBox();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.lblDetalheUsuario = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelDetalheUsuario.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            this.tlpInfoDivida.SuspendLayout();
            this.tlpCodigo.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalheUsuario
            // 
            this.panelDetalheUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetalheUsuario.BackColor = System.Drawing.Color.Silver;
            this.panelDetalheUsuario.Controls.Add(this.tlpBotoes);
            this.panelDetalheUsuario.Controls.Add(this.tlpInfoDivida);
            this.panelDetalheUsuario.Controls.Add(this.tlpCodigo);
            this.panelDetalheUsuario.Controls.Add(this.panelCabecalho);
            this.panelDetalheUsuario.Location = new System.Drawing.Point(12, 12);
            this.panelDetalheUsuario.Name = "panelDetalheUsuario";
            this.panelDetalheUsuario.Size = new System.Drawing.Size(629, 325);
            this.panelDetalheUsuario.TabIndex = 0;
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.ColumnCount = 2;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.Controls.Add(this.btnSalvar, 0, 0);
            this.tlpBotoes.Controls.Add(this.btnSair, 1, 0);
            this.tlpBotoes.Location = new System.Drawing.Point(367, 277);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.Size = new System.Drawing.Size(247, 35);
            this.tlpBotoes.TabIndex = 7;
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
            // tlpInfoDivida
            // 
            this.tlpInfoDivida.ColumnCount = 2;
            this.tlpInfoDivida.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8036F));
            this.tlpInfoDivida.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.1964F));
            this.tlpInfoDivida.Controls.Add(this.txtConfirmarSenha, 1, 3);
            this.tlpInfoDivida.Controls.Add(this.lblNome, 0, 0);
            this.tlpInfoDivida.Controls.Add(this.txtNome, 1, 0);
            this.tlpInfoDivida.Controls.Add(this.lblUsuario, 0, 1);
            this.tlpInfoDivida.Controls.Add(this.lblSenha, 0, 2);
            this.tlpInfoDivida.Controls.Add(this.lblConfirmarSenha, 0, 3);
            this.tlpInfoDivida.Controls.Add(this.txtUsuario, 1, 1);
            this.tlpInfoDivida.Controls.Add(this.txtSenha, 1, 2);
            this.tlpInfoDivida.Location = new System.Drawing.Point(3, 116);
            this.tlpInfoDivida.Name = "tlpInfoDivida";
            this.tlpInfoDivida.RowCount = 4;
            this.tlpInfoDivida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfoDivida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfoDivida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpInfoDivida.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpInfoDivida.Size = new System.Drawing.Size(611, 140);
            this.tlpInfoDivida.TabIndex = 6;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmarSenha.Location = new System.Drawing.Point(124, 107);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(484, 27);
            this.txtConfirmarSenha.TabIndex = 2;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            this.txtConfirmarSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtConfirmarSenha.Validated += new System.EventHandler(this.txtConfirmarSenha_Validated);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(115, 34);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(124, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(484, 27);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(3, 34);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(115, 34);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(3, 68);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(115, 36);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmarSenha.Location = new System.Drawing.Point(3, 104);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(115, 36);
            this.lblConfirmarSenha.TabIndex = 0;
            this.lblConfirmarSenha.Text = "Conf. senha:";
            this.lblConfirmarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(124, 37);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(484, 27);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // txtSenha
            // 
            this.txtSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(124, 71);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(484, 27);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtSenha.Validated += new System.EventHandler(this.txtSenha_Validated);
            // 
            // tlpCodigo
            // 
            this.tlpCodigo.ColumnCount = 4;
            this.tlpCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.57143F));
            this.tlpCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.42857F));
            this.tlpCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tlpCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpCodigo.Controls.Add(this.lblCodigo, 0, 0);
            this.tlpCodigo.Controls.Add(this.txtCodigo, 1, 0);
            this.tlpCodigo.Controls.Add(this.cbxAtivo, 3, 0);
            this.tlpCodigo.Location = new System.Drawing.Point(3, 73);
            this.tlpCodigo.Name = "tlpCodigo";
            this.tlpCodigo.RowCount = 1;
            this.tlpCodigo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCodigo.Size = new System.Drawing.Size(561, 37);
            this.tlpCodigo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.Location = new System.Drawing.Point(3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(116, 37);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(125, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 30);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.AutoSize = true;
            this.cbxAtivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxAtivo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxAtivo.Location = new System.Drawing.Point(472, 3);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(86, 31);
            this.cbxAtivo.TabIndex = 2;
            this.cbxAtivo.Text = "Ativo?";
            this.cbxAtivo.UseVisualStyleBackColor = true;
            this.cbxAtivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DarkGray;
            this.panelCabecalho.Controls.Add(this.lblDetalheUsuario);
            this.panelCabecalho.Controls.Add(this.btnMinimizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(629, 52);
            this.panelCabecalho.TabIndex = 4;
            // 
            // lblDetalheUsuario
            // 
            this.lblDetalheUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.lblDetalheUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDetalheUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetalheUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblDetalheUsuario.Name = "lblDetalheUsuario";
            this.lblDetalheUsuario.Size = new System.Drawing.Size(363, 52);
            this.lblDetalheUsuario.TabIndex = 3;
            this.lblDetalheUsuario.Text = "Detalhe do usuário";
            this.lblDetalheUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnMinimizar.Location = new System.Drawing.Point(2235, 0);
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
            this.btnFechar.Location = new System.Drawing.Point(578, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(51, 52);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // UsuarioDetalheFormNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(653, 349);
            this.Controls.Add(this.panelDetalheUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuarioDetalheFormNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioDetalheFormNova";
            this.panelDetalheUsuario.ResumeLayout(false);
            this.tlpBotoes.ResumeLayout(false);
            this.tlpInfoDivida.ResumeLayout(false);
            this.tlpInfoDivida.PerformLayout();
            this.tlpCodigo.ResumeLayout(false);
            this.tlpCodigo.PerformLayout();
            this.panelCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetalheUsuario;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TableLayoutPanel tlpCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox cbxAtivo;
        private System.Windows.Forms.TableLayoutPanel tlpInfoDivida;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Label lblDetalheUsuario;
    }
}