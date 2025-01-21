namespace Trafipax_20250116
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsgyors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrogzit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsstat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsexit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsgyors,
            this.tsstat,
            this.tsexit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsgyors
            // 
            this.tsgyors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrogzit});
            this.tsgyors.Name = "tsgyors";
            this.tsgyors.Size = new System.Drawing.Size(93, 20);
            this.tsgyors.Text = "Gyorshajtások";
            // 
            // tsrogzit
            // 
            this.tsrogzit.Name = "tsrogzit";
            this.tsrogzit.Size = new System.Drawing.Size(118, 22);
            this.tsrogzit.Text = "Rögzítés";
            this.tsrogzit.Click += new System.EventHandler(this.tsrogzit_Click);
            // 
            // tsstat
            // 
            this.tsstat.Name = "tsstat";
            this.tsstat.Size = new System.Drawing.Size(71, 20);
            this.tsstat.Text = "Statisztika";
            this.tsstat.Click += new System.EventHandler(this.tsstat_Click);
            // 
            // tsexit
            // 
            this.tsexit.Name = "tsexit";
            this.tsexit.Size = new System.Drawing.Size(56, 20);
            this.tsexit.Text = "Kilépés";
            this.tsexit.Click += new System.EventHandler(this.tsexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsgyors;
        private System.Windows.Forms.ToolStripMenuItem tsrogzit;
        private System.Windows.Forms.ToolStripMenuItem tsstat;
        private System.Windows.Forms.ToolStripMenuItem tsexit;
    }
}

