using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almaOOP
{
    internal class alma
    {
        public string nev;
        public string szin;
        public double suly;
        public string fajta;
        
        public alma(string nev,string szin, double suly, string fajta)
        {
            this.nev = nev;
            this.szin = szin;
            this.suly = suly;
            this.fajta = fajta;
        }

        public override string ToString()
        {
            return $"Gyümölocs neve?: {nev}, Szyne: {szin}, súlya: {suly}g, Fajta: {fajta}";
        }

    }
}
