using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonum
{
    public class Kitap
    {
        public int kitabinid { get; set; }
        public string kitabinismi { get; set; }
        public string kitabinyazari { get; set; }
        public string kitabindili { get; set; }
        public string kitabinyayinevi { get; set; }
        public int kitabinadeti { get; set; }
        public int kitabinsayfasayisi { get; set; }
        public int kitabinbasimyili { get; set; }

        public Kitap()
        {

        }
        public Kitap( int id , string kitabinismi , string kitabinyazari , string kitabindili , string kitabinyayinevi , int kitabinadeti , int kitabinsayfasayisi , int kitabinbasimyili )
        {
         this.kitabinid = kitabinid;
            this.kitabinismi = kitabinismi; 
            this.kitabinyazari = kitabinyazari; 
            this.kitabindili = kitabindili;
            this.kitabinyayinevi= kitabinyayinevi;
            this.kitabinbasimyili= kitabinbasimyili;
        }


        public void setkitabinid()
        {
            this.kitabinid = kitabinid;
        }
        public int getkitabinid()
        {
            return this.kitabinid;
        }

        public void setkitabinismi()
        {
            this.kitabinismi = kitabinismi;
        }
        public string getkitabinismi()
        {
            return this.kitabinismi;
        }
        public void setkitabinyazari()
        {
            this.kitabinyazari = kitabinyazari;
        }
        public string getkitabinyazari()
        {
            return this.kitabinyazari;
        }
        public void setkitabindili()
        {
            this.kitabindili = kitabindili;
        }

        public string getkitabindili()
        {
            return this.kitabindili;
        }


        public void setkitabinyayinevi()
        {
            this.kitabinyayinevi = kitabinyayinevi;
        }

        public string getkitabinyayinevi()
        {
            return this.kitabinyayinevi;

        }

        public void setkitabinbasimyili()
        {
            this.kitabinbasimyili = kitabinbasimyili;
        }

        public int getkitabinbasimyili()
        {
            return this.kitabinbasimyili;

        }


    }
}
