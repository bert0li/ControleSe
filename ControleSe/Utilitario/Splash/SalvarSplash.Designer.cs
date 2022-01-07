
namespace ControleSe.Utilitario.Splash
{
    partial class SalvarSplash
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
            this.pbxSalvarSplash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalvarSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxSalvarSplash
            // 
            this.pbxSalvarSplash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSalvarSplash.Image = global::ControleSe.Properties.Resources.salvarSplash;
            this.pbxSalvarSplash.Location = new System.Drawing.Point(12, 12);
            this.pbxSalvarSplash.Name = "pbxSalvarSplash";
            this.pbxSalvarSplash.Size = new System.Drawing.Size(179, 156);
            this.pbxSalvarSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSalvarSplash.TabIndex = 0;
            this.pbxSalvarSplash.TabStop = false;
            // 
            // SalvarSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(203, 180);
            this.Controls.Add(this.pbxSalvarSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalvarSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalvarSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSalvarSplash;
    }
}