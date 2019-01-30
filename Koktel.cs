using System;
using System.Collections.Generic;
using System.Text;

namespace Kafic_vjezbaa1
{
    class Koktel
    {
        private string naziv;
        private List<Sastojak> sastojci = new List<Sastojak>();

        public Koktel(string _naziv)
        {
            naziv = _naziv;
        }
        public void Dodaj(Sastojak s)
        {
            sastojci.Add(s);
        }

        public string Posluzi()
        {
            StringBuilder sb = new StringBuilder();
            double kolicinaLitara = 0;
            sb.Append("Posluzujem koktel" + naziv + Environment.NewLine);
            sb.Append("Sastojci (" + sastojci.Count + ")" + Environment.NewLine);
            foreach (Sastojak s in sastojci)
            {
                sb.Append(s.Prikazi() + Environment.NewLine);
                kolicinaLitara += s.VratiDecilitre();
            }
            sb.Append("Porebna čaša minimalno dcl: " + kolicinaLitara);

            return sb.ToString();
        }
    }
}
