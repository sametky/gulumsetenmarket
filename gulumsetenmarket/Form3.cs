using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gulumsetenmarket
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl=new sqlBaglanti();
        public string isim, yetki;
        private void button1_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.isim=lblisim.Text;
            satis.yetki = lblyetki.Text;
            satis.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fiyat fiyat = new Fiyat();
            fiyat.isim=lblisim.Text;
            fiyat.yetki=lblyetki.Text;
            fiyat.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stok stok = new Stok();
            stok.yetki = lblyetki.Text;
            stok.isim = lblisim.Text;
            stok.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.yetki = lblyetki.Text;
            urunEkle.isim = lblisim.Text;
            
            urunEkle.Show();
            this.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yoneticip yoneticip=new yoneticip();
            yoneticip.yetki = lblyetki.Text;
            yoneticip.isim = lblisim.Text;
            yoneticip.Show();
            this.Hide();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


            lblisim.Text = isim;
            lblyetki.Text = yetki;
            bgl.baglanti().Close();
        }
    }
}
