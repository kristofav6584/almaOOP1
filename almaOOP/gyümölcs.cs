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
            public double suly;

            public Gyümölcs()
            {
            }

            public Gyümölcs(string nev, string szin, double suly)
            {
                this.nev = nev;
                this.szin = szin;
                this.suly = suly;
            }

            public virtual string Leiras()
            {
                return $"Gyümölcs neve: {nev}, Színe: {szin}, Súlya: {suly}g";
            }
        }
    }
}
