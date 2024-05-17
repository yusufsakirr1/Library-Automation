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
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim=kitaplarim;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach (Kitap hedefKitap in kitaplarim)
            {
                dataGridView1.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getkitapIsim(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getyayinEvi(), hedefKitap.gettur(), hedefKitap.getadet(), hedefKitap.getsayfaSayisi(), hedefKitap.getbasimYil());

            }
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getKitapId(), kitap.getkitapIsim(), kitap.getkitapYazar(),kitap.getkitapDili(),kitap.getyayinEvi(),kitap.gettur(),kitap.getadet(),kitap.getsayfaSayisi(),kitap.getbasimYil());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int kitapID = Convert.ToInt32(textBox1.Text);
            Kitap hedefKitap = null;
            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getKitapId() == kitapID)
                {
                    hedefKitap = kitap;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getkitapIsim(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getyayinEvi(), hedefKitap.gettur(), hedefKitap.getadet(), hedefKitap.getsayfaSayisi(), hedefKitap.getbasimYil());
        }

        }
    }

