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
    public partial class yoneticip : Form
    {
        public yoneticip()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl=new sqlBaglanti();
        public string yetki, isim;

        private void yoneticip_Load(object sender, EventArgs e)
        {
            lblisim.Text = isim;
            lblyetki.Text = yetki;
        }

        private void yeniKullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıEkle ekle=new KullanıcıEkle();
            ekle.Show();
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıSil sil =new KullanıcıSil();
            sil.Show();
        }

        private void güncellenenStoklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuncellenenUrunler guncellenenUrunler=new GuncellenenUrunler();
            guncellenenUrunler.Show();
        }

        private void silinenÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SilinenUrunler silinenUrunler =new SilinenUrunler();
            silinenUrunler.Show();
        }

        private void satışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satislar satislar =new Satislar();
            satislar.Show();
        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select * from tbl_kullanici where kulyetki=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblyetki.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                if (lblyetki.Text == "0")
                {
                    Form3 frm3 = new Form3();
                    frm3.yetki = lblyetki.Text;
                    frm3.isim = lblisim.Text;
                    frm3.Show();
                }

                break;
            }
            bgl.baglanti().Close();

            this.Close();
        }
    }
}
