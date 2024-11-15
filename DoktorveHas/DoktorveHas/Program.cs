using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorveHas
{
    class Hasta
    {
        public string Ad { get; set; }
        public string TCno { get; set; }
        public Doktor Doktor { get; set; }

        public Hasta(string a, string t)
        {
            Ad = a;
            TCno = t;
        }

        public void DoktorAtama(Doktor doktor)
        {
            Doktor = doktor;
        }
    }
    class Doktor
    {
        public string Ad { get; set; }
        public string Brans { get; set; }
        public List<Hasta> Hastalar { get; set; }

        public Doktor(string a, string b)
        {
            Ad = a;
            Brans = b;
            Hastalar = new List<Hasta>();
        }

        public void HastaEKle(Hasta hasta)
        {
            if (!Hastalar.Contains(hasta))
            {
                Hastalar.Add(hasta);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
