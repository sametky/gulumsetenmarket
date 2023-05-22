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
    public partial class KullanıcıEkle : Form
    {
        public KullanıcıEkle()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl=new sqlBaglanti();
        private void KullanıcıEkle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_kullanici", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_kullanici(kulid,kulad,kulsifre,kulyetki) values(@kulid,@kulad,@kulsifre,@kulyetki)",bgl.baglanti());
            komut.Parameters.AddWithValue("@kulid", textBox1.Text);
            komut.Parameters.AddWithValue("@kulad",txtkulad.Text);
            komut.Parameters.AddWithValue("@kulsifre", txtsifre.Text);
            komut.Parameters.AddWithValue("@kulyetki", txtyetki.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni kişi eklenmiştir");
        }
    }
}
