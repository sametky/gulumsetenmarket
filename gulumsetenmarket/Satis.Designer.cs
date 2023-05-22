namespace gulumsetenmarket
{
    partial class Satis
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
            this.anamenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxadet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxbrkd = new System.Windows.Forms.TextBox();
            this.btnokut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txturunmarka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbirimfiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblyetki = new System.Windows.Forms.Label();
            this.lblisim = new System.Windows.Forms.Label();
            this.txttoplamfiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltoplamfiyat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anamenüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anamenüToolStripMenuItem
            // 
            this.anamenüToolStripMenuItem.Name = "anamenüToolStripMenuItem";
            this.anamenüToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.anamenüToolStripMenuItem.Text = "Anamenü";
            this.anamenüToolStripMenuItem.Click += new System.EventHandler(this.anamenüToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adet:";
            // 
            // txtbxadet
            // 
            this.txtbxadet.Location = new System.Drawing.Point(935, 106);
            this.txtbxadet.Name = "txtbxadet";
            this.txtbxadet.Size = new System.Drawing.Size(143, 32);
            this.txtbxadet.TabIndex = 2;
            this.txtbxadet.TextChanged += new System.EventHandler(this.txtbxadet_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(834, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod:";
            // 
            // txtbxbrkd
            // 
            this.txtbxbrkd.Location = new System.Drawing.Point(935, 60);
            this.txtbxbrkd.Name = "txtbxbrkd";
            this.txtbxbrkd.Size = new System.Drawing.Size(143, 32);
            this.txtbxbrkd.TabIndex = 5;
            this.txtbxbrkd.TextChanged += new System.EventHandler(this.txtbxbrkd_TextChanged);
            // 
            // btnokut
            // 
            this.btnokut.Location = new System.Drawing.Point(966, 307);
            this.btnokut.Name = "btnokut";
            this.btnokut.Size = new System.Drawing.Size(112, 44);
            this.btnokut.TabIndex = 6;
            this.btnokut.Text = "Okut";
            this.btnokut.UseVisualStyleBackColor = true;
            this.btnokut.Click += new System.EventHandler(this.btnokut_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ödeme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Satış İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "Ürün Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Toplam Fiyat:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 399);
            this.dataGridView1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(21, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 430);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Tablosu";
            // 
            // txturunmarka
            // 
            this.txturunmarka.Location = new System.Drawing.Point(935, 153);
            this.txturunmarka.Name = "txturunmarka";
            this.txturunmarka.Size = new System.Drawing.Size(143, 32);
            this.txturunmarka.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ürün Ad:";
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(935, 202);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(143, 32);
            this.txturunad.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(816, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ürün Marka:";
            // 
            // txtbirimfiyat
            // 
            this.txtbirimfiyat.Location = new System.Drawing.Point(935, 252);
            this.txtbirimfiyat.Name = "txtbirimfiyat";
            this.txtbirimfiyat.Size = new System.Drawing.Size(143, 32);
            this.txtbirimfiyat.TabIndex = 23;
            this.txtbirimfiyat.TextChanged += new System.EventHandler(this.txtbirimfiyat_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(827, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Birim Fiyat";
            // 
            // lblyetki
            // 
            this.lblyetki.AutoSize = true;
            this.lblyetki.Location = new System.Drawing.Point(935, 428);
            this.lblyetki.Name = "lblyetki";
            this.lblyetki.Size = new System.Drawing.Size(61, 24);
            this.lblyetki.TabIndex = 24;
            this.lblyetki.Text = "label8";
            this.lblyetki.Visible = false;
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(935, 465);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(61, 24);
            this.lblisim.TabIndex = 25;
            this.lblisim.Text = "label9";
            this.lblisim.Visible = false;
            // 
            // txttoplamfiyat
            // 
            this.txttoplamfiyat.Location = new System.Drawing.Point(186, 478);
            this.txttoplamfiyat.Name = "txttoplamfiyat";
            this.txttoplamfiyat.Size = new System.Drawing.Size(173, 32);
            this.txttoplamfiyat.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Genel Toplam:";
            // 
            // lbltoplamfiyat
            // 
            this.lbltoplamfiyat.AutoSize = true;
            this.lbltoplamfiyat.Location = new System.Drawing.Point(192, 591);
            this.lbltoplamfiyat.Name = "lbltoplamfiyat";
            this.lbltoplamfiyat.Size = new System.Drawing.Size(20, 24);
            this.lbltoplamfiyat.TabIndex = 28;
            this.lbltoplamfiyat.Text = "0";
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.lbltoplamfiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttoplamfiyat);
            this.Controls.Add(this.lblisim);
            this.Controls.Add(this.lblyetki);
            this.Controls.Add(this.txtbirimfiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txturunmarka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnokut);
            this.Controls.Add(this.txtbxbrkd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxadet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Yap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Satis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anamenüToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxadet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxbrkd;
        private System.Windows.Forms.Button btnokut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txturunmarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbirimfiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblyetki;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.TextBox txttoplamfiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltoplamfiyat;
    }
}