using KutuphaneOtamasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtamasyonu
{
    public partial class AdminSayfası : Form
    {
        List<Kisi> kisilerim;
        List<kitap> kitaplarım ;
        public AdminSayfası(List<Kisi> kisilerim,List<kitap> kitaplarım)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarım = kitaplarım;
        }

        private void AdminSayfası_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getid(),kisi.getisim(),kisi.getsoyisim(),kisi.getolusturmaTarihi(),kisi.getkullaniciAdi(),kisi.getsifre(), kisi.getyetki());
            }

            foreach (kitap kitap in kitaplarım)
            {
                dataGridView2.Rows.Add(kitap.getKitapid(), kitap.getKitapİsmi(), kitap.getKitapYazarı(), kitap.getKitapDili(), kitap.getYayınEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaSayısı(), kitap.getBasımTarih());
            }

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(textBoxID.Text),textBoxADI.Text,textBoxSOYAD.Text,maskedTextBoxTarih.Text,textBoxKullanıcıAd.Text,textBoxSifre.Text,textBoxYetki.Text);

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        public void textleriDoldur()
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxADI.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSOYAD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBoxTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxKullanıcıAd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxSifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxYetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();



        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            string id=textBoxID.Text;
            string adi=textBoxADI.Text;
            string soyad=textBoxSOYAD.Text;
            string tarih = maskedTextBoxTarih.Text;
            string kullanıcıAd = textBoxKullanıcıAd.Text;
            string sifre = textBoxSifre.Text;
            string yetki = textBoxYetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,adi,soyad,tarih,kullanıcıAd,sifre,yetki);

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBox_uyeİslemleri.Controls.Count; i ++)
            {
                if (groupBox_uyeİslemleri.Controls[i] is TextBox || groupBox_uyeİslemleri.Controls[i] is MaskedTextBox)
                {
                    groupBox_uyeİslemleri.Controls[i].Text=string.Empty;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(textBoxKitapid.Text,textBoxKitapisim.Text,textBoxYazar.Text,textBoxDili.Text,textBoxYayınEvi.Text,textBoxTur.Text,textBoxAdet.Text,textBoxSayfa.Text,textBoxBasımYılı.Text);

        }

        private void buttonKitapSil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void buttonKitapGüncel_Click(object sender, EventArgs e)
        {
            string kitapid=textBoxKitapid.Text;
            string kitapisim=textBoxKitapisim.Text;
            string yazar=textBoxYazar.Text;
            string dili=textBoxDili.Text;
            string yayınEvi = textBoxYayınEvi.Text;
            string tur=textBoxTur.Text;
            string adet=textBoxAdet.Text;
            string sayfa=textBoxSayfa.Text;
            string basımYılı = textBoxBasımYılı.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapisim, yazar, dili, yayınEvi, tur, adet, sayfa, basımYılı);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxKitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBoxKitapisim.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBoxYazar.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBoxDili.Text= dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBoxYayınEvi.Text= dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBoxTur.Text= dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBoxAdet.Text= dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBoxSayfa.Text= dataGridView2.CurrentRow.Cells[7].Value.ToString();
            textBoxBasımYılı.Text= dataGridView2.CurrentRow.Cells[8].Value.ToString();

        }

        private void buttonKitapTemiz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBoxKitap.Controls.Count; i++)
            {
                if (groupBoxKitap.Controls[i] is TextBox || groupBoxKitap.Controls[i] is MaskedTextBox)
                {
                    groupBoxKitap.Controls[i].Text = string.Empty;
                }
            }
        }

        private void groupBox_uyeİslemleri_Enter(object sender, EventArgs e)
        {

        }

        private void buttonKişiAra_Click(object sender, EventArgs e)
        {
            Kisi hedefKisi = null;

            int secilenKisiİd = Convert.ToInt32(textBox1.Text);

            foreach (Kisi kisi in kisilerim)
            {
                if(kisi.getid()==secilenKisiİd)
                {
                    hedefKisi=kisi;

                    break;
                }

            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKisi.getid(),hedefKisi.getisim(),hedefKisi.getsoyisim(),hedefKisi.getolusturmaTarihi(),hedefKisi.getkullaniciAdi(),hedefKisi.getsifre(),hedefKisi.getyetki());

        }

        private void buttonKişiYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            foreach (Kisi hedefKisi in kisilerim)
            {
             dataGridView1.Rows.Add(hedefKisi.getid(), hedefKisi.getisim(), hedefKisi.getsoyisim(), hedefKisi.getolusturmaTarihi(), hedefKisi.getkullaniciAdi(), hedefKisi.getsifre(), hedefKisi.getyetki());

            }
        }

        private void buttonKitapAra_Click(object sender, EventArgs e)
        {
            kitap hedefKitap = null;

            int kitapİD = Convert.ToInt32(textBox2.Text);

            foreach (kitap kitap in kitaplarım)
            {
                if(kitap.getKitapid()==kitapİD)
                {
                    hedefKitap = kitap;
                    break;
                }

            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapid(), hedefKitap.getKitapİsmi(), hedefKitap.getKitapYazarı(), hedefKitap.getKitapDili(), hedefKitap.getYayınEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayısı(), hedefKitap.getBasımTarih());

        }

        private void buttonKitapYenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            foreach (kitap hedefKitap in kitaplarım)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapid(), hedefKitap.getKitapİsmi(), hedefKitap.getKitapYazarı(), hedefKitap.getKitapDili(), hedefKitap.getYayınEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayısı(), hedefKitap.getBasımTarih());

            }

        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            Form1 loginSayfası= new Form1();
            loginSayfası.Show();
            this.Hide();
            MessageBox.Show("Cıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
