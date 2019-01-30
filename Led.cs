using System;
using System.Collections.Generic;
using System.Text;

namespace Kafic_vjezbaa1.Sastojci
{
    class Led : Sastojak
    {
        public Led(string _vrsta)
        {
            kolicinaDeci = 1;
            vrsta = _vrsta;
        }

        public override string Prikazi()
        {
            return "Led" + vrsta;
        }
    }
}
