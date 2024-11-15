using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvveOda
{
    class Oda
    {
        public string Boyut { get; set; }
        public string Tip { get; set; }
        
        public Oda(string b, string t)
        {
            Boyut = b;
            Tip = t;
        }
    }

    class Ev
    {
        public string Ad { get; set; }
        public List<Oda> Odalar = new List<Oda>();

        public void OdaEkle(Oda oda)
        {
            this.Odalar.Add(oda);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
