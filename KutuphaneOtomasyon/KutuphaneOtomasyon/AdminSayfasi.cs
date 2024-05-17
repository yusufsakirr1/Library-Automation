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
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim ;
        List<Kitap> kitaplarim;

        public AdminSayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
            this.kisilerim = kisilerim;
        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
               dataGridView1.Rows.Add(kisi.getId(),kisi.getIsim(),kisi.getSoyIsim(),kisi.getolusturmaTarih(),kisi.getkullaniciadi(),kisi.getsifre(),kisi.getyetki());
               
            }
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getkitapIsim(), kitap.getkitapYazar(), kitap.getkitapDili(), kitap.getyayinEvi(), kitap.gettur(), kitap.getadet(), kitap.getsayfaSayisi(), kitap.getbasimYil());
            }
        }


        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txtbx_id.Text),txtbx_isim.Text,txtbx_soyisim.Text,maskedtxtbox_kayittarihi.Text,txtbx_kullaniciadi.Text,txtbx_sifre.Text,txtbx_yetki.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
        public void txtleridoldur() {
            txtbx_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtbx_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtbx_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedtxtbox_kayittarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtbx_kullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtbx_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtbx_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtleridoldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txtbx_id.Text;
            string isim = txtbx_isim.Text;
            string soyisim = txtbx_soyisim.Text;
            string kayitTarihi = maskedtxtbox_kayittarihi.Text;
            string kullanicadi = txtbx_kullaniciadi.Text;
            string sifre = txtbx_sifre.Text;
            string yetki = txtbx_yetki.Text;
            dataGridView1.Rows.Add(id,isim,soyisim,kayitTarihi,kullanicadi,sifre,yetki);

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grpbx_uyeislemleri.Controls.Count; i++)
            {
                if (grpbx_uyeislemleri.Controls[i] is TextBox || grpbx_uyeislemleri.Controls[i] is MaskedTextBox)
                {
                    grpbx_uyeislemleri.Controls[i].Text = string.Empty;
                }
            }
        }

        private void grpbx_kitapislemleri_Enter(object sender, EventArgs e)
        {

        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text,txt_kitapismi.Text,txt_kitapYazari.Text,txt_kitapDili.Text,txt_yayinEvi.Text,txt_kitaptürü.Text,txt_kitapAdedi.Text,txt_sayfaSayisi.Text,txt_basimYili.Text);
        }

        private void btn_kitapTemzile_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grpbx_kitapislemleri.Controls.Count; i++)
            {
                if (grpbx_kitapislemleri.Controls[i] is TextBox)
                {
                    grpbx_kitapislemleri.Controls[i].Text = string.Empty;
                }
            }
            
        }

        private void btn_kitapGuncelle_Click(object sender, EventArgs e)
        {
            string kitapid = txt_kitapid.Text;
            string kitapismi = txt_kitapismi.Text;
            string kitapyazari = txt_kitapYazari.Text;
            string kitapdili = txt_kitapDili.Text;
            string yayinevi = txt_yayinEvi.Text;
            string kitaptürü = txt_kitaptürü.Text;
            string kitapadedi = txt_kitapAdedi.Text;
            string sayfasayisi = txt_sayfaSayisi.Text;
            string basimyili = txt_basimYili.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapismi, kitapyazari, kitapdili, yayinevi, kitaptürü, kitapadedi, sayfasayisi, basimyili);
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapismi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapYazari.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_kitapDili.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinEvi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_kitaptürü.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_kitapAdedi.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfaSayisi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basimYili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();

        }

        private void btn_kisiAra_Click(object sender, EventArgs e)
        {
            Kisi Hedefkisi = null;
            int secilenKisininID = Convert.ToInt32(textBox1.Text);

            foreach (Kisi kisi in kisilerim)
            {
                if (kisi.getId()==secilenKisininID)
                {
                    Hedefkisi = kisi;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(Hedefkisi.getId(),Hedefkisi.getIsim(),Hedefkisi.getSoyIsim(),Hedefkisi.getolusturmaTarih(),Hedefkisi.getkullaniciadi(),Hedefkisi.getsifre(),Hedefkisi.getyetki());

        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach (Kisi Hedefkisi in kisilerim)
            {
                dataGridView1.Rows.Add(Hedefkisi.getId(), Hedefkisi.getIsim(), Hedefkisi.getSoyIsim(), Hedefkisi.getolusturmaTarih(), Hedefkisi.getkullaniciadi(), Hedefkisi.getsifre(), Hedefkisi.getyetki());

            }
        }

        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
            Kitap hedefKitap = null;
            int secilenKitapID = Convert.ToInt32(textBox2.Text);
            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getKitapId() == secilenKitapID)
                {
                    hedefKitap = kitap;
                    break;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getkitapIsim(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getyayinEvi(), hedefKitap.gettur(), hedefKitap.getadet(), hedefKitap.getsayfaSayisi(), hedefKitap.getbasimYil());
        }

        private void btn_kitapYenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach (Kitap hedefKitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getkitapIsim(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getyayinEvi(), hedefKitap.gettur(), hedefKitap.getadet(), hedefKitap.getsayfaSayisi(), hedefKitap.getbasimYil());

            }
        }

        private void btn_CikisYapAdmin_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
