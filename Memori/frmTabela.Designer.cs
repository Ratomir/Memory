namespace Memori
{
    partial class frmTabela
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabela));
            this.tcTabMeni = new System.Windows.Forms.TabControl();
            this.tpIgraci = new System.Windows.Forms.TabPage();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.tpNajbolji = new System.Windows.Forms.TabPage();
            this.lblNajboljiBodovi3 = new System.Windows.Forms.Label();
            this.lblNajboljiIme3 = new System.Windows.Forms.Label();
            this.lblNajboljiBodovi2 = new System.Windows.Forms.Label();
            this.lblNajboljiIme2 = new System.Windows.Forms.Label();
            this.lblNajboljiBodovi1 = new System.Windows.Forms.Label();
            this.lblNajboljiIme1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bazaIgračaDataSet = new Memori.BazaIgračaDataSet();
            this.bazaIgračaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcTabMeni.SuspendLayout();
            this.tpIgraci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.tpNajbolji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaIgračaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaIgračaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTabMeni
            // 
            this.tcTabMeni.Controls.Add(this.tpIgraci);
            this.tcTabMeni.Controls.Add(this.tpNajbolji);
            this.tcTabMeni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcTabMeni.Location = new System.Drawing.Point(0, 0);
            this.tcTabMeni.Name = "tcTabMeni";
            this.tcTabMeni.SelectedIndex = 0;
            this.tcTabMeni.Size = new System.Drawing.Size(441, 261);
            this.tcTabMeni.TabIndex = 1;
            // 
            // tpIgraci
            // 
            this.tpIgraci.Controls.Add(this.dgvTabela);
            this.tpIgraci.Location = new System.Drawing.Point(4, 27);
            this.tpIgraci.Name = "tpIgraci";
            this.tpIgraci.Padding = new System.Windows.Forms.Padding(3);
            this.tpIgraci.Size = new System.Drawing.Size(433, 230);
            this.tpIgraci.TabIndex = 0;
            this.tpIgraci.Text = "Igrači";
            this.tpIgraci.UseVisualStyleBackColor = true;
            // 
            // dgvTabela
            // 
            this.dgvTabela.AllowUserToAddRows = false;
            this.dgvTabela.AllowUserToDeleteRows = false;
            this.dgvTabela.AllowUserToResizeColumns = false;
            this.dgvTabela.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabela.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTabela.Location = new System.Drawing.Point(3, 3);
            this.dgvTabela.MultiSelect = false;
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.Size = new System.Drawing.Size(427, 224);
            this.dgvTabela.TabIndex = 0;
            // 
            // tpNajbolji
            // 
            this.tpNajbolji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpNajbolji.BackgroundImage")));
            this.tpNajbolji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpNajbolji.Controls.Add(this.lblNajboljiBodovi3);
            this.tpNajbolji.Controls.Add(this.lblNajboljiIme3);
            this.tpNajbolji.Controls.Add(this.lblNajboljiBodovi2);
            this.tpNajbolji.Controls.Add(this.lblNajboljiIme2);
            this.tpNajbolji.Controls.Add(this.lblNajboljiBodovi1);
            this.tpNajbolji.Controls.Add(this.lblNajboljiIme1);
            this.tpNajbolji.Controls.Add(this.pictureBox3);
            this.tpNajbolji.Controls.Add(this.pictureBox2);
            this.tpNajbolji.Controls.Add(this.pictureBox1);
            this.tpNajbolji.Location = new System.Drawing.Point(4, 27);
            this.tpNajbolji.Name = "tpNajbolji";
            this.tpNajbolji.Padding = new System.Windows.Forms.Padding(3);
            this.tpNajbolji.Size = new System.Drawing.Size(433, 230);
            this.tpNajbolji.TabIndex = 1;
            this.tpNajbolji.Text = "Najbolji";
            this.tpNajbolji.UseVisualStyleBackColor = true;
            // 
            // lblNajboljiBodovi3
            // 
            this.lblNajboljiBodovi3.AutoSize = true;
            this.lblNajboljiBodovi3.ForeColor = System.Drawing.Color.White;
            this.lblNajboljiBodovi3.Location = new System.Drawing.Point(365, 115);
            this.lblNajboljiBodovi3.Name = "lblNajboljiBodovi3";
            this.lblNajboljiBodovi3.Size = new System.Drawing.Size(16, 18);
            this.lblNajboljiBodovi3.TabIndex = 8;
            this.lblNajboljiBodovi3.Text = "0";
            // 
            // lblNajboljiIme3
            // 
            this.lblNajboljiIme3.AutoSize = true;
            this.lblNajboljiIme3.ForeColor = System.Drawing.Color.White;
            this.lblNajboljiIme3.Location = new System.Drawing.Point(351, 97);
            this.lblNajboljiIme3.Name = "lblNajboljiIme3";
            this.lblNajboljiIme3.Size = new System.Drawing.Size(48, 18);
            this.lblNajboljiIme3.TabIndex = 7;
            this.lblNajboljiIme3.Text = "Igrač3";
            // 
            // lblNajboljiBodovi2
            // 
            this.lblNajboljiBodovi2.AutoSize = true;
            this.lblNajboljiBodovi2.ForeColor = System.Drawing.Color.White;
            this.lblNajboljiBodovi2.Location = new System.Drawing.Point(49, 81);
            this.lblNajboljiBodovi2.Name = "lblNajboljiBodovi2";
            this.lblNajboljiBodovi2.Size = new System.Drawing.Size(16, 18);
            this.lblNajboljiBodovi2.TabIndex = 6;
            this.lblNajboljiBodovi2.Text = "0";
            // 
            // lblNajboljiIme2
            // 
            this.lblNajboljiIme2.AutoSize = true;
            this.lblNajboljiIme2.ForeColor = System.Drawing.Color.White;
            this.lblNajboljiIme2.Location = new System.Drawing.Point(35, 63);
            this.lblNajboljiIme2.Name = "lblNajboljiIme2";
            this.lblNajboljiIme2.Size = new System.Drawing.Size(48, 18);
            this.lblNajboljiIme2.TabIndex = 5;
            this.lblNajboljiIme2.Text = "Igrač2";
            // 
            // lblNajboljiBodovi1
            // 
            this.lblNajboljiBodovi1.AutoSize = true;
            this.lblNajboljiBodovi1.ForeColor = System.Drawing.Color.White;
            this.lblNajboljiBodovi1.Location = new System.Drawing.Point(210, 30);
            this.lblNajboljiBodovi1.Name = "lblNajboljiBodovi1";
            this.lblNajboljiBodovi1.Size = new System.Drawing.Size(16, 18);
            this.lblNajboljiBodovi1.TabIndex = 4;
            this.lblNajboljiBodovi1.Text = "0";
            // 
            // lblNajboljiIme1
            // 
            this.lblNajboljiIme1.AutoSize = true;
            this.lblNajboljiIme1.ForeColor = System.Drawing.Color.White;
            this.lblNajboljiIme1.Location = new System.Drawing.Point(195, 12);
            this.lblNajboljiIme1.Name = "lblNajboljiIme1";
            this.lblNajboljiIme1.Size = new System.Drawing.Size(48, 18);
            this.lblNajboljiIme1.TabIndex = 3;
            this.lblNajboljiIme1.Text = "Igrač1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(324, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bazaIgračaDataSet
            // 
            this.bazaIgračaDataSet.DataSetName = "BazaIgračaDataSet";
            this.bazaIgračaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bazaIgračaDataSetBindingSource
            // 
            this.bazaIgračaDataSetBindingSource.DataSource = this.bazaIgračaDataSet;
            this.bazaIgračaDataSetBindingSource.Position = 0;
            // 
            // frmTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 261);
            this.Controls.Add(this.tcTabMeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTabela";
            this.Text = "Igrači";
            this.Load += new System.EventHandler(this.frmTabela_Load);
            this.tcTabMeni.ResumeLayout(false);
            this.tpIgraci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.tpNajbolji.ResumeLayout(false);
            this.tpNajbolji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaIgračaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaIgračaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabMeni;
        private System.Windows.Forms.TabPage tpIgraci;
        private System.Windows.Forms.TabPage tpNajbolji;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.BindingSource bazaIgračaDataSetBindingSource;
        private BazaIgračaDataSet bazaIgračaDataSet;
        private System.Windows.Forms.Label lblNajboljiBodovi3;
        private System.Windows.Forms.Label lblNajboljiIme3;
        private System.Windows.Forms.Label lblNajboljiBodovi2;
        private System.Windows.Forms.Label lblNajboljiIme2;
        private System.Windows.Forms.Label lblNajboljiBodovi1;
        private System.Windows.Forms.Label lblNajboljiIme1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}