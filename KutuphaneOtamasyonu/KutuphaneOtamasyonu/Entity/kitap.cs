using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtamasyonu.Entity
{
    public class kitap
    {
        public int kitapid { get; set; }
        public string kitapİsmi { get; set; }
        public string kitapYazarı { get; set; }
        public  string kitapDili { get; set; }
        public string yayinEvi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfaSayısı { get; set; }
        public int basimTarih { get; set; }


        public kitap()
        {
            
        }


        public kitap(int kitapid, string kitapİsmi,string kitapYazarı, string kitapDili, string yayinEvi, string tur, int adet, int sayfaSayısı, int basimTarih)
        {
            this.kitapid = kitapid;
            this.kitapİsmi = kitapİsmi;
            this.kitapYazarı = kitapYazarı;
            this.kitapDili = kitapDili;
            this.yayinEvi = yayinEvi;
            this.tur = tur;
            this.adet = adet;
            this.sayfaSayısı = sayfaSayısı;
            this.basimTarih = basimTarih;
            
        }



        public int getKitapid()
        {
            return this.kitapid;
        }
        public string getKitapİsmi()
        {
            return this.kitapİsmi;
        }
        public string getKitapYazarı()
        {
            return this.kitapYazarı;
        }
        public string getKitapDili()
        {
            return this.kitapDili;
        }
        public string getYayınEvi()
        {
            return this.yayinEvi;
        }
        public string getTur()
        {
            return this.tur;
        }
        public int getAdet()
        {
            return this.adet;
        }
        public int getSayfaSayısı()
        {
            return this.sayfaSayısı;
        }
        public int getBasımTarih()
        {
            return this.basimTarih;
        }


    }
}
