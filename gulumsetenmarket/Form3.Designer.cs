namespace gulumsetenmarket
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button4 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblyetki = new System.Windows.Forms.Label();
            this.lblisim = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.ImageKey = "uurunekle.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(716, 438);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(242, 224);
            this.button4.TabIndex = 9;
            this.button4.Text = "Ürün Ekle";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "fiyat.png");
            this.ımageList1.Images.SetKeyName(1, "satış.png");
            this.ımageList1.Images.SetKeyName(2, "stok.jpg");
            this.ımageList1.Images.SetKeyName(3, "urunekle.png");
            this.ımageList1.Images.SetKeyName(4, "uurunekle.png");
            this.ımageList1.Images.SetKeyName(5, "yntc.png");
            // 
            // button3
            // 
            this.button3.ImageKey = "stok.jpg";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(468, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 224);
            this.button3.TabIndex = 8;
            this.button3.Text = "Stok Durumu";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ImageKey = "fiyat.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(598, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 224);
            this.button2.TabIndex = 7;
            this.button2.Text = "Fiyat Listele";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageKey = "satış.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(350, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 224);
            this.button1.TabIndex = 6;
            this.button1.Text = "Satış Yap";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 100);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblyetki);
            this.panel2.Controls.Add(this.lblisim);
            this.panel2.Location = new System.Drawing.Point(12, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 555);
            this.panel2.TabIndex = 11;
            // 
            // lblyetki
            // 
            this.lblyetki.AutoSize = true;
            this.lblyetki.Location = new System.Drawing.Point(7, 37);
            this.lblyetki.Name = "lblyetki";
            this.lblyetki.Size = new System.Drawing.Size(41, 24);
            this.lblyetki.TabIndex = 1;
            this.lblyetki.Text = "null";
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(3, 9);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(41, 24);
            this.lblisim.TabIndex = 0;
            this.lblisim.Text = "null";
            // 
            // button5
            // 
            this.button5.ImageKey = "yntc.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(846, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 224);
            this.button5.TabIndex = 12;
            this.button5.Text = "Yönetici Paneli";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1013, 629);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 13;
            this.button6.Text = "Çıkış";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gülümseten Market";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblyetki;
    }
}