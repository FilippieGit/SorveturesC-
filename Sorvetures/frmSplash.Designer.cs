namespace Sorvetures
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.ptbLogoSplash = new System.Windows.Forms.PictureBox();
            this.lblNumSplash = new System.Windows.Forms.Label();
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLogoSplash
            // 
            this.ptbLogoSplash.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogoSplash.Image")));
            this.ptbLogoSplash.Location = new System.Drawing.Point(263, 88);
            this.ptbLogoSplash.Name = "ptbLogoSplash";
            this.ptbLogoSplash.Size = new System.Drawing.Size(254, 241);
            this.ptbLogoSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogoSplash.TabIndex = 0;
            this.ptbLogoSplash.TabStop = false;
            // 
            // lblNumSplash
            // 
            this.lblNumSplash.AutoSize = true;
            this.lblNumSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSplash.Location = new System.Drawing.Point(377, 369);
            this.lblNumSplash.Name = "lblNumSplash";
            this.lblNumSplash.Size = new System.Drawing.Size(16, 18);
            this.lblNumSplash.TabIndex = 1;
            this.lblNumSplash.Text = "0";
            this.lblNumSplash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumSplash.Click += new System.EventHandler(this.label1_Click);
            // 
            // pgbSplash
            // 
            this.pgbSplash.Location = new System.Drawing.Point(263, 399);
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(254, 23);
            this.pgbSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbSplash.TabIndex = 3;
            this.pgbSplash.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pgbSplash);
            this.Controls.Add(this.lblNumSplash);
            this.Controls.Add(this.ptbLogoSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carregamento";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLogoSplash;
        private System.Windows.Forms.Label lblNumSplash;
        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Timer tmrSplash;
    }
}