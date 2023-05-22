﻿using System;
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
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl=new sqlBaglanti();
        public string yetki,isim;
        private void Stok_Load(object sender, EventArgs e)
        {
            lblyetki.Text = yetki;
            lblisim.Text = isim;
            if (lblyetki.Text == "0") 
            {
                SqlDataAdapter tablo = new SqlDataAdapter("select barkod,urunmarka,urunadi,urunadet,birimfiyat,kulad from tbl_urunler ", bgl.baglanti());
                DataTable dt1 = new DataTable();
                tablo.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                SqlDataAdapter tablo1 = new SqlDataAdapter("select barkod,urunmarka,urunadi,urunadet,birimfiyat from tbl_urunler ", bgl.baglanti());
                DataTable dt2 = new DataTable();
                tablo1.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblyetki.Text == "0")
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter ara = new SqlDataAdapter("select barkod,urunmarka,urunadi,urunadet,birimfiyat,kulad from tbl_urunler where urunadi like'%" + textBox1.Text + "%' ", bgl.baglanti());
                ara.Fill(tbl);

                bgl.baglanti().Close();
                dataGridView1.DataSource = tbl;
            }
            else
            {
                DataTable tbl1 = new DataTable();
                SqlDataAdapter ara1 = new SqlDataAdapter("select barkod,urunmarka,urunadi,urunadet,birimfiyat from tbl_urunler where urunadi like'%" + textBox1.Text + "%' ", bgl.baglanti());
                ara1.Fill(tbl1);

                bgl.baglanti().Close();
                dataGridView1.DataSource = tbl1;
            }
            
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
