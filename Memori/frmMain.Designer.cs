namespace Memori
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnTabela = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slPokusaji = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slPogodci = new System.Windows.Forms.ToolStripStatusLabel();
            this.spbPogodci = new System.Windows.Forms.ToolStripProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.bwPrikazSlike = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBodovi = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pct12 = new System.Windows.Forms.PictureBox();
            this.pct11 = new System.Windows.Forms.PictureBox();
            this.pct10 = new System.Windows.Forms.PictureBox();
            this.pct9 = new System.Windows.Forms.PictureBox();
            this.pct8 = new System.Windows.Forms.PictureBox();
            this.pct7 = new System.Windows.Forms.PictureBox();
            this.pct6 = new System.Windows.Forms.PictureBox();
            this.pct5 = new System.Windows.Forms.PictureBox();
            this.pct4 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTabela
            // 
            this.btnTabela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabela.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTabela.FlatAppearance.BorderSize = 2;
            this.btnTabela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnTabela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTabela.Location = new System.Drawing.Point(375, 302);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(100, 34);
            this.btnTabela.TabIndex = 2;
            this.btnTabela.Text = "TABELA";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.slPokusaji,
            this.toolStripStatusLabel2,
            this.slVrijeme,
            this.toolStripStatusLabel3,
            this.slPogodci,
            this.spbPogodci});
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(487, 25);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "Pokušaji:";
            // 
            // slPokusaji
            // 
            this.slPokusaji.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.slPokusaji.Name = "slPokusaji";
            this.slPokusaji.Size = new System.Drawing.Size(17, 20);
            this.slPokusaji.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(47, 20);
            this.toolStripStatusLabel2.Text = "Vrijeme";
            // 
            // slVrijeme
            // 
            this.slVrijeme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.slVrijeme.Name = "slVrijeme";
            this.slVrijeme.Size = new System.Drawing.Size(37, 20);
            this.slVrijeme.Text = "0 : 0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel3.Text = "Pogodci: ";
            // 
            // slPogodci
            // 
            this.slPogodci.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.slPogodci.IsLink = true;
            this.slPogodci.Name = "slPogodci";
            this.slPogodci.Size = new System.Drawing.Size(17, 20);
            this.slPogodci.Text = "0";
            // 
            // spbPogodci
            // 
            this.spbPogodci.BackColor = System.Drawing.Color.Maroon;
            this.spbPogodci.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.spbPogodci.Maximum = 60;
            this.spbPogodci.Name = "spbPogodci";
            this.spbPogodci.Size = new System.Drawing.Size(100, 19);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(12, 274);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.lblBodovi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(151, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Igrač";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(73, 21);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(36, 20);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bodovi: ";
            // 
            // lblBodovi
            // 
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBodovi.Location = new System.Drawing.Point(73, 54);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(18, 20);
            this.lblBodovi.TabIndex = 3;
            this.lblBodovi.Text = "0";
            // 
            // btnRestart
            // 
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Enabled = false;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRestart.FlatAppearance.BorderSize = 2;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRestart.Location = new System.Drawing.Point(12, 328);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(100, 34);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pct12
            // 
            this.pct12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct12.Enabled = false;
            this.pct12.Location = new System.Drawing.Point(370, 188);
            this.pct12.Name = "pct12";
            this.pct12.Size = new System.Drawing.Size(100, 70);
            this.pct12.TabIndex = 13;
            this.pct12.TabStop = false;
            this.pct12.Click += new System.EventHandler(this.pct12_Click);
            // 
            // pct11
            // 
            this.pct11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct11.Enabled = false;
            this.pct11.Location = new System.Drawing.Point(251, 188);
            this.pct11.Name = "pct11";
            this.pct11.Size = new System.Drawing.Size(100, 70);
            this.pct11.TabIndex = 12;
            this.pct11.TabStop = false;
            this.pct11.Click += new System.EventHandler(this.pct11_Click);
            // 
            // pct10
            // 
            this.pct10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct10.Enabled = false;
            this.pct10.Location = new System.Drawing.Point(132, 188);
            this.pct10.Name = "pct10";
            this.pct10.Size = new System.Drawing.Size(100, 70);
            this.pct10.TabIndex = 11;
            this.pct10.TabStop = false;
            this.pct10.Click += new System.EventHandler(this.pct10_Click);
            // 
            // pct9
            // 
            this.pct9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct9.Enabled = false;
            this.pct9.Location = new System.Drawing.Point(12, 188);
            this.pct9.Name = "pct9";
            this.pct9.Size = new System.Drawing.Size(100, 70);
            this.pct9.TabIndex = 10;
            this.pct9.TabStop = false;
            this.pct9.Click += new System.EventHandler(this.pct9_Click);
            // 
            // pct8
            // 
            this.pct8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct8.Enabled = false;
            this.pct8.Location = new System.Drawing.Point(370, 99);
            this.pct8.Name = "pct8";
            this.pct8.Size = new System.Drawing.Size(100, 70);
            this.pct8.TabIndex = 9;
            this.pct8.TabStop = false;
            this.pct8.Click += new System.EventHandler(this.pct8_Click);
            // 
            // pct7
            // 
            this.pct7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct7.Enabled = false;
            this.pct7.Location = new System.Drawing.Point(251, 99);
            this.pct7.Name = "pct7";
            this.pct7.Size = new System.Drawing.Size(100, 70);
            this.pct7.TabIndex = 8;
            this.pct7.TabStop = false;
            this.pct7.Click += new System.EventHandler(this.pct7_Click);
            // 
            // pct6
            // 
            this.pct6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct6.Enabled = false;
            this.pct6.Location = new System.Drawing.Point(132, 99);
            this.pct6.Name = "pct6";
            this.pct6.Size = new System.Drawing.Size(100, 70);
            this.pct6.TabIndex = 7;
            this.pct6.TabStop = false;
            this.pct6.Click += new System.EventHandler(this.pct6_Click);
            // 
            // pct5
            // 
            this.pct5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct5.Enabled = false;
            this.pct5.Location = new System.Drawing.Point(12, 99);
            this.pct5.Name = "pct5";
            this.pct5.Size = new System.Drawing.Size(100, 70);
            this.pct5.TabIndex = 6;
            this.pct5.TabStop = false;
            this.pct5.Click += new System.EventHandler(this.pct5_Click);
            // 
            // pct4
            // 
            this.pct4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct4.Enabled = false;
            this.pct4.Location = new System.Drawing.Point(370, 12);
            this.pct4.Name = "pct4";
            this.pct4.Size = new System.Drawing.Size(100, 70);
            this.pct4.TabIndex = 5;
            this.pct4.TabStop = false;
            this.pct4.Click += new System.EventHandler(this.pct4_Click);
            // 
            // pct3
            // 
            this.pct3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct3.Enabled = false;
            this.pct3.Location = new System.Drawing.Point(251, 12);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(100, 70);
            this.pct3.TabIndex = 4;
            this.pct3.TabStop = false;
            this.pct3.Click += new System.EventHandler(this.pct3_Click);
            // 
            // pct2
            // 
            this.pct2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct2.Enabled = false;
            this.pct2.Location = new System.Drawing.Point(132, 12);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(100, 70);
            this.pct2.TabIndex = 3;
            this.pct2.TabStop = false;
            this.pct2.Click += new System.EventHandler(this.pct2_Click);
            // 
            // pct1
            // 
            this.pct1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct1.Enabled = false;
            this.pct1.Location = new System.Drawing.Point(12, 12);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(100, 70);
            this.pct1.TabIndex = 2;
            this.pct1.TabStop = false;
            this.pct1.Click += new System.EventHandler(this.pct1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 411);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pct12);
            this.Controls.Add(this.pct11);
            this.Controls.Add(this.pct10);
            this.Controls.Add(this.pct9);
            this.Controls.Add(this.pct8);
            this.Controls.Add(this.pct7);
            this.Controls.Add(this.pct6);
            this.Controls.Add(this.pct5);
            this.Controls.Add(this.pct4);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.btnTabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Memori";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct3;
        private System.Windows.Forms.PictureBox pct4;
        private System.Windows.Forms.PictureBox pct8;
        private System.Windows.Forms.PictureBox pct7;
        private System.Windows.Forms.PictureBox pct6;
        private System.Windows.Forms.PictureBox pct5;
        private System.Windows.Forms.PictureBox pct12;
        private System.Windows.Forms.PictureBox pct11;
        private System.Windows.Forms.PictureBox pct10;
        private System.Windows.Forms.PictureBox pct9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slPokusaji;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel slVrijeme;
        private System.Windows.Forms.ToolStripProgressBar spbPogodci;
        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker bwPrikazSlike;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel slPogodci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnRestart;
    }
}

