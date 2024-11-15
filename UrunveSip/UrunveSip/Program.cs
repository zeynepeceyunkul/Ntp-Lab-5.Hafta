using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunveSip
{
    class Siparis
    {
        public DateTime Tarih { get; set; }
        public decimal Toplam { get; set; }

        Siparis(DateTime t, decimal top)
        {
            Tarih = t;
            Toplam = top;
        }
    }

    class Urun
    {
        public string Ad { get; set; }
        private int Fiyat { get; set; }

        public Urun(string a, int f)
        {
            Ad = a;
            Fiyat = f;
        }

        public void UrunBilgisi()
        {
            Console.WriteLine(Ad + " " + Fiyat);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
