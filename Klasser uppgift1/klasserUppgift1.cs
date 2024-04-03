using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_uppgift1
{
    class Bil
    {
        public string? märke;
        public int? årsmodell;
        public string? färg;
        public int? mil;
        public int? däck;

        public Bil(string märke2, int årsmodell2, string färg2, int mil2, int däck2)
        {
            märke = märke2;
            årsmodell = årsmodell2;
            färg = färg2;
            mil = mil2;
            däck = däck2;
        }
    }
}
