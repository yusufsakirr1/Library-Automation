using KutuphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class Form1 : Form
    {

        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txtbx_kullaniciadi.Text = string.Empty;
            txtbx_sifre.Text = string.Empty;
        }

        private void txtbx_kullaniciadi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1,"Yusuf","ŞAKİR",DateTime.Now,"yusuf","1","Admin"));
            kisilerim.Add(new Kisi(2, "Kenan", "YILMAZ", DateTime.Now, "kenan", "2", "Üye"));
            kisilerim.Add(new Kisi(3, "Fatih", "KIRMIZITAŞ", DateTime.Now, "fatih", "3", "Üye"));
            kisilerim.Add(new Kisi(4, "Mehmet", "KARABAŞ", DateTime.Now, "mehmet", "4", "Üye"));

            kitaplarim.Add(new Kitap(1,"İçimizdeki Şeytan","Sebahattin Ali","Türkçe","Yapı Kredi Yayınları","Roman",100,250,2016));
            kitaplarim.Add(new Kitap(2,"Tutunamayanlar","Oğuz Atay","Türkçe","İletişim Yayıncılık","Roman",350,760,2015));
            kitaplarim.Add(new Kitap(3,"Uçurtma Avcısı","Khaled Hosseini","İngilizce","Everest Yayıncılık","Roman",100,350,2010));
            kitaplarim.Add(new Kitap(4,"Küçük Prens","Antoine de Saint-Exupery","İngilizce","Can Çocuk Yayınları","Roman",50,60,2018));
            kitaplarim.Add(new Kitap(5,"Kürk Mantolu Mandonna","Sebahattin Ali","Türkçe", "Yapı Kredi Yayınları", "Roman",650,220,2015));
            kitaplarim.Add(new Kitap(6, "Tehlikeli Oyunlar","Oğuz Atay","Türkçe", "İletişim Yayıncılık","Roman",420,500,2018));
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtbx_kullaniciadi.Text;
            string sifre = txtbx_sifre.Text;

            bool girisBasarili = false;

            foreach (Kisi kisi in kisilerim)
            {
                if (kullaniciadi.ToLower() == kisi.getkullaniciadi() && sifre.ToLower() == kisi.getsifre())
                {
                    if (kisi.getyetki() == "Admin")
                    {
                        // Admin sayfasına yönlendir...
                        AdminSayfasi adminsayfasi = new AdminSayfasi(kisilerim,kitaplarim);
                        adminsayfasi.Show();
                        this.Hide();
                        girisBasarili = true;
                        break;
                    }
                    else if (kisi.getyetki() == "Üye")
                    {
                        // Üye sayfasına yönlendir...
                        UyeSayfasi uyeSayfasi = new UyeSayfasi(kitaplarim);
                        uyeSayfasi.Show();
                        this.Hide();
                        girisBasarili = true;
                        break;
                    }
                    
                }

            }

            if (!girisBasarili)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
