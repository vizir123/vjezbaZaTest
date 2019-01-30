using System;
using System.Collections.Generic;
using System.Text;

namespace Kafic_vjezbaa1.Sastojci
{
    class Rum : Sastojak
    {
        public Rum(double _kolicina, string _vrsta)
        {
            kolicinaDeci = kolicina = _kolicina;
            vrsta = _vrsta;
        }

        public override string Prikazi()
        {
            return kolicina + "dcl ruma" + vrsta;
        }
    }
}
