using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulv
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        public Ogrenci(string A, int y)
        {
            Ad = A;
            Yas = y;
        }
        public void OgrenciBilgisi()
        {
            Console.WriteLine(Ad + " " + Yas);
        }
        
    }

    class Okul
    {
        public string Ad { get; set; }
        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public Okul(string a)
        {
            Ad = a;
            
        }
        public void OgrenciOlustur(Ogrenci ogrenci)
        {
            this.Ogrenciler.Add(ogrenci);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
