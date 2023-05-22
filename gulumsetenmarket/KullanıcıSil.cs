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
    public partial class KullanıcıSil : Form
    {
        public KullanıcıSil()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl=new sqlBaglanti();
        private void KullanıcıSil_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_kullanici", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtyetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_kullanici where kulid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            if (txtid.Text == "")
            {
                MessageBox.Show("Lütfen verileri giriniz");
            }
            else
            {
                MessageBox.Show("Kullanıcı silinmiştir.");
            }
        }
    }
}
