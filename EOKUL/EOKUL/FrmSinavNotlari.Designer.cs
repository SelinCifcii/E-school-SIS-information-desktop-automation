namespace EOKUL
{
    partial class FrmSinavNotlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinavNotlari));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNotID = new System.Windows.Forms.TextBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnAra = new XanderUI.XUIButton();
            this.btnTemizle = new XanderUI.XUIButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGüncelle = new XanderUI.XUIButton();
            this.btnHesapla = new XanderUI.XUIButton();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txtNotID);
            this.panel1.Controls.Add(this.cmbDers);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Controls.Add(this.btnHesapla);
            this.panel1.Controls.Add(this.txtDurum);
            this.panel1.Controls.Add(this.txtOrtalama);
            this.panel1.Controls.Add(this.txtFinal);
            this.panel1.Controls.Add(this.txtSınav2);
            this.panel1.Controls.Add(this.txtSınav1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 329);
            this.panel1.TabIndex = 0;
            // 
            // txtNotID
            // 
            this.txtNotID.Location = new System.Drawing.Point(172, 121);
            this.txtNotID.Name = "txtNotID";
            this.txtNotID.Size = new System.Drawing.Size(119, 30);
            this.txtNotID.TabIndex = 29;
            this.txtNotID.Visible = false;
            // 
            // cmbDers
            // 
            this.cmbDers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(472, 39);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(161, 33);
            this.cmbDers.TabIndex = 26;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(702, 157);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAra.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAra.ButtonImage")));
            this.btnAra.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnAra.ButtonText = "ARA";
            this.btnAra.ClickBackColor = System.Drawing.Color.White;
            this.btnAra.ClickTextColor = System.Drawing.Color.White;
            this.btnAra.CornerRadius = 5;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAra.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnAra.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAra.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAra.Location = new System.Drawing.Point(172, 68);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(161, 25);
            this.btnAra.TabIndex = 23;
            this.btnAra.TextColor = System.Drawing.Color.White;
            this.btnAra.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTemizle.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ButtonImage")));
            this.btnTemizle.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnTemizle.ButtonText = "TEMİZLE";
            this.btnTemizle.ClickBackColor = System.Drawing.Color.White;
            this.btnTemizle.ClickTextColor = System.Drawing.Color.White;
            this.btnTemizle.CornerRadius = 5;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTemizle.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnTemizle.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTemizle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTemizle.Location = new System.Drawing.Point(771, 157);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(169, 51);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.TextColor = System.Drawing.Color.White;
            this.btnTemizle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(702, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(702, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGüncelle.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ButtonImage")));
            this.btnGüncelle.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnGüncelle.ButtonText = "GÜNCELLE";
            this.btnGüncelle.ClickBackColor = System.Drawing.Color.White;
            this.btnGüncelle.ClickTextColor = System.Drawing.Color.White;
            this.btnGüncelle.CornerRadius = 5;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGüncelle.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnGüncelle.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGüncelle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnGüncelle.Location = new System.Drawing.Point(771, 100);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(169, 51);
            this.btnGüncelle.TabIndex = 19;
            this.btnGüncelle.TextColor = System.Drawing.Color.White;
            this.btnGüncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHesapla.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnHesapla.ButtonImage")));
            this.btnHesapla.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnHesapla.ButtonText = "HESAPLA";
            this.btnHesapla.ClickBackColor = System.Drawing.Color.White;
            this.btnHesapla.ClickTextColor = System.Drawing.Color.White;
            this.btnHesapla.CornerRadius = 5;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHesapla.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnHesapla.HoverTextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHesapla.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnHesapla.Location = new System.Drawing.Point(771, 39);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(169, 51);
            this.btnHesapla.TabIndex = 18;
            this.btnHesapla.TextColor = System.Drawing.Color.White;
            this.btnHesapla.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtDurum
            // 
            this.txtDurum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDurum.Location = new System.Drawing.Point(472, 195);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(161, 23);
            this.txtDurum.TabIndex = 17;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrtalama.Location = new System.Drawing.Point(472, 165);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(161, 23);
            this.txtOrtalama.TabIndex = 16;
            // 
            // txtFinal
            // 
            this.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFinal.Location = new System.Drawing.Point(472, 136);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(161, 23);
            this.txtFinal.TabIndex = 15;
            // 
            // txtSınav2
            // 
            this.txtSınav2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSınav2.Location = new System.Drawing.Point(472, 107);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(161, 23);
            this.txtSınav2.TabIndex = 14;
            // 
            // txtSınav1
            // 
            this.txtSınav1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSınav1.Location = new System.Drawing.Point(472, 78);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(161, 23);
            this.txtSınav1.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(172, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 23);
            this.txtID.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "DURUM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "ORTALAMA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "FİNAL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "SINAV 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "SINAV 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DERS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖGRENCİ ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1267, 449);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmSinavNotlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSinavNotlari";
            this.Size = new System.Drawing.Size(1270, 787);
            this.Load += new System.EventHandler(this.FrmSinavNotlari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtSınav2;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private XanderUI.XUIButton btnAra;
        private XanderUI.XUIButton btnTemizle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIButton btnGüncelle;
        private XanderUI.XUIButton btnHesapla;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.TextBox txtNotID;
    }
}
