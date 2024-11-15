using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazarveKit
{
    class Kitap
    {
        public string Baslik { get; set; }
        public string ISBN { get; set; }

        public Kitap(string b, string i)
        {
            Baslik = b;
            ISBN = i;
        }
    }

    class Yazar
    {
        public string Ad;
        public string Ulke;

        public List<Kitap> Kitaplar = new List<Kitap>();

        public void KitapEkle(Kitap kitap)
        {
            this.Kitaplar.Add(kitap);
            Console.WriteLine(kitap.Baslik + " yeni kitap eklenmiştir.");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
