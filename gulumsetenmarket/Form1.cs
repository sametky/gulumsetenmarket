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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          sqlBaglanti bgl =new sqlBaglanti();
        public static string kulid, kulad, kulsifre, kulyetki;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        bool durumkontrol =false;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_kullanici",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["kulad"].ToString() == textBox1.Text && oku["kulsifre"].ToString() == textBox2.Text && oku["kulyetki"].ToString() == "0")
                {
                    durumkontrol = true;
                    kulid = oku.GetValue(0).ToString();
                    kulad = oku.GetValue(1).ToString();
                    kulsifre = oku.GetValue(2).ToString();
                    kulyetki = oku.GetValue(3).ToString();
                    Form3 frm3 = new Form3();
                    frm3.isim = oku["kulad"].ToString();
                    frm3.yetki = oku["kulyetki"].ToString();
                    frm3.Show();
                    this.Hide();
                    break;
                }
                if (oku["kulad"].ToString() == textBox1.Text && oku["kulsifre"].ToString() == textBox2.Text && oku["kulyetki"].ToString() == "1")
                {
                    durumkontrol = true;
                    kulid = oku.GetValue(0).ToString();
                    kulad = oku.GetValue(1).ToString();
                    kulsifre = oku.GetValue(2).ToString();
                    kulyetki = oku.GetValue(3).ToString();
                    Form2 frm2 = new Form2();
                    frm2.isim = oku["kulad"].ToString();
                    frm2.yetki = oku["kulyetki"].ToString();
                    frm2.Show();
                    this.Hide();
                    break;
                }
            }
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz");
            }
            else if (durumkontrol == false)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            bgl.baglanti().Close();


        }
    }
}
