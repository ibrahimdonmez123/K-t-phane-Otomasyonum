using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonum
{
    public partial class AdminSayfası : Form
    {
        List<Kişi> kisilerim;
        List<Kitap> kitaplarım;
        public AdminSayfası(List<Kişi> kisilerim , List<Kitap> kitaplarım)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarım = kitaplarım;
        }

        private void AdminSayfası_Load(object sender, EventArgs e)
        {
            foreach (Kişi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getid(), kisi.getisim(), kisi.getsoyisim(), kisi.getolusturmatarihi(), kisi.getkullaniciadi(), kisi.getyetki());
            }
            foreach (Kitap kitap in kitaplarım)
            {
                dataGridView2.Rows.Add(kitap.getkitabinid(), kitap.getkitabinismi(), kitap.getkitabinyazari(), kitap.getkitabindili(), kitap.getkitabinyayinevi());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyisim.Text, txt_olusturma_tarihi.Text, txt_kullanıcı_adı.Text, txt_yetki.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }


        public void textleriDoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_olusturma_tarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullanıcı_adı.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string olusturma_tarihi = txt_olusturma_tarihi.Text;
            string kullanıcıadı = txt_kullanıcı_adı.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id , isim , soyisim , olusturma_tarihi , kullanıcıadı , sifre , yetki);
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                groupBox1.Controls[i].Text = string.Empty;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string kitapid = txt_kitapid.Text;
            string kitapisim = txt_kitapisim.Text;
            string kirapyazar = txt_kitapyazar.Text;
            string kitapdili = txt_kitapdil.Text;
            string kitapyayınevi = txt_yayinevi.Text;
            string kitapturu = txt_kitaptur.Text;
            string kitapadet = txt_kitapadet.Text;
            string kitapsayfa = txt_kitapsaysasayisi.Text;
            string kitapbasimyili = txt_basımyili.Text;
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, Kitapisim, Kitapyazar, kitapdili, kitapyayınevi, kitapturu, kitapadet, kitapsayfa, kitapbasimyili);
        }

        private void btn_kitap_ekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text, txt_isim.Text, txt_kitapyazar.Text, txt_kitapdil.Text, txt_yayinevi.Text, txt_kitaptur.Text, txt_kitapadet.Text, txt_kitapsaysasayisi.Text, txt_basımyili.Text);
        }

        private void btn_kitap_sil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                if (groupBox2.Controls[i] is TextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_kitapdil.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_basımyili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();




        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            Kişi hedefkisi = null;

            int secilenkisiid = Convert.ToInt32(textBox1.Text);

            foreach (Kişi kisi in kisilerim )
            {
                if(kisi.getid() == secilenkisiid) 
                {
                hedefkisi= kisi;
                break;
                }

            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.getid(), hedefkisi.getisim(), hedefkisi.getsoyisim(), hedefkisi.getolusturmatarihi(), hedefkisi.getkullaniciadi(), hedefkisi.getsifre(), hedefkisi.getyetki());


        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);    

            foreach (Kişi hedefkisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefkisi.getid(), hedefkisi.getisim(), hedefkisi.getsoyisim(), hedefkisi.getolusturmatarihi(), hedefkisi.getkullaniciadi(), hedefkisi.getsifre(), hedefkisi.getyetki());

            }
        }

        private void kitapsearch_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;
            int kitapid = Convert.ToInt32(textBox2);
            foreach (Kitap kitap in kitaplarım)
            {
                if(kitap.getkitabinid() == kitapid)
                {
                    hedefkitap= kitap;  
                }

               
            }

            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkitabinid(), hedefkitap.getkitabinismi(), hedefkitap.getkitabinyayinevi(), hedefkitap.getkitabindili(), hedefkitap.getkitabinyayinevi());
        }

        private void kitapnew_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            foreach(Kitap hedefkitap in kitaplarım)
            {
                dataGridView2.Rows.Add(hedefkitap.getkitabinid(), hedefkitap.getkitabinismi(), hedefkitap.getkitabinyayinevi(), hedefkitap.getkitabindili(), hedefkitap.getkitabinyayinevi());

            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapılıyor ", "Bilgilendirme ", MessageBoxButtons.OK);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
