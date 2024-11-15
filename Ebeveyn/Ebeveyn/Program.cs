using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebeveyn
{
    class Cocuk
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Ebeveyn Ebeveyn { get; set; }

        public Cocuk(string a, int y)
        {
            Ad = a;
            Yas = y;
        }
        public void EbeveynAtama(Ebeveyn ebeveyn)
        {
            Ebeveyn = ebeveyn;
        }
        

    }
    class Ebeveyn
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public List<Cocuk> Cocuklar = new List<Cocuk>();

        public Ebeveyn(string a, int y)
        {
            Ad = a;
            Yas = y;
        }

        public void CocukEkle(Cocuk cocuk)
        {
            this.Cocuklar.Add(cocuk);
            Console.WriteLine(cocuk.Ad + " çocuk eklenmiştir.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
