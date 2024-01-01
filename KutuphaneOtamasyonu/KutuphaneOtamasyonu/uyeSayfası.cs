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
    public partial class uyeSayfası : Form
    {
          List<kitap> kitaplarim;  
        public uyeSayfası(List<kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void buttonCıkısYap_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi=new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Cıkış yapıldı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void uyeSayfası_Load(object sender, EventArgs e)
        {
            foreach (kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getKitapid(), kitap.getKitapİsmi(), kitap.getKitapYazarı(), kitap.getKitapDili(), kitap.getYayınEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaSayısı(), kitap.getBasımTarih());
            }
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            int kitapİD = Convert.ToInt32(textBoxKitapİd.Text);
            kitap HedefKitap=null;

            foreach (kitap kitap in kitaplarim)
            {
                if (kitap.getKitapid() == kitapİD)
                {
                    HedefKitap= kitap;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(HedefKitap.getKitapid(), HedefKitap.getKitapİsmi(), HedefKitap.getKitapYazarı(), HedefKitap.getKitapDili(), HedefKitap.getYayınEvi(), HedefKitap.getTur(), HedefKitap.getAdet(), HedefKitap.getSayfaSayısı(), HedefKitap.getBasımTarih());

        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);



            foreach (kitap HedefKitap in kitaplarim)
            {
                dataGridView1.Rows.Add(HedefKitap.getKitapid(), HedefKitap.getKitapİsmi(), HedefKitap.getKitapYazarı(), HedefKitap.getKitapDili(), HedefKitap.getYayınEvi(), HedefKitap.getTur(), HedefKitap.getAdet(), HedefKitap.getSayfaSayısı(), HedefKitap.getBasımTarih());

            }
        }
    }
}
