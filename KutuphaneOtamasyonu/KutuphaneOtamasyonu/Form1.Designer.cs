namespace KutuphaneOtamasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_kullanıcıAd = new System.Windows.Forms.Label();
            this.textBox_kullanıcıAD = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_kullanıcıAd
            // 
            this.lbl_kullanıcıAd.AutoSize = true;
            this.lbl_kullanıcıAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullanıcıAd.Location = new System.Drawing.Point(206, 62);
            this.lbl_kullanıcıAd.Name = "lbl_kullanıcıAd";
            this.lbl_kullanıcıAd.Size = new System.Drawing.Size(101, 20);
            this.lbl_kullanıcıAd.TabIndex = 4;
            this.lbl_kullanıcıAd.Text = "Kullanıcı Adı";
            // 
            // textBox_kullanıcıAD
            // 
            this.textBox_kullanıcıAD.Location = new System.Drawing.Point(313, 62);
            this.textBox_kullanıcıAD.Name = "textBox_kullanıcıAD";
            this.textBox_kullanıcıAD.Size = new System.Drawing.Size(194, 22);
            this.textBox_kullanıcıAD.TabIndex = 0;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.Location = new System.Drawing.Point(221, 96);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(44, 20);
            this.lbl_Sifre.TabIndex = 5;
            this.lbl_Sifre.Text = "Sifre";
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(313, 96);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(194, 22);
            this.textBox_sifre.TabIndex = 1;
            // 
            // button_giris
            // 
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.Location = new System.Drawing.Point(313, 140);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(90, 33);
            this.button_giris.TabIndex = 2;
            this.button_giris.Text = "Giris";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_temizle.Location = new System.Drawing.Point(409, 140);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(90, 33);
            this.button_temizle.TabIndex = 3;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 220);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.textBox_kullanıcıAD);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_kullanıcıAd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_kullanıcıAd;
        private System.Windows.Forms.TextBox textBox_kullanıcıAD;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Button button_temizle;
    }
}

