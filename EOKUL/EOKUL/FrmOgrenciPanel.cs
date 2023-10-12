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
using System.Reflection.Emit;
using Hastane_Proje_1;

namespace EOKUL
{
    public partial class FrmOgrenciPanel : Form
    {
        public FrmOgrenciPanel()
        {
            InitializeComponent();
            InitializeFormControls();
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void InitializeFormControls()
        {
            FormHelper.InitializeForm(this, panel1, Maximizebxogrt);
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

        baglanti bgl = new baglanti();

        public string numara;
        
        private void ÖğrenciPanel_Load(object sender, EventArgs e)
        {
            
            using (var bgl2 = bgl.sqlbaglanti())
            {
                FormSize.Initialize(this);
                //datagride ıd numarasına göre notları çekme
                
                SqlCommand komut = new SqlCommand("SELECT DersAd,Sınav1,Sınav2,Final,Ortalama,Durum FROM TBLNOTLAR INNER JOIN TBLDERSLER ON TBLNOTLAR.DersID = TBLDERSLER.DersID WHERE OgrID=1", bgl2);
                komut.Parameters.AddWithValue("@p1", numara);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                //yan panele ad soyad ve numara yazımı
                SqlCommand komut2 = new SqlCommand("Select * From TBlOGRENCILER  where OgrID=@p1", bgl.sqlbaglanti());
                komut2.Parameters.AddWithValue("@p1", numara);
                SqlDataReader oku = komut2.ExecuteReader();
                while (oku.Read())
                {
                    string ogrAd = oku["OgrAD"].ToString();
                    string ogrSoyad = oku["OgrSOYAD"].ToString();
                    lblAd.Text = ogrAd;
                    lblSoyad.Text = ogrSoyad;
                    lblID.Text = numara.ToString();
                }
                bgl.sqlbaglanti().Close();
            }
        }

        private void pctrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
