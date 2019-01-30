using System;
using System.Collections.Generic;
using System.Text;

namespace Kafic_vjezbaa1.Sastojci
{
    class CocaCola : Sastojak
    {
        public CocaCola(double _kolicina, string _vrsta)
        {
            kolicina = _kolicina;
            vrsta = _vrsta;
            kolicinaDeci = kolicina * 2.5;
        }
        public override string Prikazi()
        {
            return kolicina + "Coca-cola" + vrsta;
        }
    }
}
