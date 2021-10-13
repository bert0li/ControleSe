
namespace ControleSe.Operacoes
{
    partial class LoginForm
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
            this.tlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpLogin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLogin
            // 
            this.tlpLogin.ColumnCount = 2;
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.14773F));
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.85227F));
            this.tlpLogin.Controls.Add(this.lblUsuario, 0, 0);
            this.tlpLogin.Controls.Add(this.lblSenha, 0, 1);
            this.tlpLogin.Controls.Add(this.txtUsuario, 1, 0);
            this.tlpLogin.Controls.Add(this.txtSenha, 1, 1);
            this.tlpLogin.Location = new System.Drawing.Point(12, 41);
            this.tlpLogin.Name = "tlpLogin";
            this.tlpLogin.RowCount = 2;
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.68421F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579F));
            this.tlpLogin.Size = new System.Drawing.Size(352, 68);
            this.tlpLogin.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(3, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 33);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(3, 33);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(79, 35);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(88, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(261, 27);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtSenha
            // 
            this.txtSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(88, 36);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(261, 27);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnEntrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(164, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 34);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.ForeColor = System.Drawing.Color.Green;
            this.btnEntrar.Location = new System.Drawing.Point(3, 3);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(94, 28);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(103, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 28);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 179);
            this.Controls.Add(this.tlpLogin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem vindo ao ControleSe!!";
            this.tlpLogin.ResumeLayout(false);
            this.tlpLogin.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}