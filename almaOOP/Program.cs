using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gyümölcs.Gyümölcs g = new gyümölcs.Gyümölcs("Narancs", "Narancssárga", 170);
            Console.WriteLine(g.Leiras());
            Console.WriteLine("------------------------------------------");

            alma a = new alma("Alma", "piros", 130, "pirosalma");
            Console.WriteLine(a.Leiras());
            Console.WriteLine("--------------------------------------");

            List<object> gyumolcsok = new List<object>();
            gyumolcsok.Add(g);
            gyumolcsok.Add(a);

        }
    }
}
