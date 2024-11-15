using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane2
{
    class Kitap
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }

        public Kitap(string b, string y)
        {
            Baslik = b;
            Yazar = y;
        }
    }

    class Kutuphane
    {
        public string Ad { get; set; }
        public List<Kitap> Kitaplar = new List<Kitap>();

        public Kutuphane(string a)
        {
            Ad = a;
        }

        public void KitapEkle(Kitap kitap)
        {
            this.Kitaplar.Add(kitap);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
