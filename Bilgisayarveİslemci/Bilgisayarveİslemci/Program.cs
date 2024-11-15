using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayarveİslemci
{
    class İslemci
    {
        public int Cekirdekler { get; set; }
        public int Frekans { get; set; }

        public İslemci(int c, int f)
        {
            Cekirdekler = c;
            Frekans = f;
        }

        public void İslemBilgisi()
        {
            Console.WriteLine(Cekirdekler + " " + Frekans);
        }
    }

    class Bilgisayar
    {
        public string Model { get; set; }
        public İslemci İslemci { get; set; }

        public Bilgisayar(string m)
        {
            Model = m;
            İslemci = new İslemci(8, 5);
            

        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
