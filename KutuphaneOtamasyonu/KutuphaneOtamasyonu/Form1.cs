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
    public partial class Form1 : Form
    {

        List<Kisi> kisilerim=new List<Kisi>();
        List<kitap> kitaplarım=new List<kitap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_kullanıcıAD.Text=string.Empty;
            textBox_sifre.Text=string.Empty;
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = " ";

            kullaniciAdi = textBox_kullanıcıAD.Text;
            sifre = textBox_sifre.Text;

            bool kontrol = false;

            foreach (Kisi kisi in kisilerim)
            {
                if(kullaniciAdi.ToLower()==kisi.getkullaniciAdi() && sifre.ToLower()==kisi.getsifre() && kisi.getyetki() == "admin")
                {
                    // admin sayfası acılır
                    AdminSayfası adminSayfası=new AdminSayfası(kisilerim,kitaplarım);
                    adminSayfası.Show();
                    this.Hide();
                    kontrol= true;
                    break;

                }
                else if(kullaniciAdi.ToLower() == kisi.getkullaniciAdi() && sifre.ToLower() == kisi.getsifre() && kisi.getyetki() == "uye")
                {
                    // uye sayfası acılır
                    uyeSayfası uyeSayfası=new uyeSayfası(kitaplarım);
                    uyeSayfası.Show();
                    this.Hide();
                    kontrol= true;
                    break;
                }
               
                
            }
            if (!kontrol)
            {
                MessageBox.Show("bir hata oluştu","eror",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1,"ozan","sevim",DateTime.Now,"ozan","1","admin"));
            kisilerim.Add(new Kisi(2, "ahmet", "mert", DateTime.Now, "ahmet", "2", "uye"));
            kisilerim.Add(new Kisi(3, "basak", "meral", DateTime.Now, "basak", "3", "uye"));
            kisilerim.Add(new Kisi(4, "selim", "vurucu", DateTime.Now, "selim", "4", "uye"));



            kitaplarım.Add(new kitap(1, "içimizdeki şeytan", "sabahattin ali", "türkce", "aksaray kitap", "roman", 100, 250, 2016));
            kitaplarım.Add(new kitap(2, "tutanamayanlar ", " oğuz hatay", "türkce", "aksaray kitap", "roman", 100, 350, 2010));
            kitaplarım.Add(new kitap(3, "sefiller", "viktor hugo", "ingilizce", "aksaray kitap", "roman", 200, 350, 1990));
            kitaplarım.Add(new kitap(4, "falaka", "ahmet rasim", "türkce", "aksaray kitap", "roman", 50, 250, 2012));
            
        }
    }
}
