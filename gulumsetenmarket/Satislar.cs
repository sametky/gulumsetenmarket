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
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl=new sqlBaglanti();
        private void Satislar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da=new SqlDataAdapter("select * from tbl_satislar",bgl.baglanti());
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}
