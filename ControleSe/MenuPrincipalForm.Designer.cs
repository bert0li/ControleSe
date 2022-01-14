
namespace ControleSe
{
    partial class MenuPrincipalForm
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
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnCofre = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnDividas = new System.Windows.Forms.Button();
            this.panelRodape = new System.Windows.Forms.Panel();
            this.lblRodapeDataHora = new System.Windows.Forms.Label();
            this.lblRodapeUsuarioLogado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DarkGray;
            this.panelCabecalho.Controls.Add(this.btnMinimizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1039, 52);
            this.panelCabecalho.TabIndex = 0;
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
            this.btnMinimizar.Location = new System.Drawing.Point(931, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(51, 52);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(988, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(51, 52);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkGray;
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnRelatorios);
            this.panelMenu.Controls.Add(this.btnCofre);
            this.panelMenu.Controls.Add(this.btnEntradas);
            this.panelMenu.Controls.Add(this.btnDividas);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 52);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.Location = new System.Drawing.Point(3, 231);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(194, 48);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRelatorios.Location = new System.Drawing.Point(3, 177);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(194, 48);
            this.btnRelatorios.TabIndex = 5;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnCofre
            // 
            this.btnCofre.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCofre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCofre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCofre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCofre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCofre.Location = new System.Drawing.Point(3, 123);
            this.btnCofre.Name = "btnCofre";
            this.btnCofre.Size = new System.Drawing.Size(194, 48);
            this.btnCofre.TabIndex = 4;
            this.btnCofre.Text = "Cofre";
            this.btnCofre.UseVisualStyleBackColor = true;
            this.btnCofre.Click += new System.EventHandler(this.btnCofre_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntradas.Location = new System.Drawing.Point(3, 69);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(194, 48);
            this.btnEntradas.TabIndex = 3;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnDividas
            // 
            this.btnDividas.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDividas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDividas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnDividas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividas.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDividas.Location = new System.Drawing.Point(3, 15);
            this.btnDividas.Name = "btnDividas";
            this.btnDividas.Size = new System.Drawing.Size(194, 48);
            this.btnDividas.TabIndex = 2;
            this.btnDividas.Text = "Dividas";
            this.btnDividas.UseVisualStyleBackColor = true;
            this.btnDividas.Click += new System.EventHandler(this.btnDividas_Click);
            // 
            // panelRodape
            // 
            this.panelRodape.BackColor = System.Drawing.Color.DarkGray;
            this.panelRodape.Controls.Add(this.lblRodapeDataHora);
            this.panelRodape.Controls.Add(this.lblRodapeUsuarioLogado);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Location = new System.Drawing.Point(200, 457);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(839, 45);
            this.panelRodape.TabIndex = 2;
            // 
            // lblRodapeDataHora
            // 
            this.lblRodapeDataHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRodapeDataHora.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRodapeDataHora.Location = new System.Drawing.Point(402, 0);
            this.lblRodapeDataHora.Name = "lblRodapeDataHora";
            this.lblRodapeDataHora.Size = new System.Drawing.Size(437, 45);
            this.lblRodapeDataHora.TabIndex = 1;
            this.lblRodapeDataHora.Text = "Data/Hora";
            this.lblRodapeDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRodapeUsuarioLogado
            // 
            this.lblRodapeUsuarioLogado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRodapeUsuarioLogado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRodapeUsuarioLogado.Location = new System.Drawing.Point(0, 0);
            this.lblRodapeUsuarioLogado.Name = "lblRodapeUsuarioLogado";
            this.lblRodapeUsuarioLogado.Size = new System.Drawing.Size(396, 45);
            this.lblRodapeUsuarioLogado.TabIndex = 0;
            this.lblRodapeUsuarioLogado.Text = "Usuário logado:";
            this.lblRodapeUsuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(200, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 405);
            this.label1.TabIndex = 3;
            this.label1.Text = "ControleSe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1039, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelRodape);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelCabecalho.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDividas;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnCofre;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Label lblRodapeUsuarioLogado;
        private System.Windows.Forms.Label lblRodapeDataHora;
        private System.Windows.Forms.Label label1;
    }
}