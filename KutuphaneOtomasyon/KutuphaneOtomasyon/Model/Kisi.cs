using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Model
{
    public class Kisi
    {
        public int id { get; set; }
        public string  isim { get; set; }
        public string  soyisim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string  yetki { get; set; }

        public Kisi()
        {

        }
        public Kisi(int id, string isim,string soyisim, DateTime olusturmaTarih,string kullaniciAdi,string sifre,string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.kullaniciAdi = kullaniciAdi;
            this.olusturmaTarih = olusturmaTarih;
            this.sifre = sifre;
            this.soyisim = soyisim;
            this.yetki = yetki;
        }

        public void setId(int id) {
            this.id = id;
        }

        public int getId() {
            return id;
        }

        public void setisim(String isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return isim;
        }

        public void setSoyisim(String soyisim)
        {
            this.soyisim = soyisim;
        }

        public string getSoyIsim()
        {
            return soyisim;
        }

        public void setkullaniciadi(String kullaniciadi)
        {
            this.kullaniciAdi = kullaniciadi;
        }

        public string getkullaniciadi()
        {
            return kullaniciAdi;
        }

        public void setolusturmaTarih(DateTime olusturmaTarih)
        {
            this.olusturmaTarih = olusturmaTarih;
        }

        public DateTime getolusturmaTarih()
        {
            return olusturmaTarih;
        }

        public void setsifre(String sifre)
        {
            this.sifre = sifre;
        }

        public string getsifre()
        {
            return sifre;
        }

        public void setyetki(String yetki)
        {
            this.yetki = yetki;
        }

        public string getyetki()
        {
            return yetki;
        }

        public override string ToString()
        {
            return "İsim- Soyisim: "+this.isim+" "+this.soyisim;
        }



    }
}
