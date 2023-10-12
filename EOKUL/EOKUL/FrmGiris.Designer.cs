namespace EOKUL
{
    partial class FrmGiris
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Maximizebx = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblGiriş = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOgretmen = new XanderUI.XUIButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOgrenci = new XanderUI.XUIButton();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xuıSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizebx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.xuıSlidingPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(131)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.Maximizebx);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 28);
            this.panel1.TabIndex = 0;
            // 
            // Maximizebx
            // 
            this.Maximizebx.Image = ((System.Drawing.Image)(resources.GetObject("Maximizebx.Image")));
            this.Maximizebx.Location = new System.Drawing.Point(586, 2);
            this.Maximizebx.Name = "Maximizebx";
            this.Maximizebx.Size = new System.Drawing.Size(27, 22);
            this.Maximizebx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizebx.TabIndex = 2;
            this.Maximizebx.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(619, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lblGiriş
            // 
            this.lblGiriş.AutoSize = true;
            this.lblGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiriş.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGiriş.Location = new System.Drawing.Point(222, 44);
            this.lblGiriş.Name = "lblGiriş";
            this.lblGiriş.Size = new System.Drawing.Size(347, 32);
            this.lblGiriş.TabIndex = 3;
            this.lblGiriş.Text = "Bilgilendirme Sistemi Giriş";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.btnOgretmen);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnOgrenci);
            this.panel3.Controls.Add(this.txtSifre);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(199, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 285);
            this.panel3.TabIndex = 4;
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.BackgroundColor = System.Drawing.Color.Silver;
            this.btnOgretmen.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnOgretmen.ButtonImage")));
            this.btnOgretmen.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnOgretmen.ButtonText = "Öğretmen Girişi";
            this.btnOgretmen.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnOgretmen.ClickTextColor = System.Drawing.Color.White;
            this.btnOgretmen.CornerRadius = 5;
            this.btnOgretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgretmen.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOgretmen.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnOgretmen.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnOgretmen.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnOgretmen.Location = new System.Drawing.Point(213, 158);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(176, 81);
            this.btnOgretmen.TabIndex = 7;
            this.btnOgretmen.TextColor = System.Drawing.Color.Black;
            this.btnOgretmen.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(255, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 2);
            this.panel5.TabIndex = 9;
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackgroundColor = System.Drawing.Color.Silver;
            this.btnOgrenci.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnOgrenci.ButtonImage")));
            this.btnOgrenci.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnOgrenci.ButtonText = "Öğrenci Girişi";
            this.btnOgrenci.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnOgrenci.ClickTextColor = System.Drawing.Color.White;
            this.btnOgrenci.CornerRadius = 5;
            this.btnOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrenci.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOgrenci.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnOgrenci.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnOgrenci.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnOgrenci.Location = new System.Drawing.Point(18, 158);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(176, 81);
            this.btnOgrenci.TabIndex = 6;
            this.btnOgrenci.TextColor = System.Drawing.Color.Black;
            this.btnOgrenci.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOgrenci.Click += new System.EventHandler(this.xuıButton1_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Gray;
            this.txtSifre.Location = new System.Drawing.Point(255, 92);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(134, 28);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(74, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(253, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 2);
            this.panel4.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.ForeColor = System.Drawing.Color.Gray;
            this.txtID.Location = new System.Drawing.Point(253, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 28);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Numaranızı girin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(81, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Numarası:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xuıSlidingPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 417);
            this.panel2.TabIndex = 5;
            // 
            // xuıSlidingPanel1
            // 
            this.xuıSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuıSlidingPanel1.BottomRight = System.Drawing.Color.Blue;
            this.xuıSlidingPanel1.CollapseControl = null;
            this.xuıSlidingPanel1.Collapsed = true;
            this.xuıSlidingPanel1.Controls.Add(this.pictureBox3);
            this.xuıSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuıSlidingPanel1.HideControls = false;
            this.xuıSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuıSlidingPanel1.Name = "xuıSlidingPanel1";
            this.xuıSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuıSlidingPanel1.PanelWidthExpanded = 200;
            this.xuıSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuıSlidingPanel1.Size = new System.Drawing.Size(155, 417);
            this.xuıSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuıSlidingPanel1.TabIndex = 0;
            this.xuıSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuıSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(26, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(661, 445);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblGiriş);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGiris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Maximizebx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.xuıSlidingPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGiriş;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnOgrenci;
        private XanderUI.XUIButton btnOgretmen;
        private XanderUI.XUISlidingPanel xuıSlidingPanel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Maximizebx;
    }
}

