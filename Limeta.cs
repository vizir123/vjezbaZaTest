using System;
using System.Collections.Generic;
using System.Text;

namespace Kafic_vjezbaa1.Sastojci
{
    class Limeta : Sastojak
    {
        public Limeta(double _kolicina)
        {
            kolicina = _kolicina;
            kolicinaDeci = kolicina * 0.4;
        }
        public override string Prikazi()
        {
            return kolicina + "limete";
        }

    }
}
