
namespace ControleSe.Operacoes
{
    partial class CofreForm
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
            this.lblValorTotalCofre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloValorTotalCofre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorTotalCofre
            // 
            this.lblValorTotalCofre.BackColor = System.Drawing.Color.LightGray;
            this.lblValorTotalCofre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorTotalCofre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorTotalCofre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorTotalCofre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotalCofre.Location = new System.Drawing.Point(3, 58);
            this.lblValorTotalCofre.Name = "lblValorTotalCofre";
            this.lblValorTotalCofre.Size = new System.Drawing.Size(529, 240);
            this.lblValorTotalCofre.TabIndex = 0;
            this.lblValorTotalCofre.Text = "R$";
            this.lblValorTotalCofre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.01198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.98802F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.3634F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.6366F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblValorTotalCofre, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTituloValorTotalCofre, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(130, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.54023F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.45977F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(535, 298);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblTituloValorTotalCofre
            // 
            this.lblTituloValorTotalCofre.AutoSize = true;
            this.lblTituloValorTotalCofre.BackColor = System.Drawing.Color.Silver;
            this.lblTituloValorTotalCofre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTituloValorTotalCofre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloValorTotalCofre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTituloValorTotalCofre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloValorTotalCofre.Location = new System.Drawing.Point(3, 0);
            this.lblTituloValorTotalCofre.Name = "lblTituloValorTotalCofre";
            this.lblTituloValorTotalCofre.Size = new System.Drawing.Size(529, 58);
            this.lblTituloValorTotalCofre.TabIndex = 1;
            this.lblTituloValorTotalCofre.Text = "VALOR TOTAL NO COFRE";
            this.lblTituloValorTotalCofre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CofreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CofreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cofre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValorTotalCofre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTituloValorTotalCofre;
    }
}