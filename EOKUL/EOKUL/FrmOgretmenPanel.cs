using Hastane_Proje_1;
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


namespace EOKUL
{
    public partial class FrmOgretmenPanel : Form
    {
        public FrmOgretmenPanel()
        {
            InitializeComponent();
            InitializeFormControls1();
            FormSize.Initialize(this);
        }
        private void InitializeFormControls1()
        {
            FormHelper.InitializeForm(this, panel1, Maximizebx);
            
        }
        
        baglanti bgl = new baglanti();
        public string num;
        
        private void FrmOgretmenPanel_Load(object sender, EventArgs e)
        {
            FormSize.Initialize(this);
            SqlCommand komut2 = new SqlCommand("Select * From TBlOGRETMENLER  where OgretmenID=@p1", bgl.sqlbaglanti());
            komut2.Parameters.AddWithValue("@p1", num);
            SqlDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                string ogrtAdSoyad = oku["OgretmenAdSoyad"].ToString();
                lblAdSoyad.Text = ogrtAdSoyad;
                lblID.Text = num.ToString();
            }
            bgl.sqlbaglanti().Close();
             
          
        }

        private void pctrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // User Control panellerini çağırma fonksiyonu
        private void addUserControl(UserControl userControl1)
        {
            userControl1.Dock = DockStyle.Fill;
            panelUserC.Controls.Clear();
            panelUserC.Controls.Add(userControl1);
            userControl1.BringToFront();
        }
        private void btnKulüp_Click(object sender, EventArgs e)
        {
            FrmKulupIslemleri frmKulup = new FrmKulupIslemleri();
            addUserControl(frmKulup);
        }

        private void btnDersIslm_Click(object sender, EventArgs e)
        {
            FrmDersIslemleri frmders = new FrmDersIslemleri();
            addUserControl(frmders);

        }

        private void btnSınavNotları_Click(object sender, EventArgs e)
        {
            FrmSinavNotlari frmsinav = new FrmSinavNotlari();
            addUserControl(frmsinav);
        }

        private void btnOgrenciIslm_Click(object sender, EventArgs e)
        {
            FrmOgrenciİslemleri frmogrenci = new FrmOgrenciİslemleri();
            addUserControl(frmogrenci);
        }   
    }
}
