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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl=new sqlBaglanti();
        public string yetki,isim;

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into tbl_urunler(barkod,urunmarka,urunadi,urunadet,birimfiyat,kulad) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", textBox5.Text);
            komut.Parameters.AddWithValue("@p5", textBox6.Text);
            komut.Parameters.AddWithValue("@p6", lblisimm.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün eklenmiştir");
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox2.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand komut1 = new SqlCommand("select * from tbl_kullanici where kulyetki=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblyetkii.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                if (lblyetkii.Text == "0")
                {
                    Form3 frm3 = new Form3();
                    frm3.yetki = lblyetkii.Text;
                    frm3.isim=lblisimm.Text;
                    frm3.Show();
                }
                else if(lblyetkii.Text=="1")
                {
                    Form2 frm2 = new Form2();
                    frm2.yetki = lblyetkii.Text;
                    frm2.isim = lblisimm.Text;
                    frm2.Show();
                }
                break;
            }
            bgl.baglanti().Close();

            this.Close();
                

        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            lblisimm.Text = isim;
            SqlCommand komut = new SqlCommand("select kulid,kulyetki from tbl_kullanici where kulad=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblisimm.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblid.Text = dr1[0].ToString();
                lblyetkii.Text=dr1[1].ToString();
            }
            bgl.baglanti().Close();



        }
    }
    }
