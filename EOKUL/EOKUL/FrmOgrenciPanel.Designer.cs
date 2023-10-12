namespace EOKUL
{
    partial class FrmOgrenciPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Maximizebxogrt = new System.Windows.Forms.PictureBox();
            this.pctrExit = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xuıSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizebxogrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.xuıSlidingPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(131)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Maximizebxogrt);
            this.panel1.Controls.Add(this.pctrExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 31);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Bilgi Paneli";
            // 
            // Maximizebxogrt
            // 
            this.Maximizebxogrt.Image = ((System.Drawing.Image)(resources.GetObject("Maximizebxogrt.Image")));
            this.Maximizebxogrt.Location = new System.Drawing.Point(942, 4);
            this.Maximizebxogrt.Name = "Maximizebxogrt";
            this.Maximizebxogrt.Size = new System.Drawing.Size(23, 23);
            this.Maximizebxogrt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizebxogrt.TabIndex = 1;
            this.Maximizebxogrt.TabStop = false;
            // 
            // pctrExit
            // 
            this.pctrExit.Image = ((System.Drawing.Image)(resources.GetObject("pctrExit.Image")));
            this.pctrExit.Location = new System.Drawing.Point(971, 4);
            this.pctrExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pctrExit.Name = "pctrExit";
            this.pctrExit.Size = new System.Drawing.Size(23, 23);
            this.pctrExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrExit.TabIndex = 0;
            this.pctrExit.TabStop = false;
            this.pctrExit.Click += new System.EventHandler(this.pctrExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(197, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(812, 521);
            this.dataGridView1.TabIndex = 2;
            // 
            // xuıSlidingPanel1
            // 
            this.xuıSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuıSlidingPanel1.BottomRight = System.Drawing.Color.Blue;
            this.xuıSlidingPanel1.CollapseControl = null;
            this.xuıSlidingPanel1.Collapsed = true;
            this.xuıSlidingPanel1.Controls.Add(this.lblSoyad);
            this.xuıSlidingPanel1.Controls.Add(this.lblID);
            this.xuıSlidingPanel1.Controls.Add(this.lblAd);
            this.xuıSlidingPanel1.Controls.Add(this.label3);
            this.xuıSlidingPanel1.Controls.Add(this.label2);
            this.xuıSlidingPanel1.Controls.Add(this.pictureBox3);
            this.xuıSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuıSlidingPanel1.HideControls = false;
            this.xuıSlidingPanel1.Location = new System.Drawing.Point(0, 31);
            this.xuıSlidingPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xuıSlidingPanel1.Name = "xuıSlidingPanel1";
            this.xuıSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuıSlidingPanel1.PanelWidthExpanded = 200;
            this.xuıSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuıSlidingPanel1.Size = new System.Drawing.Size(203, 521);
            this.xuıSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuıSlidingPanel1.TabIndex = 3;
            this.xuıSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuıSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSoyad.Location = new System.Drawing.Point(52, 197);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(41, 22);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Null";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblID.Location = new System.Drawing.Point(14, 260);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 22);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Null";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAd.Location = new System.Drawing.Point(14, 197);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(41, 22);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Ad:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 17);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // FrmOgrenciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 552);
            this.Controls.Add(this.xuıSlidingPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOgrenciPanel";
            this.Text = "ÖğrenciPanel";
            this.Load += new System.EventHandler(this.ÖğrenciPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizebxogrt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.xuıSlidingPanel1.ResumeLayout(false);
            this.xuıSlidingPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctrExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private XanderUI.XUISlidingPanel xuıSlidingPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Maximizebxogrt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
    }
}