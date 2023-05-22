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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public string isim, yetki;

        private void button1_Click(object sender, EventArgs e)
        {
            Satis satis=new Satis();
            satis.isim = lblisim.Text;
            satis.Text = lblyetki.Text;
            satis.Show();
            this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fiyat fiyat=new Fiyat();
            fiyat.isim=lblisim.Text;
            fiyat.yetki=lblyetki.Text;
            fiyat.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stok stok =new Stok();
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
            Form1 form1=new Form1();
            form1.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            lblisim.Text = isim;
            SqlCommand komut = new SqlCommand("select kulyetki from tbl_kullanici where kulad=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblisim.Text);
            SqlDataReader dr1=komut.ExecuteReader();
            while (dr1.Read())
            {
                
                lblyetki.Text=dr1[0].ToString();
            }
            bgl.baglanti().Close();
            //yeni formlar aç form 3tekiler için veya çözüm bul
        }
    }
}
