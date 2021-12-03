
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelDividas = new System.Windows.Forms.Panel();
            this.btnDividas = new System.Windows.Forms.Button();
            this.panelEntradas = new System.Windows.Forms.Panel();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panelDividas.SuspendLayout();
            this.panelEntradas.SuspendLayout();
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
            this.lblData.Size = new System.Drawing.Size(41, 19);
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
            this.btnDividas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDividas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDividas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividas.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.btnEntradas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1010, 384);
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
    }
}