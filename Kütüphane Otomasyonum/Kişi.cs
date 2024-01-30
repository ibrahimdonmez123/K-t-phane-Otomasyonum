using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonum
{
    public class Kişi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string  soyisim { get; set; }
        public DateTime olusturma_tarihi { get; set; }
        public string kullanıcı_adı { get; set; }
        public string  sifre { get; set; }
        public string yetki { get; set; }

        public Kişi()
        {

        }
        public Kişi( int id , string isim , string soyisim , DateTime olusturma_tarihi , string kullanıcı_adı , string sifre , string yetki)
        {

            this.id = id;
            this.isim = isim;   
            this.soyisim= soyisim;  
            this.olusturma_tarihi= olusturma_tarihi;
            this.kullanıcı_adı = kullanıcı_adı;
            this.sifre = sifre;
            this.yetki = yetki;

        }

        public void setid()
        {
            this.id = id;
        }
        public int getid()
        {
            return this.id;
        }

        public void setisim()
        {
            this.isim = isim;
        }
        public string getisim()
        {
            return this.isim;
        }
        public void setsoyisim()
        {
            this.soyisim = soyisim;   
        }
        public string getsoyisim()
        {
            return this.soyisim;
        }
        public void setolusturmatarihi()
        {
            this.olusturma_tarihi = olusturma_tarihi;
        }

        public DateTime getolusturmatarihi()
        {
            return this.olusturma_tarihi;
        }

        public void setkullaniciadi()
        {
            this.kullanıcı_adı = kullanıcı_adı;
        }

        public string getkullaniciadi()
        {
            return this.kullanıcı_adı;

        }

        public void setsifre()
        {
            this.sifre = sifre;
        }

        public string getsifre()
        {
            return this.sifre;
        }

        public void setyetki()
        {
         this.yetki = yetki;
        }

        public string getyetki()
        { 
        return this.yetki;
        }


        public override string ToString()
        {
            return " isim ve soyisim :" + this.isim + this.soyisim; 
        }
    }
}
