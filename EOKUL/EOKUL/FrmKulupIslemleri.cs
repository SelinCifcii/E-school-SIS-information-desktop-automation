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

namespace EOKUL
{
    public partial class FrmKulupIslemleri : UserControl
    {
        public FrmKulupIslemleri()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();

        void liste()
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLKULUPLER", bgl2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void FrmKulupIslemleri_Load(object sender, EventArgs e)
        {
            liste();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TBLKULUPLER(KULÜPAD) VALUES (@P1)", bgl2);
                komut.Parameters.AddWithValue("@P1", txtKulüpAd.Text);
                komut.ExecuteNonQuery();
                liste();
                MessageBox.Show("Kulüp listeye eklendi", "Bilgi", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkulüpID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulüpAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlCommand komut = new SqlCommand("UPDATE TBLKULUPLER SET KULÜPAD= @P1 WHERE KULÜPID=@P2", bgl2);
                komut.Parameters.AddWithValue("@P1", txtKulüpAd.Text);
                komut.Parameters.AddWithValue("@P2", txtkulüpID.Text);
                komut.ExecuteNonQuery();
                liste();
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlCommand komut = new SqlCommand("DELETE FROM TBLKULUPLER WHERE KULÜPID= @P1", bgl2);
                komut.Parameters.AddWithValue("@p1", txtkulüpID.Text);
                komut.ExecuteNonQuery();
                liste();
                MessageBox.Show("Silme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK);
            }

        }

       
    }
}
