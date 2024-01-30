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
    public partial class ÜyeSayfası : Form
    {
        List<Kitap> kitaplarım;

        public ÜyeSayfası(List<Kitap> kitaplarım)
        {
            InitializeComponent();
            this.kitaplarım = kitaplarım;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapılıyor ", "Bilgilendirme ", MessageBoxButtons.OK);

        }

        private void ÜyeSayfası_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarım )
            {
                dataGridView2.Rows.Add(kitap.getkitabinid(), kitap.getkitabinismi(), kitap.getkitabinyazari(), kitap.getkitabindili(), kitap.getkitabinyayinevi(), kitap.getkitabinbasimyili());
    
            }
            
        }

        private void btn_kitap_ara_Click(object sender, EventArgs e)
        {
            int kitapid = Convert.ToInt32(textBox1.Text);
            Kitap hedefkitap = null;

            foreach(Kitap kitap in kitaplarım)
            {
                if (kitap.getkitabinid()==kitapid)
                {
                    hedefkitap = kitap;
                }
            }

            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkitabinid(), hedefkitap.getkitabinismi(), hedefkitap.getkitabinyazari(), hedefkitap.getkitabindili(), hedefkitap.getkitabinyayinevi(), hedefkitap.getkitabinbasimyili());
        }
    }
}
