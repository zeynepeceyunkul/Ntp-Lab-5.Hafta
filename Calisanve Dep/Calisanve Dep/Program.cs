using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisanve_Dep
{
    class Departman
    {
       public string Ad;
       public string Lokasyon;

        public Departman(string a, string l)
        {
            Ad = a;
            Lokasyon = l;
        }
    }
    class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public Departman Departman { get; set; }

        public Calisan(string a, string p)
        {
            Ad = a;
            Pozisyon = p;
        }

        public void DepartmanAta(Departman departman)
        {
            Departman = departman;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
