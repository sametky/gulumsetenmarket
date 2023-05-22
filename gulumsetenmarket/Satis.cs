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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl =new sqlBaglanti();
        DataSet ds = new DataSet();
        public string isim, yetki;
        private void sepetlistele()
        {
            SqlDataAdapter dt=new SqlDataAdapter("select barkod, urunmarka, urunadi,urunadet,birimfiyat,toplamfiyat,tarih,kulad from tbl_sepet",bgl.baglanti());
            dt.Fill(ds,"tbl_sepet");
            dataGridView1.DataSource = ds.Tables["tbl_sepet"];
            bgl.baglanti().Close();
        }
        private void btnokut_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into tbl_sepet(barkod,urunmarka,urunadi,urunadet,birimfiyat,toplamfiyat,kulad,tarih) values(@barkod,@urunmarka,@urunadi,@urunadet,@birimfiyat,@toplamfiyat,@kulad,@tarih)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@barkod",txtbxbrkd.Text);
            ekle.Parameters.AddWithValue("@urunmarka", txturunmarka.Text);
            ekle.Parameters.AddWithValue("@urunadi", txturunad.Text);
            ekle.Parameters.AddWithValue("@urunadet", int.Parse(txtbxadet.Text));
            ekle.Parameters.AddWithValue("@birimfiyat", double.Parse(txtbirimfiyat.Text));
            ekle.Parameters.AddWithValue("@toplamfiyat", double.Parse(txttoplamfiyat.Text));
            ekle.Parameters.AddWithValue("@kulad", lblisim.Text);
            ekle.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            ds.Tables["tbl_sepet"].Clear();
            sepetlistele();
            hesapla();
            //
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                SqlCommand ekle = new SqlCommand("insert into tbl_satislar(barkod,urunmarka,urunadi,urunadet,birimfiyat,toplamfiyat,kulad,tarih) values(@barkod,@urunmarka,@urunadi,@urunadet,@birimfiyat,@toplamfiyat,@kulad,@tarih)", bgl.baglanti());
                ekle.Parameters.AddWithValue("@barkod", dataGridView1.Rows[i].Cells["barkod"].Value.ToString());
                ekle.Parameters.AddWithValue("@urunmarka", dataGridView1.Rows[i].Cells["urunmarka"].Value.ToString());
                ekle.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                ekle.Parameters.AddWithValue("@urunadet", int.Parse(dataGridView1.Rows[i].Cells["urunadet"].Value.ToString()));
                ekle.Parameters.AddWithValue("@birimfiyat", double.Parse(dataGridView1.Rows[i].Cells["birimfiyat"].Value.ToString()));
                ekle.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                ekle.Parameters.AddWithValue("@kulad", dataGridView1.Rows[i].Cells["kulad"].Value.ToString());
                ekle.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                ekle.ExecuteNonQuery();
                SqlCommand guncelle = new SqlCommand("update tbl_urunler set urunadet=urunadet-'"+ int.Parse(dataGridView1.Rows[i].Cells["urunadet"].Value.ToString())+"'where barkod='"+ dataGridView1.Rows[i].Cells["barkod"].Value.ToString() + "'",bgl.baglanti());
                guncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            SqlCommand komut = new SqlCommand("delete from tbl_sepet ", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            ds.Tables["tbl_sepet"].Clear();
            sepetlistele();
            hesapla();

        }
        private void hesapla()
        {
            try//null değer döndürdüğünde hata vermesin
            {
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from tbl_sepet",bgl.baglanti());
                lbltoplamfiyat.Text=komut.ExecuteScalar()+" TL";
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                ;
            }
        }
        private void Satis_Load(object sender, EventArgs e)
        {
            sepetlistele();
            lblisim.Text = isim;
            lblyetki.Text = yetki;
        }

        private void txtbxbrkd_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_urunler where barkod like'"+txtbxbrkd.Text+"'",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txturunad.Text = oku["urunadi"].ToString();
                txturunmarka.Text = oku["urunmarka"].ToString();
                txtbirimfiyat.Text = oku["birimfiyat"].ToString();



            }
            bgl.baglanti().Close();
        }

        private void txtbxadet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtbxadet.Text) * double.Parse(txtbirimfiyat.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }

        }

        private void txtbirimfiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtbxadet.Text) * double.Parse(txtbirimfiyat.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_sepet where barkod='"+dataGridView1.CurrentRow.Cells["barkod"].Value.ToString()+"'",bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ürün sepetten çıkarıldı");
            ds.Tables["tbl_sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_sepet ", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ürünler sepetten çıkarıldı");
            ds.Tables["tbl_sepet"].Clear();
            sepetlistele();
            hesapla();
            
        }

        private void anamenüToolStripMenuItem_Click(object sender, EventArgs e)
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
                else if (lblyetki.Text == "1")
                {
                    Form2 frm2 = new Form2();
                    frm2.yetki = lblyetki.Text;
                    frm2.isim = lblisim.Text;
                    frm2.Show();
                }
                break;
            }
            bgl.baglanti().Close();

            this.Close();
        }
    }
}
