
namespace ControleSe
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelDividas = new System.Windows.Forms.Panel();
            this.btnDividas = new System.Windows.Forms.Button();
            this.panelEntradas = new System.Windows.Forms.Panel();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelCofre = new System.Windows.Forms.Panel();
            this.btnCofre = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelRelatorio = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panelDividas.SuspendLayout();
            this.panelEntradas.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.panelCofre.SuspendLayout();
            this.panelRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHora,
            this.lblData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1010, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 19);
            this.lblHora.Text = "hora";
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 19);
            this.lblData.Text = "data";
            // 
            // panelDividas
            // 
            this.panelDividas.Controls.Add(this.btnDividas);
            this.panelDividas.Location = new System.Drawing.Point(12, 12);
            this.panelDividas.Name = "panelDividas";
            this.panelDividas.Size = new System.Drawing.Size(149, 161);
            this.panelDividas.TabIndex = 2;
            // 
            // btnDividas
            // 
            this.btnDividas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDividas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDividas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDividas.Image = global::ControleSe.Properties.Resources.dividaMenu;
            this.btnDividas.Location = new System.Drawing.Point(0, 0);
            this.btnDividas.Name = "btnDividas";
            this.btnDividas.Size = new System.Drawing.Size(149, 161);
            this.btnDividas.TabIndex = 1;
            this.btnDividas.Text = "Dividas";
            this.btnDividas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDividas.UseVisualStyleBackColor = false;
            this.btnDividas.Click += new System.EventHandler(this.btnDividas_Click);
            // 
            // panelEntradas
            // 
            this.panelEntradas.Controls.Add(this.btnEntradas);
            this.panelEntradas.Controls.Add(this.button3);
            this.panelEntradas.Location = new System.Drawing.Point(179, 12);
            this.panelEntradas.Name = "panelEntradas";
            this.panelEntradas.Size = new System.Drawing.Size(149, 161);
            this.panelEntradas.TabIndex = 3;
            // 
            // btnEntradas
            // 
            this.btnEntradas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntradas.Image = global::ControleSe.Properties.Resources.entradaMenu;
            this.btnEntradas.Location = new System.Drawing.Point(0, 0);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(149, 161);
            this.btnEntradas.TabIndex = 1;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntradas.UseVisualStyleBackColor = false;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::ControleSe.Properties.Resources.dividaMenu;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 161);
            this.button3.TabIndex = 0;
            this.button3.Text = "Dividas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Controls.Add(this.btnUsuarios);
            this.panelUsuarios.Controls.Add(this.button2);
            this.panelUsuarios.Location = new System.Drawing.Point(682, 12);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(149, 161);
            this.panelUsuarios.TabIndex = 4;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(149, 161);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::ControleSe.Properties.Resources.dividaMenu;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 161);
            this.button2.TabIndex = 0;
            this.button2.Text = "Dividas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelCofre
            // 
            this.panelCofre.Controls.Add(this.btnCofre);
            this.panelCofre.Controls.Add(this.button4);
            this.panelCofre.Location = new System.Drawing.Point(348, 12);
            this.panelCofre.Name = "panelCofre";
            this.panelCofre.Size = new System.Drawing.Size(149, 161);
            this.panelCofre.TabIndex = 5;
            // 
            // btnCofre
            // 
            this.btnCofre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCofre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCofre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCofre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCofre.Image = global::ControleSe.Properties.Resources.cofreMenu;
            this.btnCofre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCofre.Location = new System.Drawing.Point(0, 0);
            this.btnCofre.Name = "btnCofre";
            this.btnCofre.Size = new System.Drawing.Size(149, 161);
            this.btnCofre.TabIndex = 1;
            this.btnCofre.Text = "Cofre";
            this.btnCofre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCofre.UseVisualStyleBackColor = false;
            this.btnCofre.Click += new System.EventHandler(this.btnCofre_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::ControleSe.Properties.Resources.dividaMenu;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 161);
            this.button4.TabIndex = 0;
            this.button4.Text = "Dividas";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panelRelatorio
            // 
            this.panelRelatorio.Controls.Add(this.btnRelatorios);
            this.panelRelatorio.Controls.Add(this.button5);
            this.panelRelatorio.Location = new System.Drawing.Point(514, 12);
            this.panelRelatorio.Name = "panelRelatorio";
            this.panelRelatorio.Size = new System.Drawing.Size(149, 161);
            this.panelRelatorio.TabIndex = 6;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRelatorios.Image = global::ControleSe.Properties.Resources.relatorioMenu;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 0);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(149, 161);
            this.btnRelatorios.TabIndex = 1;
            this.btnRelatorios.Text = "Relatório";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = global::ControleSe.Properties.Resources.dividaMenu;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 161);
            this.button5.TabIndex = 0;
            this.button5.Text = "Dividas";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1010, 384);
            this.Controls.Add(this.panelRelatorio);
            this.Controls.Add(this.panelCofre);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.panelEntradas);
            this.Controls.Add(this.panelDividas);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelDividas.ResumeLayout(false);
            this.panelEntradas.ResumeLayout(false);
            this.panelUsuarios.ResumeLayout(false);
            this.panelCofre.ResumeLayout(false);
            this.panelRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.Panel panelDividas;
        private System.Windows.Forms.Button btnDividas;
        private System.Windows.Forms.Panel panelEntradas;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelCofre;
        private System.Windows.Forms.Button btnCofre;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelRelatorio;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button button5;
    }
}