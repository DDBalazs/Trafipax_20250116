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
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mertseb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buntetes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rball = new System.Windows.Forms.RadioButton();
            this.rdkategoria = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmeresek = new System.Windows.Forms.Label();
            this.lbosszeg = new System.Windows.Forms.Label();
            this.cbkategoriak = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rendszam,
            this.mertseb,
            this.buntetes});
            this.dgadatok.Location = new System.Drawing.Point(22, 58);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(523, 380);
            this.dgadatok.TabIndex = 0;
            // 
            // rendszam
            // 
            this.rendszam.HeaderText = "Rendszám";
            this.rendszam.Name = "rendszam";
            this.rendszam.ReadOnly = true;
            // 
            // mertseb
            // 
            this.mertseb.HeaderText = "Mért sebesség";
            this.mertseb.Name = "mertseb";
            this.mertseb.ReadOnly = true;
            // 
            // buntetes
            // 
            this.buntetes.HeaderText = "Büntetés összege";
            this.buntetes.Name = "buntetes";
            this.buntetes.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbkategoriak);
            this.groupBox1.Controls.Add(this.rdkategoria);
            this.groupBox1.Controls.Add(this.rball);
            this.groupBox1.Location = new System.Drawing.Point(581, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szűrés";
            // 
            // rball
            // 
            this.rball.AutoSize = true;
            this.rball.Location = new System.Drawing.Point(15, 19);
            this.rball.Name = "rball";
            this.rball.Size = new System.Drawing.Size(65, 17);
            this.rball.TabIndex = 0;
            this.rball.TabStop = true;
            this.rball.Text = "Összes";
            this.rball.UseVisualStyleBackColor = true;
            this.rball.CheckedChanged += new System.EventHandler(this.rball_CheckedChanged);
            // 
            // rdkategoria
            // 
            this.rdkategoria.AutoSize = true;
            this.rdkategoria.Location = new System.Drawing.Point(15, 42);
            this.rdkategoria.Name = "rdkategoria";
            this.rdkategoria.Size = new System.Drawing.Size(204, 17);
            this.rdkategoria.TabIndex = 1;
            this.rdkategoria.TabStop = true;
            this.rdkategoria.Text = "Sebesség kategüria kiválasztás";
            this.rdkategoria.UseVisualStyleBackColor = true;
            this.rdkategoria.CheckedChanged += new System.EventHandler(this.rdkategoria_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(611, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mérések száma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(611, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bíroságok összege:";
            // 
            // lbmeresek
            // 
            this.lbmeresek.AutoSize = true;
            this.lbmeresek.ForeColor = System.Drawing.Color.Red;
            this.lbmeresek.Location = new System.Drawing.Point(768, 283);
            this.lbmeresek.Name = "lbmeresek";
            this.lbmeresek.Size = new System.Drawing.Size(32, 13);
            this.lbmeresek.TabIndex = 4;
            this.lbmeresek.Text = "0 db";
            // 
            // lbosszeg
            // 
            this.lbosszeg.AutoSize = true;
            this.lbosszeg.ForeColor = System.Drawing.Color.Red;
            this.lbosszeg.Location = new System.Drawing.Point(768, 326);
            this.lbosszeg.Name = "lbosszeg";
            this.lbosszeg.Size = new System.Drawing.Size(26, 13);
            this.lbosszeg.TabIndex = 5;
            this.lbosszeg.Text = "0 ft";
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
            this.cbkategoriak.Location = new System.Drawing.Point(98, 65);
            this.cbkategoriak.Name = "cbkategoriak";
            this.cbkategoriak.Size = new System.Drawing.Size(121, 21);
            this.cbkategoriak.TabIndex = 2;
            this.cbkategoriak.Visible = false;
            this.cbkategoriak.SelectedIndexChanged += new System.EventHandler(this.cbkategoriak_SelectedIndexChanged);
            // 
            // frmstatisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.lbosszeg);
            this.Controls.Add(this.lbmeresek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgadatok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmstatisztika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statisztika";
            this.Load += new System.EventHandler(this.frmstatisztika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn mertseb;
        private System.Windows.Forms.DataGridViewTextBoxColumn buntetes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdkategoria;
        private System.Windows.Forms.RadioButton rball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbmeresek;
        private System.Windows.Forms.Label lbosszeg;
        private System.Windows.Forms.ComboBox cbkategoriak;
    }
}