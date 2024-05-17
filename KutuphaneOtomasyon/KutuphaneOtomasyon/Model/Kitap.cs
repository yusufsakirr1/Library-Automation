using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Model
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string kitapIsim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayinEvi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public int basimYil { get; set; }
        public Kitap()
        {

        }

        public Kitap(int KitapId, string kitapIsim, string kitapYazar, string kitapDili, string yayinEvi, string tur, int adet, int sayfaSayisi, int basimYil)
        {
            this.KitapId = KitapId;
            this.kitapIsim = kitapIsim;
            this.kitapYazar = kitapYazar;
            this.kitapDili = kitapDili;
            this.yayinEvi = yayinEvi;
            this.tur = tur;
            this.adet = adet;
            this.sayfaSayisi = sayfaSayisi;
            this.basimYil = basimYil;
        }
        public int getKitapId() {
            return this.KitapId;
        }
        public string getkitapIsim()
        {
            return this.kitapIsim;
        }
        public string getkitapYazar()
        {
            return this.kitapYazar;
        }
        public string getkitapDili()
        {
            return this.kitapDili;
        }
        public string getyayinEvi()
        {
            return this.yayinEvi;
        }
        public string gettur()
        {
            return this.tur;
        }
        public int getadet()
        {
            return this.adet;
        }
        public int getsayfaSayisi()
        {
            return this.sayfaSayisi;
        }
        
            public int getbasimYil()
        {
            return this.basimYil;
        }


    }
}
