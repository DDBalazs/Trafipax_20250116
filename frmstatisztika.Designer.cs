namespace Trafipax_20250116
{
    partial class frmstatisztika
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbkategoriak = new System.Windows.Forms.ComboBox();
            this.rbkategoria = new System.Windows.Forms.RadioButton();
            this.rball = new System.Windows.Forms.RadioButton();
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mertseb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buntetes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbmeres = new System.Windows.Forms.Label();
            this.lbosszeg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbkategoriak);
            this.groupBox1.Controls.Add(this.rbkategoria);
            this.groupBox1.Controls.Add(this.rball);
            this.groupBox1.Location = new System.Drawing.Point(535, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szűrés";
            // 
            // cbkategoriak
            // 
            this.cbkategoriak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkategoriak.FormattingEnabled = true;
            this.cbkategoriak.Items.AddRange(new object[] {
            "Nincs gyorshajtás",
            "1. kategória",
            "2. kategória",
            "3. kategória",
            "4. kategória",
            "5. kategória"});
            this.cbkategoriak.Location = new System.Drawing.Point(78, 131);
            this.cbkategoriak.Name = "cbkategoriak";
            this.cbkategoriak.Size = new System.Drawing.Size(199, 21);
            this.cbkategoriak.TabIndex = 2;
            this.cbkategoriak.Visible = false;
            this.cbkategoriak.SelectedIndexChanged += new System.EventHandler(this.cbkategoriak_SelectedIndexChanged);
            // 
            // rbkategoria
            // 
            this.rbkategoria.AutoSize = true;
            this.rbkategoria.Location = new System.Drawing.Point(31, 92);
            this.rbkategoria.Name = "rbkategoria";
            this.rbkategoria.Size = new System.Drawing.Size(194, 17);
            this.rbkategoria.TabIndex = 1;
            this.rbkategoria.TabStop = true;
            this.rbkategoria.Text = "Sebesség kategória választás";
            this.rbkategoria.UseVisualStyleBackColor = true;
            this.rbkategoria.CheckedChanged += new System.EventHandler(this.rbkategoria_CheckedChanged);
            // 
            // rball
            // 
            this.rball.AutoSize = true;
            this.rball.Location = new System.Drawing.Point(31, 35);
            this.rball.Name = "rball";
            this.rball.Size = new System.Drawing.Size(65, 17);
            this.rball.TabIndex = 0;
            this.rball.TabStop = true;
            this.rball.Text = "Összes";
            this.rball.UseVisualStyleBackColor = true;
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rendszam,
            this.mertseb,
            this.buntetes});
            this.dgadatok.Location = new System.Drawing.Point(24, 42);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.RowHeadersWidth = 51;
            this.dgadatok.RowTemplate.Height = 24;
            this.dgadatok.Size = new System.Drawing.Size(488, 396);
            this.dgadatok.TabIndex = 1;
            // 
            // rendszam
            // 
            this.rendszam.HeaderText = "Rendszám";
            this.rendszam.MinimumWidth = 6;
            this.rendszam.Name = "rendszam";
            this.rendszam.ReadOnly = true;
            this.rendszam.Width = 125;
            // 
            // mertseb
            // 
            this.mertseb.HeaderText = "Mért sebesség";
            this.mertseb.MinimumWidth = 6;
            this.mertseb.Name = "mertseb";
            this.mertseb.ReadOnly = true;
            this.mertseb.Width = 125;
            // 
            // buntetes
            // 
            this.buntetes.HeaderText = "Büntetés összege";
            this.buntetes.MinimumWidth = 6;
            this.buntetes.Name = "buntetes";
            this.buntetes.ReadOnly = true;
            this.buntetes.Width = 125;
            // 
            // lbmeres
            // 
            this.lbmeres.AutoSize = true;
            this.lbmeres.ForeColor = System.Drawing.Color.Red;
            this.lbmeres.Location = new System.Drawing.Point(566, 308);
            this.lbmeres.Name = "lbmeres";
            this.lbmeres.Size = new System.Drawing.Size(127, 13);
            this.lbmeres.TabIndex = 2;
            this.lbmeres.Text = "Mérések száma: 0 db";
            // 
            // lbosszeg
            // 
            this.lbosszeg.AutoSize = true;
            this.lbosszeg.ForeColor = System.Drawing.Color.Red;
            this.lbosszeg.Location = new System.Drawing.Point(566, 368);
            this.lbosszeg.Name = "lbosszeg";
            this.lbosszeg.Size = new System.Drawing.Size(138, 13);
            this.lbosszeg.TabIndex = 3;
            this.lbosszeg.Text = "Bírságok összege: 0 Ft";
            // 
            // frmstatisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.lbosszeg);
            this.Controls.Add(this.lbmeres);
            this.Controls.Add(this.dgadatok);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmstatisztika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statisztika";
            this.Load += new System.EventHandler(this.frmstatisztika_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn mertseb;
        private System.Windows.Forms.DataGridViewTextBoxColumn buntetes;
        private System.Windows.Forms.ComboBox cbkategoriak;
        private System.Windows.Forms.RadioButton rbkategoria;
        private System.Windows.Forms.RadioButton rball;
        private System.Windows.Forms.Label lbmeres;
        private System.Windows.Forms.Label lbosszeg;
    }
}