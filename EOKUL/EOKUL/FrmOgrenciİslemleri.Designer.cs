namespace EOKUL
{
    partial class FrmOgrenciİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciİslemleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnSil = new XanderUI.XUIButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAra = new XanderUI.XUIButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnGüncelle = new XanderUI.XUIButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEkle = new XanderUI.XUIButton();
            this.txtklpID = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKulüp = new System.Windows.Forms.ComboBox();
            this.rdoErkek = new XanderUI.XUIRadio();
            this.rdoKız = new XanderUI.XUIRadio();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(1076, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(362, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 30);
            this.textBox1.TabIndex = 36;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(532, 134);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSil.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSil.ButtonImage")));
            this.btnSil.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnSil.ButtonText = "SİL";
            this.btnSil.ClickBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.ClickTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.CornerRadius = 5;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSil.HoverBackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSil.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSil.Location = new System.Drawing.Point(601, 134);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(169, 51);
            this.btnSil.TabIndex = 34;
            this.btnSil.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(362, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAra.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAra.ButtonImage")));
            this.btnAra.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnAra.ButtonText = "ARA";
            this.btnAra.ClickBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.ClickTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.CornerRadius = 5;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAra.HoverBackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAra.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAra.Location = new System.Drawing.Point(418, 79);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(291, 39);
            this.btnAra.TabIndex = 31;
            this.btnAra.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(532, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGüncelle.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ButtonImage")));
            this.btnGüncelle.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnGüncelle.ButtonText = "GÜNCELLE";
            this.btnGüncelle.ClickBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGüncelle.ClickTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGüncelle.CornerRadius = 5;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGüncelle.HoverBackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGüncelle.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGüncelle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnGüncelle.Location = new System.Drawing.Point(601, 18);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(169, 51);
            this.btnGüncelle.TabIndex = 30;
            this.btnGüncelle.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGüncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(532, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEkle.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.ButtonImage")));
            this.btnEkle.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnEkle.ButtonText = "EKLE";
            this.btnEkle.ClickBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.ClickTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.CornerRadius = 5;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEkle.HoverBackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEkle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEkle.Location = new System.Drawing.Point(601, 75);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(169, 51);
            this.btnEkle.TabIndex = 27;
            this.btnEkle.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtklpID
            // 
            this.txtklpID.AutoSize = true;
            this.txtklpID.Location = new System.Drawing.Point(866, 206);
            this.txtklpID.Name = "txtklpID";
            this.txtklpID.Size = new System.Drawing.Size(67, 20);
            this.txtklpID.TabIndex = 36;
            this.txtklpID.Text = "KLÜPID";
            this.txtklpID.Visible = false;
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(347, 102);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(161, 23);
            this.txtSifre.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "ŞİFRE:";
            // 
            // cmbKulüp
            // 
            this.cmbKulüp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbKulüp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKulüp.FormattingEnabled = true;
            this.cmbKulüp.Location = new System.Drawing.Point(347, 131);
            this.cmbKulüp.Name = "cmbKulüp";
            this.cmbKulüp.Size = new System.Drawing.Size(161, 33);
            this.cmbKulüp.TabIndex = 33;
            // 
            // rdoErkek
            // 
            this.rdoErkek.Checked = false;
            this.rdoErkek.ForeColor = System.Drawing.Color.Black;
            this.rdoErkek.Location = new System.Drawing.Point(444, 185);
            this.rdoErkek.Name = "rdoErkek";
            this.rdoErkek.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.rdoErkek.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdoErkek.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rdoErkek.Size = new System.Drawing.Size(76, 20);
            this.rdoErkek.TabIndex = 26;
            this.rdoErkek.Text = "Erkek";
            // 
            // rdoKız
            // 
            this.rdoKız.Checked = false;
            this.rdoKız.ForeColor = System.Drawing.Color.Black;
            this.rdoKız.Location = new System.Drawing.Point(362, 185);
            this.rdoKız.Name = "rdoKız";
            this.rdoKız.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.rdoKız.RadioHoverColor = System.Drawing.Color.Magenta;
            this.rdoKız.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rdoKız.Size = new System.Drawing.Size(76, 20);
            this.rdoKız.TabIndex = 25;
            this.rdoKız.Text = "Kız";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(347, 73);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(161, 23);
            this.txtSoyad.TabIndex = 23;
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(347, 44);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(161, 23);
            this.txtAd.TabIndex = 22;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(347, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 23);
            this.txtID.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "CİNSİYET:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "KULÜBÜ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "SOYADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "ADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ÖGRENCİ ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSoyad);
            this.panel3.Controls.Add(this.txtklpID);
            this.panel3.Controls.Add(this.btnGüncelle);
            this.panel3.Controls.Add(this.txtAd);
            this.panel3.Controls.Add(this.btnEkle);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.rdoKız);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rdoErkek);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtSifre);
            this.panel3.Controls.Add(this.cmbKulüp);
            this.panel3.Location = new System.Drawing.Point(3, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1070, 243);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Location = new System.Drawing.Point(3, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 141);
            this.panel1.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "ÖĞRENCİ ADI:";
            // 
            // FrmOgrenciİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOgrenciİslemleri";
            this.Size = new System.Drawing.Size(1076, 771);
            this.Load += new System.EventHandler(this.FrmOgrenciİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private XanderUI.XUIButton btnSil;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private XanderUI.XUIButton btnAra;
        private XanderUI.XUIButton btnGüncelle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private XanderUI.XUIButton btnEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIRadio rdoKız;
        private XanderUI.XUIRadio rdoErkek;
        private System.Windows.Forms.ComboBox cmbKulüp;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtklpID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}
