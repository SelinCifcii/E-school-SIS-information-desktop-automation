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
using System.Xml.Linq;
using System.Data.Common;

namespace EOKUL
{
    public partial class FrmOgrenciİslemleri : UserControl
    {
        public FrmOgrenciİslemleri()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        void liste()
        {
            SqlCommand komut = new SqlCommand("SELECT OgrID as 'ID',OgrAD as 'Ad',OgrSOYAD as 'Soyad',KULÜPAD as 'Kulüp',OgrCINSIYET as 'Cinsiyet',OgrSifre as 'Şifre' FROM TBLOGRENCILER INNER JOIN TBLKULUPLER ON TBLOGRENCILER.OgrKULUP = TBLKULUPLER.KULÜPID ", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmOgrenciİslemleri_Load(object sender, EventArgs e)
        {
            liste();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLKULUPLER", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKulüp.DisplayMember = "KULÜPAD";
            cmbKulüp.ValueMember = "KULÜPID";
            cmbKulüp.DataSource = dt;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT OgrID as 'ID',OgrAD as 'Ad',OgrSOYAD as 'Soyad',OgrKULUP as 'Kulüp',OgrCINSIYET as 'Cinsiyet',OgrSifre as 'Şifre' FROM TBLOGRENCILER INNER JOIN TBLKULUPLER ON TBLOGRENCILER.OgrKULUP = TBLKULUPLER.KULÜPID WHERE OgrAD=@P1", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@P1", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbKulüp.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "KIZ")
            {
                rdoKız.Checked = true;
                rdoErkek.Checked = false;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "ERKEK")
            {
                rdoErkek.Checked = true;
                rdoKız.Checked = false;
            }
        }
        string c ="";
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(rdoKız.Checked== true)
            {
                c = "KIZ";

            }
            if (rdoErkek.Checked == true)
            {
                c = "ERKEK";
            }
            //txtklpID.Text = cmbKulüp.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLOGRENCILER (OgrAD, OgrSOYAD, OgrSifre, OgrKULUP, OgrCINSIYET) " + "VALUES (@P1, @P2, @P3, @P4, @P5)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@P1",txtAd.Text);
            komut.Parameters.AddWithValue("@P2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",txtSifre.Text);
            komut.Parameters.AddWithValue("@P4", Byte.Parse(cmbKulüp.SelectedValue.ToString()));
            //Byte.Parse(cmbKulüp.Text)
            komut.Parameters.AddWithValue("@P5",c);
            komut.ExecuteNonQuery();
            liste();
            MessageBox.Show("Öğrencilisteye eklendi", "Bilgi", MessageBoxButtons.OK);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM TBLOGRENCILER WHERE OgrID= @P1", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            liste();
            MessageBox.Show("Silme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK);
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (rdoKız.Checked == true)
            {
                c = "KIZ";

            }
            if (rdoErkek.Checked == true)
            {
                c = "ERKEK";
            }
            SqlCommand komut = new SqlCommand("UPDATE TBLOGRENCILER SET OgrAD= @P1, OgrSOYAD=@P2,OgrSifre=@P3,OgrKULUP=@P4,OgrCINSIYET=@P5 WHERE OgrID=@P6", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", txtSifre.Text);
            komut.Parameters.AddWithValue("@P4", Byte.Parse(cmbKulüp.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@P5",c);
            komut.Parameters.AddWithValue("@P6", txtID.Text);
            komut.ExecuteNonQuery();
            liste();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK);

        }

        
    }      
}
