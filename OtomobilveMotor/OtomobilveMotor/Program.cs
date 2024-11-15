using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomobilveMotor
{
    class Motor
    {
        private int Güc { get; set; }
        public string Tip { get; set; }

        public Motor(int g, string t)
        {
            Güc = g;
            Tip = t;
        }

        public void MotorBilgisi()
        {
            Console.WriteLine(Güc + " " + Tip);

        }
    }

    class Otomobil
    {
        public string Marka { get; set; }
        public Motor Motor { get; set; }

        public Otomobil(string m)
        {
            Marka = m;
            Motor = new Motor(5000, "a");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
