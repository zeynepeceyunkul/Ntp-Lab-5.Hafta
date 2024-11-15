using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket
{
    class Calisan
    {
        public string Isim { get; set; }
        public int Maas { get; set; }
        public Sirket Sirket { get; set; }

        public Calisan(string i, int m)
        {
            Isim = i;
            Maas = m;
        }

        public void SirketAtama(Sirket sirket)
        {
            Sirket = sirket;
        }
    }
    class Sirket
    {
        public string Ad { get; set; }
        public string Konum { get; set; }
        public List<Calisan> Calisanlar = new List<Calisan>();

        public void CalisanEkle(Calisan calisan)
        {
            this.Calisanlar.Add(calisan);
            Console.WriteLine(calisan.Isim + " çalışan eklenmiştir.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
