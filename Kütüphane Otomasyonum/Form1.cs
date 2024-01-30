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
    public partial class Form1 : Form
    {
        List<Kişi> kisilerim = new List<Kişi>();
        List<Kitap>kitaplarım = new List<Kitap>();  
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullanıcı_adı.Text = string.Empty;
            txt_sifre.Text = string.Empty;

        }

        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";
            kullaniciadi = txt_kullanıcı_adı.Text;
            sifre= txt_sifre.Text;

            bool kontrol = false;
            foreach (Kişi kisi in kisilerim)
            {
                if(kullaniciadi.ToLower()==kisi.getkullaniciadi() && sifre.ToLower()==kisi.getsifre() && kisi.getyetki() == "admin")
                {
                    AdminSayfası adminsayfası = new AdminSayfası(kisilerim , kitaplarım);
                    adminsayfası.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }

                else if (kullaniciadi.ToLower() == kisi.getkullaniciadi() && sifre.ToLower() == kisi.getsifre() && kisi.getyetki() == "üye")
                {
                    ÜyeSayfası uyesayfası = new ÜyeSayfası(kitaplarım);
                    uyesayfası.Show();
                    this.Hide();    
                    kontrol = true;
                    break;
                }

            }
            if (!kontrol)
            {
                MessageBox.Show("Hatalı giriş", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kişi(1, "ibrahim", "dönmez", DateTime.Now, "ibo", "1", "admin"));
            kisilerim.Add(new Kişi(2, "irem", "dönmez", DateTime.Now, "iro", "2", "üye"));
            kisilerim.Add(new Kişi(3, "baran", "nekiz", DateTime.Now, "baro", "3", "üye"));
            kisilerim.Add(new Kişi(4, "merve", "özsezik", DateTime.Now, "mervo", "4", "üye"));


            kitaplarım.Add(new Kitap(1, "İçimdeki şeytan", "Sebehattan ali ", "türkçe ", "güzelkitaplar aş", 500, 97, 1998));
            kitaplarım.Add(new Kitap(2, "kaderle oyun", "engin koç ", "türkçe ", "DNL kitaplar a.ş.", 1020, 97, 1888));
            kitaplarım.Add(new Kitap(3, "içimdeki çocuk", "zülfü çağdaş ", "türkçe ", " Okyanus yayınevi aş", 1050, 97, 2013));
            kitaplarım.Add(new Kitap(4, "mavi hayat", "bekir güven ", "türkçe ", "güzelkitaplar aş", 4200, 97, 2010));
            kitaplarım.Add(new Kitap(5, "günei gördüm", "mehmet ali uslu ", "türkçe ", "güzelkitaplar aş", 700, 97, 2009));

        }
    }
}
