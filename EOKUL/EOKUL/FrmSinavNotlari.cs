using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace EOKUL
{
    public partial class FrmSinavNotlari : UserControl
    {
        public FrmSinavNotlari()
        {
            InitializeComponent();

        }
        baglanti bgl = new baglanti();
        void liste()
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                
                SqlCommand komut = new SqlCommand("SELECT NotID,OgrID,DersAD,Sınav1,Sınav2,Final,Ortalama,Durum FROM TBLNOTLAR INNER JOIN TBLDERSLER ON TBLNOTLAR.DersID= TBLDERSLER.DersID ", bgl2);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void FrmSinavNotlari_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(this.Width - panel1.Width, panel1.Location.Y);
            liste();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLDERSLER", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.DisplayMember = "DersAd";
            cmbDers.ValueMember = "DersID";
            cmbDers.DataSource = dt;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT DersID as 'Ders Ad',OgrID as 'Öğrenci ID',Sınav1,Sınav2,Final,Ortalama,Durum FROM TBLNOTLAR  WHERE OgrID=@P1", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@P1", txtID.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        //int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNotID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbDers.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtFinal.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sınav1, sınav2, final;
            double ortalama;
            sınav1 = Convert.ToInt16(txtSınav1.Text);
            sınav2 = Convert.ToInt16(txtSınav2.Text);
            final = Convert.ToInt16(txtFinal.Text);
            ortalama = (sınav1 + sınav2 + final) / 3;
            txtOrtalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }

        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlCommand komut = new SqlCommand("UPDATE TBLNOTLAR SET DersID = @P1, OgrID = @P2, Sınav1 = @P3, Sınav2 = @P4, Final = @P5, Ortalama = @P6, Durum = @P7 WHERE NotID = @P8", bgl2);
                komut.Parameters.AddWithValue("@P1", byte.Parse(cmbDers.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@P2", int.Parse(txtID.Text));
                komut.Parameters.AddWithValue("@P3", decimal.Parse(txtSınav1.Text));
                komut.Parameters.AddWithValue("@P4", decimal.Parse(txtSınav2.Text));
                komut.Parameters.AddWithValue("@P5", decimal.Parse(txtFinal.Text));
                komut.Parameters.AddWithValue("@P6", decimal.Parse(txtOrtalama.Text));
                komut.Parameters.AddWithValue("@P7", txtDurum.Text);
                komut.Parameters.AddWithValue("@P8", txtNotID.Text);
                komut.ExecuteNonQuery();
                liste();
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK);
            }

        }

    }
}
