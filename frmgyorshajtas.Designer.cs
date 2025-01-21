namespace Trafipax_20250116
{
    partial class frmgyorshajtas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgyorshajtas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbkategoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbbuntetes = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.txrendszam = new System.Windows.Forms.TextBox();
            this.txmertseb = new System.Windows.Forms.TextBox();
            this.btexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sebességhatár: 100 km/h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Büntetési kategória: ";
            // 
            // lbkategoria
            // 
            this.lbkategoria.AutoSize = true;
            this.lbkategoria.Location = new System.Drawing.Point(198, 189);
            this.lbkategoria.Name = "lbkategoria";
            this.lbkategoria.Size = new System.Drawing.Size(121, 17);
            this.lbkategoria.TabIndex = 3;
            this.lbkategoria.Text = "Nincs kategória";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mért sebesség:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Büntetés összege: ";
            // 
            // lbbuntetes
            // 
            this.lbbuntetes.AutoSize = true;
            this.lbbuntetes.Location = new System.Drawing.Point(590, 189);
            this.lbbuntetes.Name = "lbbuntetes";
            this.lbbuntetes.Size = new System.Drawing.Size(36, 17);
            this.lbbuntetes.TabIndex = 6;
            this.lbbuntetes.Text = "0 Ft";
            // 
            // btsave
            // 
            this.btsave.Image = ((System.Drawing.Image)(resources.GetObject("btsave.Image")));
            this.btsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsave.Location = new System.Drawing.Point(68, 242);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(160, 63);
            this.btsave.TabIndex = 7;
            this.btsave.Text = "Mentés";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // txrendszam
            // 
            this.txrendszam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txrendszam.Location = new System.Drawing.Point(107, 32);
            this.txrendszam.Name = "txrendszam";
            this.txrendszam.Size = new System.Drawing.Size(100, 23);
            this.txrendszam.TabIndex = 8;
            this.txrendszam.TextChanged += new System.EventHandler(this.txrendszam_TextChanged);
            // 
            // txmertseb
            // 
            this.txmertseb.Location = new System.Drawing.Point(570, 112);
            this.txmertseb.Name = "txmertseb";
            this.txmertseb.Size = new System.Drawing.Size(100, 23);
            this.txmertseb.TabIndex = 9;
            this.txmertseb.TextChanged += new System.EventHandler(this.txmertseb_TextChanged);
            // 
            // btexit
            // 
            this.btexit.Image = ((System.Drawing.Image)(resources.GetObject("btexit.Image")));
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btexit.Location = new System.Drawing.Point(449, 242);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(160, 63);
            this.btexit.TabIndex = 10;
            this.btexit.Text = "Elvet";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // frmgyorshajtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 366);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.txmertseb);
            this.Controls.Add(this.txrendszam);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.lbbuntetes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbkategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmgyorshajtas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gyorshajtások rögzítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbkategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbbuntetes;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.TextBox txrendszam;
        private System.Windows.Forms.TextBox txmertseb;
        private System.Windows.Forms.Button btexit;
    }
}