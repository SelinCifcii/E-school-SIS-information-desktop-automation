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
using Hastane_Proje_1;

namespace EOKUL
{
    public partial class FrmDersIslemleri : UserControl
    {
        public FrmDersIslemleri()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        void liste()
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLDERSLER", bgl2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void FrmDersIslemleri_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TBLDERSLER(DersAd) VALUES (@P1)", bgl2);
                komut.Parameters.AddWithValue("@P1", txtDersAd.Text);
                komut.ExecuteNonQuery();
                liste();
                MessageBox.Show("Ders listeye eklendi", "Bilgi", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlCommand komut = new SqlCommand("UPDATE TBLDERSLER SET DersAd= @P1 WHERE DersID=@P2", bgl2);
                komut.Parameters.AddWithValue("@P1", txtDersAd.Text);
                komut.Parameters.AddWithValue("@P2", txtDersId.Text);
                komut.ExecuteNonQuery();
                liste();
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlCommand komut = new SqlCommand("DELETE FROM TBLDERSLER WHERE DersID= @P1", bgl2);
                komut.Parameters.AddWithValue("@p1", txtDersId.Text);
                komut.ExecuteNonQuery();
                liste();
                MessageBox.Show("Silme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK);
            }
        }
    }
}
