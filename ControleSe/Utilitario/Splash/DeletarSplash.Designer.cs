
namespace ControleSe.Utilitario.Splash
{
    partial class DeletarSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarSplash));
            this.pbxDeletarSplash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeletarSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDeletarSplash
            // 
            this.pbxDeletarSplash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxDeletarSplash.Image = ((System.Drawing.Image)(resources.GetObject("pbxDeletarSplash.Image")));
            this.pbxDeletarSplash.Location = new System.Drawing.Point(12, 12);
            this.pbxDeletarSplash.Name = "pbxDeletarSplash";
            this.pbxDeletarSplash.Size = new System.Drawing.Size(185, 152);
            this.pbxDeletarSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDeletarSplash.TabIndex = 0;
            this.pbxDeletarSplash.TabStop = false;
            // 
            // DeletarSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(209, 176);
            this.Controls.Add(this.pbxDeletarSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletarSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletarSplash";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeletarSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDeletarSplash;
    }
}