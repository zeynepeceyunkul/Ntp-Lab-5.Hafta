using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketveCalisan2
{
    class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }

        public Calisan(string a, string p)
        {
            Ad = a;
            Pozisyon = p;

        }

        public void CalisanBilgisi()
        {
            Console.WriteLine(Ad +" "+ Pozisyon);
        }
    }

    class Sirket
    {
        public string Ad { get; set; }
        public List<Calisan> Calisanlar = new List<Calisan>();

        public void CalisanEkle(Calisan calisan)
        {
            this.Calisanlar.Add(calisan);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
