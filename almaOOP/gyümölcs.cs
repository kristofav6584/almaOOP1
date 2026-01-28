using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almaOOP
{
    internal class gyümölcs
    {
        public class Gyümölcs
        {
            public string nev;
            public string szin;
            public string suly;

            public Gyümölcs()
            {
            }

            public Gyümölcs(string nev, string szin, string suly)
            {
                this.nev = nev;
                this.szin = szin;
                this.suly = suly;
            }

            public override string ToString()
            {
                return $"Gyümölocs neve?: {nev}, Szyne: {szin}, súlya: {suly}g";
            }
        }
    }
}
