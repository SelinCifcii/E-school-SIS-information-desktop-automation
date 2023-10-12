using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Hastane_Proje_1;

namespace EOKUL
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeFormControls();
        }
       

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 10;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
        private void InitializeFormControls()
        {
            //üst panel sınıfı
            FormHelper.InitializeForm(this, panel1, Maximizebx);
        }

        baglanti bgl = new baglanti();
        private void Form1_Load(object sender, EventArgs e)
        {
            //form boyutunun dinamik olarak ayarlanması
            FormSize.Initialize(this);
            Size yeniBoyut = new Size(650, 445);
            this.Size = yeniBoyut;

            //Formu ekranın ortasına konumlandırma
            Point yeniKonum = new Point();
            yeniKonum.X = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            yeniKonum.Y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = yeniKonum;

            //bağlantı ayarlarının kontrol formu (sql managementdaki connect to server formu)
            string cs = HelperStaticMethods.ReadConnectionString();
            while(string.IsNullOrEmpty(cs) || (HelperStaticMethods.IsConnectionAlive(cs) == false))
            {
                FrmSettings frm = new FrmSettings();
                frm.Enabled = true;
                frm.ShowDialog();
                cs = HelperStaticMethods.ReadConnectionString();
                continue;
            } 

            if (HelperStaticMethods.IsDbAlive() == false)
                HelperStaticMethods.CreateDatabase(cs);

        }
        //çıkış butonu 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xuıButton1_Click(object sender, EventArgs e)
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlCommand komut = new SqlCommand("Select * From TBLOGRENCILER Where OgrID=@p1 and OgrSifre=@p2", bgl2);
                komut.Parameters.AddWithValue("@p1", txtID.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    FrmOgrenciPanel fr = new FrmOgrenciPanel();
                    fr.numara = txtID.Text;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış ID yada şifre");
                }
            }
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            using (var bgl2 = bgl.sqlbaglanti())
            {
                SqlCommand komut1 = new SqlCommand("Select * From TBLOGRETMENLER Where OgretmenID=@p1 and OgretmenSifre=@p2", bgl2);
                komut1.Parameters.AddWithValue("@p1", txtID.Text);
                komut1.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr = komut1.ExecuteReader();

                if (dr.Read())
                {
                    FrmOgretmenPanel fr = new FrmOgretmenPanel();
                    fr.num = txtID.Text;
                    fr.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Yanlış ID yada şifre");
                }
                bgl.sqlbaglanti().Close();
            }
        }
        
    }
    
}
