using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriveUrun
{
    class Siparis
    {
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }

        Siparis(DateTime t, string d)
        {
            Tarih = t;
            Durum = d;
        }
    }

    class Urun
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }

        public Urun(string a, string t)
        {
            Ad = a;
            Telefon = t;
        }

        public void SiparisVer()
        {
           string Siparis = Ad + Telefon;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
