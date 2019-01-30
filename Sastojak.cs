using System;
using System.Collections.Generic;
using System.Text;

namespace Kafic_vjezbaa1
{
    class Sastojak
    {
        protected double kolicina;
        protected double kolicinaDeci;
        protected string vrsta;

        public double VratiDecilitre()
        {
            return kolicina = kolicinaDeci;
        }

        public virtual string Prikazi()
        {
            return "Sastojci" + kolicina;
        }
    }
}
