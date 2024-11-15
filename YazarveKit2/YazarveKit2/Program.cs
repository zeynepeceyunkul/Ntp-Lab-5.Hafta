using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazarveKit2
{
    class Kitap
    {
        public string Baslik { get; set; }
        public DateTime YayinTarihi { get; set; }
        public Yazar Yazar { get; set; }

        public Kitap(string b, DateTime y)
        {
            Baslik = b;
            YayinTarihi = y;

        }

        public void YazarAtama(Yazar yazar)
        {
            Yazar = yazar;
        }
    }
    class Yazar
    {
        public string Ad { get; set; }
        public string Ulke { get; set; }

        public List<Kitap> Kitaplar = new List<Kitap>();

        public void KitapEkle(Kitap yenikitap)
        {
            this.Kitaplar.Add(yenikitap);
            Console.WriteLine(yenikitap.Ad + " kitabı kütüphaneye eklenmiştir.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
