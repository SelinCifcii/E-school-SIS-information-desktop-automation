namespace EOKUL
{
    partial class FrmKulupIslemleri
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKulupIslemleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtkulüpID = new System.Windows.Forms.TextBox();
            this.txtKulüpAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSil = new XanderUI.XUIButton();
            this.btnGüncelle = new XanderUI.XUIButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEkle = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtkulüpID
            // 
            this.txtkulüpID.Enabled = false;
            this.txtkulüpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkulüpID.Location = new System.Drawing.Point(365, 393);
            this.txtkulüpID.Name = "txtkulüpID";
            this.txtkulüpID.Size = new System.Drawing.Size(216, 30);
            this.txtkulüpID.TabIndex = 1;
            // 
            // txtKulüpAd
            // 
            this.txtKulüpAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulüpAd.Location = new System.Drawing.Point(365, 429);
            this.txtKulüpAd.Name = "txtKulüpAd";
            this.txtKulüpAd.Size = new System.Drawing.Size(216, 30);
            this.txtKulüpAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(254, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "KULÜP ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(245, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "KULÜP AD:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 238);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(667, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(365, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSil.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSil.ButtonImage")));
            this.btnSil.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnSil.ButtonText = "Sil";
            this.btnSil.ClickBackColor = System.Drawing.Color.White;
            this.btnSil.ClickTextColor = System.Drawing.Color.White;
            this.btnSil.CornerRadius = 5;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSil.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnSil.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSil.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSil.Location = new System.Drawing.Point(755, 24);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(194, 62);
            this.btnSil.TabIndex = 5;
            this.btnSil.TextColor = System.Drawing.Color.White;
            this.btnSil.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGüncelle.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ButtonImage")));
            this.btnGüncelle.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnGüncelle.ButtonText = "Güncelle";
            this.btnGüncelle.ClickBackColor = System.Drawing.Color.White;
            this.btnGüncelle.ClickTextColor = System.Drawing.Color.White;
            this.btnGüncelle.CornerRadius = 5;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGüncelle.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnGüncelle.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGüncelle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnGüncelle.Location = new System.Drawing.Point(444, 24);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(194, 62);
            this.btnGüncelle.TabIndex = 4;
            this.btnGüncelle.TextColor = System.Drawing.Color.White;
            this.btnGüncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEkle.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.ButtonImage")));
            this.btnEkle.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnEkle.ButtonText = "Ekle";
            this.btnEkle.ClickBackColor = System.Drawing.Color.White;
            this.btnEkle.ClickTextColor = System.Drawing.Color.White;
            this.btnEkle.CornerRadius = 5;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEkle.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnEkle.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEkle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEkle.Location = new System.Drawing.Point(141, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(194, 62);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.TextColor = System.Drawing.Color.White;
            this.btnEkle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmKulupIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKulüpAd);
            this.Controls.Add(this.txtkulüpID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKulupIslemleri";
            this.Size = new System.Drawing.Size(1107, 715);
            this.Load += new System.EventHandler(this.FrmKulupIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtkulüpID;
        private System.Windows.Forms.TextBox txtKulüpAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private XanderUI.XUIButton btnSil;
        private XanderUI.XUIButton btnGüncelle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private XanderUI.XUIButton btnEkle;
    }
}
