using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders13_2
{
    internal class kullanici
    {
        string kullanici_adi;
        string kullanici_sifre;
        string ad;
        string soyad;

        public string Kullanici_adi { get => kullanici_adi; set => kullanici_adi = value; }
        public string Kullanici_sifre { get => kullanici_sifre; set => kullanici_sifre = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }

        public kullanici(string kullanici_adi, string kullanici_sifre, string ad, string soyad)
        {
            this.Kullanici_adi = kullanici_adi;
            this.Kullanici_sifre = kullanici_sifre;
            this.Ad = ad;
            this.Soyad = soyad;
        }
    }
}