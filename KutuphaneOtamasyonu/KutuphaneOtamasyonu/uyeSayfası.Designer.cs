namespace KutuphaneOtamasyonu
{
    partial class uyeSayfası
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
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonYenile = new System.Windows.Forms.Button();
            this.textBoxKitapİd = new System.Windows.Forms.TextBox();
            this.buttonCıkısYap = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basıntarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(12, 22);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(75, 23);
            this.buttonAra.TabIndex = 0;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonYenile
            // 
            this.buttonYenile.Location = new System.Drawing.Point(199, 22);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(75, 23);
            this.buttonYenile.TabIndex = 0;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseVisualStyleBackColor = true;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // textBoxKitapİd
            // 
            this.textBoxKitapİd.Location = new System.Drawing.Point(93, 23);
            this.textBoxKitapİd.Name = "textBoxKitapİd";
            this.textBoxKitapİd.Size = new System.Drawing.Size(100, 22);
            this.textBoxKitapİd.TabIndex = 1;
            // 
            // buttonCıkısYap
            // 
            this.buttonCıkısYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCıkısYap.Location = new System.Drawing.Point(12, 314);
            this.buttonCıkısYap.Name = "buttonCıkısYap";
            this.buttonCıkısYap.Size = new System.Drawing.Size(109, 32);
            this.buttonCıkısYap.TabIndex = 3;
            this.buttonCıkısYap.Text = "Cıkış yap";
            this.buttonCıkısYap.UseVisualStyleBackColor = true;
            this.buttonCıkısYap.Click += new System.EventHandler(this.buttonCıkısYap_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdili,
            this.yayınevi,
            this.tur,
            this.adet,
            this.sayfa,
            this.basıntarih});
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 210);
            this.dataGridView1.TabIndex = 4;
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KİTAPİD";
            this.kitapid.MinimumWidth = 6;
            this.kitapid.Name = "kitapid";
            this.kitapid.Width = 80;
            // 
            // kitapisim
            // 
            this.kitapisim.HeaderText = "KİTAP İSİM";
            this.kitapisim.MinimumWidth = 6;
            this.kitapisim.Name = "kitapisim";
            this.kitapisim.Width = 80;
            // 
            // kitapyazar
            // 
            this.kitapyazar.HeaderText = "kİTAP YAZARI";
            this.kitapyazar.MinimumWidth = 6;
            this.kitapyazar.Name = "kitapyazar";
            this.kitapyazar.Width = 80;
            // 
            // kitapdili
            // 
            this.kitapdili.HeaderText = "KİTAP DİLİ";
            this.kitapdili.MinimumWidth = 6;
            this.kitapdili.Name = "kitapdili";
            this.kitapdili.Width = 80;
            // 
            // yayınevi
            // 
            this.yayınevi.HeaderText = "YAYIN EVİ";
            this.yayınevi.MinimumWidth = 6;
            this.yayınevi.Name = "yayınevi";
            this.yayınevi.Width = 80;
            // 
            // tur
            // 
            this.tur.HeaderText = "TUR";
            this.tur.MinimumWidth = 6;
            this.tur.Name = "tur";
            this.tur.Width = 80;
            // 
            // adet
            // 
            this.adet.HeaderText = "ADET";
            this.adet.MinimumWidth = 6;
            this.adet.Name = "adet";
            this.adet.Width = 80;
            // 
            // sayfa
            // 
            this.sayfa.HeaderText = "SAYFA";
            this.sayfa.MinimumWidth = 6;
            this.sayfa.Name = "sayfa";
            this.sayfa.Width = 80;
            // 
            // basıntarih
            // 
            this.basıntarih.HeaderText = "BASIM TARİHİ";
            this.basıntarih.MinimumWidth = 6;
            this.basıntarih.Name = "basıntarih";
            this.basıntarih.Width = 80;
            // 
            // uyeSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 369);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCıkısYap);
            this.Controls.Add(this.textBoxKitapİd);
            this.Controls.Add(this.buttonYenile);
            this.Controls.Add(this.buttonAra);
            this.Name = "uyeSayfası";
            this.Text = "uyeSayfası";
            this.Load += new System.EventHandler(this.uyeSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonYenile;
        private System.Windows.Forms.TextBox textBoxKitapİd;
        private System.Windows.Forms.Button buttonCıkısYap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn basıntarih;
    }
}